using CarCatalog.Data;
using CarCatalog.ViewModels;
using System.Diagnostics;

namespace CarCatalog
{
    public partial class DetailsManagmentForm : Form
    {
        private TypeDetail? _typeDetail;
        private CarDetail? _carDetail;
        private Detail? _detail;
        private Brand? _brand;
        private Car? _car;

        public DetailsManagmentForm()
        {
            InitializeComponent();

            UpdateTypeDetailItemsListBox();
            UpdateDetailItemsListBox();
            UpdateBrandItemsListBox();
            UpdateModelItemsListBox();
            UpdateCarDetailsItemsListBox();
        }

        private void UpdateTypeDetailItemsListBox()
        {
            IEnumerable<TypeDetail> typeDetails = Program.TypeDetailRepository.GetAll();
            IEnumerable<object> items = typeDetails.Select(item => new TypeDetailItem
            {
                Id = item.Id,
                Name = item.Name,
            });

            FormUtils.SetItemsToListBox(TypeDetailsListBox, items);
        }

        private void UpdateDetailItemsListBox()
        {
            ICollection<Detail> details = _typeDetail?.Details ?? Program.DetailRepository.GetAll().ToList();
            IEnumerable<object> items = details.Select(item => new DetailItem
            {
                Id = item.Id,
                Name = item.Name
            });

            FormUtils.SetItemsToListBox(DetailsListBox, items);
        }

        private void UpdateBrandItemsListBox()
        {
            IEnumerable<Brand> brands = Program.BrandRepository.GetAll();
            IEnumerable<object> items = brands.Select(item => new BrandItem
            {
                Id = item.Id,
                Name = item.Name,
            });

            FormUtils.SetItemsToListBox(BrandsListBox, items);
        }

        private void UpdateModelItemsListBox()
        {
            ICollection<Car> cars = _brand?.Cars ?? Program.CarRepository.GetAll().ToList();
            IEnumerable<object> items = cars.Select(item => new CarItem
            {
                Id = item.Id,
                Model = item.Model,
            });

            FormUtils.SetItemsToListBox(ModelsListBox, items, "Model");
        }

        private void UpdateCarDetailsItemsListBox()
        {
            IEnumerable<CarDetail> carDetails = Program.CarDetailRepository.GetAll();

            if (_car != null)
                carDetails = carDetails.Where(item => item.Car?.Id == _car.Id);
            else if (_brand != null)
                carDetails = carDetails.Where(item => item.Car?.Brand?.Name == _brand.Name);

            IEnumerable<object> items = carDetails.Select(item => new CarDetailItem
            {
                Id = item.Id,
                CarModel = item?.Car?.Model,
                DetailName = item?.Detail?.Name,
                Car = item?.Car,
                Detail = item?.Detail
            });

            FormUtils.SetItemsToListBox(CarDetailsListBox, items, "DetailName");
        }

        private void SetInfoDetailLabels()
        {
            Detail? detail = _carDetail?.Detail ?? _detail;
            string brandModel = $"{_carDetail?.Car?.Brand?.Name} {_carDetail?.Car?.Model}";

            NameDetailLabel.Text = detail?.Name ?? "НЕИЗВЕСТНО";
            DescriptionDetailLabel.Text = detail?.Description ?? "НЕИЗВЕСТНО";
            ManufacturerDetailLabel.Text = detail?.Manufacturer ?? "НЕИЗВЕСТНО";
            CountryOriginDetailLabel.Text = detail?.CountryOfOrigin ?? "НЕИЗВЕСТНО";
            PriceDetailLabel.Text = detail?.Price.ToString() ?? "НЕИЗВЕСТНО";
            TypeDetailLabel.Text = detail?.TypeDetail?.Name ?? "НЕИЗВЕСТНО";
            BrandModelLabel.Text = !string.IsNullOrWhiteSpace(brandModel) ? brandModel : "НЕИЗВЕСТНО";
        }

        // Работа с брендами
        private void BrandsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BrandItem item = (BrandItem)BrandsListBox.SelectedItem;

            if (item != null)
                BrandTextBox.Text = item.Name;
        }

        private void BrandTextBox_TextChanged(object sender, EventArgs e)
        {
            int? id = ((BrandsListBox.SelectedItem as BrandItem)?.Id);

            ModelTextBox.Text = string.Empty;
            ModelsListBox.SelectedItems.Clear();
            _brand = null;
            _car = null;

            if (!id.HasValue)
                return;

            _brand = Program.BrandRepository.GetById(id ?? 0);

            UpdateModelItemsListBox();
            UpdateCarDetailsItemsListBox();
        }

        private void AddBrandButton_Click(object sender, EventArgs e)
        {
            string name = BrandTextBox.Text;

            if (Program.BrandRepository.IsExistByName(name))
            {
                MessageBox.Show("Данный бренд уже занесен в базу данных!", "Внимание!");
                return;
            }

            try
            {
                Brand brand = new Brand { Name = name };
                BrandTextBox.Text = string.Empty;

                Program.BrandRepository.Create(brand);

                UpdateBrandItemsListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
            }
        }

        private void DeleteBrandButton_Click(object sender, EventArgs e)
        {
            if (_brand != null)
            {
                Program.BrandRepository.Delete(_brand);

                BrandTextBox.Text = string.Empty;
            }

            UpdateBrandItemsListBox();
        }

