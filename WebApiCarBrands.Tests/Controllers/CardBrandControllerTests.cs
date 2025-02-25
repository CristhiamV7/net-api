using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Moq;
using WebApiCarBrands.Application.Interfaces;
using WebApiCarBrands.Controllers;
using WebApiCarBrands.Domain.Entities;
using Xunit;

public class CarBrandControllerTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly Mock<ICarBrandService> _mockService;
    private readonly CarBrandController _controller;

    public CarBrandControllerTests()
    {
        _mockService = new Mock<ICarBrandService>();
        _controller = new CarBrandController(_mockService.Object);
    }

    [Fact]
    public async Task GetCarBrands_ReturnsOk_WithListOfCarBrands()
    {
        var carBrands = new List<CarBrand> { new() { Id = 1, Name = "Toyota" } };
        _mockService.Setup(s => s.GetCarBrandsAsync()).ReturnsAsync(carBrands);

        var result = await _controller.GetCarBrands();

        var actionResult = Assert.IsType<OkObjectResult>(result.Result);
        var returnedBrands = Assert.IsType<List<CarBrand>>(actionResult.Value);
        Assert.Single(returnedBrands);
    }

    [Fact]
    public async Task GetCarBrandById_ReturnsNotFound_WhenNotExists()
    {
        _mockService.Setup(s => s.GetCarBrandByIdAsync(1)).ReturnsAsync((CarBrand)null);

        var result = await _controller.GetCarBrandById(1);

        Assert.IsType<NotFoundResult>(result.Result);
    }
}
