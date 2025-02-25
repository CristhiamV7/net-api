using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiCarBrands.Domain.Entities;

namespace WebApiCarBrands.Application.Interfaces
{
    public interface ICarBrandService
    {
        Task<List<CarBrand>> GetCarBrandsAsync();
        Task<CarBrand?> GetCarBrandByIdAsync(int id);
        Task<CarBrand> AddCarBrandAsync(CarBrand newCarBrand);
        Task<bool> UpdateCarBrandAsync(CarBrand updateCarBrand);
        Task<bool> DeleteCarBrandAsync(int id);
    }
}
