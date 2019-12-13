namespace proje1
{
    partial class frmMenu
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
            this.btnMusteriAnket = new System.Windows.Forms.Button();
            this.btnPersonel = new System.Windows.Forms.Button();
            this.btnSubemarket = new System.Windows.Forms.Button();
            this.btnYonetici = new System.Windows.Forms.Button();
            this.btnYoneticiAnket = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMusteriAnket
            // 
            this.btnMusteriAnket.Location = new System.Drawing.Point(533, 37);
            this.btnMusteriAnket.Name = "btnMusteriAnket";
            this.btnMusteriAnket.Size = new System.Drawing.Size(257, 32);
            this.btnMusteriAnket.TabIndex = 2;
            this.btnMusteriAnket.Text = "Müşteri Anket Rapor";
            this.btnMusteriAnket.UseVisualStyleBackColor = true;
            this.btnMusteriAnket.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnPersonel
            // 
            this.btnPersonel.Location = new System.Drawing.Point(121, 75);
            this.btnPersonel.Name = "btnPersonel";
            this.btnPersonel.Size = new System.Drawing.Size(348, 32);
            this.btnPersonel.TabIndex = 3;
            this.btnPersonel.Text = "Personel EKLE-GÜNCELLE-SİL-RAPOR";
            this.btnPersonel.UseVisualStyleBackColor = true;
            this.btnPersonel.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnSubemarket
            // 
            this.btnSubemarket.Location = new System.Drawing.Point(121, 113);
            this.btnSubemarket.Name = "btnSubemarket";
            this.btnSubemarket.Size = new System.Drawing.Size(348, 32);
            this.btnSubemarket.TabIndex = 4;
            this.btnSubemarket.Text = "Şube Market EKLE-GÜNCELLE-SİL-RAPOR";
            this.btnSubemarket.UseVisualStyleBackColor = true;
            this.btnSubemarket.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnYonetici
            // 
            this.btnYonetici.Location = new System.Drawing.Point(121, 37);
            this.btnYonetici.Name = "btnYonetici";
            this.btnYonetici.Size = new System.Drawing.Size(348, 32);
            this.btnYonetici.TabIndex = 6;
            this.btnYonetici.Text = "Yönetici EKLE-GÜNCELLE-SİL-RAPOR";
            this.btnYonetici.UseVisualStyleBackColor = true;
            this.btnYonetici.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnYoneticiAnket
            // 
            this.btnYoneticiAnket.Location = new System.Drawing.Point(533, 75);
            this.btnYoneticiAnket.Name = "btnYoneticiAnket";
            this.btnYoneticiAnket.Size = new System.Drawing.Size(257, 32);
            this.btnYoneticiAnket.TabIndex = 7;
            this.btnYoneticiAnket.Text = "Yönetici Anket Rapor";
            this.btnYoneticiAnket.UseVisualStyleBackColor = true;
            this.btnYoneticiAnket.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(570, 118);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(126, 27);
            this.button9.TabIndex = 8;
            this.button9.Text = "Çıkış";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 183);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.btnYoneticiAnket);
            this.Controls.Add(this.btnYonetici);
            this.Controls.Add(this.btnSubemarket);
            this.Controls.Add(this.btnPersonel);
            this.Controls.Add(this.btnMusteriAnket);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENÜ";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMusteriAnket;
        private System.Windows.Forms.Button btnPersonel;
        private System.Windows.Forms.Button btnSubemarket;
        private System.Windows.Forms.Button btnYonetici;
        private System.Windows.Forms.Button btnYoneticiAnket;
        private System.Windows.Forms.Button button9;
    }
}