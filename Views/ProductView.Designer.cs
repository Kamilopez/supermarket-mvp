namespace Supermarket_mvp.Views
{
    partial class ProductView
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
            tabControl1 = new TabControl();
            tabPageProductList = new TabPage();
            BtnCloseP = new Button();
            BtnDeleteP = new Button();
            BtnEditP = new Button();
            BtnNewP = new Button();
            DgProduct = new DataGridView();
            BtnSearchP = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabPageProductDetail = new TabPage();
            TxtProductCategory = new TextBox();
            label7 = new Label();
            TxtProductStock = new TextBox();
            label6 = new Label();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtProductPrice = new TextBox();
            TxtProductName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            TxtProductId = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPageProductList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProduct).BeginInit();
            tabPageProductDetail.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageProductList);
            tabControl1.Controls.Add(tabPageProductDetail);
            tabControl1.Location = new Point(-1, 88);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(824, 388);
            tabControl1.TabIndex = 3;
            // 
            // tabPageProductList
            // 
            tabPageProductList.Controls.Add(BtnCloseP);
            tabPageProductList.Controls.Add(BtnDeleteP);
            tabPageProductList.Controls.Add(BtnEditP);
            tabPageProductList.Controls.Add(BtnNewP);
            tabPageProductList.Controls.Add(DgProduct);
            tabPageProductList.Controls.Add(BtnSearchP);
            tabPageProductList.Controls.Add(TxtSearch);
            tabPageProductList.Controls.Add(label2);
            tabPageProductList.Location = new Point(4, 29);
            tabPageProductList.Name = "tabPageProductList";
            tabPageProductList.Padding = new Padding(3);
            tabPageProductList.Size = new Size(816, 355);
            tabPageProductList.TabIndex = 0;
            tabPageProductList.Text = "Products List";
            tabPageProductList.UseVisualStyleBackColor = true;
            // 
            // BtnCloseP
            // 
            BtnCloseP.Image = Properties.Resources.cerrar;
            BtnCloseP.Location = new Point(656, 269);
            BtnCloseP.Name = "BtnCloseP";
            BtnCloseP.Size = new Size(140, 59);
            BtnCloseP.TabIndex = 15;
            BtnCloseP.UseVisualStyleBackColor = true;
            // 
            // BtnDeleteP
            // 
            BtnDeleteP.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDeleteP.Image = Properties.Resources.delete;
            BtnDeleteP.Location = new Point(656, 204);
            BtnDeleteP.Name = "BtnDeleteP";
            BtnDeleteP.Size = new Size(140, 59);
            BtnDeleteP.TabIndex = 14;
            BtnDeleteP.UseVisualStyleBackColor = true;
            // 
            // BtnEditP
            // 
            BtnEditP.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEditP.Image = Properties.Resources.edit;
            BtnEditP.Location = new Point(656, 139);
            BtnEditP.Name = "BtnEditP";
            BtnEditP.Size = new Size(140, 59);
            BtnEditP.TabIndex = 13;
            BtnEditP.UseVisualStyleBackColor = true;
            // 
            // BtnNewP
            // 
            BtnNewP.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNewP.Image = Properties.Resources._new;
            BtnNewP.Location = new Point(656, 74);
            BtnNewP.Name = "BtnNewP";
            BtnNewP.Size = new Size(140, 59);
            BtnNewP.TabIndex = 12;
            BtnNewP.UseVisualStyleBackColor = true;
            // 
            // DgProduct
            // 
            DgProduct.AllowUserToAddRows = false;
            DgProduct.AllowUserToDeleteRows = false;
            DgProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProduct.Location = new Point(17, 68);
            DgProduct.Name = "DgProduct";
            DgProduct.ReadOnly = true;
            DgProduct.RowHeadersWidth = 51;
            DgProduct.Size = new Size(627, 279);
            DgProduct.TabIndex = 11;
            // 
            // BtnSearchP
            // 
            BtnSearchP.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearchP.Image = Properties.Resources.search_small;
            BtnSearchP.Location = new Point(585, 12);
            BtnSearchP.Name = "BtnSearchP";
            BtnSearchP.Size = new Size(56, 49);
            BtnSearchP.TabIndex = 10;
            BtnSearchP.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(17, 30);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(554, 27);
            TxtSearch.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 7);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 8;
            label2.Text = "Search Product";
            // 
            // tabPageProductDetail
            // 
            tabPageProductDetail.Controls.Add(TxtProductCategory);
            tabPageProductDetail.Controls.Add(label7);
            tabPageProductDetail.Controls.Add(TxtProductStock);
            tabPageProductDetail.Controls.Add(label6);
            tabPageProductDetail.Controls.Add(BtnCancel);
            tabPageProductDetail.Controls.Add(BtnSave);
            tabPageProductDetail.Controls.Add(TxtProductPrice);
            tabPageProductDetail.Controls.Add(TxtProductName);
            tabPageProductDetail.Controls.Add(label5);
            tabPageProductDetail.Controls.Add(label4);
            tabPageProductDetail.Controls.Add(TxtProductId);
            tabPageProductDetail.Controls.Add(label3);
            tabPageProductDetail.ImeMode = ImeMode.On;
            tabPageProductDetail.Location = new Point(4, 29);
            tabPageProductDetail.Name = "tabPageProductDetail";
            tabPageProductDetail.Padding = new Padding(3);
            tabPageProductDetail.Size = new Size(816, 355);
            tabPageProductDetail.TabIndex = 1;
            tabPageProductDetail.Text = "Products Detail";
            tabPageProductDetail.UseVisualStyleBackColor = true;
            // 
            // TxtProductCategory
            // 
            TxtProductCategory.Location = new Point(45, 322);
            TxtProductCategory.Name = "TxtProductCategory";
            TxtProductCategory.PlaceholderText = "Product Category";
            TxtProductCategory.Size = new Size(444, 27);
            TxtProductCategory.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(48, 302);
            label7.Name = "label7";
            label7.Size = new Size(124, 20);
            label7.TabIndex = 10;
            label7.Text = "Product Category";
            // 
            // TxtProductStock
            // 
            TxtProductStock.Location = new Point(45, 249);
            TxtProductStock.Name = "TxtProductStock";
            TxtProductStock.PlaceholderText = "Product Stock";
            TxtProductStock.Size = new Size(444, 27);
            TxtProductStock.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 229);
            label6.Name = "label6";
            label6.Size = new Size(100, 20);
            label6.TabIndex = 8;
            label6.Text = "Product Stock";
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(634, 222);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(94, 80);
            BtnCancel.TabIndex = 7;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(634, 97);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(94, 80);
            BtnSave.TabIndex = 6;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtProductPrice
            // 
            TxtProductPrice.Location = new Point(45, 175);
            TxtProductPrice.Name = "TxtProductPrice";
            TxtProductPrice.PlaceholderText = "Product Price";
            TxtProductPrice.Size = new Size(444, 27);
            TxtProductPrice.TabIndex = 5;
            // 
            // TxtProductName
            // 
            TxtProductName.Location = new Point(45, 105);
            TxtProductName.Name = "TxtProductName";
            TxtProductName.PlaceholderText = "Pay Mode Name";
            TxtProductName.Size = new Size(444, 27);
            TxtProductName.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 155);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 3;
            label5.Text = "Product Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 85);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 2;
            label4.Text = "Product Name";
            // 
            // TxtProductId
            // 
            TxtProductId.Location = new Point(45, 38);
            TxtProductId.Name = "TxtProductId";
            TxtProductId.ReadOnly = true;
            TxtProductId.Size = new Size(207, 27);
            TxtProductId.TabIndex = 1;
            TxtProductId.Text = "0";
            TxtProductId.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 18);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 0;
            label3.Text = "Product Id";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(811, 113);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.products;
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(129, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(134, 25);
            label1.Name = "label1";
            label1.Size = new Size(221, 67);
            label1.TabIndex = 0;
            label1.Text = "Products";
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 554);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProductView";
            Text = "Product Management";
            tabControl1.ResumeLayout(false);
            tabPageProductList.ResumeLayout(false);
            tabPageProductList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProduct).EndInit();
            tabPageProductDetail.ResumeLayout(false);
            tabPageProductDetail.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageProductList;
        private TabPage tabPageProductDetail;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtProductPrice;
        private TextBox TxtProductName;
        private Label label5;
        private Label label4;
        private TextBox TxtProductId;
        private Label label3;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button BtnDeleteP;
        private Button BtnEditP;
        private Button BtnNewP;
        private DataGridView DgProduct;
        private Button BtnSearchP;
        private TextBox TxtSearch;
        private Label label2;
        private TextBox TxtProductCategory;
        private Label label7;
        private TextBox TxtProductStock;
        private Label label6;
        private Button BtnCloseP;
    }
}