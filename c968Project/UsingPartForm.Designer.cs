namespace c968Project
{
    public partial class UsingPartForm
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
            this.maxBox = new System.Windows.Forms.TextBox();
            this.outsourcedRadio = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.minBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.machNcompBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.invBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.machNcompLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inHouseRadio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // maxBox
            // 
            this.maxBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.maxBox.Location = new System.Drawing.Point(148, 227);
            this.maxBox.MaximumSize = new System.Drawing.Size(10, 5000);
            this.maxBox.MinimumSize = new System.Drawing.Size(70, 30);
            this.maxBox.Name = "maxBox";
            this.maxBox.Size = new System.Drawing.Size(70, 30);
            this.maxBox.TabIndex = 39;
            this.maxBox.Text = "Min";
            this.maxBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // outsourcedRadio
            // 
            this.outsourcedRadio.AutoSize = true;
            this.outsourcedRadio.Checked = true;
            this.outsourcedRadio.Location = new System.Drawing.Point(239, 12);
            this.outsourcedRadio.MinimumSize = new System.Drawing.Size(90, 17);
            this.outsourcedRadio.Name = "outsourcedRadio";
            this.outsourcedRadio.Size = new System.Drawing.Size(90, 17);
            this.outsourcedRadio.TabIndex = 38;
            this.outsourcedRadio.TabStop = true;
            this.outsourcedRadio.Text = "Outsourced";
            this.outsourcedRadio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.outsourcedRadio.UseVisualStyleBackColor = true;
            this.outsourcedRadio.CheckedChanged += new System.EventHandler(this.OutSrcd_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(216, 332);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 37;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Save_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // minBox
            // 
            this.minBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.minBox.Location = new System.Drawing.Point(273, 227);
            this.minBox.MaximumSize = new System.Drawing.Size(10, 5000);
            this.minBox.MinimumSize = new System.Drawing.Size(70, 30);
            this.minBox.Name = "minBox";
            this.minBox.Size = new System.Drawing.Size(70, 30);
            this.minBox.TabIndex = 35;
            this.minBox.Text = "Min";
            this.minBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(236, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Min";
            // 
            // machNcompBox
            // 
            this.machNcompBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.machNcompBox.Location = new System.Drawing.Point(147, 266);
            this.machNcompBox.MaximumSize = new System.Drawing.Size(120, 35);
            this.machNcompBox.MinimumSize = new System.Drawing.Size(116, 30);
            this.machNcompBox.Name = "machNcompBox";
            this.machNcompBox.Size = new System.Drawing.Size(120, 20);
            this.machNcompBox.TabIndex = 33;
            this.machNcompBox.Text = "Comp Nm";
            this.machNcompBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // priceBox
            // 
            this.priceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.priceBox.Location = new System.Drawing.Point(147, 188);
            this.priceBox.MaximumSize = new System.Drawing.Size(120, 35);
            this.priceBox.MinimumSize = new System.Drawing.Size(116, 30);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(120, 20);
            this.priceBox.TabIndex = 32;
            this.priceBox.Text = "Price/Cost";
            this.priceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // invBox
            // 
            this.invBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.invBox.Location = new System.Drawing.Point(147, 149);
            this.invBox.MaximumSize = new System.Drawing.Size(120, 35);
            this.invBox.MinimumSize = new System.Drawing.Size(116, 30);
            this.invBox.Name = "invBox";
            this.invBox.Size = new System.Drawing.Size(120, 20);
            this.invBox.TabIndex = 31;
            this.invBox.Text = "Inv";
            this.invBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.nameBox.Location = new System.Drawing.Point(147, 110);
            this.nameBox.MaximumSize = new System.Drawing.Size(120, 35);
            this.nameBox.MinimumSize = new System.Drawing.Size(116, 30);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(120, 20);
            this.nameBox.TabIndex = 30;
            this.nameBox.Text = "Part Name";
            this.nameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // idBox
            // 
            this.idBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.idBox.Enabled = false;
            this.idBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.idBox.Location = new System.Drawing.Point(148, 71);
            this.idBox.MaximumSize = new System.Drawing.Size(120, 35);
            this.idBox.MinimumSize = new System.Drawing.Size(116, 30);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(120, 20);
            this.idBox.TabIndex = 29;
            this.idBox.Text = "0";
            this.idBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // machNcompLabel
            // 
            this.machNcompLabel.AutoSize = true;
            this.machNcompLabel.Location = new System.Drawing.Point(50, 269);
            this.machNcompLabel.Name = "machNcompLabel";
            this.machNcompLabel.Size = new System.Drawing.Size(82, 13);
            this.machNcompLabel.TabIndex = 28;
            this.machNcompLabel.Text = "Company Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Price/Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Inv";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "ID";
            // 
            // inHouseRadio
            // 
            this.inHouseRadio.AutoSize = true;
            this.inHouseRadio.Location = new System.Drawing.Point(128, 12);
            this.inHouseRadio.MinimumSize = new System.Drawing.Size(90, 17);
            this.inHouseRadio.Name = "inHouseRadio";
            this.inHouseRadio.Size = new System.Drawing.Size(90, 17);
            this.inHouseRadio.TabIndex = 22;
            this.inHouseRadio.Text = "In-House";
            this.inHouseRadio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.inHouseRadio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Add Part";
            // 
            // UsingPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 423);
            this.Controls.Add(this.maxBox);
            this.Controls.Add(this.outsourcedRadio);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.minBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.machNcompBox);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.invBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.machNcompLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inHouseRadio);
            this.Controls.Add(this.label1);
            this.Name = "UsingPartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Part Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox maxBox;
        private System.Windows.Forms.RadioButton outsourcedRadio;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox minBox;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox machNcompBox;
        public System.Windows.Forms.TextBox priceBox;
        public System.Windows.Forms.TextBox invBox;
        public System.Windows.Forms.TextBox nameBox;
        public System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label machNcompLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton inHouseRadio;
        public System.Windows.Forms.Label label1;
    }
}