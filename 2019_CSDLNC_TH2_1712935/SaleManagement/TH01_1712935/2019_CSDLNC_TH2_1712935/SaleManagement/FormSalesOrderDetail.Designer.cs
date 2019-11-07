namespace SaleManagement
{
    partial class FormSalesOrderDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSalesOrderDetail));
            this.dataGridViewSalesOrderDetail = new System.Windows.Forms.DataGridView();
            this.txtbSaelsOrderID = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.txtbUnitPrice = new System.Windows.Forms.TextBox();
            this.txtbProdctID = new System.Windows.Forms.TextBox();
            this.txtbDiscount = new System.Windows.Forms.TextBox();
            this.txtbSpecialID = new System.Windows.Forms.TextBox();
            this.txtbOrderQty = new System.Windows.Forms.TextBox();
            this.txtbCarrier = new System.Windows.Forms.TextBox();
            this.txtbSalesOrderIDDetail = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btLoadDetailList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalesOrderDetail)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewSalesOrderDetail
            // 
            this.dataGridViewSalesOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSalesOrderDetail.Location = new System.Drawing.Point(4, 3);
            this.dataGridViewSalesOrderDetail.Name = "dataGridViewSalesOrderDetail";
            this.dataGridViewSalesOrderDetail.RowHeadersWidth = 51;
            this.dataGridViewSalesOrderDetail.RowTemplate.Height = 24;
            this.dataGridViewSalesOrderDetail.Size = new System.Drawing.Size(723, 313);
            this.dataGridViewSalesOrderDetail.TabIndex = 66;
            this.dataGridViewSalesOrderDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSalesOrderDetail_CellClick);
            // 
            // txtbSaelsOrderID
            // 
            this.txtbSaelsOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSaelsOrderID.Location = new System.Drawing.Point(201, 10);
            this.txtbSaelsOrderID.Name = "txtbSaelsOrderID";
            this.txtbSaelsOrderID.Size = new System.Drawing.Size(145, 22);
            this.txtbSaelsOrderID.TabIndex = 65;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label22.Location = new System.Drawing.Point(15, 10);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(107, 16);
            this.label22.TabIndex = 66;
            this.label22.Text = "Sales order ID";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label23.Location = new System.Drawing.Point(15, 99);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(109, 16);
            this.label23.TabIndex = 67;
            this.label23.Text = "Order quantity";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label24.Location = new System.Drawing.Point(406, 40);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(115, 16);
            this.label24.TabIndex = 68;
            this.label24.Text = "Special offer ID";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label25.Location = new System.Drawing.Point(406, 100);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(141, 16);
            this.label25.TabIndex = 69;
            this.label25.Text = "Unit price discount";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label26.Location = new System.Drawing.Point(406, 68);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(76, 16);
            this.label26.TabIndex = 70;
            this.label26.Text = "Unit price";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label27.Location = new System.Drawing.Point(15, 68);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(176, 16);
            this.label27.TabIndex = 71;
            this.label27.Text = "Carrier tracking number";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label28.Location = new System.Drawing.Point(15, 40);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(150, 16);
            this.label28.TabIndex = 72;
            this.label28.Text = "Sales order detail ID";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label29.Location = new System.Drawing.Point(406, 12);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(81, 16);
            this.label29.TabIndex = 73;
            this.label29.Text = "Product ID";
            // 
            // txtbUnitPrice
            // 
            this.txtbUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbUnitPrice.Location = new System.Drawing.Point(566, 68);
            this.txtbUnitPrice.Name = "txtbUnitPrice";
            this.txtbUnitPrice.Size = new System.Drawing.Size(145, 22);
            this.txtbUnitPrice.TabIndex = 74;
            // 
            // txtbProdctID
            // 
            this.txtbProdctID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbProdctID.Location = new System.Drawing.Point(566, 12);
            this.txtbProdctID.Name = "txtbProdctID";
            this.txtbProdctID.Size = new System.Drawing.Size(145, 22);
            this.txtbProdctID.TabIndex = 75;
            // 
            // txtbDiscount
            // 
            this.txtbDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbDiscount.Location = new System.Drawing.Point(566, 96);
            this.txtbDiscount.Name = "txtbDiscount";
            this.txtbDiscount.Size = new System.Drawing.Size(145, 22);
            this.txtbDiscount.TabIndex = 76;
            // 
            // txtbSpecialID
            // 
            this.txtbSpecialID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSpecialID.Location = new System.Drawing.Point(566, 40);
            this.txtbSpecialID.Name = "txtbSpecialID";
            this.txtbSpecialID.Size = new System.Drawing.Size(145, 22);
            this.txtbSpecialID.TabIndex = 77;
            // 
            // txtbOrderQty
            // 
            this.txtbOrderQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbOrderQty.Location = new System.Drawing.Point(201, 97);
            this.txtbOrderQty.Name = "txtbOrderQty";
            this.txtbOrderQty.Size = new System.Drawing.Size(145, 22);
            this.txtbOrderQty.TabIndex = 78;
            // 
            // txtbCarrier
            // 
            this.txtbCarrier.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbCarrier.Location = new System.Drawing.Point(201, 68);
            this.txtbCarrier.Name = "txtbCarrier";
            this.txtbCarrier.Size = new System.Drawing.Size(145, 22);
            this.txtbCarrier.TabIndex = 79;
            // 
            // txtbSalesOrderIDDetail
            // 
            this.txtbSalesOrderIDDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSalesOrderIDDetail.Location = new System.Drawing.Point(201, 40);
            this.txtbSalesOrderIDDetail.Name = "txtbSalesOrderIDDetail";
            this.txtbSalesOrderIDDetail.Size = new System.Drawing.Size(145, 22);
            this.txtbSalesOrderIDDetail.TabIndex = 80;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(745, 726);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 81;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtbCarrier);
            this.panel1.Controls.Add(this.label27);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.txtbDiscount);
            this.panel1.Controls.Add(this.txtbSpecialID);
            this.panel1.Controls.Add(this.txtbSalesOrderIDDetail);
            this.panel1.Controls.Add(this.txtbProdctID);
            this.panel1.Controls.Add(this.txtbOrderQty);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.txtbUnitPrice);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.txtbSaelsOrderID);
            this.panel1.Controls.Add(this.label29);
            this.panel1.Controls.Add(this.label26);
            this.panel1.Location = new System.Drawing.Point(12, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 133);
            this.panel1.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 34);
            this.label1.TabIndex = 83;
            this.label1.Text = "SALES ORDER DETAIL";
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(71, 322);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(85, 36);
            this.btAdd.TabIndex = 84;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(198, 322);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(85, 36);
            this.btClear.TabIndex = 85;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(330, 322);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(85, 36);
            this.btBack.TabIndex = 86;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(456, 322);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(85, 36);
            this.btExit.TabIndex = 87;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btLoadDetailList);
            this.panel2.Controls.Add(this.btExit);
            this.panel2.Controls.Add(this.dataGridViewSalesOrderDetail);
            this.panel2.Controls.Add(this.btBack);
            this.panel2.Controls.Add(this.btClear);
            this.panel2.Controls.Add(this.btAdd);
            this.panel2.Location = new System.Drawing.Point(12, 195);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(730, 367);
            this.panel2.TabIndex = 88;
            // 
            // btLoadDetailList
            // 
            this.btLoadDetailList.Location = new System.Drawing.Point(585, 322);
            this.btLoadDetailList.Name = "btLoadDetailList";
            this.btLoadDetailList.Size = new System.Drawing.Size(85, 36);
            this.btLoadDetailList.TabIndex = 88;
            this.btLoadDetailList.Text = "Load";
            this.btLoadDetailList.UseVisualStyleBackColor = true;
            this.btLoadDetailList.Click += new System.EventHandler(this.btLoadDetailList_Click);
            // 
            // FormSalesOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(754, 574);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormSalesOrderDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales order detail";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalesOrderDetail)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewSalesOrderDetail;
        private System.Windows.Forms.TextBox txtbSaelsOrderID;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtbUnitPrice;
        private System.Windows.Forms.TextBox txtbProdctID;
        private System.Windows.Forms.TextBox txtbDiscount;
        private System.Windows.Forms.TextBox txtbSpecialID;
        private System.Windows.Forms.TextBox txtbOrderQty;
        private System.Windows.Forms.TextBox txtbCarrier;
        private System.Windows.Forms.TextBox txtbSalesOrderIDDetail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btLoadDetailList;
    }
}