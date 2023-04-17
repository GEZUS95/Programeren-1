namespace assesment9
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
            this.rbfootball = new System.Windows.Forms.RadioButton();
            this.rbhandbal = new System.Windows.Forms.RadioButton();
            this.lblsport = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.lblmembership = new System.Windows.Forms.Label();
            this.lblfee = new System.Windows.Forms.Label();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtmembership = new System.Windows.Forms.TextBox();
            this.txtfee = new System.Windows.Forms.TextBox();
            this.btncalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbfootball
            // 
            this.rbfootball.AutoSize = true;
            this.rbfootball.Location = new System.Drawing.Point(511, 77);
            this.rbfootball.Name = "rbfootball";
            this.rbfootball.Size = new System.Drawing.Size(85, 24);
            this.rbfootball.TabIndex = 0;
            this.rbfootball.TabStop = true;
            this.rbfootball.Text = "Football";
            this.rbfootball.UseVisualStyleBackColor = true;
            // 
            // rbhandbal
            // 
            this.rbhandbal.AutoSize = true;
            this.rbhandbal.Location = new System.Drawing.Point(511, 123);
            this.rbhandbal.Name = "rbhandbal";
            this.rbhandbal.Size = new System.Drawing.Size(91, 24);
            this.rbhandbal.TabIndex = 0;
            this.rbhandbal.TabStop = true;
            this.rbhandbal.Text = "Handball";
            this.rbhandbal.UseVisualStyleBackColor = true;
            // 
            // lblsport
            // 
            this.lblsport.AutoSize = true;
            this.lblsport.Location = new System.Drawing.Point(123, 71);
            this.lblsport.Name = "lblsport";
            this.lblsport.Size = new System.Drawing.Size(45, 20);
            this.lblsport.TabIndex = 1;
            this.lblsport.Text = "Sport";
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Location = new System.Drawing.Point(123, 223);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(36, 20);
            this.lblage.TabIndex = 1;
            this.lblage.Text = "Age";
            // 
            // lblmembership
            // 
            this.lblmembership.AutoSize = true;
            this.lblmembership.Location = new System.Drawing.Point(123, 255);
            this.lblmembership.Name = "lblmembership";
            this.lblmembership.Size = new System.Drawing.Size(152, 20);
            this.lblmembership.TabIndex = 1;
            this.lblmembership.Text = "Membership duration";
            // 
            // lblfee
            // 
            this.lblfee.AutoSize = true;
            this.lblfee.Location = new System.Drawing.Point(123, 381);
            this.lblfee.Name = "lblfee";
            this.lblfee.Size = new System.Drawing.Size(105, 20);
            this.lblfee.TabIndex = 1;
            this.lblfee.Text = "Fee to be paid";
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(511, 220);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(125, 27);
            this.txtage.TabIndex = 2;
            // 
            // txtmembership
            // 
            this.txtmembership.Location = new System.Drawing.Point(511, 252);
            this.txtmembership.Name = "txtmembership";
            this.txtmembership.Size = new System.Drawing.Size(125, 27);
            this.txtmembership.TabIndex = 2;
            // 
            // txtfee
            // 
            this.txtfee.Location = new System.Drawing.Point(511, 378);
            this.txtfee.Name = "txtfee";
            this.txtfee.ReadOnly = true;
            this.txtfee.Size = new System.Drawing.Size(125, 27);
            this.txtfee.TabIndex = 2;
            // 
            // btncalc
            // 
            this.btncalc.Location = new System.Drawing.Point(123, 294);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(513, 54);
            this.btncalc.TabIndex = 3;
            this.btncalc.Text = "Calculate Fee";
            this.btncalc.UseVisualStyleBackColor = true;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.txtfee);
            this.Controls.Add(this.txtmembership);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.lblfee);
            this.Controls.Add(this.lblmembership);
            this.Controls.Add(this.lblage);
            this.Controls.Add(this.lblsport);
            this.Controls.Add(this.rbhandbal);
            this.Controls.Add(this.rbfootball);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbhandbal;
        private System.Windows.Forms.Label lblsport;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lblmembership;
        private System.Windows.Forms.Label lblfee;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtmembership;
        private System.Windows.Forms.TextBox txtfee;
        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.RadioButton rbfootball;
    }
}

