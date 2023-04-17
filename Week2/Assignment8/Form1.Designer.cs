namespace Assignment8
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbxinvoice = new System.Windows.Forms.GroupBox();
            this.txtnumshirt = new System.Windows.Forms.TextBox();
            this.txtnumjean = new System.Windows.Forms.TextBox();
            this.lbltshirtnum = new System.Windows.Forms.Label();
            this.lbljeansnum = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Button();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.lblvat = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.txtpriceexcl = new System.Windows.Forms.TextBox();
            this.txtvat = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.gbxinvoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxinvoice
            // 
            this.gbxinvoice.Controls.Add(this.txttotal);
            this.gbxinvoice.Controls.Add(this.txtvat);
            this.gbxinvoice.Controls.Add(this.txtpriceexcl);
            this.gbxinvoice.Controls.Add(this.txtdate);
            this.gbxinvoice.Controls.Add(this.lbltotal);
            this.gbxinvoice.Controls.Add(this.lblvat);
            this.gbxinvoice.Controls.Add(this.lblprice);
            this.gbxinvoice.Controls.Add(this.lbldate);
            this.gbxinvoice.Location = new System.Drawing.Point(15, 140);
            this.gbxinvoice.Name = "gbxinvoice";
            this.gbxinvoice.Size = new System.Drawing.Size(301, 147);
            this.gbxinvoice.TabIndex = 0;
            this.gbxinvoice.TabStop = false;
            this.gbxinvoice.Text = "Invoice";
            // 
            // txtnumshirt
            // 
            this.txtnumshirt.Location = new System.Drawing.Point(208, 45);
            this.txtnumshirt.Name = "txtnumshirt";
            this.txtnumshirt.Size = new System.Drawing.Size(100, 20);
            this.txtnumshirt.TabIndex = 1;
            // 
            // txtnumjean
            // 
            this.txtnumjean.Location = new System.Drawing.Point(208, 71);
            this.txtnumjean.Name = "txtnumjean";
            this.txtnumjean.Size = new System.Drawing.Size(100, 20);
            this.txtnumjean.TabIndex = 2;
            // 
            // lbltshirtnum
            // 
            this.lbltshirtnum.AutoSize = true;
            this.lbltshirtnum.Location = new System.Drawing.Point(12, 48);
            this.lbltshirtnum.Name = "lbltshirtnum";
            this.lbltshirtnum.Size = new System.Drawing.Size(152, 13);
            this.lbltshirtnum.TabIndex = 3;
            this.lbltshirtnum.Text = "Number of T-shirts ( x € 30,00):";
            // 
            // lbljeansnum
            // 
            this.lbljeansnum.AutoSize = true;
            this.lbljeansnum.Location = new System.Drawing.Point(12, 74);
            this.lbljeansnum.Name = "lbljeansnum";
            this.lbljeansnum.Size = new System.Drawing.Size(149, 13);
            this.lbljeansnum.TabIndex = 4;
            this.lbljeansnum.Text = "Number of jeans ( x € 100.00):";
            // 
            // btncalculate
            // 
            this.btncalculate.Image = ((System.Drawing.Image)(resources.GetObject("btncalculate.Image")));
            this.btncalculate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncalculate.Location = new System.Drawing.Point(15, 97);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(293, 37);
            this.btncalculate.TabIndex = 5;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(19, 26);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(33, 13);
            this.lbldate.TabIndex = 0;
            this.lbldate.Text = "Date:";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Location = new System.Drawing.Point(19, 52);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(34, 13);
            this.lblprice.TabIndex = 1;
            this.lblprice.Text = "Price:";
            // 
            // lblvat
            // 
            this.lblvat.AutoSize = true;
            this.lblvat.Location = new System.Drawing.Point(19, 78);
            this.lblvat.Name = "lblvat";
            this.lblvat.Size = new System.Drawing.Size(31, 13);
            this.lblvat.TabIndex = 2;
            this.lblvat.Text = "VAT:";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(19, 111);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(60, 13);
            this.lbltotal.TabIndex = 3;
            this.lbltotal.Text = "Total price:";
            // 
            // txtdate
            // 
            this.txtdate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdate.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtdate.Location = new System.Drawing.Point(141, 23);
            this.txtdate.Name = "txtdate";
            this.txtdate.ReadOnly = true;
            this.txtdate.Size = new System.Drawing.Size(152, 13);
            this.txtdate.TabIndex = 4;
            // 
            // txtpriceexcl
            // 
            this.txtpriceexcl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpriceexcl.Location = new System.Drawing.Point(193, 49);
            this.txtpriceexcl.Name = "txtpriceexcl";
            this.txtpriceexcl.ReadOnly = true;
            this.txtpriceexcl.Size = new System.Drawing.Size(100, 13);
            this.txtpriceexcl.TabIndex = 5;
            // 
            // txtvat
            // 
            this.txtvat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtvat.Location = new System.Drawing.Point(193, 75);
            this.txtvat.Name = "txtvat";
            this.txtvat.ReadOnly = true;
            this.txtvat.Size = new System.Drawing.Size(100, 13);
            this.txtvat.TabIndex = 6;
            // 
            // txttotal
            // 
            this.txttotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttotal.Location = new System.Drawing.Point(193, 108);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(100, 13);
            this.txttotal.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 298);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.lbljeansnum);
            this.Controls.Add(this.lbltshirtnum);
            this.Controls.Add(this.txtnumjean);
            this.Controls.Add(this.txtnumshirt);
            this.Controls.Add(this.gbxinvoice);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Assignment 8";
            this.gbxinvoice.ResumeLayout(false);
            this.gbxinvoice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxinvoice;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtvat;
        private System.Windows.Forms.TextBox txtpriceexcl;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lblvat;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.TextBox txtnumshirt;
        private System.Windows.Forms.TextBox txtnumjean;
        private System.Windows.Forms.Label lbltshirtnum;
        private System.Windows.Forms.Label lbljeansnum;
        private System.Windows.Forms.Button btncalculate;
    }
}

