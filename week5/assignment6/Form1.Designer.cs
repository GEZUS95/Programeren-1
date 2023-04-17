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
            this.lblbefore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltxtbefore = new System.Windows.Forms.Label();
            this.lbltxtafter = new System.Windows.Forms.Label();
            this.lblcompare = new System.Windows.Forms.Label();
            this.txtcompairnum = new System.Windows.Forms.TextBox();
            this.btncompair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblbefore
            // 
            this.lblbefore.AutoSize = true;
            this.lblbefore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbefore.Location = new System.Drawing.Point(71, 65);
            this.lblbefore.Name = "lblbefore";
            this.lblbefore.Size = new System.Drawing.Size(131, 13);
            this.lblbefore.TabIndex = 0;
            this.lblbefore.Text = "Content table (before)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Content table (after)";
            // 
            // lbltxtbefore
            // 
            this.lbltxtbefore.AutoSize = true;
            this.lbltxtbefore.Location = new System.Drawing.Point(74, 100);
            this.lbltxtbefore.Name = "lbltxtbefore";
            this.lbltxtbefore.Size = new System.Drawing.Size(58, 13);
            this.lbltxtbefore.TabIndex = 2;
            this.lbltxtbefore.Text = "lbltxtbefore";
            // 
            // lbltxtafter
            // 
            this.lbltxtafter.AutoSize = true;
            this.lbltxtafter.Location = new System.Drawing.Point(322, 100);
            this.lbltxtafter.Name = "lbltxtafter";
            this.lbltxtafter.Size = new System.Drawing.Size(49, 13);
            this.lbltxtafter.TabIndex = 3;
            this.lbltxtafter.Text = "lbltxtafter";
            // 
            // lblcompare
            // 
            this.lblcompare.AutoSize = true;
            this.lblcompare.Location = new System.Drawing.Point(77, 556);
            this.lblcompare.Name = "lblcompare";
            this.lblcompare.Size = new System.Drawing.Size(100, 13);
            this.lblcompare.TabIndex = 4;
            this.lblcompare.Text = "Comparison number";
            // 
            // txtcompairnum
            // 
            this.txtcompairnum.Location = new System.Drawing.Point(207, 553);
            this.txtcompairnum.Name = "txtcompairnum";
            this.txtcompairnum.Size = new System.Drawing.Size(100, 20);
            this.txtcompairnum.TabIndex = 5;
            // 
            // btncompair
            // 
            this.btncompair.Location = new System.Drawing.Point(325, 551);
            this.btncompair.Name = "btncompair";
            this.btncompair.Size = new System.Drawing.Size(75, 23);
            this.btncompair.TabIndex = 6;
            this.btncompair.Text = "Compare";
            this.btncompair.UseVisualStyleBackColor = true;
            this.btncompair.Click += new System.EventHandler(this.btncompair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 617);
            this.Controls.Add(this.btncompair);
            this.Controls.Add(this.txtcompairnum);
            this.Controls.Add(this.lblcompare);
            this.Controls.Add(this.lbltxtafter);
            this.Controls.Add(this.lbltxtbefore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblbefore);
            this.Name = "Form1";
            this.Text = "Assignment 6";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblbefore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltxtbefore;
        private System.Windows.Forms.Label lbltxtafter;
        private System.Windows.Forms.Label lblcompare;
        private System.Windows.Forms.TextBox txtcompairnum;
        private System.Windows.Forms.Button btncompair;
    }
}

