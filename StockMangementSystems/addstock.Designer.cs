namespace StockMangementSystems
{
    partial class addstock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addstock));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.LinkLabel();
            this.stocktable = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.stocktable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(279, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add a new item of stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Aqua;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stock Code :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Aqua;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stock Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Aqua;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stock Quantity :";
            // 
            // btnAddStock
            // 
            this.btnAddStock.BackColor = System.Drawing.Color.Lime;
            this.btnAddStock.Location = new System.Drawing.Point(40, 506);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(126, 38);
            this.btnAddStock.TabIndex = 7;
            this.btnAddStock.Text = "Reset";
            this.btnAddStock.UseVisualStyleBackColor = false;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.Lime;
            this.btnedit.Location = new System.Drawing.Point(286, 506);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(126, 38);
            this.btnedit.TabIndex = 7;
            this.btnedit.Text = "Save";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Home
            // 
            this.Home.AutoSize = true;
            this.Home.BackColor = System.Drawing.Color.LawnGreen;
            this.Home.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Home.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.Location = new System.Drawing.Point(172, 574);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(99, 38);
            this.Home.TabIndex = 9;
            this.Home.TabStop = true;
            this.Home.Text = "Home";
            this.Home.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Home_LinkClicked);
            // 
            // stocktable
            // 
            this.stocktable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stocktable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stocktable.Location = new System.Drawing.Point(477, 155);
            this.stocktable.Name = "stocktable";
            this.stocktable.RowHeadersWidth = 51;
            this.stocktable.RowTemplate.Height = 24;
            this.stocktable.Size = new System.Drawing.Size(499, 423);
            this.stocktable.TabIndex = 10;
            this.stocktable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stocktable_CellDoubleClick);
            // 
            // Code
            // 
            this.Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Code.Location = new System.Drawing.Point(224, 182);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(215, 34);
            this.Code.TabIndex = 11;
            this.Code.TextChanged += new System.EventHandler(this.Code_TextChanged);
            // 
            // Name
            // 
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.Location = new System.Drawing.Point(224, 312);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(215, 34);
            this.Name.TabIndex = 12;
            // 
            // Quantity
            // 
            this.Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.Location = new System.Drawing.Point(224, 432);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(215, 34);
            this.Quantity.TabIndex = 13;
            // 
            // addstock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(990, 651);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Code);
            this.Controls.Add(this.stocktable);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnAddStock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            //this.Name = "addstock";
            this.Load += new System.EventHandler(this.addstock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stocktable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.LinkLabel Home;
        private System.Windows.Forms.DataGridView stocktable;
        private System.Windows.Forms.TextBox Code;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Quantity;
    }
}