using Microsoft.EntityFrameworkCore;
using WebApiCarBrands.Application.Interfaces;
using WebApiCarBrands.Domain.Entities;
using WebApiCarBrands.Infrastructure.Data;

namespace WebApiCarBrands.Infrastructure.Repositories
{
    public class CarBrandRepository: ICarBrandRepository
    {
        private readonly CarBrandDbContext _context;

        public CarBrandRepository(CarBrandDbContext context)
        {
            _context = context;
        }

        public async Task<List<CarBrand>> GetAllAsync() =>
            await _context.CarBrands.ToListAsync();

        public async Task<CarBrand?> GetByIdAsync(int id) =>
            await _context.CarBrands.FindAsync(id);

        public async Task<CarBrand> AddAsync(CarBrand carBrand)
        {
            _context.CarBrands.Add(carBrand);
            await _context.SaveChangesAsync();
            return carBrand;
        }

        public async Task<bool> UpdateAsync(CarBrand carBrand)
        {
            _context.CarBrands.Update(carBrand);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var carBrand = await _context.CarBrands.FindAsync(id);
            if (carBrand == null) return false;

            _context.CarBrands.Remove(carBrand);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
