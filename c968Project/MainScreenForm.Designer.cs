namespace c968Project
{
    partial class MainScreenForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.partBtnSearch = new System.Windows.Forms.Button();
            this.partSearchTextBox = new System.Windows.Forms.TextBox();
            this.partBtnAdd = new System.Windows.Forms.Button();
            this.partBtnMod = new System.Windows.Forms.Button();
            this.partBtnDel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.prodBtnDel = new System.Windows.Forms.Button();
            this.prodBtnMod = new System.Windows.Forms.Button();
            this.prodBtnAdd = new System.Windows.Forms.Button();
            this.prodSearchTextBox = new System.Windows.Forms.TextBox();
            this.prodBtnSearch = new System.Windows.Forms.Button();
            this.DGVProducts = new System.Windows.Forms.DataGridView();
            this.productId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodInventoryLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodPricePerUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button9 = new System.Windows.Forms.Button();
            this.DGVParts = new System.Windows.Forms.DataGridView();
            this.partID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partInventoryLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partPricePerUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.exitAppBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVParts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Management System";
            // 
            // partBtnSearch
            // 
            this.partBtnSearch.Location = new System.Drawing.Point(288, 19);
            this.partBtnSearch.Name = "partBtnSearch";
            this.partBtnSearch.Size = new System.Drawing.Size(60, 23);
            this.partBtnSearch.TabIndex = 2;
            this.partBtnSearch.Text = "Search";
            this.partBtnSearch.UseVisualStyleBackColor = true;
            this.partBtnSearch.Click += new System.EventHandler(this.PartBtnSearch_Click);
            // 
            // partSearchTextBox
            // 
            this.partSearchTextBox.Location = new System.Drawing.Point(354, 22);
            this.partSearchTextBox.Name = "partSearchTextBox";
            this.partSearchTextBox.Size = new System.Drawing.Size(105, 20);
            this.partSearchTextBox.TabIndex = 3;
            // 
            // partBtnAdd
            // 
            this.partBtnAdd.Location = new System.Drawing.Point(164, 309);
            this.partBtnAdd.Name = "partBtnAdd";
            this.partBtnAdd.Size = new System.Drawing.Size(79, 23);
            this.partBtnAdd.TabIndex = 1;
            this.partBtnAdd.Text = "Add";
            this.partBtnAdd.UseVisualStyleBackColor = true;
            this.partBtnAdd.Click += new System.EventHandler(this.PartBtnAdd_Click);
            // 
            // partBtnMod
            // 
            this.partBtnMod.Location = new System.Drawing.Point(259, 309);
            this.partBtnMod.Name = "partBtnMod";
            this.partBtnMod.Size = new System.Drawing.Size(79, 23);
            this.partBtnMod.TabIndex = 5;
            this.partBtnMod.Text = "Modify";
            this.partBtnMod.UseVisualStyleBackColor = true;
            this.partBtnMod.Click += new System.EventHandler(this.MdfyBtnPart_Click);
            // 
            // partBtnDel
            // 
            this.partBtnDel.Location = new System.Drawing.Point(354, 309);
            this.partBtnDel.Name = "partBtnDel";
            this.partBtnDel.Size = new System.Drawing.Size(79, 23);
            this.partBtnDel.TabIndex = 6;
            this.partBtnDel.Text = "Delete";
            this.partBtnDel.UseVisualStyleBackColor = true;
            this.partBtnDel.Click += new System.EventHandler(this.DeletePartBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(13, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Parts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(24, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Products";
            // 
            // prodBtnDel
            // 
            this.prodBtnDel.Location = new System.Drawing.Point(368, 308);
            this.prodBtnDel.Name = "prodBtnDel";
            this.prodBtnDel.Size = new System.Drawing.Size(79, 23);
            this.prodBtnDel.TabIndex = 14;
            this.prodBtnDel.Text = "Delete";
            this.prodBtnDel.UseVisualStyleBackColor = true;
            this.prodBtnDel.Click += new System.EventHandler(this.DeleteProdBtn_Click);
            // 
            // prodBtnMod
            // 
            this.prodBtnMod.Location = new System.Drawing.Point(273, 308);
            this.prodBtnMod.Name = "prodBtnMod";
            this.prodBtnMod.Size = new System.Drawing.Size(79, 23);
            this.prodBtnMod.TabIndex = 13;
            this.prodBtnMod.Text = "Modify";
            this.prodBtnMod.UseVisualStyleBackColor = true;
            this.prodBtnMod.Click += new System.EventHandler(this.MdfyBtnProd_Click);
            // 
            // prodBtnAdd
            // 
            this.prodBtnAdd.Location = new System.Drawing.Point(178, 308);
            this.prodBtnAdd.Name = "prodBtnAdd";
            this.prodBtnAdd.Size = new System.Drawing.Size(79, 23);
            this.prodBtnAdd.TabIndex = 1;
            this.prodBtnAdd.Text = "Add";
            this.prodBtnAdd.UseVisualStyleBackColor = true;
            this.prodBtnAdd.Click += new System.EventHandler(this.ProdBtnAdd_Click);
            // 
            // prodSearchTextBox
            // 
            this.prodSearchTextBox.Location = new System.Drawing.Point(368, 22);
            this.prodSearchTextBox.Name = "prodSearchTextBox";
            this.prodSearchTextBox.Size = new System.Drawing.Size(97, 20);
            this.prodSearchTextBox.TabIndex = 11;
            // 
            // prodBtnSearch
            // 
            this.prodBtnSearch.Location = new System.Drawing.Point(302, 19);
            this.prodBtnSearch.Name = "prodBtnSearch";
            this.prodBtnSearch.Size = new System.Drawing.Size(60, 23);
            this.prodBtnSearch.TabIndex = 10;
            this.prodBtnSearch.Text = "Search";
            this.prodBtnSearch.UseVisualStyleBackColor = true;
            this.prodBtnSearch.Click += new System.EventHandler(this.ProdBtnSearch_Click);
            // 
            // DGVProducts
            // 
            this.DGVProducts.AllowUserToAddRows = false;
            this.DGVProducts.AllowUserToDeleteRows = false;
            this.DGVProducts.AllowUserToResizeColumns = false;
            this.DGVProducts.AllowUserToResizeRows = false;
            this.DGVProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGVProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productId,
            this.productName,
            this.prodInventoryLevel,
            this.prodPricePerUnit});
            this.DGVProducts.Location = new System.Drawing.Point(27, 58);
            this.DGVProducts.Name = "DGVProducts";
            this.DGVProducts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGVProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVProducts.Size = new System.Drawing.Size(438, 244);
            this.DGVProducts.TabIndex = 9;
            this.DGVProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectRowHandler);
            this.DGVProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectRowHandler);
            this.DGVProducts.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectRowHandler);
            this.DGVProducts.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectRowHandler);
            // 
            // productId
            // 
            this.productId.HeaderText = "Product ID";
            this.productId.Name = "productId";
            // 
            // productName
            // 
            this.productName.HeaderText = "Product Name";
            this.productName.Name = "productName";
            // 
            // prodInventoryLevel
            // 
            this.prodInventoryLevel.HeaderText = "Inventory Level";
            this.prodInventoryLevel.Name = "prodInventoryLevel";
            // 
            // prodPricePerUnit
            // 
            this.prodPricePerUnit.HeaderText = "Price/Cost per Unit";
            this.prodPricePerUnit.Name = "prodPricePerUnit";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(402, 359);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 16;
            this.button9.Text = "Exit";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Exit_Button);
            // 
            // DGVParts
            // 
            this.DGVParts.AllowUserToAddRows = false;
            this.DGVParts.AllowUserToDeleteRows = false;
            this.DGVParts.AllowUserToResizeColumns = false;
            this.DGVParts.AllowUserToResizeRows = false;
            this.DGVParts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGVParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partID,
            this.partName,
            this.partInventoryLevel,
            this.partPricePerUnit});
            this.DGVParts.Location = new System.Drawing.Point(16, 59);
            this.DGVParts.Name = "DGVParts";
            this.DGVParts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGVParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVParts.Size = new System.Drawing.Size(443, 244);
            this.DGVParts.TabIndex = 1;
            this.DGVParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectRowHandler);
            this.DGVParts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectRowHandler);
            this.DGVParts.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectRowHandler);
            this.DGVParts.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectRowHandler);
            // 
            // partID
            // 
            this.partID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.partID.HeaderText = "Part ID";
            this.partID.Name = "partID";
            // 
            // partName
            // 
            this.partName.HeaderText = "Part Name";
            this.partName.Name = "partName";
            // 
            // partInventoryLevel
            // 
            this.partInventoryLevel.HeaderText = "Inventory Level";
            this.partInventoryLevel.Name = "partInventoryLevel";
            // 
            // partPricePerUnit
            // 
            this.partPricePerUnit.HeaderText = "Price/Cost per Unit";
            this.partPricePerUnit.Name = "partPricePerUnit";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DGVParts);
            this.groupBox1.Controls.Add(this.partBtnSearch);
            this.groupBox1.Controls.Add(this.partSearchTextBox);
            this.groupBox1.Controls.Add(this.partBtnAdd);
            this.groupBox1.Controls.Add(this.partBtnMod);
            this.groupBox1.Controls.Add(this.partBtnDel);
            this.groupBox1.Location = new System.Drawing.Point(21, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 345);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.DGVProducts);
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Controls.Add(this.prodBtnSearch);
            this.groupBox2.Controls.Add(this.prodSearchTextBox);
            this.groupBox2.Controls.Add(this.prodBtnDel);
            this.groupBox2.Controls.Add(this.prodBtnAdd);
            this.groupBox2.Controls.Add(this.prodBtnMod);
            this.groupBox2.Location = new System.Drawing.Point(574, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 345);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // exitAppBtn
            // 
            this.exitAppBtn.Location = new System.Drawing.Point(942, 407);
            this.exitAppBtn.Name = "exitAppBtn";
            this.exitAppBtn.Size = new System.Drawing.Size(75, 23);
            this.exitAppBtn.TabIndex = 19;
            this.exitAppBtn.Text = "Exit";
            this.exitAppBtn.UseVisualStyleBackColor = true;
            this.exitAppBtn.Click += new System.EventHandler(this.Exit_Button);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1076, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1087, 470);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exitAppBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "MainScreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)(this.DGVProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVParts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button partBtnSearch;
        private System.Windows.Forms.TextBox partSearchTextBox;
        private System.Windows.Forms.Button partBtnAdd;
        private System.Windows.Forms.Button partBtnMod;
        private System.Windows.Forms.Button partBtnDel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button prodBtnDel;
        private System.Windows.Forms.Button prodBtnMod;
        private System.Windows.Forms.Button prodBtnAdd;
        private System.Windows.Forms.TextBox prodSearchTextBox;
        private System.Windows.Forms.Button prodBtnSearch;
        public System.Windows.Forms.DataGridView DGVProducts;
        private System.Windows.Forms.Button button9;
        public System.Windows.Forms.DataGridView DGVParts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button exitAppBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productId;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodInventoryLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodPricePerUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn partID;
        private System.Windows.Forms.DataGridViewTextBoxColumn partName;
        private System.Windows.Forms.DataGridViewTextBoxColumn partInventoryLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn partPricePerUnit;
        private System.Windows.Forms.Button button1;
    }
}

