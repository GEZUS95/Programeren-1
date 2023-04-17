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
            this.lblinput = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lbloutput = new System.Windows.Forms.Label();
            this.txtinput = new System.Windows.Forms.TextBox();
            this.btnSqrRef = new System.Windows.Forms.Button();
            this.btnSqrRefOut = new System.Windows.Forms.Button();
            this.btnSqrVal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblinput
            // 
            this.lblinput.AutoSize = true;
            this.lblinput.Location = new System.Drawing.Point(31, 49);
            this.lblinput.Name = "lblinput";
            this.lblinput.Size = new System.Drawing.Size(44, 13);
            this.lblinput.TabIndex = 0;
            this.lblinput.Text = "Number";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(34, 321);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "Result";
            // 
            // lbloutput
            // 
            this.lbloutput.AutoSize = true;
            this.lbloutput.Location = new System.Drawing.Point(206, 321);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(37, 13);
            this.lbloutput.TabIndex = 2;
            this.lbloutput.Text = "output";
            // 
            // txtinput
            // 
            this.txtinput.Location = new System.Drawing.Point(209, 46);
            this.txtinput.Name = "txtinput";
            this.txtinput.Size = new System.Drawing.Size(100, 20);
            this.txtinput.TabIndex = 3;
            // 
            // btnSqrRef
            // 
            this.btnSqrRef.Location = new System.Drawing.Point(34, 109);
            this.btnSqrRef.Name = "btnSqrRef";
            this.btnSqrRef.Size = new System.Drawing.Size(275, 23);
            this.btnSqrRef.TabIndex = 4;
            this.btnSqrRef.Text = "Square By Reference";
            this.btnSqrRef.UseVisualStyleBackColor = true;
            this.btnSqrRef.Click += new System.EventHandler(this.btnSqrRef_Click);
            // 
            // btnSqrRefOut
            // 
            this.btnSqrRefOut.Location = new System.Drawing.Point(34, 154);
            this.btnSqrRefOut.Name = "btnSqrRefOut";
            this.btnSqrRefOut.Size = new System.Drawing.Size(275, 23);
            this.btnSqrRefOut.TabIndex = 5;
            this.btnSqrRefOut.Text = "Square By Reference Out";
            this.btnSqrRefOut.UseVisualStyleBackColor = true;
            this.btnSqrRefOut.Click += new System.EventHandler(this.btnSqrRefOut_Click);
            // 
            // btnSqrVal
            // 
            this.btnSqrVal.Location = new System.Drawing.Point(34, 209);
            this.btnSqrVal.Name = "btnSqrVal";
            this.btnSqrVal.Size = new System.Drawing.Size(275, 23);
            this.btnSqrVal.TabIndex = 6;
            this.btnSqrVal.Text = "Square By Value";
            this.btnSqrVal.UseVisualStyleBackColor = true;
            this.btnSqrVal.Click += new System.EventHandler(this.btnSqrVal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSqrVal);
            this.Controls.Add(this.btnSqrRefOut);
            this.Controls.Add(this.btnSqrRef);
            this.Controls.Add(this.txtinput);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblinput);
            this.Name = "Form1";
            this.Text = "Assignment 6";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblinput;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.TextBox txtinput;
        private System.Windows.Forms.Button btnSqrRef;
        private System.Windows.Forms.Button btnSqrRefOut;
        private System.Windows.Forms.Button btnSqrVal;
    }
}

