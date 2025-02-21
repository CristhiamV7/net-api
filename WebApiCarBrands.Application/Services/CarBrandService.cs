using WebApiCarBrands.Application.Interfaces;
using WebApiCarBrands.Domain.Entities;

namespace WebApiCarBrands.Application.Services
{
    public class CarBrandService
    {
        private readonly ICarBrandRepository _repository;

        public CarBrandService(ICarBrandRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<CarBrand>> GetCarBrandsAsync() => await _repository.GetAllAsync();

        public async Task<CarBrand?> GetCarBrandByIdAsync(int id) => await _repository.GetByIdAsync(id);

        public async Task<CarBrand> AddCarBrandAsync(CarBrand carBrand) => await _repository.AddAsync(carBrand);

        public async Task<bool> UpdateCarBrandAsync(CarBrand carBrand) => await _repository.UpdateAsync(carBrand);

        public async Task<bool> DeleteCarBrandAsync(int id) => await _repository.DeleteAsync(id);
    }
}
