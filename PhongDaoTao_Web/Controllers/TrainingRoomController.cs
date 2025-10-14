using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhongDaoTao_Web.Data;
using PhongDaoTao_Web.Models;

namespace PhongDaoTao_Web.Controllers
{
    public class TrainingRoomController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TrainingRoomController(ApplicationDbContext context)
        {
            _context = context;
        }

        // ================================
        // 🔹 DANH SÁCH PHÒNG HỌC
        // ================================
        public async Task<IActionResult> Index()
        {
            var rooms = await _context.TrainingRooms.AsNoTracking().ToListAsync();
            return View(rooms);
        }

        // ================================
        // 🔹 XEM CHI TIẾT PHÒNG
        // ================================
        public async Task<IActionResult> Details(int id)
        {
            var room = await _context.TrainingRooms
                .AsNoTracking()
                .FirstOrDefaultAsync(r => r.IdTrainingRoom == id);

            if (room == null)
                return NotFound();

            return View(room);
        }

        // ================================
        // 🔹 THÊM PHÒNG HỌC MỚI
        // ================================
        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TrainingRoom room)
        {
            if (ModelState.IsValid)
            {
                _context.TrainingRooms.Add(room);
                await _context.SaveChangesAsync();
                TempData["Message"] = $"Đã thêm phòng {room.Name} thành công!";
                return RedirectToAction(nameof(Index));
            }
            return View(room);
        }

        // ================================
        // 🔹 SỬA THÔNG TIN PHÒNG
        // ================================
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var room = await _context.TrainingRooms.FindAsync(id);
            if (room == null)
                return NotFound();

            return View(room);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, TrainingRoom room)
        {
            if (id != room.IdTrainingRoom)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(room);
                    await _context.SaveChangesAsync();
                    TempData["Message"] = $"Đã cập nhật thông tin phòng {room.Name}.";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.TrainingRooms.Any(e => e.IdTrainingRoom == id))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(room);
        }

        // ================================
        // 🔹 XÓA PHÒNG HỌC
        // ================================
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var room = await _context.TrainingRooms.AsNoTracking()
                .FirstOrDefaultAsync(r => r.IdTrainingRoom == id);

            if (room == null)
                return NotFound();

            return View(room);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var room = await _context.TrainingRooms.FindAsync(id);
            if (room != null)
            {
                _context.TrainingRooms.Remove(room);
                await _context.SaveChangesAsync();
                TempData["Message"] = $"Phòng {room.Name} đã bị xóa.";
            }

            return RedirectToAction(nameof(Index));
        }

        // ================================
        // 🔹 MỞ PHÒNG
        // ================================
        [HttpPost]
        public async Task<IActionResult> OpenRoom(int id)
        {
            var room = await _context.TrainingRooms.FindAsync(id);
            if (room == null)
                return NotFound();

            room.IsActive = true;
            _context.Update(room);
            await _context.SaveChangesAsync();

            TempData["Message"] = $"Phòng {room.Name} đã được mở.";
            return RedirectToAction(nameof(Index));
        }

        // ================================
        // 🔹 ĐÓNG PHÒNG
        // ================================
        [HttpPost]
        public async Task<IActionResult> CloseRoom(int id)
        {
            var room = await _context.TrainingRooms.FindAsync(id);
            if (room == null)
                return NotFound();

            room.IsActive = false;
            _context.Update(room);
            await _context.SaveChangesAsync();

            TempData["Message"] = $"Phòng {room.Name} đã được đóng.";
            return RedirectToAction(nameof(Index));
        }
    }
}
