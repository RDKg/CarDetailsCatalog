namespace CarCatalog
{
    partial class CarCatalogForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            BrandsListBox = new ListBox();
            label1 = new Label();
            CostsContainer = new GroupBox();
            PriceEndTextBox = new TextBox();
            PriceStartTextBox = new TextBox();
            label2 = new Label();
            label5 = new Label();
            label8 = new Label();
            ClearButton = new Button();
            ModelsListBox = new ListBox();
            label3 = new Label();
            TypeDetailsCheckedListBox = new CheckedListBox();
            menuStrip1 = new MenuStrip();
            добавитьАвтомобильToolStripMenuItem = new ToolStripMenuItem();
            DetailsManagementMenuItem = new ToolStripMenuItem();
            CartMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            label4 = new Label();
            SearchTimer = new System.Windows.Forms.Timer(components);
            DetailsPanel = new FlowLayoutPanel();
            panel1 = new Panel();
            CostsContainer.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // BrandsListBox
            // 
            BrandsListBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BrandsListBox.FormattingEnabled = true;
            BrandsListBox.ItemHeight = 15;
            BrandsListBox.Location = new Point(12, 51);
            BrandsListBox.Name = "BrandsListBox";
            BrandsListBox.Size = new Size(145, 139);
            BrandsListBox.TabIndex = 0;
            BrandsListBox.SelectedIndexChanged += BrandsListBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 1;
            label1.Text = "БРЕНД";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CostsContainer
            // 
            CostsContainer.Controls.Add(PriceEndTextBox);
            CostsContainer.Controls.Add(PriceStartTextBox);
            CostsContainer.Controls.Add(label2);
            CostsContainer.Controls.Add(label5);
            CostsContainer.Location = new Point(12, 301);
            CostsContainer.Name = "CostsContainer";
            CostsContainer.Size = new Size(296, 77);
            CostsContainer.TabIndex = 8;
            CostsContainer.TabStop = false;
            CostsContainer.Text = "СТОИМОСТЬ";
            // 
            // PriceEndTextBox
            // 
            PriceEndTextBox.Location = new Point(35, 46);
            PriceEndTextBox.Name = "PriceEndTextBox";
            PriceEndTextBox.PlaceholderText = "Введите максимальную цену в руб.";
            PriceEndTextBox.Size = new Size(255, 23);
            PriceEndTextBox.TabIndex = 8;
            PriceEndTextBox.TextChanged += PriceEndTextBox_TextChanged;
            // 
            // PriceStartTextBox
            // 
            PriceStartTextBox.Location = new Point(35, 21);
            PriceStartTextBox.Name = "PriceStartTextBox";
            PriceStartTextBox.PlaceholderText = "Введите минимальную цену в руб.";
            PriceStartTextBox.Size = new Size(255, 23);
            PriceStartTextBox.TabIndex = 7;
            PriceStartTextBox.TextChanged += PriceStartTextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 49);
            label2.Name = "label2";
            label2.Size = new Size(22, 15);
            label2.TabIndex = 6;
            label2.Text = "До";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 24);
            label5.Name = "label5";
            label5.Size = new Size(21, 15);
            label5.TabIndex = 5;
            label5.Text = "От";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(163, 33);
            label8.Name = "label8";
            label8.Size = new Size(56, 15);
            label8.TabIndex = 11;
            label8.Text = "МОДЕЛЬ";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ClearButton
            // 
            ClearButton.BackColor = Color.RosyBrown;
            ClearButton.Cursor = Cursors.Hand;
            ClearButton.FlatStyle = FlatStyle.Flat;
            ClearButton.Location = new Point(12, 387);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(296, 37);
            ClearButton.TabIndex = 13;
            ClearButton.Text = "СБРОСИТЬ";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // ModelsListBox
            // 
            ModelsListBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ModelsListBox.FormattingEnabled = true;
            ModelsListBox.ItemHeight = 15;
            ModelsListBox.Location = new Point(163, 51);
            ModelsListBox.Name = "ModelsListBox";
            ModelsListBox.Size = new Size(145, 139);
            ModelsListBox.TabIndex = 14;
            ModelsListBox.SelectedIndexChanged += ModelsListBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 193);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 15;
            label3.Text = "ТИП ДЕТАЛИ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TypeDetailsCheckedListBox
            // 
            TypeDetailsCheckedListBox.FormattingEnabled = true;
            TypeDetailsCheckedListBox.IntegralHeight = false;
            TypeDetailsCheckedListBox.Location = new Point(12, 211);
            TypeDetailsCheckedListBox.Name = "TypeDetailsCheckedListBox";
            TypeDetailsCheckedListBox.Size = new Size(296, 84);
            TypeDetailsCheckedListBox.TabIndex = 16;
            TypeDetailsCheckedListBox.ItemCheck += TypeDetailsCheckedListBox_ItemCheck;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { добавитьАвтомобильToolStripMenuItem, CartMenuItem, toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1350, 24);
            menuStrip1.TabIndex = 19;
            menuStrip1.Text = "menuStrip1";
            // 
            // добавитьАвтомобильToolStripMenuItem
            // 
            добавитьАвтомобильToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { DetailsManagementMenuItem });
            добавитьАвтомобильToolStripMenuItem.Name = "добавитьАвтомобильToolStripMenuItem";
            добавитьАвтомобильToolStripMenuItem.Size = new Size(139, 20);
            добавитьАвтомобильToolStripMenuItem.Text = "Управление данными";
            // 
            // DetailsManagementMenuItem
            // 
            DetailsManagementMenuItem.AccessibleDescription = "";
            DetailsManagementMenuItem.Name = "DetailsManagementMenuItem";
            DetailsManagementMenuItem.Size = new Size(113, 22);
            DetailsManagementMenuItem.Text = "Детали";
            DetailsManagementMenuItem.Click += DetailsManagementMenuItem_Click;
            // 
            // CartMenuItem
            // 
            CartMenuItem.Name = "CartMenuItem";
            CartMenuItem.Size = new Size(65, 20);
            CartMenuItem.Text = "Корзина";
            CartMenuItem.Click += CartMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(12, 20);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(314, 33);
            label4.Name = "label4";
            label4.Size = new Size(128, 15);
            label4.TabIndex = 20;
            label4.Text = "НАЙДЕННЫЕ ДЕТАЛИ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SearchTimer
            // 
            SearchTimer.Enabled = true;
            SearchTimer.Interval = 1000;
            SearchTimer.Tick += SearchTimer_Tick;
            // 
            // DetailsPanel
            // 
            DetailsPanel.AutoScroll = true;
            DetailsPanel.AutoSize = true;
            DetailsPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            DetailsPanel.Dock = DockStyle.Fill;
            DetailsPanel.FlowDirection = FlowDirection.TopDown;
            DetailsPanel.Location = new Point(0, 0);
            DetailsPanel.Name = "DetailsPanel";
            DetailsPanel.Size = new Size(1024, 373);
            DetailsPanel.TabIndex = 21;
            DetailsPanel.WrapContents = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(DetailsPanel);
            panel1.Location = new Point(314, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(1024, 373);
            panel1.TabIndex = 22;
            // 
            // CarCatalogForm
            // 
            AccessibleDescription = "";
            AccessibleName = "";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1350, 437);
            Controls.Add(panel1);
            Controls.Add(CostsContainer);
            Controls.Add(label4);
            Controls.Add(TypeDetailsCheckedListBox);
            Controls.Add(label3);
            Controls.Add(ModelsListBox);
            Controls.Add(ClearButton);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(BrandsListBox);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "CarCatalogForm";
            Text = "Каталог деталей";
            Resize += CarCatalogForm_Resize;
            CostsContainer.ResumeLayout(false);
            CostsContainer.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox BrandsListBox;
        private Label label1;
        private GroupBox CostsContainer;
        private Label label2;
        private Label label5;
        private Label label8;
        private Button ClearButton;
        private ListBox ModelsListBox;
        private Label label3;
        private CheckedListBox TypeDetailsCheckedListBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem добавитьАвтомобильToolStripMenuItem;
        private ToolStripMenuItem DetailsManagementMenuItem;
        private Label label4;
        private ToolStripMenuItem CartMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Timer SearchTimer;
        private TextBox PriceEndTextBox;
        private TextBox PriceStartTextBox;
        private TextBox tyut;
        private FlowLayoutPanel DetailsPanel;
        private Panel panel1;
    }
}