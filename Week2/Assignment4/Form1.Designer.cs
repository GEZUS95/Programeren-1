namespace Assignment4
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
            this.btnDetermine = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblEnterPrice = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblVAT = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtVAT = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDetermine
            // 
            this.btnDetermine.Location = new System.Drawing.Point(35, 88);
            this.btnDetermine.Name = "btnDetermine";
            this.btnDetermine.Size = new System.Drawing.Size(252, 23);
            this.btnDetermine.TabIndex = 0;
            this.btnDetermine.Text = "Determine VAT";
            this.btnDetermine.UseVisualStyleBackColor = true;
            this.btnDetermine.Click += new System.EventHandler(this.btnDetermine_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(187, 49);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 1;
            // 
            // lblEnterPrice
            // 
            this.lblEnterPrice.AutoSize = true;
            this.lblEnterPrice.Location = new System.Drawing.Point(32, 49);
            this.lblEnterPrice.Name = "lblEnterPrice";
            this.lblEnterPrice.Size = new System.Drawing.Size(70, 13);
            this.lblEnterPrice.TabIndex = 2;
            this.lblEnterPrice.Text = "Enter a price:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(35, 200);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price:";
            // 
            // lblVAT
            // 
            this.lblVAT.AutoSize = true;
            this.lblVAT.Location = new System.Drawing.Point(35, 226);
            this.lblVAT.Name = "lblVAT";
            this.lblVAT.Size = new System.Drawing.Size(31, 13);
            this.lblVAT.TabIndex = 4;
            this.lblVAT.Text = "VAT:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(35, 252);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total:";
            // 
            // txtPrice
            // 
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.Location = new System.Drawing.Point(187, 200);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(100, 13);
            this.txtPrice.TabIndex = 6;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtVAT
            // 
            this.txtVAT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVAT.Location = new System.Drawing.Point(187, 226);
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.ReadOnly = true;
            this.txtVAT.Size = new System.Drawing.Size(100, 13);
            this.txtVAT.TabIndex = 7;
            this.txtVAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Location = new System.Drawing.Point(187, 252);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 13);
            this.txtTotal.TabIndex = 8;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 317);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtVAT);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblVAT);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblEnterPrice);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnDetermine);
            this.Name = "Assignment 4";
            this.Text = "Assignment 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDetermine;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblEnterPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblVAT;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtVAT;
        private System.Windows.Forms.TextBox txtTotal;
    }
}

