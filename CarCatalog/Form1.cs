using CarCatalog.Data;
using CarCatalog.UIControls;
using CarCatalog.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace CarCatalog
{
    public partial class CarCatalogForm : Form
    {
        private List<ProductItemContainer> _productContainers = new List<ProductItemContainer>();

        private IEnumerable<TypeDetail>? _typeDetails;

        private Brand? _brand;
        private Car? _car;

        private decimal? _startPrice;
        private decimal? _endPrice;

        public CarCatalogForm()
        {
            InitializeComponent();

            Program.DetailRepository.GetAll().ToList();

            UpdateTypeDetailItemsListBox();
            UpdateBrandItemsListBox();
            UpdateModelItemsListBox();
        }

        private void UpdateTypeDetailItemsListBox()
        {
            IEnumerable<TypeDetail> typeDetails = Program.TypeDetailRepository.GetAll();
            IEnumerable<object> items = typeDetails.Select(item => new TypeDetailItem
            {
                Id = item.Id,
                Name = item.Name,
            });

            FormUtils.SetItemsToListBox(TypeDetailsCheckedListBox, items);
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

        private void UpdateDetailsSearchContainer()
        {
            IEnumerable<CarDetail> carDetails = Program.CarDetailRepository
                .GetAll()
                .Where(item =>
                {
                    bool isValid = true;

                    if (_brand != null)
                        isValid = isValid && item?.Car?.Brand?.Name == _brand?.Name;

                    if (_car != null)
                        isValid = isValid && item?.Car?.Model == _car?.Model;

                    if (_typeDetails?.Count() > 0)
                        isValid = isValid && _typeDetails.Contains(item?.Detail?.TypeDetail);

                    if (_startPrice != null)
                        isValid = isValid && item?.Detail?.Price >= _startPrice;

                    if (_endPrice != null)
                        isValid = isValid && item?.Detail?.Price <= _endPrice;

                    return isValid;
                });
            IEnumerable<CartItem> cartItems = Program.CartItemRepository
                .GetByCarDetails(carDetails);

            _productContainers = FormUtils.setProductItemsInPanel(carDetails, cartItems, DetailsPanel);
        }

        private void ClearSearchData()
        {
            TypeDetailsCheckedListBox.SelectedItems.Clear();

            for (int i = 0; i < TypeDetailsCheckedListBox.Items.Count; i++)
                TypeDetailsCheckedListBox.SetItemCheckState(i, CheckState.Unchecked);

            DetailsPanel.Controls.Clear();
            BrandsListBox.SelectedItems.Clear();
            ModelsListBox.SelectedItems.Clear();

            PriceStartTextBox.Text = string.Empty;
            PriceEndTextBox.Text = string.Empty;

            _car = null;
            _brand = null;
            _typeDetails = null;

            SearchTimer.Enabled = true;
        }

        private void BrandsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchTimer.Enabled = false;

            int? id = ((BrandsListBox.SelectedItem as BrandItem)?.Id);

            ModelsListBox.SelectedItems.Clear();
            _brand = null;
            _car = null;

            if (!id.HasValue)
                return;

            _brand = Program.BrandRepository.GetById(id ?? 0);

            UpdateModelItemsListBox();

            SearchTimer.Enabled = true;
        }

        private void ModelsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchTimer.Enabled = false;

            int? id = ((ModelsListBox.SelectedItem as CarItem)?.Id);

            _car = null;

            if (!id.HasValue)
                return;

            _car = Program.CarRepository.GetById(id ?? 0);
            SearchTimer.Enabled = true;
        }

        private void TypeDetailsCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            SearchTimer.Enabled = false;

            TypeDetailItem checkedItem = (TypeDetailItem)TypeDetailsCheckedListBox.Items[e.Index];
            int[] ids = TypeDetailsCheckedListBox.CheckedItems
                .OfType<TypeDetailItem>()
                .Select(x => x.Id)
                .ToArray();

            if (e.NewValue == CheckState.Checked)
                ids = ids.Concat(new[] { checkedItem.Id }).ToArray();
            else if (e.NewValue == CheckState.Unchecked)
                ids = ids.Where(id => id != checkedItem.Id).ToArray();

            _typeDetails = Program.TypeDetailRepository.GetByIds(ids);
            SearchTimer.Enabled = true;
        }

        private void PriceStartTextBox_TextChanged(object sender, EventArgs e)
        {
            decimal startPrice;

            SearchTimer.Enabled = false;

            if (decimal.TryParse(PriceStartTextBox.Text, out startPrice))
                _startPrice = startPrice;
            else
                _startPrice = null;

            SearchTimer.Enabled = true;
        }

        private void PriceEndTextBox_TextChanged(object sender, EventArgs e)
        {
            decimal endPrice;

            SearchTimer.Enabled = false;

            if (decimal.TryParse(PriceEndTextBox.Text, out endPrice))
                _endPrice = endPrice;
            else
                _endPrice = null;

            SearchTimer.Enabled = true;
        }

        private void SearchTimer_Tick(object sender, EventArgs e)
        {
            SearchTimer.Enabled = false;
            DetailsPanel.Controls.Clear();

            UpdateDetailsSearchContainer();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearSearchData();
        }

        private void CartMenuItem_Click(object sender, EventArgs e)
        {
            CartManagmentForm cartManagmentForm = new CartManagmentForm();

            cartManagmentForm.ShowDialog();

            ClearSearchData();
            UpdateTypeDetailItemsListBox();
            UpdateBrandItemsListBox();
            UpdateModelItemsListBox();
        }

        private void DetailsManagementMenuItem_Click(object sender, EventArgs e)
        {
            DetailsManagmentForm detailsManagmentForm = new DetailsManagmentForm();

            detailsManagmentForm.ShowDialog();

            ClearSearchData();
            UpdateTypeDetailItemsListBox();
            UpdateBrandItemsListBox();
            UpdateModelItemsListBox();
        }

        private void CarCatalogForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
        }
    }
}