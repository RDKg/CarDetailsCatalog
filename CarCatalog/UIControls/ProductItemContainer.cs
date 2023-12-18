using CarCatalog.ViewModels;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace CarCatalog.UIControls
{
    public class ProductItemContainer : UserControl
    {
        private Padding _padding = new Padding(5);

        private Font _markFont = new Font("Segoe UI", 12, FontStyle.Bold);

        private Label? _nameLabel;
        private Label? _priceLabel;
        private Label? _descriptionLabel;
        private Label? _informationLabel;

        private ProductItem? _product;

        private TableLayoutPanel? _tableLayoutPanel;

        private bool _isAddedToCart;

        public Button? button;

        public ProductItemContainer(ProductItem product, bool isAddedToCart)
        {
            _isAddedToCart = isAddedToCart;
            _product = product;

            InitializeLabels();
            InitializeButtons();
            InitializeComponents();
        }

        private Label DefaultLabel(string text)
        {
            return new Label
            {
                Text = text,
                Margin = _padding,
                Dock = DockStyle.Fill,
                AutoSize = true,
            };
        }

        private void InitializeLabels()
        {
            string information = $"Тип детали: {_product.TypeDetail}\n" +
                                 $"Машина: {_product.CarBrandAndModel}\n" +
                                 $"Изготовитель: {_product.CountryOfOrigin}\n" +
                                 $"Производитель: {_product.Manufacturer}";

            _informationLabel = DefaultLabel(information);
            _descriptionLabel = DefaultLabel($"Описание: {_product.Description}");
            _nameLabel = DefaultLabel($"Название: {_product.Name}");
            _priceLabel = DefaultLabel($"Цена: {_product.Price.ToString()} руб.");

            _nameLabel.Font = _markFont;
            _priceLabel.Font = _markFont;
        }

        private void InitializeButtons()
        {
            button = new Button()
            {
                Cursor = Cursors.Hand,
                FlatStyle = FlatStyle.Flat,
                Width = TextRenderer.MeasureText(
                    "УДАЛИТЬ ИЗ КОРЗИНЫ",
                    _markFont
                ).Width,
            };

            if (_isAddedToCart)
            {
                button.BackColor = Color.LightGoldenrodYellow;
                button.Text = "УДАЛИТЬ ИЗ КОРЗИНЫ";
            }
            else
            {
                button.BackColor = Color.DarkSeaGreen;
                button.Text = "ДОБАВИТЬ В КОРЗИНУ";
            }
        }

        private void InitializeComponents()
        {
            _tableLayoutPanel = new TableLayoutPanel()
            {
                Dock = DockStyle.Fill,
                BackColor = Color.WhiteSmoke,
                Padding = _padding,
                AutoSize = true,
            };
            _tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75f));
            _tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25f));

            _tableLayoutPanel.Controls.Add(_nameLabel, 0, 0);
            _tableLayoutPanel.Controls.Add(_descriptionLabel, 0, 1);
            _tableLayoutPanel.Controls.Add(_informationLabel, 0, 2);
            _tableLayoutPanel.Controls.Add(button, 1, 0);
            _tableLayoutPanel.Controls.Add(_priceLabel, 1, 1);

            this.Controls.Add(_tableLayoutPanel);
        }
    }
}
