namespace assignment8
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
            this.btncompare = new System.Windows.Forms.Button();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.lblnumber = new System.Windows.Forms.Label();
            this.lblsum = new System.Windows.Forms.Label();
            this.lblformula = new System.Windows.Forms.Label();
            this.txtformula = new System.Windows.Forms.TextBox();
            this.txtsum = new System.Windows.Forms.TextBox();
            this.txtequal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btncompare
            // 
            this.btncompare.Location = new System.Drawing.Point(116, 198);
            this.btncompare.Name = "btncompare";
            this.btncompare.Size = new System.Drawing.Size(333, 23);
            this.btncompare.TabIndex = 0;
            this.btncompare.Text = "Compare";
            this.btncompare.UseVisualStyleBackColor = true;
            this.btncompare.Click += new System.EventHandler(this.btncompare_Click);
            // 
            // txtnumber
            // 
            this.txtnumber.Location = new System.Drawing.Point(349, 89);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(100, 20);
            this.txtnumber.TabIndex = 1;
            // 
            // lblnumber
            // 
            this.lblnumber.AutoSize = true;
            this.lblnumber.Location = new System.Drawing.Point(113, 89);
            this.lblnumber.Name = "lblnumber";
            this.lblnumber.Size = new System.Drawing.Size(94, 13);
            this.lblnumber.TabIndex = 2;
            this.lblnumber.Text = "Enter a number (n)";
            // 
            // lblsum
            // 
            this.lblsum.AutoSize = true;
            this.lblsum.Location = new System.Drawing.Point(113, 271);
            this.lblsum.Name = "lblsum";
            this.lblsum.Size = new System.Drawing.Size(101, 13);
            this.lblsum.TabIndex = 3;
            this.lblsum.Text = "sum = 1 + 2 + ... + n";
            // 
            // lblformula
            // 
            this.lblformula.AutoSize = true;
            this.lblformula.Location = new System.Drawing.Point(113, 301);
            this.lblformula.Name = "lblformula";
            this.lblformula.Size = new System.Drawing.Size(98, 13);
            this.lblformula.TabIndex = 4;
            this.lblformula.Text = "sum = n * (n +1) / 2";
            // 
            // txtformula
            // 
            this.txtformula.Location = new System.Drawing.Point(349, 298);
            this.txtformula.Name = "txtformula";
            this.txtformula.ReadOnly = true;
            this.txtformula.Size = new System.Drawing.Size(100, 20);
            this.txtformula.TabIndex = 6;
            // 
            // txtsum
            // 
            this.txtsum.Location = new System.Drawing.Point(349, 268);
            this.txtsum.Name = "txtsum";
            this.txtsum.ReadOnly = true;
            this.txtsum.Size = new System.Drawing.Size(100, 20);
            this.txtsum.TabIndex = 7;
            // 
            // txtequal
            // 
            this.txtequal.Location = new System.Drawing.Point(116, 380);
            this.txtequal.Name = "txtequal";
            this.txtequal.ReadOnly = true;
            this.txtequal.Size = new System.Drawing.Size(333, 20);
            this.txtequal.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtequal);
            this.Controls.Add(this.txtsum);
            this.Controls.Add(this.txtformula);
            this.Controls.Add(this.lblformula);
            this.Controls.Add(this.lblsum);
            this.Controls.Add(this.lblnumber);
            this.Controls.Add(this.txtnumber);
            this.Controls.Add(this.btncompare);
            this.Name = "Form1";
            this.Text = "Assignment 8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncompare;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.Label lblnumber;
        private System.Windows.Forms.Label lblsum;
        private System.Windows.Forms.Label lblformula;
        private System.Windows.Forms.TextBox txtformula;
        private System.Windows.Forms.TextBox txtsum;
        private System.Windows.Forms.TextBox txtequal;
    }
}

