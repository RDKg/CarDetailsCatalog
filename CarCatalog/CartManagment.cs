using CarCatalog.Data;
using CarCatalog.UIControls;
using CarCatalog.ViewModels;

namespace CarCatalog
{
    public partial class CartManagmentForm : Form
    {
        private List<ProductItemContainer> _productContainers = new List<ProductItemContainer>();

        public CartManagmentForm()
        {
            InitializeComponent();

            UpdateCartItems();
        }

        private void UpdateCartItems()
        {
            IEnumerable<CartItem> cartItems = Program.CartItemRepository.GetAll();
            IEnumerable<CarDetail> carDetails = cartItems.Select(ci => ci.CarDetail);

            _productContainers = FormUtils.setProductItemsInPanel(carDetails, cartItems, DetailsPanel);
        }

        private void CartManagmentForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
        }

        private void CartManagmentForm_Load(object sender, EventArgs e)
        {
            if (_productContainers.Count() == 0) 
            {
                MessageBox.Show("Корзина пуста!", "Внимание!");
                this.Close();
            }
        }
    }
}