        // Работа с моделями
        private void ModelsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarItem item = (CarItem)ModelsListBox.SelectedItem;

            if (item != null)
                ModelTextBox.Text = item.Model;
        }

        private void ModelTextBox_TextChanged(object sender, EventArgs e)
        {
            int? id = ((ModelsListBox.SelectedItem as CarItem)?.Id);

            _car = null;

            if (!id.HasValue)
                return;

            _car = Program.CarRepository.GetById(id ?? 0);

            UpdateCarDetailsItemsListBox();
        }

        private void AddModelButton_Click(object sender, EventArgs e)
        {
            string model = ModelTextBox.Text;

            if (Program.CarRepository.IsExistByBrandAndModel(model, _brand?.Name))
            {
                MessageBox.Show("Данная модель уже занесена в базу данных!", "Внимание!");
                return;
            }

            try
            {
                Car car = new Car
                {
                    Model = model,
                    Brand = _brand
                };
                ModelTextBox.Text = string.Empty;

                Program.CarRepository.Create(car);

                UpdateModelItemsListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
            }
        }

        private void DeleteModelButton_Click(object sender, EventArgs e)
        {
            if (_car != null)
            {
                Program.CarRepository.Delete(_car);

                ModelTextBox.Text = string.Empty;
            }

            UpdateModelItemsListBox();
        }

        // Работа с типами деталей
        private void TypeDetailsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TypeDetailItem item = (TypeDetailItem)TypeDetailsListBox.SelectedItem;

            if (item != null)
                TypeDetailTextBox.Text = item.Name;
        }

        private void TypeDetailTextBox_TextChanged(object sender, EventArgs e)
        {
            int? id = ((TypeDetailsListBox.SelectedItem as TypeDetailItem)?.Id);

            _typeDetail = null;

            if (!id.HasValue)
                return;

            _typeDetail = Program.TypeDetailRepository.GetById(id ?? 0);

            UpdateDetailItemsListBox();
        }

        private void AddTypeDetailButton_Click(object sender, EventArgs e)
        {
            string name = TypeDetailTextBox.Text;

            if (Program.TypeDetailRepository.IsExistByName(name))
            {
                MessageBox.Show("Данный тип детали уже занесен в базу данных!", "Внимание!");
                return;
            }

            try
            {
                TypeDetail typeDetail = new TypeDetail { Name = name };
                TypeDetailTextBox.Text = string.Empty;

                Program.TypeDetailRepository.Create(typeDetail);

                UpdateTypeDetailItemsListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
            }
        }

        private void DeleteTypeDetailButton_Click(object sender, EventArgs e)
        {
            if (_typeDetail != null)
            {
                Program.TypeDetailRepository.Delete(_typeDetail);

                TypeDetailTextBox.Text = string.Empty;
            }

            UpdateTypeDetailItemsListBox();
        }

        // Работа с деталями
        private void DetailsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DetailItem item = (DetailItem)DetailsListBox.SelectedItem;

            if (item != null)
            {
                _detail = Program.DetailRepository.GetById(item.Id);
                CarDetailsListBox.SelectedItems.Clear();
                _carDetail = null;
            }

            SetInfoDetailLabels();
        }

        private void AddNewDetailButton_Click(object sender, EventArgs e)
        {
            decimal price;

            if (!decimal.TryParse(PriceDetailTextBox.Text, out price))
            {
                MessageBox.Show("Цена детали указана неверно!", "Ошибка!");
                return;
            }

            try
            {
                Detail detail = new Detail
                {
                    CountryOfOrigin = CountryOriginDetailTextBox.Text,
                    Description = DescDetailTextBox.Text,
                    Manufacturer = ManufacturerDetailTextBox.Text,
                    Name = NameDetailTextBox.Text,
                    Price = price,
                    TypeDetail = _typeDetail
                };
                TypeDetailTextBox.Text = string.Empty;

                Program.DetailRepository.Create(detail);

                UpdateDetailItemsListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
            }
        }

        private void DeleteDetailButton_Click(object sender, EventArgs e)
        {
            if (_detail != null)
            {
                Program.DetailRepository.Delete(_detail);
                _detail = null;
            }

            UpdateDetailItemsListBox();
            UpdateCarDetailsItemsListBox();
        }

        // Работа со связкой деталей и машин
        private void CarDetailsListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            CarDetailItem item = (CarDetailItem)CarDetailsListBox.SelectedItem;

            if (item != null)
                _carDetail = Program.CarDetailRepository.GetById(item?.Id ?? 0);

            SetInfoDetailLabels();
        }

        private void DeleteCarDetailButton_Click(object sender, EventArgs e)
        {
            if (_carDetail != null)
            {
                Program.CarDetailRepository.Delete(_carDetail);
                _carDetail = null;
            }

            UpdateCarDetailsItemsListBox();
        }

        private void AddCarDetailButton_Click(object sender, EventArgs e)
        {
            try
            {
                CarDetail carDetail = new CarDetail
                {
                    Detail = _detail,
                    Car = _car
                };

                Program.CarDetailRepository.Create(carDetail);

                UpdateCarDetailsItemsListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
            }
        }

        // Работа с главным окном
        private void DetailsManagmentForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
        }
    }
}
