namespace calculatorapp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.box = new System.Windows.Forms.ComboBox();
            this.txtnilaia = new System.Windows.Forms.TextBox();
            this.txtnilaib = new System.Windows.Forms.TextBox();
            this.hasil = new System.Windows.Forms.TextBox();
            this.btnhitung = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "operasi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "nilai A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "nilai B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "hasil";
            // 
            // box
            // 
            this.box.FormattingEnabled = true;
            this.box.Items.AddRange(new object[] {
            "penjumlahan",
            "pengurangan",
            "perkalian",
            "pembagian"});
            this.box.Location = new System.Drawing.Point(73, 26);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(121, 21);
            this.box.TabIndex = 4;
            // 
            // txtnilaia
            // 
            this.txtnilaia.Location = new System.Drawing.Point(73, 54);
            this.txtnilaia.Name = "txtnilaia";
            this.txtnilaia.Size = new System.Drawing.Size(100, 20);
            this.txtnilaia.TabIndex = 5;
            // 
            // txtnilaib
            // 
            this.txtnilaib.Location = new System.Drawing.Point(73, 81);
            this.txtnilaib.Name = "txtnilaib";
            this.txtnilaib.Size = new System.Drawing.Size(100, 20);
            this.txtnilaib.TabIndex = 6;
            // 
            // hasil
            // 
            this.hasil.Location = new System.Drawing.Point(73, 111);
            this.hasil.Name = "hasil";
            this.hasil.Size = new System.Drawing.Size(100, 20);
            this.hasil.TabIndex = 7;
            // 
            // btnhitung
            // 
            this.btnhitung.Location = new System.Drawing.Point(73, 137);
            this.btnhitung.Name = "btnhitung";
            this.btnhitung.Size = new System.Drawing.Size(75, 25);
            this.btnhitung.TabIndex = 8;
            this.btnhitung.Text = "hitung";
            this.btnhitung.UseVisualStyleBackColor = true;
            this.btnhitung.Click += new System.EventHandler(this.btnhitung_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 226);
            this.Controls.Add(this.btnhitung);
            this.Controls.Add(this.hasil);
            this.Controls.Add(this.txtnilaib);
            this.Controls.Add(this.txtnilaia);
            this.Controls.Add(this.box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox box;
        private System.Windows.Forms.TextBox txtnilaia;
        private System.Windows.Forms.TextBox txtnilaib;
        private System.Windows.Forms.TextBox hasil;
        private System.Windows.Forms.Button btnhitung;
    }
}

