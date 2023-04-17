namespace Assignment7
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
            this.btncalc = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.lblstart = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.lblend = new System.Windows.Forms.Label();
            this.lblbovat = new System.Windows.Forms.Label();
            this.lblvat = new System.Windows.Forms.Label();
            this.lblwithvat = new System.Windows.Forms.Label();
            this.txtstart = new System.Windows.Forms.TextBox();
            this.txtend = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtpriceexcl = new System.Windows.Forms.TextBox();
            this.txtvat = new System.Windows.Forms.TextBox();
            this.txtpriceincl = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // btncalc
            // 
            this.btncalc.Location = new System.Drawing.Point(231, 91);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(75, 23);
            this.btncalc.TabIndex = 0;
            this.btncalc.Text = "Calculate";
            this.btncalc.UseVisualStyleBackColor = true;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(231, 29);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 1;
            this.btnclear.Text = "Erase";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // lblstart
            // 
            this.lblstart.AutoSize = true;
            this.lblstart.Location = new System.Drawing.Point(12, 34);
            this.lblstart.Name = "lblstart";
            this.lblstart.Size = new System.Drawing.Size(46, 13);
            this.lblstart.TabIndex = 2;
            this.lblstart.Text = "Start km";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Location = new System.Drawing.Point(12, 96);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(56, 13);
            this.lblprice.TabIndex = 3;
            this.lblprice.Text = "Price / km";
            // 
            // lblend
            // 
            this.lblend.AutoSize = true;
            this.lblend.Location = new System.Drawing.Point(12, 65);
            this.lblend.Name = "lblend";
            this.lblend.Size = new System.Drawing.Size(43, 13);
            this.lblend.TabIndex = 4;
            this.lblend.Text = "End km";
            // 
            // lblbovat
            // 
            this.lblbovat.AutoSize = true;
            this.lblbovat.Location = new System.Drawing.Point(12, 150);
            this.lblbovat.Name = "lblbovat";
            this.lblbovat.Size = new System.Drawing.Size(80, 13);
            this.lblbovat.TabIndex = 5;
            this.lblbovat.Text = "Price excl. VAT";
            // 
            // lblvat
            // 
            this.lblvat.AutoSize = true;
            this.lblvat.Location = new System.Drawing.Point(98, 150);
            this.lblvat.Name = "lblvat";
            this.lblvat.Size = new System.Drawing.Size(28, 13);
            this.lblvat.TabIndex = 6;
            this.lblvat.Text = "VAT";
            // 
            // lblwithvat
            // 
            this.lblwithvat.AutoSize = true;
            this.lblwithvat.Location = new System.Drawing.Point(228, 150);
            this.lblwithvat.Name = "lblwithvat";
            this.lblwithvat.Size = new System.Drawing.Size(77, 13);
            this.lblwithvat.TabIndex = 7;
            this.lblwithvat.Text = "Price incl. VAT";
            // 
            // txtstart
            // 
            this.txtstart.Location = new System.Drawing.Point(93, 31);
            this.txtstart.Name = "txtstart";
            this.txtstart.Size = new System.Drawing.Size(100, 20);
            this.txtstart.TabIndex = 8;
            // 
            // txtend
            // 
            this.txtend.Location = new System.Drawing.Point(93, 62);
            this.txtend.Name = "txtend";
            this.txtend.Size = new System.Drawing.Size(100, 20);
            this.txtend.TabIndex = 9;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(93, 93);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(100, 20);
            this.txtprice.TabIndex = 10;
            // 
            // txtpriceexcl
            // 
            this.txtpriceexcl.BackColor = System.Drawing.SystemColors.Control;
            this.txtpriceexcl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpriceexcl.Location = new System.Drawing.Point(15, 195);
            this.txtpriceexcl.Name = "txtpriceexcl";
            this.txtpriceexcl.Size = new System.Drawing.Size(100, 13);
            this.txtpriceexcl.TabIndex = 11;
            // 
            // txtvat
            // 
            this.txtvat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtvat.Location = new System.Drawing.Point(101, 195);
            this.txtvat.Name = "txtvat";
            this.txtvat.ReadOnly = true;
            this.txtvat.Size = new System.Drawing.Size(100, 13);
            this.txtvat.TabIndex = 12;
            // 
            // txtpriceincl
            // 
            this.txtpriceincl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpriceincl.Location = new System.Drawing.Point(231, 195);
            this.txtpriceincl.Name = "txtpriceincl";
            this.txtpriceincl.ReadOnly = true;
            this.txtpriceincl.Size = new System.Drawing.Size(100, 13);
            this.txtpriceincl.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(15, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 10);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 233);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtpriceincl);
            this.Controls.Add(this.txtvat);
            this.Controls.Add(this.txtpriceexcl);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtend);
            this.Controls.Add(this.txtstart);
            this.Controls.Add(this.lblwithvat);
            this.Controls.Add(this.lblvat);
            this.Controls.Add(this.lblbovat);
            this.Controls.Add(this.lblend);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.lblstart);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalc);
            this.Name = "Form1";
            this.Text = "Assignment 7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label lblstart;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label lblend;
        private System.Windows.Forms.Label lblbovat;
        private System.Windows.Forms.Label lblvat;
        private System.Windows.Forms.Label lblwithvat;
        private System.Windows.Forms.TextBox txtstart;
        private System.Windows.Forms.TextBox txtend;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtpriceexcl;
        private System.Windows.Forms.TextBox txtvat;
        private System.Windows.Forms.TextBox txtpriceincl;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

