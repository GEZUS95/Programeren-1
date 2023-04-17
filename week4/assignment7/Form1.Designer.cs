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
            this.lblside = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.btncreate = new System.Windows.Forms.Button();
            this.lbloutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblside
            // 
            this.lblside.AutoSize = true;
            this.lblside.Location = new System.Drawing.Point(118, 60);
            this.lblside.Name = "lblside";
            this.lblside.Size = new System.Drawing.Size(28, 13);
            this.lblside.TabIndex = 0;
            this.lblside.Text = "Side";
            this.lblside.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(265, 57);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(100, 20);
            this.txtnum.TabIndex = 1;
            // 
            // btncreate
            // 
            this.btncreate.Location = new System.Drawing.Point(121, 105);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(244, 23);
            this.btncreate.TabIndex = 2;
            this.btncreate.Text = "Create square";
            this.btncreate.UseVisualStyleBackColor = true;
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // lbloutput
            // 
            this.lbloutput.AutoSize = true;
            this.lbloutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloutput.Location = new System.Drawing.Point(202, 147);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(40, 24);
            this.lbloutput.TabIndex = 5;
            this.lbloutput.Text = "     ";
            this.lbloutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.btncreate);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.lblside);
            this.Name = "Form1";
            this.Text = "Assignment 7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblside;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.Label lbloutput;
    }
}

