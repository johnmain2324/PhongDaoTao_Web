using PhongDaoTao_Web.Models;

namespace PhongDaoTao_Web.Services
{
    public interface ITrainingRoomService
    {
        Task<List<TrainingRoom>> GetAllAsync();
        Task<TrainingRoom?> GetByIdAsync(int id);
        Task CreateAsync(TrainingRoom room);
        Task UpdateAsync(TrainingRoom room);
        Task DeleteAsync(int id);
    }
}
