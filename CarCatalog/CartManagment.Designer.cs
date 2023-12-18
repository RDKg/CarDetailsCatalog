namespace CarCatalog
{
    partial class CartManagmentForm
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
            panel1 = new Panel();
            DetailsPanel = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(DetailsPanel);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1024, 373);
            panel1.TabIndex = 25;
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
            // CartManagmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1051, 400);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CartManagmentForm";
            Text = "Корзина";
            Load += CartManagmentForm_Load;
            Resize += CartManagmentForm_Resize;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel DetailsPanel;
    }
}