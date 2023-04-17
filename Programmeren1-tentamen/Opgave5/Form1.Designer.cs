namespace Opgave5
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
            this.btnCalc = new System.Windows.Forms.Button();
            this.lbldag = new System.Windows.Forms.Label();
            this.lblmaand = new System.Windows.Forms.Label();
            this.lbljaar = new System.Windows.Forms.Label();
            this.lblrest = new System.Windows.Forms.Label();
            this.lbltxtresterend = new System.Windows.Forms.Label();
            this.txtdag = new System.Windows.Forms.TextBox();
            this.txtmaand = new System.Windows.Forms.TextBox();
            this.txtjaar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(400, 240);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "Bereken";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lbldag
            // 
            this.lbldag.AutoSize = true;
            this.lbldag.Location = new System.Drawing.Point(181, 68);
            this.lbldag.Name = "lbldag";
            this.lbldag.Size = new System.Drawing.Size(30, 13);
            this.lbldag.TabIndex = 1;
            this.lbldag.Text = "Dag:";
            // 
            // lblmaand
            // 
            this.lblmaand.AutoSize = true;
            this.lblmaand.Location = new System.Drawing.Point(181, 117);
            this.lblmaand.Name = "lblmaand";
            this.lblmaand.Size = new System.Drawing.Size(43, 13);
            this.lblmaand.TabIndex = 2;
            this.lblmaand.Text = "Maand:";
            // 
            // lbljaar
            // 
            this.lbljaar.AutoSize = true;
            this.lbljaar.Location = new System.Drawing.Point(181, 166);
            this.lbljaar.Name = "lbljaar";
            this.lbljaar.Size = new System.Drawing.Size(30, 13);
            this.lbljaar.TabIndex = 3;
            this.lbljaar.Text = "Jaar:";
            // 
            // lblrest
            // 
            this.lblrest.AutoSize = true;
            this.lblrest.Location = new System.Drawing.Point(181, 370);
            this.lblrest.Name = "lblrest";
            this.lblrest.Size = new System.Drawing.Size(98, 13);
            this.lblrest.TabIndex = 4;
            this.lblrest.Text = "Resterende dagen:";
            // 
            // lbltxtresterend
            // 
            this.lbltxtresterend.AutoSize = true;
            this.lbltxtresterend.Location = new System.Drawing.Point(331, 370);
            this.lbltxtresterend.Name = "lbltxtresterend";
            this.lbltxtresterend.Size = new System.Drawing.Size(62, 13);
            this.lbltxtresterend.TabIndex = 5;
            this.lbltxtresterend.Text = "placeholder";
            // 
            // txtdag
            // 
            this.txtdag.Location = new System.Drawing.Point(375, 65);
            this.txtdag.Name = "txtdag";
            this.txtdag.Size = new System.Drawing.Size(100, 20);
            this.txtdag.TabIndex = 6;
            // 
            // txtmaand
            // 
            this.txtmaand.Location = new System.Drawing.Point(375, 114);
            this.txtmaand.Name = "txtmaand";
            this.txtmaand.Size = new System.Drawing.Size(100, 20);
            this.txtmaand.TabIndex = 7;
            // 
            // txtjaar
            // 
            this.txtjaar.Location = new System.Drawing.Point(375, 163);
            this.txtjaar.Name = "txtjaar";
            this.txtjaar.Size = new System.Drawing.Size(100, 20);
            this.txtjaar.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtjaar);
            this.Controls.Add(this.txtmaand);
            this.Controls.Add(this.txtdag);
            this.Controls.Add(this.lbltxtresterend);
            this.Controls.Add(this.lblrest);
            this.Controls.Add(this.lbljaar);
            this.Controls.Add(this.lblmaand);
            this.Controls.Add(this.lbldag);
            this.Controls.Add(this.btnCalc);
            this.Name = "Form1";
            this.Text = "Tentamen - Opgave 5";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lbldag;
        private System.Windows.Forms.Label lblmaand;
        private System.Windows.Forms.Label lbljaar;
        private System.Windows.Forms.Label lblrest;
        private System.Windows.Forms.Label lbltxtresterend;
        private System.Windows.Forms.TextBox txtdag;
        private System.Windows.Forms.TextBox txtmaand;
        private System.Windows.Forms.TextBox txtjaar;
    }
}

