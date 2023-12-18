namespace CarCatalog
{
    partial class DetailsManagmentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AddTypeDetailButton = new Button();
            DeleteTypeDetailButton = new Button();
            TypeDetailTextBox = new TextBox();
            label1 = new Label();
            TypeDetailsListBox = new ListBox();
            DeleteDetailButton = new Button();
            label2 = new Label();
            DetailsListBox = new ListBox();
            NewDetailPanel = new GroupBox();
            AddNewDetailButton = new Button();
            PriceDetailTextBox = new TextBox();
            CountryOriginDetailTextBox = new TextBox();
            ManufacturerDetailTextBox = new TextBox();
            DescDetailTextBox = new TextBox();
            NameDetailTextBox = new TextBox();
            label4 = new Label();
            ModelsListBox = new ListBox();
            label3 = new Label();
            BrandsListBox = new ListBox();
            panel1 = new Panel();
            label5 = new Label();
            NameDetailLabel = new Label();
            panel2 = new Panel();
            label8 = new Label();
            DescriptionDetailLabel = new Label();
            panel3 = new Panel();
            label10 = new Label();
            ManufacturerDetailLabel = new Label();
            panel4 = new Panel();
            label11 = new Label();
            CountryOriginDetailLabel = new Label();
            panel5 = new Panel();
            label13 = new Label();
            PriceDetailLabel = new Label();
            label6 = new Label();
            AddCarDetailButton = new Button();
            BrandTextBox = new TextBox();
            ModelTextBox = new TextBox();
            AddModelButton = new Button();
            DeleteModelButton = new Button();
            AddBrandButton = new Button();
            DeleteBrandButton = new Button();
            DeleteCarDetailButton = new Button();
            label7 = new Label();
            CarDetailsListBox = new ListBox();
            panel6 = new Panel();
            label9 = new Label();
            TypeDetailLabel = new Label();
            panel7 = new Panel();
            label12 = new Label();
            BrandModelLabel = new Label();
            MainPanel = new Panel();
            NewDetailPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            MainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // AddTypeDetailButton
            // 
            AddTypeDetailButton.BackColor = Color.DarkSeaGreen;
            AddTypeDetailButton.Cursor = Cursors.Hand;
            AddTypeDetailButton.FlatStyle = FlatStyle.Flat;
            AddTypeDetailButton.Location = new Point(3, 408);
            AddTypeDetailButton.Name = "AddTypeDetailButton";
            AddTypeDetailButton.Size = new Size(140, 23);
            AddTypeDetailButton.TabIndex = 14;
            AddTypeDetailButton.Text = "ДОБАВИТЬ";
            AddTypeDetailButton.UseVisualStyleBackColor = false;
            AddTypeDetailButton.Click += AddTypeDetailButton_Click;
            // 
            // DeleteTypeDetailButton
            // 
            DeleteTypeDetailButton.BackColor = Color.RosyBrown;
            DeleteTypeDetailButton.Cursor = Cursors.Hand;
            DeleteTypeDetailButton.FlatStyle = FlatStyle.Flat;
            DeleteTypeDetailButton.Location = new Point(3, 437);
            DeleteTypeDetailButton.Name = "DeleteTypeDetailButton";
            DeleteTypeDetailButton.Size = new Size(140, 23);
            DeleteTypeDetailButton.TabIndex = 13;
            DeleteTypeDetailButton.Text = "УДАЛИТЬ";
            DeleteTypeDetailButton.UseVisualStyleBackColor = false;
            DeleteTypeDetailButton.Click += DeleteTypeDetailButton_Click;
            // 
            // TypeDetailTextBox
            // 
            TypeDetailTextBox.AccessibleName = "";
            TypeDetailTextBox.Location = new Point(3, 378);
            TypeDetailTextBox.Name = "TypeDetailTextBox";
            TypeDetailTextBox.PlaceholderText = "Название типа детали";
            TypeDetailTextBox.Size = new Size(140, 23);
            TypeDetailTextBox.TabIndex = 12;
            TypeDetailTextBox.TextChanged += TypeDetailTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 232);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 11;
            label1.Text = "ТИП ДЕТАЛИ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TypeDetailsListBox
            // 
            TypeDetailsListBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TypeDetailsListBox.FormattingEnabled = true;
            TypeDetailsListBox.IntegralHeight = false;
            TypeDetailsListBox.ItemHeight = 15;
            TypeDetailsListBox.Location = new Point(3, 250);
            TypeDetailsListBox.Name = "TypeDetailsListBox";
            TypeDetailsListBox.Size = new Size(140, 122);
            TypeDetailsListBox.TabIndex = 10;
            TypeDetailsListBox.SelectedIndexChanged += TypeDetailsListBox_SelectedIndexChanged;
            // 
            // DeleteDetailButton
            // 
            DeleteDetailButton.BackColor = Color.RosyBrown;
            DeleteDetailButton.Cursor = Cursors.Hand;
            DeleteDetailButton.FlatStyle = FlatStyle.Flat;
            DeleteDetailButton.Location = new Point(149, 437);
            DeleteDetailButton.Name = "DeleteDetailButton";
            DeleteDetailButton.Size = new Size(140, 23);
            DeleteDetailButton.TabIndex = 18;
            DeleteDetailButton.Text = "УДАЛИТЬ";
            DeleteDetailButton.UseVisualStyleBackColor = false;
            DeleteDetailButton.Click += DeleteDetailButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(149, 232);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 16;
            label2.Text = "ДЕТАЛЬ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DetailsListBox
            // 
            DetailsListBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DetailsListBox.FormattingEnabled = true;
            DetailsListBox.IntegralHeight = false;
            DetailsListBox.ItemHeight = 15;
            DetailsListBox.Location = new Point(149, 250);
            DetailsListBox.Name = "DetailsListBox";
            DetailsListBox.Size = new Size(140, 122);
            DetailsListBox.TabIndex = 15;
            DetailsListBox.SelectedIndexChanged += DetailsListBox_SelectedIndexChanged;
            // 
            // NewDetailPanel
            // 
            NewDetailPanel.Controls.Add(AddNewDetailButton);
            NewDetailPanel.Controls.Add(PriceDetailTextBox);
            NewDetailPanel.Controls.Add(CountryOriginDetailTextBox);
            NewDetailPanel.Controls.Add(ManufacturerDetailTextBox);
            NewDetailPanel.Controls.Add(DescDetailTextBox);
            NewDetailPanel.Controls.Add(NameDetailTextBox);
            NewDetailPanel.Location = new Point(3, 466);
            NewDetailPanel.Name = "NewDetailPanel";
            NewDetailPanel.Size = new Size(286, 193);
            NewDetailPanel.TabIndex = 20;
            NewDetailPanel.TabStop = false;
            NewDetailPanel.Text = "НОВАЯ ДЕТАЛЬ";
            // 
            // AddNewDetailButton
            // 
            AddNewDetailButton.BackColor = Color.DarkSeaGreen;
            AddNewDetailButton.Cursor = Cursors.Hand;
            AddNewDetailButton.FlatStyle = FlatStyle.Flat;
            AddNewDetailButton.Location = new Point(6, 163);
            AddNewDetailButton.Name = "AddNewDetailButton";
            AddNewDetailButton.Size = new Size(272, 23);
            AddNewDetailButton.TabIndex = 21;
            AddNewDetailButton.Text = "ДОБАВИТЬ";
            AddNewDetailButton.UseVisualStyleBackColor = false;
            AddNewDetailButton.Click += AddNewDetailButton_Click;
            // 
            // PriceDetailTextBox
            // 
            PriceDetailTextBox.AccessibleName = "";
            PriceDetailTextBox.Location = new Point(6, 134);
            PriceDetailTextBox.Name = "PriceDetailTextBox";
            PriceDetailTextBox.PlaceholderText = "Введите цену в рублях";
            PriceDetailTextBox.Size = new Size(272, 23);
            PriceDetailTextBox.TabIndex = 22;
            // 
            // CountryOriginDetailTextBox
            // 
            CountryOriginDetailTextBox.AccessibleName = "";
            CountryOriginDetailTextBox.Location = new Point(6, 105);
            CountryOriginDetailTextBox.Name = "CountryOriginDetailTextBox";
            CountryOriginDetailTextBox.PlaceholderText = "Введите страну изготовителя";
            CountryOriginDetailTextBox.Size = new Size(272, 23);
            CountryOriginDetailTextBox.TabIndex = 21;
            // 
            // ManufacturerDetailTextBox
            // 
            ManufacturerDetailTextBox.AccessibleName = "";
            ManufacturerDetailTextBox.Location = new Point(6, 76);
            ManufacturerDetailTextBox.Name = "ManufacturerDetailTextBox";
            ManufacturerDetailTextBox.PlaceholderText = "Введите производителя";
            ManufacturerDetailTextBox.Size = new Size(272, 23);
            ManufacturerDetailTextBox.TabIndex = 20;
            // 
            // DescDetailTextBox
            // 
            DescDetailTextBox.AccessibleName = "";
            DescDetailTextBox.Location = new Point(6, 47);
            DescDetailTextBox.Name = "DescDetailTextBox";
            DescDetailTextBox.PlaceholderText = "Введите описание";
            DescDetailTextBox.Size = new Size(272, 23);
            DescDetailTextBox.TabIndex = 19;
            // 
            // NameDetailTextBox
            // 
            NameDetailTextBox.AccessibleName = "";
            NameDetailTextBox.Location = new Point(6, 18);
            NameDetailTextBox.Name = "NameDetailTextBox";
            NameDetailTextBox.PlaceholderText = "Введите название детали";
            NameDetailTextBox.Size = new Size(272, 23);
            NameDetailTextBox.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(149, 1);
            label4.Name = "label4";
            label4.Size = new Size(116, 15);
            label4.TabIndex = 23;
            label4.Text = "МОДЕЛЬ МАШИНЫ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ModelsListBox
            // 
            ModelsListBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ModelsListBox.FormattingEnabled = true;
            ModelsListBox.IntegralHeight = false;
            ModelsListBox.ItemHeight = 15;
            ModelsListBox.Location = new Point(149, 18);
            ModelsListBox.Name = "ModelsListBox";
            ModelsListBox.Size = new Size(140, 122);
            ModelsListBox.TabIndex = 24;
            ModelsListBox.SelectedIndexChanged += ModelsListBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 1);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 21;
            label3.Text = "БРЕНД МАШИНЫ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BrandsListBox
            // 
            BrandsListBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BrandsListBox.FormattingEnabled = true;
            BrandsListBox.IntegralHeight = false;
            BrandsListBox.ItemHeight = 15;
            BrandsListBox.Location = new Point(3, 19);
            BrandsListBox.Name = "BrandsListBox";
            BrandsListBox.Size = new Size(140, 122);
            BrandsListBox.TabIndex = 21;
            BrandsListBox.SelectedIndexChanged += BrandsListBox_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(NameDetailLabel);
            panel1.Location = new Point(441, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(172, 124);
            panel1.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonShadow;
            label5.Location = new Point(5, 4);
            label5.Name = "label5";
            label5.Size = new Size(48, 12);
            label5.TabIndex = 0;
            label5.Text = "Название";
            // 
            // NameDetailLabel
            // 
            NameDetailLabel.BackColor = Color.Transparent;
            NameDetailLabel.ForeColor = SystemColors.ControlText;
            NameDetailLabel.Location = new Point(0, 0);
            NameDetailLabel.Name = "NameDetailLabel";
            NameDetailLabel.Size = new Size(172, 124);
            NameDetailLabel.TabIndex = 1;
            NameDetailLabel.Text = "НЕИЗВЕСТНО";
            NameDetailLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(DescriptionDetailLabel);
            panel2.Location = new Point(441, 145);
            panel2.Name = "panel2";
            panel2.Size = new Size(172, 252);
            panel2.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonShadow;
            label8.Location = new Point(5, 4);
            label8.Name = "label8";
            label8.Size = new Size(52, 12);
            label8.TabIndex = 0;
            label8.Text = "Описание";
            // 
            // DescriptionDetailLabel
            // 
            DescriptionDetailLabel.BackColor = Color.Transparent;
            DescriptionDetailLabel.ForeColor = SystemColors.ControlText;
            DescriptionDetailLabel.Location = new Point(0, 0);
            DescriptionDetailLabel.Name = "DescriptionDetailLabel";
            DescriptionDetailLabel.Size = new Size(172, 252);
            DescriptionDetailLabel.TabIndex = 1;
            DescriptionDetailLabel.Text = "НЕИЗВЕСТНО";
            DescriptionDetailLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(label10);
            panel3.Controls.Add(ManufacturerDetailLabel);
            panel3.Location = new Point(441, 502);
            panel3.Name = "panel3";
            panel3.Size = new Size(172, 48);
            panel3.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ButtonShadow;
            label10.Location = new Point(5, 4);
            label10.Name = "label10";
            label10.Size = new Size(75, 12);
            label10.TabIndex = 0;
            label10.Text = "Производитель";
            // 
            // ManufacturerDetailLabel
            // 
            ManufacturerDetailLabel.BackColor = Color.Transparent;
            ManufacturerDetailLabel.ForeColor = SystemColors.ControlText;
            ManufacturerDetailLabel.Location = new Point(0, 0);
            ManufacturerDetailLabel.Name = "ManufacturerDetailLabel";
            ManufacturerDetailLabel.Size = new Size(172, 48);
            ManufacturerDetailLabel.TabIndex = 1;
            ManufacturerDetailLabel.Text = "НЕИЗВЕСТНО";
            ManufacturerDetailLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.WhiteSmoke;
            panel4.Controls.Add(label11);
            panel4.Controls.Add(CountryOriginDetailLabel);
            panel4.Location = new Point(441, 553);
            panel4.Name = "panel4";
            panel4.Size = new Size(172, 48);
            panel4.TabIndex = 23;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ButtonShadow;
            label11.Location = new Point(5, 4);
            label11.Name = "label11";
            label11.Size = new Size(66, 12);
            label11.TabIndex = 0;
            label11.Text = "Изготовитель";
            // 
            // CountryOriginDetailLabel
            // 
            CountryOriginDetailLabel.BackColor = Color.Transparent;
            CountryOriginDetailLabel.ForeColor = SystemColors.ControlText;
            CountryOriginDetailLabel.Location = new Point(0, 0);
            CountryOriginDetailLabel.Name = "CountryOriginDetailLabel";
            CountryOriginDetailLabel.Size = new Size(172, 48);
            CountryOriginDetailLabel.TabIndex = 1;
            CountryOriginDetailLabel.Text = "НЕИЗВЕСТНО";
            CountryOriginDetailLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.BackColor = Color.WhiteSmoke;
            panel5.Controls.Add(label13);
            panel5.Controls.Add(PriceDetailLabel);
            panel5.Location = new Point(441, 604);
            panel5.Name = "panel5";
            panel5.Size = new Size(172, 48);
            panel5.TabIndex = 24;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ButtonShadow;
            label13.Location = new Point(5, 4);
            label13.Name = "label13";
            label13.Size = new Size(28, 12);
            label13.TabIndex = 0;
            label13.Text = "Цена";
            // 
            // PriceDetailLabel
            // 
            PriceDetailLabel.BackColor = Color.Transparent;
            PriceDetailLabel.ForeColor = SystemColors.ControlText;
            PriceDetailLabel.Location = new Point(0, 0);
            PriceDetailLabel.Name = "PriceDetailLabel";
            PriceDetailLabel.Size = new Size(172, 48);
            PriceDetailLabel.TabIndex = 1;
            PriceDetailLabel.Text = "НЕИЗВЕСТНО";
            PriceDetailLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(441, 0);
            label6.Name = "label6";
            label6.Size = new Size(154, 15);
            label6.TabIndex = 25;
            label6.Text = "ИНФОРМАЦИЯ О ДЕТАЛИ";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddCarDetailButton
            // 
            AddCarDetailButton.BackColor = Color.LemonChiffon;
            AddCarDetailButton.Cursor = Cursors.Hand;
            AddCarDetailButton.FlatStyle = FlatStyle.Flat;
            AddCarDetailButton.Location = new Point(295, 570);
            AddCarDetailButton.Name = "AddCarDetailButton";
            AddCarDetailButton.Size = new Size(140, 54);
            AddCarDetailButton.TabIndex = 25;
            AddCarDetailButton.Text = "СВЯЗАТЬ МОДЕЛЬ И ДЕТАЛЬ";
            AddCarDetailButton.UseVisualStyleBackColor = false;
            AddCarDetailButton.Click += AddCarDetailButton_Click;
            // 
            // BrandTextBox
            // 
            BrandTextBox.AccessibleName = "";
            BrandTextBox.Location = new Point(3, 147);
            BrandTextBox.Name = "BrandTextBox";
            BrandTextBox.PlaceholderText = "Название бренда";
            BrandTextBox.Size = new Size(140, 23);
            BrandTextBox.TabIndex = 30;
            BrandTextBox.TextChanged += BrandTextBox_TextChanged;
            // 
            // ModelTextBox
            // 
            ModelTextBox.AccessibleName = "";
            ModelTextBox.Location = new Point(149, 146);
            ModelTextBox.Name = "ModelTextBox";
            ModelTextBox.PlaceholderText = "Название модели";
            ModelTextBox.Size = new Size(140, 23);
            ModelTextBox.TabIndex = 31;
            ModelTextBox.TextChanged += ModelTextBox_TextChanged;
            // 
            // AddModelButton
            // 
            AddModelButton.BackColor = Color.DarkSeaGreen;
            AddModelButton.Cursor = Cursors.Hand;
            AddModelButton.FlatStyle = FlatStyle.Flat;
            AddModelButton.Location = new Point(149, 176);
            AddModelButton.Name = "AddModelButton";
            AddModelButton.Size = new Size(140, 23);
            AddModelButton.TabIndex = 35;
            AddModelButton.Text = "ДОБАВИТЬ";
            AddModelButton.UseVisualStyleBackColor = false;
            AddModelButton.Click += AddModelButton_Click;
            // 
            // DeleteModelButton
            // 
            DeleteModelButton.BackColor = Color.RosyBrown;
            DeleteModelButton.Cursor = Cursors.Hand;
            DeleteModelButton.FlatStyle = FlatStyle.Flat;
            DeleteModelButton.Location = new Point(149, 205);
            DeleteModelButton.Name = "DeleteModelButton";
            DeleteModelButton.Size = new Size(140, 23);
            DeleteModelButton.TabIndex = 34;
            DeleteModelButton.Text = "УДАЛИТЬ";
            DeleteModelButton.UseVisualStyleBackColor = false;
            DeleteModelButton.Click += DeleteModelButton_Click;
            // 
            // AddBrandButton
            // 
            AddBrandButton.BackColor = Color.DarkSeaGreen;
            AddBrandButton.Cursor = Cursors.Hand;
            AddBrandButton.FlatStyle = FlatStyle.Flat;
            AddBrandButton.Location = new Point(3, 176);
            AddBrandButton.Name = "AddBrandButton";
            AddBrandButton.Size = new Size(140, 23);
            AddBrandButton.TabIndex = 33;
            AddBrandButton.Text = "ДОБАВИТЬ";
            AddBrandButton.UseVisualStyleBackColor = false;
            AddBrandButton.Click += AddBrandButton_Click;
            // 
            // DeleteBrandButton
            // 
            DeleteBrandButton.BackColor = Color.RosyBrown;
            DeleteBrandButton.Cursor = Cursors.Hand;
            DeleteBrandButton.FlatStyle = FlatStyle.Flat;
            DeleteBrandButton.Location = new Point(3, 205);
            DeleteBrandButton.Name = "DeleteBrandButton";
            DeleteBrandButton.Size = new Size(140, 23);
            DeleteBrandButton.TabIndex = 32;
            DeleteBrandButton.Text = "УДАЛИТЬ";
            DeleteBrandButton.UseVisualStyleBackColor = false;
            DeleteBrandButton.Click += DeleteBrandButton_Click;
            // 
            // DeleteCarDetailButton
            // 
            DeleteCarDetailButton.BackColor = Color.RosyBrown;
            DeleteCarDetailButton.Cursor = Cursors.Hand;
            DeleteCarDetailButton.FlatStyle = FlatStyle.Flat;
            DeleteCarDetailButton.Location = new Point(295, 629);
            DeleteCarDetailButton.Name = "DeleteCarDetailButton";
            DeleteCarDetailButton.Size = new Size(140, 23);
            DeleteCarDetailButton.TabIndex = 38;
            DeleteCarDetailButton.Text = "УДАЛИТЬ";
            DeleteCarDetailButton.UseVisualStyleBackColor = false;
            DeleteCarDetailButton.Click += DeleteCarDetailButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(295, 0);
            label7.Name = "label7";
            label7.Size = new Size(133, 15);
            label7.TabIndex = 37;
            label7.Text = "ДЕТАЛИ НА ПРОДАЖЕ";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CarDetailsListBox
            // 
            CarDetailsListBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CarDetailsListBox.FormattingEnabled = true;
            CarDetailsListBox.IntegralHeight = false;
            CarDetailsListBox.ItemHeight = 15;
            CarDetailsListBox.Location = new Point(295, 18);
            CarDetailsListBox.Name = "CarDetailsListBox";
            CarDetailsListBox.Size = new Size(140, 547);
            CarDetailsListBox.TabIndex = 36;
            CarDetailsListBox.SelectedIndexChanged += CarDetailsListBox_SelectedValueChanged;
            // 
            // panel6
            // 
            panel6.BackColor = Color.WhiteSmoke;
            panel6.Controls.Add(label9);
            panel6.Controls.Add(TypeDetailLabel);
            panel6.Location = new Point(441, 400);
            panel6.Name = "panel6";
            panel6.Size = new Size(172, 48);
            panel6.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonShadow;
            label9.Location = new Point(5, 4);
            label9.Name = "label9";
            label9.Size = new Size(55, 12);
            label9.TabIndex = 0;
            label9.Text = "Тип детали";
            // 
            // TypeDetailLabel
            // 
            TypeDetailLabel.BackColor = Color.Transparent;
            TypeDetailLabel.ForeColor = SystemColors.ControlText;
            TypeDetailLabel.Location = new Point(0, 0);
            TypeDetailLabel.Name = "TypeDetailLabel";
            TypeDetailLabel.Size = new Size(172, 48);
            TypeDetailLabel.TabIndex = 1;
            TypeDetailLabel.Text = "НЕИЗВЕСТНО";
            TypeDetailLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            panel7.BackColor = Color.WhiteSmoke;
            panel7.Controls.Add(label12);
            panel7.Controls.Add(BrandModelLabel);
            panel7.Location = new Point(441, 451);
            panel7.Name = "panel7";
            panel7.Size = new Size(172, 48);
            panel7.TabIndex = 23;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ButtonShadow;
            label12.Location = new Point(5, 4);
            label12.Name = "label12";
            label12.Size = new Size(44, 12);
            label12.TabIndex = 0;
            label12.Text = "Машина";
            // 
            // BrandModelLabel
            // 
            BrandModelLabel.BackColor = Color.Transparent;
            BrandModelLabel.ForeColor = SystemColors.ControlText;
            BrandModelLabel.Location = new Point(0, 0);
            BrandModelLabel.Name = "BrandModelLabel";
            BrandModelLabel.Size = new Size(172, 48);
            BrandModelLabel.TabIndex = 1;
            BrandModelLabel.Text = "НЕИЗВЕСТНО";
            BrandModelLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(label3);
            MainPanel.Controls.Add(panel7);
            MainPanel.Controls.Add(TypeDetailsListBox);
            MainPanel.Controls.Add(panel6);
            MainPanel.Controls.Add(label1);
            MainPanel.Controls.Add(DeleteCarDetailButton);
            MainPanel.Controls.Add(TypeDetailTextBox);
            MainPanel.Controls.Add(label7);
            MainPanel.Controls.Add(DeleteTypeDetailButton);
            MainPanel.Controls.Add(CarDetailsListBox);
            MainPanel.Controls.Add(AddTypeDetailButton);
            MainPanel.Controls.Add(AddModelButton);
            MainPanel.Controls.Add(DetailsListBox);
            MainPanel.Controls.Add(DeleteModelButton);
            MainPanel.Controls.Add(label2);
            MainPanel.Controls.Add(AddBrandButton);
            MainPanel.Controls.Add(DeleteDetailButton);
            MainPanel.Controls.Add(DeleteBrandButton);
            MainPanel.Controls.Add(BrandsListBox);
            MainPanel.Controls.Add(ModelTextBox);
            MainPanel.Controls.Add(NewDetailPanel);
            MainPanel.Controls.Add(BrandTextBox);
            MainPanel.Controls.Add(panel1);
            MainPanel.Controls.Add(AddCarDetailButton);
            MainPanel.Controls.Add(panel2);
            MainPanel.Controls.Add(label6);
            MainPanel.Controls.Add(ModelsListBox);
            MainPanel.Controls.Add(label4);
            MainPanel.Controls.Add(panel3);
            MainPanel.Controls.Add(panel5);
            MainPanel.Controls.Add(panel4);
            MainPanel.Location = new Point(12, 12);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(621, 663);
            MainPanel.TabIndex = 39;
            // 
            // DetailsManagmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(640, 681);
            Controls.Add(MainPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "DetailsManagmentForm";
            Text = "Управление данными о деталях";
            Resize += DetailsManagmentForm_Resize;
            NewDetailPanel.ResumeLayout(false);
            NewDetailPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button AddTypeDetailButton;
        private Button DeleteTypeDetailButton;
        private TextBox TypeDetailTextBox;
        private Label label1;
        private ListBox TypeDetailsListBox;
        private Button DeleteDetailButton;
        private Label label2;
        private ListBox DetailsListBox;
        private GroupBox NewDetailPanel;
        private TextBox NameDetailTextBox;
        private TextBox DescDetailTextBox;
        private TextBox ManufacturerDetailTextBox;
        private TextBox CountryOriginDetailTextBox;
        private TextBox PriceDetailTextBox;
        private Button AddNewDetailButton;
        private Label label4;
        private ListBox ModelsListBox;
        private Label label3;
        private ListBox BrandsListBox;
        private Panel panel1;
        private Label NameDetailLabel;
        private Label label5;
        private Panel panel2;
        private Label DescriptionDetailLabel;
        private Label label8;
        private Panel panel3;
        private Label ManufacturerDetailLabel;
        private Label label10;
        private Panel panel4;
        private Label label11;
        private Label CountryOriginDetailLabel;
        private Panel panel5;
        private Label label13;
        private Label PriceDetailLabel;
        private Label label6;
        private Button AddCarDetailButton;
        private TextBox BrandTextBox;
        private TextBox ModelTextBox;
        private Button AddModelButton;
        private Button DeleteModelButton;
        private Button AddBrandButton;
        private Button DeleteBrandButton;
        private Button DeleteCarDetailButton;
        private Label label7;
        private ListBox CarDetailsListBox;
        private Panel panel6;
        private Label label9;
        private Label TypeDetailLabel;
        private Panel panel7;
        private Label label12;
        private Label BrandModelLabel;
        private Panel MainPanel;
    }
}