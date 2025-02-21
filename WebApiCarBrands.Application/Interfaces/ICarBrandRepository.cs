using WebApiCarBrands.Domain.Entities;


namespace WebApiCarBrands.Application.Interfaces
{
    public interface ICarBrandRepository
    {
        Task<List<CarBrand>> GetAllAsync();
        Task<CarBrand?> GetByIdAsync(int id);
        Task<CarBrand> AddAsync(CarBrand carBrand);
        Task<bool> UpdateAsync(CarBrand carBrand);
        Task<bool> DeleteAsync(int id);
    }
}
