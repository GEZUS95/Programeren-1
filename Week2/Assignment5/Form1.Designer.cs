namespace Assignment5
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
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.txtnum3 = new System.Windows.Forms.TextBox();
            this.lblnum1 = new System.Windows.Forms.Label();
            this.lblnum2 = new System.Windows.Forms.Label();
            this.lblnum3 = new System.Windows.Forms.Label();
            this.lblaverage = new System.Windows.Forms.Label();
            this.txtaverage = new System.Windows.Forms.TextBox();
            this.btncalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(319, 92);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(100, 20);
            this.txtnum1.TabIndex = 0;
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(319, 134);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(100, 20);
            this.txtnum2.TabIndex = 1;
            // 
            // txtnum3
            // 
            this.txtnum3.Location = new System.Drawing.Point(319, 178);
            this.txtnum3.Name = "txtnum3";
            this.txtnum3.Size = new System.Drawing.Size(100, 20);
            this.txtnum3.TabIndex = 2;
            // 
            // lblnum1
            // 
            this.lblnum1.AutoSize = true;
            this.lblnum1.Location = new System.Drawing.Point(218, 95);
            this.lblnum1.Name = "lblnum1";
            this.lblnum1.Size = new System.Drawing.Size(56, 13);
            this.lblnum1.TabIndex = 3;
            this.lblnum1.Text = "Number 1:";
            // 
            // lblnum2
            // 
            this.lblnum2.AutoSize = true;
            this.lblnum2.Location = new System.Drawing.Point(218, 137);
            this.lblnum2.Name = "lblnum2";
            this.lblnum2.Size = new System.Drawing.Size(56, 13);
            this.lblnum2.TabIndex = 4;
            this.lblnum2.Text = "Number 2:";
            // 
            // lblnum3
            // 
            this.lblnum3.AutoSize = true;
            this.lblnum3.Location = new System.Drawing.Point(218, 181);
            this.lblnum3.Name = "lblnum3";
            this.lblnum3.Size = new System.Drawing.Size(56, 13);
            this.lblnum3.TabIndex = 5;
            this.lblnum3.Text = "Number 3:";
            // 
            // lblaverage
            // 
            this.lblaverage.AutoSize = true;
            this.lblaverage.Location = new System.Drawing.Point(218, 301);
            this.lblaverage.Name = "lblaverage";
            this.lblaverage.Size = new System.Drawing.Size(47, 13);
            this.lblaverage.TabIndex = 6;
            this.lblaverage.Text = "Average";
            // 
            // txtaverage
            // 
            this.txtaverage.BackColor = System.Drawing.SystemColors.Window;
            this.txtaverage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtaverage.Enabled = false;
            this.txtaverage.Location = new System.Drawing.Point(319, 301);
            this.txtaverage.Name = "txtaverage";
            this.txtaverage.Size = new System.Drawing.Size(100, 13);
            this.txtaverage.TabIndex = 7;
            // 
            // btncalc
            // 
            this.btncalc.Location = new System.Drawing.Point(221, 233);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(198, 23);
            this.btncalc.TabIndex = 8;
            this.btncalc.Text = "Calculate average";
            this.btncalc.UseVisualStyleBackColor = true;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.txtaverage);
            this.Controls.Add(this.lblaverage);
            this.Controls.Add(this.lblnum3);
            this.Controls.Add(this.lblnum2);
            this.Controls.Add(this.lblnum1);
            this.Controls.Add(this.txtnum3);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.TextBox txtnum3;
        private System.Windows.Forms.Label lblnum1;
        private System.Windows.Forms.Label lblnum2;
        private System.Windows.Forms.Label lblnum3;
        private System.Windows.Forms.Label lblaverage;
        private System.Windows.Forms.TextBox txtaverage;
        private System.Windows.Forms.Button btncalc;
    }
}

