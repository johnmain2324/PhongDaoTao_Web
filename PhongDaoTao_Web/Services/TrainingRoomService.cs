using PhongDaoTao_Web.Data;
using PhongDaoTao_Web.Models;
using Microsoft.EntityFrameworkCore;

namespace PhongDaoTao_Web.Services
{
    public class TrainingRoomService : ITrainingRoomService
    {
        private readonly ApplicationDbContext _db;

        public TrainingRoomService(ApplicationDbContext db)
        {
            _db = db;
        }

        // ✅ Lấy toàn bộ danh sách phòng học
        public async Task<List<TrainingRoom>> GetAllAsync()
        {
            return await _db.TrainingRooms
                .AsNoTracking()
                .OrderBy(r => r.Name)
                .ToListAsync();
        }

        // ✅ Lấy một phòng theo ID
        public async Task<TrainingRoom?> GetByIdAsync(int id)
        {
            return await _db.TrainingRooms
                .AsNoTracking()
                .FirstOrDefaultAsync(r => r.IdTrainingRoom == id);
        }

        // ✅ Tạo phòng mới
        public async Task CreateAsync(TrainingRoom room)
        {
            _db.TrainingRooms.Add(room);
            await _db.SaveChangesAsync();
        }

        // ✅ Cập nhật phòng
        public async Task UpdateAsync(TrainingRoom room)
        {
            _db.TrainingRooms.Update(room);
            await _db.SaveChangesAsync();
        }

        // ✅ Xóa phòng
        public async Task DeleteAsync(int id)
        {
            var room = await _db.TrainingRooms.FindAsync(id);
            if (room != null)
            {
                _db.TrainingRooms.Remove(room);
                await _db.SaveChangesAsync();
            }
        }
    }
}
