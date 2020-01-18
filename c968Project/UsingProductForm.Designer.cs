namespace c968Project
{
    partial class UsingProductForm
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
            this.searchBtnProd = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cnclBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.DGVTop = new System.Windows.Forms.DataGridView();
            this.idClmn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameClmn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invClmn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceClmn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVBot = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.upfIdBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.invBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.maxBox = new System.Windows.Forms.TextBox();
            this.idLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.invLbl = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.maxLbl = new System.Windows.Forms.Label();
            this.minLbl = new System.Windows.Forms.Label();
            this.minBox = new System.Windows.Forms.TextBox();
            this.mainGroupBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBot)).BeginInit();
            this.mainGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchBtnProd
            // 
            this.searchBtnProd.Location = new System.Drawing.Point(537, 22);
            this.searchBtnProd.Name = "searchBtnProd";
            this.searchBtnProd.Size = new System.Drawing.Size(75, 23);
            this.searchBtnProd.TabIndex = 0;
            this.searchBtnProd.Text = "Search";
            this.searchBtnProd.UseVisualStyleBackColor = true;
            this.searchBtnProd.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Enabled = false;
            this.saveBtn.Location = new System.Drawing.Point(628, 521);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // cnclBtn
            // 
            this.cnclBtn.Location = new System.Drawing.Point(724, 521);
            this.cnclBtn.Name = "cnclBtn";
            this.cnclBtn.Size = new System.Drawing.Size(75, 23);
            this.cnclBtn.TabIndex = 2;
            this.cnclBtn.Text = "Cancel";
            this.cnclBtn.UseVisualStyleBackColor = true;
            this.cnclBtn.Click += new System.EventHandler(this.CnclBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(724, 481);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(75, 23);
            this.delBtn.TabIndex = 3;
            this.delBtn.Text = "Delete";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(724, 217);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DGVTop
            // 
            this.DGVTop.AllowUserToAddRows = false;
            this.DGVTop.AllowUserToDeleteRows = false;
            this.DGVTop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClmn,
            this.nameClmn,
            this.invClmn,
            this.priceClmn});
            this.DGVTop.Location = new System.Drawing.Point(382, 61);
            this.DGVTop.Name = "DGVTop";
            this.DGVTop.ReadOnly = true;
            this.DGVTop.Size = new System.Drawing.Size(443, 146);
            this.DGVTop.TabIndex = 5;
            this.DGVTop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVTop_CellClick);
            this.DGVTop.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVTop_CellClick);
            this.DGVTop.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVTop_CellClick);
            // 
            // idClmn
            // 
            this.idClmn.HeaderText = "Part ID";
            this.idClmn.Name = "idClmn";
            this.idClmn.ReadOnly = true;
            // 
            // nameClmn
            // 
            this.nameClmn.HeaderText = "Part Name";
            this.nameClmn.Name = "nameClmn";
            this.nameClmn.ReadOnly = true;
            // 
            // invClmn
            // 
            this.invClmn.HeaderText = "Inventory Level";
            this.invClmn.Name = "invClmn";
            this.invClmn.ReadOnly = true;
            // 
            // priceClmn
            // 
            this.priceClmn.HeaderText = "Price per Unit";
            this.priceClmn.Name = "priceClmn";
            this.priceClmn.ReadOnly = true;
            // 
            // DGVBot
            // 
            this.DGVBot.AllowUserToAddRows = false;
            this.DGVBot.AllowUserToDeleteRows = false;
            this.DGVBot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBot.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4});
            this.DGVBot.Location = new System.Drawing.Point(382, 283);
            this.DGVBot.Name = "DGVBot";
            this.DGVBot.ReadOnly = true;
            this.DGVBot.Size = new System.Drawing.Size(443, 156);
            this.DGVBot.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Part ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Part Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Inventory Level";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Price per Unit";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(628, 24);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(131, 20);
            this.searchBox.TabIndex = 7;
            // 
            // upfIdBox
            // 
            this.upfIdBox.Enabled = false;
            this.upfIdBox.Location = new System.Drawing.Point(128, 135);
            this.upfIdBox.Name = "upfIdBox";
            this.upfIdBox.Size = new System.Drawing.Size(100, 20);
            this.upfIdBox.TabIndex = 8;
            this.upfIdBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.nameBox.Location = new System.Drawing.Point(128, 169);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 9;
            this.nameBox.Text = "Product Name";
            this.nameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // invBox
            // 
            this.invBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.invBox.Location = new System.Drawing.Point(128, 206);
            this.invBox.Name = "invBox";
            this.invBox.Size = new System.Drawing.Size(55, 20);
            this.invBox.TabIndex = 10;
            this.invBox.Text = "InvStock";
            this.invBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // priceBox
            // 
            this.priceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.priceBox.Location = new System.Drawing.Point(128, 243);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(55, 20);
            this.priceBox.TabIndex = 11;
            this.priceBox.Text = "Price";
            this.priceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maxBox
            // 
            this.maxBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.maxBox.Location = new System.Drawing.Point(128, 280);
            this.maxBox.Name = "maxBox";
            this.maxBox.Size = new System.Drawing.Size(55, 20);
            this.maxBox.TabIndex = 12;
            this.maxBox.Text = "Max";
            this.maxBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Location = new System.Drawing.Point(60, 135);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(18, 13);
            this.idLbl.TabIndex = 13;
            this.idLbl.Text = "ID";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(60, 172);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(35, 13);
            this.nameLbl.TabIndex = 14;
            this.nameLbl.Text = "Name";
            // 
            // invLbl
            // 
            this.invLbl.AutoSize = true;
            this.invLbl.Location = new System.Drawing.Point(60, 209);
            this.invLbl.Name = "invLbl";
            this.invLbl.Size = new System.Drawing.Size(22, 13);
            this.invLbl.TabIndex = 15;
            this.invLbl.Text = "Inv";
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Location = new System.Drawing.Point(60, 246);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(31, 13);
            this.priceLbl.TabIndex = 16;
            this.priceLbl.Text = "Price";
            // 
            // maxLbl
            // 
            this.maxLbl.AutoSize = true;
            this.maxLbl.Location = new System.Drawing.Point(60, 283);
            this.maxLbl.Name = "maxLbl";
            this.maxLbl.Size = new System.Drawing.Size(27, 13);
            this.maxLbl.TabIndex = 17;
            this.maxLbl.Text = "Max";
            // 
            // minLbl
            // 
            this.minLbl.AutoSize = true;
            this.minLbl.Location = new System.Drawing.Point(208, 283);
            this.minLbl.Name = "minLbl";
            this.minLbl.Size = new System.Drawing.Size(24, 13);
            this.minLbl.TabIndex = 18;
            this.minLbl.Text = "Min";
            // 
            // minBox
            // 
            this.minBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.minBox.Location = new System.Drawing.Point(249, 280);
            this.minBox.Name = "minBox";
            this.minBox.Size = new System.Drawing.Size(55, 20);
            this.minBox.TabIndex = 19;
            this.minBox.Text = "Min";
            this.minBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mainGroupBox
            // 
            this.mainGroupBox.Controls.Add(this.button1);
            this.mainGroupBox.Controls.Add(this.textBox1);
            this.mainGroupBox.Controls.Add(this.label1);
            this.mainGroupBox.Controls.Add(this.minBox);
            this.mainGroupBox.Controls.Add(this.minLbl);
            this.mainGroupBox.Controls.Add(this.maxLbl);
            this.mainGroupBox.Controls.Add(this.priceLbl);
            this.mainGroupBox.Controls.Add(this.invLbl);
            this.mainGroupBox.Controls.Add(this.nameLbl);
            this.mainGroupBox.Controls.Add(this.idLbl);
            this.mainGroupBox.Controls.Add(this.maxBox);
            this.mainGroupBox.Controls.Add(this.priceBox);
            this.mainGroupBox.Controls.Add(this.invBox);
            this.mainGroupBox.Controls.Add(this.nameBox);
            this.mainGroupBox.Controls.Add(this.upfIdBox);
            this.mainGroupBox.Controls.Add(this.searchBox);
            this.mainGroupBox.Controls.Add(this.DGVBot);
            this.mainGroupBox.Controls.Add(this.DGVTop);
            this.mainGroupBox.Controls.Add(this.addBtn);
            this.mainGroupBox.Controls.Add(this.delBtn);
            this.mainGroupBox.Controls.Add(this.cnclBtn);
            this.mainGroupBox.Controls.Add(this.saveBtn);
            this.mainGroupBox.Controls.Add(this.searchBtnProd);
            this.mainGroupBox.Location = new System.Drawing.Point(14, 12);
            this.mainGroupBox.Name = "mainGroupBox";
            this.mainGroupBox.Size = new System.Drawing.Size(914, 562);
            this.mainGroupBox.TabIndex = 20;
            this.mainGroupBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 480);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(224, 481);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(77, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Add Product";
            // 
            // UsingProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 593);
            this.Controls.Add(this.mainGroupBox);
            this.Name = "UsingProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Screen";
            ((System.ComponentModel.ISupportInitialize)(this.DGVTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBot)).EndInit();
            this.mainGroupBox.ResumeLayout(false);
            this.mainGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button searchBtnProd;
        public System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cnclBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridView DGVTop;
        public System.Windows.Forms.DataGridView DGVBot;
        public System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClmn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameClmn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invClmn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceClmn;
        public System.Windows.Forms.TextBox upfIdBox;
        public System.Windows.Forms.TextBox nameBox;
        public System.Windows.Forms.TextBox invBox;
        public System.Windows.Forms.TextBox priceBox;
        public System.Windows.Forms.TextBox maxBox;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label invLbl;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Label maxLbl;
        private System.Windows.Forms.Label minLbl;
        public System.Windows.Forms.TextBox minBox;
        private System.Windows.Forms.GroupBox mainGroupBox;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}