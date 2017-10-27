namespace TruvaTour
{
    partial class Overview
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
            this.lstvTours = new System.Windows.Forms.ListView();
            this.columnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bttnDetails = new System.Windows.Forms.Button();
            this.grpbBuy = new System.Windows.Forms.GroupBox();
            this.bttnBuy = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.grpbBuy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lstvTours
            // 
            this.lstvTours.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader0,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstvTours.FullRowSelect = true;
            this.lstvTours.GridLines = true;
            this.lstvTours.Location = new System.Drawing.Point(12, 12);
            this.lstvTours.Name = "lstvTours";
            this.lstvTours.Size = new System.Drawing.Size(357, 301);
            this.lstvTours.TabIndex = 0;
            this.lstvTours.UseCompatibleStateImageBehavior = false;
            this.lstvTours.View = System.Windows.Forms.View.Details;
            this.lstvTours.SelectedIndexChanged += new System.EventHandler(this.lstvTours_SelectedIndexChanged);
            // 
            // columnHeader0
            // 
            this.columnHeader0.Text = "Tur Kodu";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tur Adı";
            this.columnHeader1.Width = 138;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fiyat";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kalan Kontenjan";
            this.columnHeader3.Width = 92;
            // 
            // bttnDetails
            // 
            this.bttnDetails.Location = new System.Drawing.Point(396, 37);
            this.bttnDetails.Name = "bttnDetails";
            this.bttnDetails.Size = new System.Drawing.Size(236, 23);
            this.bttnDetails.TabIndex = 1;
            this.bttnDetails.Text = "Ayrıntılar";
            this.bttnDetails.UseVisualStyleBackColor = true;
            this.bttnDetails.Click += new System.EventHandler(this.bttnDetails_Click);
            // 
            // grpbBuy
            // 
            this.grpbBuy.Controls.Add(this.bttnBuy);
            this.grpbBuy.Controls.Add(this.lblQuantity);
            this.grpbBuy.Controls.Add(this.nudQuantity);
            this.grpbBuy.Location = new System.Drawing.Point(396, 106);
            this.grpbBuy.Name = "grpbBuy";
            this.grpbBuy.Size = new System.Drawing.Size(236, 207);
            this.grpbBuy.TabIndex = 2;
            this.grpbBuy.TabStop = false;
            this.grpbBuy.Text = "Satın Al";
            // 
            // bttnBuy
            // 
            this.bttnBuy.Location = new System.Drawing.Point(94, 123);
            this.bttnBuy.Name = "bttnBuy";
            this.bttnBuy.Size = new System.Drawing.Size(75, 23);
            this.bttnBuy.TabIndex = 2;
            this.bttnBuy.Text = "Satın Al";
            this.bttnBuy.UseVisualStyleBackColor = true;
            this.bttnBuy.Click += new System.EventHandler(this.bttnBuy_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(27, 77);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(39, 13);
            this.lblQuantity.TabIndex = 1;
            this.lblQuantity.Text = "Miktar:";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(72, 75);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(120, 20);
            this.nudQuantity.TabIndex = 0;
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 371);
            this.Controls.Add(this.grpbBuy);
            this.Controls.Add(this.bttnDetails);
            this.Controls.Add(this.lstvTours);
            this.Name = "Overview";
            this.Text = "TruvaTour";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Overview_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpbBuy.ResumeLayout(false);
            this.grpbBuy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstvTours;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader0;
        private System.Windows.Forms.Button bttnDetails;
        private System.Windows.Forms.GroupBox grpbBuy;
        private System.Windows.Forms.Button bttnBuy;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown nudQuantity;
    }
}

