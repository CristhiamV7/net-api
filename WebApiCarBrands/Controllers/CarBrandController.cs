using Microsoft.AspNetCore.Mvc;
using WebApiCarBrands.Application.Interfaces;
using WebApiCarBrands.Domain.Entities;

namespace WebApiCarBrands.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarBrandController(ICarBrandService service) : ControllerBase
    {
        private readonly ICarBrandService _service = service;

        [HttpGet]
        public async Task<ActionResult<List<CarBrand>>> GetCarBrands()
        {
            return Ok(await _service.GetCarBrandsAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CarBrand>> GetCarBrandById(int id)
        {
            var carBrand = await _service.GetCarBrandByIdAsync(id);
            return carBrand is not null ? Ok(carBrand) : NotFound();
        }

        [HttpPost]
        public async Task<ActionResult<CarBrand>> AddCarBrand(CarBrand newCarBrand)
        {
            if (newCarBrand is null) return BadRequest();
            var created = await _service.AddCarBrandAsync(newCarBrand);
            return CreatedAtAction(nameof(GetCarBrandById), new { id = created.Id }, created);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCarBrand(int id, CarBrand updateCarBrand)
        {
            var success = await _service.UpdateCarBrandAsync(updateCarBrand);
            return success ? NoContent() : NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCarBrand(int id)
        {
            var success = await _service.DeleteCarBrandAsync(id);
            return success ? NoContent() : NotFound();
        }
    }
}
