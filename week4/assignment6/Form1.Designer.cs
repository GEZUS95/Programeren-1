namespace assignment6
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
            this.txtstart = new System.Windows.Forms.TextBox();
            this.txtfinal = new System.Windows.Forms.TextBox();
            this.lblstart = new System.Windows.Forms.Label();
            this.lblfinal = new System.Windows.Forms.Label();
            this.btncalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtstart
            // 
            this.txtstart.Location = new System.Drawing.Point(485, 118);
            this.txtstart.Name = "txtstart";
            this.txtstart.Size = new System.Drawing.Size(100, 20);
            this.txtstart.TabIndex = 0;
            // 
            // txtfinal
            // 
            this.txtfinal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtfinal.Location = new System.Drawing.Point(485, 315);
            this.txtfinal.Name = "txtfinal";
            this.txtfinal.ReadOnly = true;
            this.txtfinal.Size = new System.Drawing.Size(100, 13);
            this.txtfinal.TabIndex = 1;
            // 
            // lblstart
            // 
            this.lblstart.AutoSize = true;
            this.lblstart.Location = new System.Drawing.Point(115, 121);
            this.lblstart.Name = "lblstart";
            this.lblstart.Size = new System.Drawing.Size(67, 13);
            this.lblstart.TabIndex = 2;
            this.lblstart.Text = "Start amount";
            // 
            // lblfinal
            // 
            this.lblfinal.AutoSize = true;
            this.lblfinal.Location = new System.Drawing.Point(115, 318);
            this.lblfinal.Name = "lblfinal";
            this.lblfinal.Size = new System.Drawing.Size(63, 13);
            this.lblfinal.TabIndex = 3;
            this.lblfinal.Text = "Final capital";
            // 
            // btncalc
            // 
            this.btncalc.Location = new System.Drawing.Point(118, 171);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(467, 117);
            this.btncalc.TabIndex = 4;
            this.btncalc.Text = "Calculate final capital";
            this.btncalc.UseVisualStyleBackColor = true;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.lblfinal);
            this.Controls.Add(this.lblstart);
            this.Controls.Add(this.txtfinal);
            this.Controls.Add(this.txtstart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtstart;
        private System.Windows.Forms.TextBox txtfinal;
        private System.Windows.Forms.Label lblstart;
        private System.Windows.Forms.Label lblfinal;
        private System.Windows.Forms.Button btncalc;
    }
}

