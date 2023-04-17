namespace Assignment6
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
            this.txtseconds = new System.Windows.Forms.TextBox();
            this.lblseconds = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.txttime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btncalc
            // 
            this.btncalc.Location = new System.Drawing.Point(353, 181);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(100, 23);
            this.btncalc.TabIndex = 0;
            this.btncalc.Text = "Calculate Time";
            this.btncalc.UseVisualStyleBackColor = true;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // txtseconds
            // 
            this.txtseconds.Location = new System.Drawing.Point(353, 141);
            this.txtseconds.Name = "txtseconds";
            this.txtseconds.Size = new System.Drawing.Size(100, 20);
            this.txtseconds.TabIndex = 1;
            // 
            // lblseconds
            // 
            this.lblseconds.AutoSize = true;
            this.lblseconds.Location = new System.Drawing.Point(273, 144);
            this.lblseconds.Name = "lblseconds";
            this.lblseconds.Size = new System.Drawing.Size(49, 13);
            this.lblseconds.TabIndex = 2;
            this.lblseconds.Text = "Seconds";
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Location = new System.Drawing.Point(273, 272);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(127, 13);
            this.lbltime.TabIndex = 3;
            this.lbltime.Text = "hours : minutes : seconds";
            // 
            // txttime
            // 
            this.txttime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttime.Cursor = System.Windows.Forms.Cursors.Default;
            this.txttime.Enabled = false;
            this.txttime.Location = new System.Drawing.Point(276, 315);
            this.txttime.Name = "txttime";
            this.txttime.ReadOnly = true;
            this.txttime.Size = new System.Drawing.Size(100, 13);
            this.txttime.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txttime);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.lblseconds);
            this.Controls.Add(this.txtseconds);
            this.Controls.Add(this.btncalc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.TextBox txtseconds;
        private System.Windows.Forms.Label lblseconds;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.TextBox txttime;
    }
}

