namespace WebApiCarBrands.Domain.Entities
{
    public class CarBrand
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Year { get; set; }
        public string? Country { get; set; }
    }
}
