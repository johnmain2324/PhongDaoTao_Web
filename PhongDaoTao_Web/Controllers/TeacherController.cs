using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhongDaoTao_Web.Data;

namespace PhongDaoTao_Web.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TeacherController(ApplicationDbContext context)
        {
            _context = context;
        }

        // 🔹 Xem thời khóa biểu
        public async Task<IActionResult> ThoiKhoaBieu(string maGiaoVien)
        {
            var lopDay = await _context.Classrooms
                .Include(l => l.Schedules)
                .Where(l => l.TeacherID == maGiaoVien)
                .ToListAsync();

            return View(lopDay);
        }


        // 🔹 Nhập điểm
        public async Task<IActionResult> NhapDiem(int maLop)
        {
            var danhSach = await _context.Score
                .Include(d => d.HocVien)
                .Where(d => d.MaLop == maLop)
                .ToListAsync();

            ViewBag.Lop = await _context.Classrooms.FindAsync(maLop);
            return View(danhSach);
        }

        [HttpPost]
        public async Task<IActionResult> CapNhatDiem(int maDiem, double diemGiuaKy, double diemCuoiKy, string nhanXet)
        {
            var diem = await _context.Score.FindAsync(maDiem);
            if (diem == null) return NotFound();

            diem.DiemGiuaKy = diemGiuaKy;
            diem.DiemCuoiKy = diemCuoiKy;
            diem.NhanXet = nhanXet;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(NhapDiem), new { maLop = diem.MaLop });
        }
    }
}

