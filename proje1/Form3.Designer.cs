namespace proje1
{
    partial class frmYonetici
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAdi = new System.Windows.Forms.Label();
            this.lblSoyadi = new System.Windows.Forms.Label();
            this.lblPersonelKodu = new System.Windows.Forms.Label();
            this.lblSifresi = new System.Windows.Forms.Label();
            this.lblBolgesi = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.cmbBolgesi = new System.Windows.Forms.ComboBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.txtPersonelKodu = new System.Windows.Forms.TextBox();
            this.txtSifresi = new System.Windows.Forms.TextBox();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.rndTc = new System.Windows.Forms.RadioButton();
            this.rndAd = new System.Windows.Forms.RadioButton();
            this.rndSoyad = new System.Windows.Forms.RadioButton();
            this.rndPersonelKodu = new System.Windows.Forms.RadioButton();
            this.rndSifresi = new System.Windows.Forms.RadioButton();
            this.rndBolgesi = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rndCinsiyet = new System.Windows.Forms.RadioButton();
            this.checkErkek = new System.Windows.Forms.CheckBox();
            this.checkKadin = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.eKLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sİLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gÜNCELLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lİSTELEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gERİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hAKKIMIZDAToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gERİToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.çIKIŞToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aRKAPLANToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kIRMIZIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sARIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mAVİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bEYAZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 404);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(830, 235);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(561, 139);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(97, 40);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(561, 191);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(97, 37);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(679, 139);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(106, 37);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(679, 190);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(97, 38);
            this.btnListele.TabIndex = 4;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "YÖNETİCİ EKRAN";
            // 
            // lblAdi
            // 
            this.lblAdi.AutoSize = true;
            this.lblAdi.Location = new System.Drawing.Point(229, 158);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(39, 18);
            this.lblAdi.TabIndex = 6;
            this.lblAdi.Text = "ADI:";
            // 
            // lblSoyadi
            // 
            this.lblSoyadi.AutoSize = true;
            this.lblSoyadi.Location = new System.Drawing.Point(196, 194);
            this.lblSoyadi.Name = "lblSoyadi";
            this.lblSoyadi.Size = new System.Drawing.Size(73, 18);
            this.lblSoyadi.TabIndex = 7;
            this.lblSoyadi.Text = "SOYADI:";
            // 
            // lblPersonelKodu
            // 
            this.lblPersonelKodu.AutoSize = true;
            this.lblPersonelKodu.Location = new System.Drawing.Point(112, 225);
            this.lblPersonelKodu.Name = "lblPersonelKodu";
            this.lblPersonelKodu.Size = new System.Drawing.Size(156, 18);
            this.lblPersonelKodu.TabIndex = 8;
            this.lblPersonelKodu.Text = "PERSONEL KODU:";
            // 
            // lblSifresi
            // 
            this.lblSifresi.AutoSize = true;
            this.lblSifresi.Location = new System.Drawing.Point(192, 255);
            this.lblSifresi.Name = "lblSifresi";
            this.lblSifresi.Size = new System.Drawing.Size(76, 18);
            this.lblSifresi.TabIndex = 9;
            this.lblSifresi.Text = "ŞİFRESİ:";
            // 
            // lblBolgesi
            // 
            this.lblBolgesi.AutoSize = true;
            this.lblBolgesi.Location = new System.Drawing.Point(184, 285);
            this.lblBolgesi.Name = "lblBolgesi";
            this.lblBolgesi.Size = new System.Drawing.Size(85, 18);
            this.lblBolgesi.TabIndex = 10;
            this.lblBolgesi.Text = "BÖLGESİ:";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(229, 122);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(40, 18);
            this.lblTC.TabIndex = 11;
            this.lblTC.Text = "T.C:";
            // 
            // cmbBolgesi
            // 
            this.cmbBolgesi.FormattingEnabled = true;
            this.cmbBolgesi.Items.AddRange(new object[] {
            "İSTANBUL(AVRUPA)",
            "İSTANBUL(ANADOLU)",
            "ANKARA",
            "İZMİR",
            "ADANA"});
            this.cmbBolgesi.Location = new System.Drawing.Point(275, 282);
            this.cmbBolgesi.Name = "cmbBolgesi";
            this.cmbBolgesi.Size = new System.Drawing.Size(186, 26);
            this.cmbBolgesi.TabIndex = 12;
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(275, 119);
            this.txtTC.MaxLength = 11;
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(186, 24);
            this.txtTC.TabIndex = 13;
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(275, 155);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(186, 24);
            this.txtAdi.TabIndex = 14;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(275, 191);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(186, 24);
            this.txtSoyadi.TabIndex = 15;
            // 
            // txtPersonelKodu
            // 
            this.txtPersonelKodu.Location = new System.Drawing.Point(275, 222);
            this.txtPersonelKodu.Name = "txtPersonelKodu";
            this.txtPersonelKodu.Size = new System.Drawing.Size(186, 24);
            this.txtPersonelKodu.TabIndex = 16;
            // 
            // txtSifresi
            // 
            this.txtSifresi.Location = new System.Drawing.Point(275, 252);
            this.txtSifresi.Name = "txtSifresi";
            this.txtSifresi.PasswordChar = '*';
            this.txtSifresi.Size = new System.Drawing.Size(186, 24);
            this.txtSifresi.TabIndex = 17;
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Location = new System.Drawing.Point(181, 321);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(87, 18);
            this.lblCinsiyet.TabIndex = 41;
            this.lblCinsiyet.Text = "CİNSİYET:";
            // 
            // rndTc
            // 
            this.rndTc.AutoSize = true;
            this.rndTc.Location = new System.Drawing.Point(6, 42);
            this.rndTc.Name = "rndTc";
            this.rndTc.Size = new System.Drawing.Size(14, 13);
            this.rndTc.TabIndex = 79;
            this.rndTc.TabStop = true;
            this.rndTc.UseVisualStyleBackColor = true;
            this.rndTc.CheckedChanged += new System.EventHandler(this.rndTc_CheckedChanged);
            // 
            // rndAd
            // 
            this.rndAd.AutoSize = true;
            this.rndAd.Location = new System.Drawing.Point(6, 78);
            this.rndAd.Name = "rndAd";
            this.rndAd.Size = new System.Drawing.Size(14, 13);
            this.rndAd.TabIndex = 80;
            this.rndAd.TabStop = true;
            this.rndAd.UseVisualStyleBackColor = true;
            this.rndAd.CheckedChanged += new System.EventHandler(this.rndAd_CheckedChanged);
            // 
            // rndSoyad
            // 
            this.rndSoyad.AutoSize = true;
            this.rndSoyad.Location = new System.Drawing.Point(6, 114);
            this.rndSoyad.Name = "rndSoyad";
            this.rndSoyad.Size = new System.Drawing.Size(14, 13);
            this.rndSoyad.TabIndex = 81;
            this.rndSoyad.TabStop = true;
            this.rndSoyad.UseVisualStyleBackColor = true;
            this.rndSoyad.CheckedChanged += new System.EventHandler(this.rndSoyad_CheckedChanged);
            // 
            // rndPersonelKodu
            // 
            this.rndPersonelKodu.AutoSize = true;
            this.rndPersonelKodu.Location = new System.Drawing.Point(6, 145);
            this.rndPersonelKodu.Name = "rndPersonelKodu";
            this.rndPersonelKodu.Size = new System.Drawing.Size(14, 13);
            this.rndPersonelKodu.TabIndex = 82;
            this.rndPersonelKodu.TabStop = true;
            this.rndPersonelKodu.UseVisualStyleBackColor = true;
            this.rndPersonelKodu.CheckedChanged += new System.EventHandler(this.rndPersonelKodu_CheckedChanged);
            // 
            // rndSifresi
            // 
            this.rndSifresi.AutoSize = true;
            this.rndSifresi.Location = new System.Drawing.Point(6, 175);
            this.rndSifresi.Name = "rndSifresi";
            this.rndSifresi.Size = new System.Drawing.Size(14, 13);
            this.rndSifresi.TabIndex = 83;
            this.rndSifresi.TabStop = true;
            this.rndSifresi.UseVisualStyleBackColor = true;
            this.rndSifresi.CheckedChanged += new System.EventHandler(this.rndSifresi_CheckedChanged);
            // 
            // rndBolgesi
            // 
            this.rndBolgesi.AutoSize = true;
            this.rndBolgesi.Location = new System.Drawing.Point(6, 205);
            this.rndBolgesi.Name = "rndBolgesi";
            this.rndBolgesi.Size = new System.Drawing.Size(14, 13);
            this.rndBolgesi.TabIndex = 84;
            this.rndBolgesi.TabStop = true;
            this.rndBolgesi.UseVisualStyleBackColor = true;
            this.rndBolgesi.CheckedChanged += new System.EventHandler(this.rndBolgesi_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rndCinsiyet);
            this.groupBox1.Controls.Add(this.rndTc);
            this.groupBox1.Controls.Add(this.rndBolgesi);
            this.groupBox1.Controls.Add(this.rndAd);
            this.groupBox1.Controls.Add(this.rndSifresi);
            this.groupBox1.Controls.Add(this.rndSoyad);
            this.groupBox1.Controls.Add(this.rndPersonelKodu);
            this.groupBox1.Location = new System.Drawing.Point(467, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(50, 267);
            this.groupBox1.TabIndex = 85;
            this.groupBox1.TabStop = false;
            // 
            // rndCinsiyet
            // 
            this.rndCinsiyet.AutoSize = true;
            this.rndCinsiyet.Location = new System.Drawing.Point(6, 238);
            this.rndCinsiyet.Name = "rndCinsiyet";
            this.rndCinsiyet.Size = new System.Drawing.Size(14, 13);
            this.rndCinsiyet.TabIndex = 85;
            this.rndCinsiyet.TabStop = true;
            this.rndCinsiyet.UseVisualStyleBackColor = true;
            this.rndCinsiyet.CheckedChanged += new System.EventHandler(this.rndCinsiyet_CheckedChanged);
            // 
            // checkErkek
            // 
            this.checkErkek.AutoSize = true;
            this.checkErkek.Location = new System.Drawing.Point(275, 320);
            this.checkErkek.Name = "checkErkek";
            this.checkErkek.Size = new System.Drawing.Size(83, 22);
            this.checkErkek.TabIndex = 90;
            this.checkErkek.Text = "ERKEK";
            this.checkErkek.UseVisualStyleBackColor = true;
            this.checkErkek.CheckedChanged += new System.EventHandler(this.checkErkek_CheckedChanged);
            // 
            // checkKadin
            // 
            this.checkKadin.AutoSize = true;
            this.checkKadin.Location = new System.Drawing.Point(364, 321);
            this.checkKadin.Name = "checkKadin";
            this.checkKadin.Size = new System.Drawing.Size(76, 22);
            this.checkKadin.TabIndex = 91;
            this.checkKadin.Text = "KADIN";
            this.checkKadin.UseVisualStyleBackColor = true;
            this.checkKadin.CheckedChanged += new System.EventHandler(this.checkKadın_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eKLEToolStripMenuItem,
            this.sİLToolStripMenuItem,
            this.gÜNCELLEToolStripMenuItem,
            this.lİSTELEToolStripMenuItem,
            this.gERİToolStripMenuItem,
            this.aRKAPLANToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(830, 24);
            this.menuStrip1.TabIndex = 92;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // eKLEToolStripMenuItem
            // 
            this.eKLEToolStripMenuItem.Name = "eKLEToolStripMenuItem";
            this.eKLEToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.eKLEToolStripMenuItem.Text = "EKLE";
            this.eKLEToolStripMenuItem.Click += new System.EventHandler(this.eKLEToolStripMenuItem_Click);
            // 
            // sİLToolStripMenuItem
            // 
            this.sİLToolStripMenuItem.Name = "sİLToolStripMenuItem";
            this.sİLToolStripMenuItem.Size = new System.Drawing.Size(34, 20);
            this.sİLToolStripMenuItem.Text = "SİL";
            this.sİLToolStripMenuItem.Click += new System.EventHandler(this.sİLToolStripMenuItem_Click);
            // 
            // gÜNCELLEToolStripMenuItem
            // 
            this.gÜNCELLEToolStripMenuItem.Name = "gÜNCELLEToolStripMenuItem";
            this.gÜNCELLEToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.gÜNCELLEToolStripMenuItem.Text = "GÜNCELLE";
            this.gÜNCELLEToolStripMenuItem.Click += new System.EventHandler(this.gÜNCELLEToolStripMenuItem_Click);
            // 
            // lİSTELEToolStripMenuItem
            // 
            this.lİSTELEToolStripMenuItem.Name = "lİSTELEToolStripMenuItem";
            this.lİSTELEToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.lİSTELEToolStripMenuItem.Text = "LİSTELE";
            this.lİSTELEToolStripMenuItem.Click += new System.EventHandler(this.lİSTELEToolStripMenuItem_Click);
            // 
            // gERİToolStripMenuItem
            // 
            this.gERİToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hAKKIMIZDAToolStripMenuItem1,
            this.gERİToolStripMenuItem1,
            this.çIKIŞToolStripMenuItem});
            this.gERİToolStripMenuItem.Name = "gERİToolStripMenuItem";
            this.gERİToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.gERİToolStripMenuItem.Text = "HIZLI ERİŞİM";
            // 
            // hAKKIMIZDAToolStripMenuItem1
            // 
            this.hAKKIMIZDAToolStripMenuItem1.Name = "hAKKIMIZDAToolStripMenuItem1";
            this.hAKKIMIZDAToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.hAKKIMIZDAToolStripMenuItem1.Text = "HAKKIMIZDA";
            this.hAKKIMIZDAToolStripMenuItem1.Click += new System.EventHandler(this.hAKKIMIZDAToolStripMenuItem1_Click);
            // 
            // gERİToolStripMenuItem1
            // 
            this.gERİToolStripMenuItem1.Name = "gERİToolStripMenuItem1";
            this.gERİToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.gERİToolStripMenuItem1.Text = "GERİ";
            this.gERİToolStripMenuItem1.Click += new System.EventHandler(this.gERİToolStripMenuItem1_Click);
            // 
            // çIKIŞToolStripMenuItem
            // 
            this.çIKIŞToolStripMenuItem.Name = "çIKIŞToolStripMenuItem";
            this.çIKIŞToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.çIKIŞToolStripMenuItem.Text = "ÇIKIŞ";
            this.çIKIŞToolStripMenuItem.Click += new System.EventHandler(this.çIKIŞToolStripMenuItem_Click);
            // 
            // aRKAPLANToolStripMenuItem
            // 
            this.aRKAPLANToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kIRMIZIToolStripMenuItem,
            this.sARIToolStripMenuItem,
            this.mAVİToolStripMenuItem,
            this.mORToolStripMenuItem,
            this.bEYAZToolStripMenuItem});
            this.aRKAPLANToolStripMenuItem.Name = "aRKAPLANToolStripMenuItem";
            this.aRKAPLANToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.aRKAPLANToolStripMenuItem.Text = "ARKA PLAN";
            // 
            // kIRMIZIToolStripMenuItem
            // 
            this.kIRMIZIToolStripMenuItem.Name = "kIRMIZIToolStripMenuItem";
            this.kIRMIZIToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.kIRMIZIToolStripMenuItem.Text = "KIRMIZI";
            this.kIRMIZIToolStripMenuItem.Click += new System.EventHandler(this.kIRMIZIToolStripMenuItem_Click);
            // 
            // sARIToolStripMenuItem
            // 
            this.sARIToolStripMenuItem.Name = "sARIToolStripMenuItem";
            this.sARIToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.sARIToolStripMenuItem.Text = "SARI";
            this.sARIToolStripMenuItem.Click += new System.EventHandler(this.sARIToolStripMenuItem_Click);
            // 
            // mAVİToolStripMenuItem
            // 
            this.mAVİToolStripMenuItem.Name = "mAVİToolStripMenuItem";
            this.mAVİToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.mAVİToolStripMenuItem.Text = "MAVİ";
            this.mAVİToolStripMenuItem.Click += new System.EventHandler(this.mAVİToolStripMenuItem_Click);
            // 
            // mORToolStripMenuItem
            // 
            this.mORToolStripMenuItem.Name = "mORToolStripMenuItem";
            this.mORToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.mORToolStripMenuItem.Text = "TURUNCU";
            this.mORToolStripMenuItem.Click += new System.EventHandler(this.mORToolStripMenuItem_Click);
            // 
            // bEYAZToolStripMenuItem
            // 
            this.bEYAZToolStripMenuItem.Name = "bEYAZToolStripMenuItem";
            this.bEYAZToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.bEYAZToolStripMenuItem.Text = "BEYAZ";
            this.bEYAZToolStripMenuItem.Click += new System.EventHandler(this.bEYAZToolStripMenuItem_Click);
            // 
            // frmYonetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 639);
            this.Controls.Add(this.checkKadin);
            this.Controls.Add(this.checkErkek);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCinsiyet);
            this.Controls.Add(this.txtSifresi);
            this.Controls.Add(this.txtPersonelKodu);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.cmbBolgesi);
            this.Controls.Add(this.lblTC);
            this.Controls.Add(this.lblBolgesi);
            this.Controls.Add(this.lblSifresi);
            this.Controls.Add(this.lblPersonelKodu);
            this.Controls.Add(this.lblSoyadi);
            this.Controls.Add(this.lblAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmYonetici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YÖNETİCİ";
            this.Load += new System.EventHandler(this.frmYonetici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAdi;
        private System.Windows.Forms.Label lblSoyadi;
        private System.Windows.Forms.Label lblPersonelKodu;
        private System.Windows.Forms.Label lblSifresi;
        private System.Windows.Forms.Label lblBolgesi;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.ComboBox cmbBolgesi;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.TextBox txtPersonelKodu;
        private System.Windows.Forms.TextBox txtSifresi;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.RadioButton rndTc;
        private System.Windows.Forms.RadioButton rndAd;
        private System.Windows.Forms.RadioButton rndSoyad;
        private System.Windows.Forms.RadioButton rndPersonelKodu;
        private System.Windows.Forms.RadioButton rndSifresi;
        private System.Windows.Forms.RadioButton rndBolgesi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rndCinsiyet;
        private System.Windows.Forms.CheckBox checkErkek;
        private System.Windows.Forms.CheckBox checkKadin;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eKLEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sİLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gÜNCELLEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lİSTELEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gERİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hAKKIMIZDAToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gERİToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem çIKIŞToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aRKAPLANToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kIRMIZIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sARIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mAVİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bEYAZToolStripMenuItem;
    }
}