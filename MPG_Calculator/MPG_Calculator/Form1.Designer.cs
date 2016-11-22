namespace MPG_Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMiles = new System.Windows.Forms.TextBox();
            this.txtGallons = new System.Windows.Forms.TextBox();
            this.txtDPG = new System.Windows.Forms.TextBox();
            this.lblMPG = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMPG = new System.Windows.Forms.Button();
            this.btnDPM = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Miles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gallons";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "$/Gallon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "MPG";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "$/Mile";
            // 
            // txtMiles
            // 
            this.txtMiles.Location = new System.Drawing.Point(70, 25);
            this.txtMiles.Name = "txtMiles";
            this.txtMiles.Size = new System.Drawing.Size(100, 20);
            this.txtMiles.TabIndex = 5;
            // 
            // txtGallons
            // 
            this.txtGallons.Location = new System.Drawing.Point(70, 57);
            this.txtGallons.Name = "txtGallons";
            this.txtGallons.Size = new System.Drawing.Size(100, 20);
            this.txtGallons.TabIndex = 6;
            // 
            // txtDPG
            // 
            this.txtDPG.Location = new System.Drawing.Point(70, 90);
            this.txtDPG.Name = "txtDPG";
            this.txtDPG.Size = new System.Drawing.Size(100, 20);
            this.txtDPG.TabIndex = 7;
            // 
            // lblMPG
            // 
            this.lblMPG.BackColor = System.Drawing.SystemColors.Window;
            this.lblMPG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMPG.Location = new System.Drawing.Point(70, 189);
            this.lblMPG.Name = "lblMPG";
            this.lblMPG.Size = new System.Drawing.Size(100, 20);
            this.lblMPG.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(70, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 9;
            // 
            // btnMPG
            // 
            this.btnMPG.Location = new System.Drawing.Point(176, 189);
            this.btnMPG.Name = "btnMPG";
            this.btnMPG.Size = new System.Drawing.Size(75, 20);
            this.btnMPG.TabIndex = 10;
            this.btnMPG.Text = "MPG";
            this.btnMPG.UseVisualStyleBackColor = true;
            this.btnMPG.Click += new System.EventHandler(this.btnMPG_Click);
            // 
            // btnDPM
            // 
            this.btnDPM.Location = new System.Drawing.Point(176, 229);
            this.btnDPM.Name = "btnDPM";
            this.btnDPM.Size = new System.Drawing.Size(75, 20);
            this.btnDPM.TabIndex = 11;
            this.btnDPM.Text = "$/Mile";
            this.btnDPM.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(82, 139);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 20);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 290);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDPM);
            this.Controls.Add(this.btnMPG);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblMPG);
            this.Controls.Add(this.txtDPG);
            this.Controls.Add(this.txtGallons);
            this.Controls.Add(this.txtMiles);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MPG Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMiles;
        private System.Windows.Forms.TextBox txtGallons;
        private System.Windows.Forms.TextBox txtDPG;
        private System.Windows.Forms.Label lblMPG;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnMPG;
        private System.Windows.Forms.Button btnDPM;
        private System.Windows.Forms.Button btnClear;
    }
}

