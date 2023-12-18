using CarCatalog.Data;
using CarCatalog.UIControls;
using CarCatalog.ViewModels;

namespace CarCatalog
{
    internal class FormUtils
    {
        public static void SetItemsToListBox(ListBox listBox, IEnumerable<object> items, string displayKey = "Name", string valueKey = "Key")
        {
            listBox.Items.Clear();
            listBox.Items.AddRange(items.ToArray());
            listBox.DisplayMember = displayKey;
            listBox.ValueMember = valueKey;
        }

        public static List<ProductItemContainer> setProductItemsInPanel(IEnumerable<CarDetail> carDetails, IEnumerable<CartItem> cartItems, Panel panel)
        {
            List<ProductItemContainer> productItems = new List<ProductItemContainer>();

            foreach (CarDetail carDetail in carDetails)
            {
                Detail detail = carDetail.Detail;
                Car car = carDetail.Car;
                CartItem? cartItem = cartItems.Where(ci => ci.CarDetail.Id == carDetail.Id).FirstOrDefault();
                ProductItem productItem = new ProductItem
                {
                    Name = detail.Name,
                    Price = detail.Price,
                    Description = detail.Description,
                    Manufacturer = detail.Manufacturer,
                    TypeDetail = detail.TypeDetail?.Name,
                    CountryOfOrigin = detail.CountryOfOrigin,
                    CarBrandAndModel = $"{car.Brand?.Name} {car.Model}",
                };
                ProductItemContainer productContainer = new ProductItemContainer(productItem, cartItem != null)
                {
                    Width = panel.Width - 50,
                    Height = 200,
                };

                productContainer.button.Tag = carDetail;

                if (cartItem != null)
                    productContainer.button.Click += deleteFromCartButton_Click;
                else
                    productContainer.button.Click += addToCartButton_Click;

                panel.Controls.Add(productContainer);
                productItems.Add(productContainer);
            }

            return productItems;
        }

        public static void addToCartButton_Click(object sender, EventArgs e)
        {
            Button button = (sender as Button);
            CarDetail item = (CarDetail)button.Tag;

            try
            {
                CartItem cartItem = new CartItem() { CarDetail = item };
                Program.CartItemRepository.Create(cartItem);

                button.Text = "УДАЛИТЬ ИЗ КОРЗИНЫ";
                button.BackColor = Color.LightGoldenrodYellow;
                button.Click -= addToCartButton_Click;
                button.Click += deleteFromCartButton_Click;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка добавления товара: {ex}", "Ошибка!");
            }
        }

        public static void deleteFromCartButton_Click(object sender, EventArgs e)
        {
            Button button = (sender as Button);
            CarDetail item = (CarDetail)button.Tag;
            CartItem cartItem = Program.CartItemRepository.GetByCarDetail(item);

            try
            {
                Program.CartItemRepository.Delete(cartItem);

                button.Text = "ДОБАВИТЬ В КОРЗИНУ";
                button.BackColor = Color.DarkSeaGreen;
                button.Click -= deleteFromCartButton_Click;
                button.Click += addToCartButton_Click;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка удаления товара из корзины: {ex}", "Ошибка!");
            }
        }
    }
}
