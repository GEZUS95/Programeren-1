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
            this.LblDegreees = new System.Windows.Forms.Label();
            this.TxtInput = new System.Windows.Forms.TextBox();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.GrbConvers = new System.Windows.Forms.GroupBox();
            this.RbtnCtK = new System.Windows.Forms.RadioButton();
            this.RbtnCtF = new System.Windows.Forms.RadioButton();
            this.RbtnFtC = new System.Windows.Forms.RadioButton();
            this.Lbloutputtext = new System.Windows.Forms.Label();
            this.LblOutput = new System.Windows.Forms.Label();
            this.GrbConvers.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblDegreees
            // 
            this.LblDegreees.AutoSize = true;
            this.LblDegreees.Location = new System.Drawing.Point(66, 86);
            this.LblDegreees.Name = "LblDegreees";
            this.LblDegreees.Size = new System.Drawing.Size(47, 13);
            this.LblDegreees.TabIndex = 0;
            this.LblDegreees.Text = "Degrees";
            // 
            // TxtInput
            // 
            this.TxtInput.Location = new System.Drawing.Point(244, 83);
            this.TxtInput.Name = "TxtInput";
            this.TxtInput.Size = new System.Drawing.Size(100, 20);
            this.TxtInput.TabIndex = 1;
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(69, 291);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(275, 35);
            this.BtnCalculate.TabIndex = 2;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // GrbConvers
            // 
            this.GrbConvers.Controls.Add(this.RbtnFtC);
            this.GrbConvers.Controls.Add(this.RbtnCtF);
            this.GrbConvers.Controls.Add(this.RbtnCtK);
            this.GrbConvers.Location = new System.Drawing.Point(69, 129);
            this.GrbConvers.Name = "GrbConvers";
            this.GrbConvers.Size = new System.Drawing.Size(275, 128);
            this.GrbConvers.TabIndex = 3;
            this.GrbConvers.TabStop = false;
            this.GrbConvers.Text = "Conversion";
            // 
            // RbtnCtK
            // 
            this.RbtnCtK.AutoSize = true;
            this.RbtnCtK.Location = new System.Drawing.Point(25, 33);
            this.RbtnCtK.Name = "RbtnCtK";
            this.RbtnCtK.Size = new System.Drawing.Size(102, 17);
            this.RbtnCtK.TabIndex = 0;
            this.RbtnCtK.TabStop = true;
            this.RbtnCtK.Text = "Celsius to Kelvin";
            this.RbtnCtK.UseVisualStyleBackColor = true;
            // 
            // RbtnCtF
            // 
            this.RbtnCtF.AutoSize = true;
            this.RbtnCtF.Location = new System.Drawing.Point(25, 56);
            this.RbtnCtF.Name = "RbtnCtF";
            this.RbtnCtF.Size = new System.Drawing.Size(123, 17);
            this.RbtnCtF.TabIndex = 1;
            this.RbtnCtF.TabStop = true;
            this.RbtnCtF.Text = "Celsius to Fahrenheit";
            this.RbtnCtF.UseVisualStyleBackColor = true;
            // 
            // RbtnFtC
            // 
            this.RbtnFtC.AutoSize = true;
            this.RbtnFtC.Location = new System.Drawing.Point(25, 79);
            this.RbtnFtC.Name = "RbtnFtC";
            this.RbtnFtC.Size = new System.Drawing.Size(124, 17);
            this.RbtnFtC.TabIndex = 4;
            this.RbtnFtC.TabStop = true;
            this.RbtnFtC.Text = "Fahrenheit to Celcius";
            this.RbtnFtC.UseVisualStyleBackColor = true;
            // 
            // Lbloutputtext
            // 
            this.Lbloutputtext.AutoSize = true;
            this.Lbloutputtext.Location = new System.Drawing.Point(69, 361);
            this.Lbloutputtext.Name = "Lbloutputtext";
            this.Lbloutputtext.Size = new System.Drawing.Size(97, 13);
            this.Lbloutputtext.TabIndex = 4;
            this.Lbloutputtext.Text = "Converted degrees";
            // 
            // LblOutput
            // 
            this.LblOutput.AutoSize = true;
            this.LblOutput.Location = new System.Drawing.Point(241, 361);
            this.LblOutput.Name = "LblOutput";
            this.LblOutput.Size = new System.Drawing.Size(37, 13);
            this.LblOutput.TabIndex = 5;
            this.LblOutput.Text = "output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 450);
            this.Controls.Add(this.LblOutput);
            this.Controls.Add(this.Lbloutputtext);
            this.Controls.Add(this.GrbConvers);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.TxtInput);
            this.Controls.Add(this.LblDegreees);
            this.Name = "Form1";
            this.Text = "Assignment 7";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GrbConvers.ResumeLayout(false);
            this.GrbConvers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblDegreees;
        private System.Windows.Forms.TextBox TxtInput;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.GroupBox GrbConvers;
        private System.Windows.Forms.RadioButton RbtnFtC;
        private System.Windows.Forms.RadioButton RbtnCtF;
        private System.Windows.Forms.RadioButton RbtnCtK;
        private System.Windows.Forms.Label Lbloutputtext;
        private System.Windows.Forms.Label LblOutput;
    }
}

