
using CarCatalog.Data;

namespace CarCatalog.ViewModels
{
    public class TypeDetailItem
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }

    public class BrandItem 
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }

    public class CarItem
    {
        public int Id { get; set; }
        public string? Model { get; set; }
        public Brand? Brand { get; set; }
    }

    public class DetailItem
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Manufacturer { get; set; }
        public string? CountryOfOrigin { get; set; }

        public TypeDetail? TypeDetail { get; set; }
    }

    public class CarDetailItem
    {
        public int Id { get; set; }
        public string? DetailName {  get; set; }
        public string? CarModel { get; set; }

        public Detail? Detail { get; set; }
        public Car? Car { get; set; }
    }

    public class CartItemItem 
    {
        public int Id { get; set; }

        public CarDetail? CarDetail { get; set; }
    }
}
