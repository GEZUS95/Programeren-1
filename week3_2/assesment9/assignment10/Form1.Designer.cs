namespace assignment10
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblage = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.btnprice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Location = new System.Drawing.Point(136, 84);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(36, 20);
            this.lblage.TabIndex = 0;
            this.lblage.Text = "Age";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Location = new System.Drawing.Point(136, 294);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(81, 20);
            this.lblprice.TabIndex = 1;
            this.lblprice.Text = "Price ticket";
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(533, 81);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(125, 27);
            this.txtage.TabIndex = 2;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(533, 291);
            this.txtprice.Name = "txtprice";
            this.txtprice.ReadOnly = true;
            this.txtprice.Size = new System.Drawing.Size(125, 27);
            this.txtprice.TabIndex = 3;
            // 
            // btnprice
            // 
            this.btnprice.Location = new System.Drawing.Point(136, 164);
            this.btnprice.Name = "btnprice";
            this.btnprice.Size = new System.Drawing.Size(522, 61);
            this.btnprice.TabIndex = 4;
            this.btnprice.Text = "Calculate Price";
            this.btnprice.UseVisualStyleBackColor = true;
            this.btnprice.Click += new System.EventHandler(this.btnprice_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnprice);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.lblage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Button btnprice;
    }
}

