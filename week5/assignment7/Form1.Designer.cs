namespace assignment7
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
            this.lbldice = new System.Windows.Forms.Label();
            this.btnthrow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbldice
            // 
            this.lbldice.AutoSize = true;
            this.lbldice.Location = new System.Drawing.Point(102, 72);
            this.lbldice.Name = "lbldice";
            this.lbldice.Size = new System.Drawing.Size(46, 17);
            this.lbldice.TabIndex = 0;
            this.lbldice.Text = "label1";
            // 
            // btnthrow
            // 
            this.btnthrow.Location = new System.Drawing.Point(354, 380);
            this.btnthrow.Name = "btnthrow";
            this.btnthrow.Size = new System.Drawing.Size(75, 32);
            this.btnthrow.TabIndex = 1;
            this.btnthrow.Text = "Throw";
            this.btnthrow.UseVisualStyleBackColor = true;
            this.btnthrow.Click += new System.EventHandler(this.btnthrow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnthrow);
            this.Controls.Add(this.lbldice);
            this.Name = "Form1";
            this.Text = "Assignment 7";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldice;
        private System.Windows.Forms.Button btnthrow;
    }
}

