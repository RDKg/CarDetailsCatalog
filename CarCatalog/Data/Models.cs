using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace CarCatalog.Data
{
    public class Brand
    {
        private string? _name;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Name { 
            get => _name; 
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Не указано название бренда!");

                _name = value.Trim();
            } 
        }

        public ICollection<Car> Cars { get; set; } = new List<Car>();
    }

    public class TypeDetail 
    {
        private string? _name;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Не указано название типа детали!");

                _name = value.Trim();
            }
        }

        public ICollection<Detail> Details { get; set; } = new List<Detail>();
    }

    public class Car
    {
        private string? _model;

        private Brand? _brand;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Model
        {
            get => _model;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Не указано название модели!");

                _model = value.Trim();
            }
        }

        public Brand? Brand
        {
            get => _brand;
            set
            {
                if (value == null)
                    throw new ArgumentException("Не указан бренд модели!");

                _brand = value;
            }
        }

        public ICollection<Detail> Details { get; set; } = new List<Detail>();
        public ICollection<CarDetail> CarDetails { get; set; } = new List<CarDetail>();

    }

    public class Detail
    {
        private string? _name;
        private string? _desc;
        private string? _manuf;
        private string? _country;

        private TypeDetail? _typeDetail;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Не указано название детали!");

                _name = value.Trim();
            }
        }
        public string? Description
        {
            get => _desc;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Не указано описание детали!");

                _desc = value.Trim();
            }
        }
        public string? Manufacturer
        {
            get => _manuf;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Не указан производитель детали!");

                _manuf = value.Trim();
            }
        }
        public string? CountryOfOrigin
        {
            get => _country;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Не указана страна изготовителя детали!");

                _country = value.Trim();
            }
        }
        public decimal Price { get; set; }

        public TypeDetail? TypeDetail
        {
            get => _typeDetail;
            set
            {
                _typeDetail = value;

                if (_typeDetail == null)
                    throw new ArgumentException("Не указан тип детали!");
            }
        }

        public ICollection<Car>? Cars { get; set; } = new List<Car>();
        public ICollection<CarDetail>? CarDetails { get; set; } = new List<CarDetail>();

    }

    public class CarDetail
    {
        private Detail? _detail;
        private Car? _car;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public Detail? Detail 
        { 
            get => _detail;
            set
            {
                _detail = value;

                if (_detail == null)
                    throw new ArgumentException("Не указана деталь!");
            }
        
        }
        public Car? Car 
        { 
            get => _car; 
            set
            {
                _car = value;

                if (_car == null)
                    throw new ArgumentException("Не указана модель машины!");
            } 
        }
    }

    public class CartItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public CarDetail? CarDetail { get; set; } 
    }
}
