namespace proje1
{
    partial class frmPersonel
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
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
            this.checkKadin = new System.Windows.Forms.CheckBox();
            this.checkErkek = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rndCinsiyet = new System.Windows.Forms.RadioButton();
            this.rndTc = new System.Windows.Forms.RadioButton();
            this.rndBolgesi = new System.Windows.Forms.RadioButton();
            this.rndAd = new System.Windows.Forms.RadioButton();
            this.rndSifresi = new System.Windows.Forms.RadioButton();
            this.rndSoyad = new System.Windows.Forms.RadioButton();
            this.rndPersonelKodu = new System.Windows.Forms.RadioButton();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.txtSifresi = new System.Windows.Forms.TextBox();
            this.txtPersonelKodu = new System.Windows.Forms.TextBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.cmbBolgesi = new System.Windows.Forms.ComboBox();
            this.lblTC = new System.Windows.Forms.Label();
            this.lblBolgesi = new System.Windows.Forms.Label();
            this.lblSifresi = new System.Windows.Forms.Label();
            this.lblPersonelKodu = new System.Windows.Forms.Label();
            this.lblSoyadi = new System.Windows.Forms.Label();
            this.lblAdi = new System.Windows.Forms.Label();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "PERSONEL EKRANI";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 381);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(824, 248);
            this.dataGridView1.TabIndex = 92;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 18);
            this.label2.TabIndex = 93;
            this.label2.Text = "PERSONEL EKRANI";
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
            this.menuStrip1.Size = new System.Drawing.Size(823, 24);
            this.menuStrip1.TabIndex = 94;
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
            this.sİLToolStripMenuItem.Click += new System.EventHandler(this.sİLToolStripMenuItem_Click_1);
            // 
            // gÜNCELLEToolStripMenuItem
            // 
            this.gÜNCELLEToolStripMenuItem.Name = "gÜNCELLEToolStripMenuItem";
            this.gÜNCELLEToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.gÜNCELLEToolStripMenuItem.Text = "GÜNCELLE";
            this.gÜNCELLEToolStripMenuItem.Click += new System.EventHandler(this.gÜNCELLEToolStripMenuItem_Click_1);
            // 
            // lİSTELEToolStripMenuItem
            // 
            this.lİSTELEToolStripMenuItem.Name = "lİSTELEToolStripMenuItem";
            this.lİSTELEToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.lİSTELEToolStripMenuItem.Text = "LİSTELE";
            this.lİSTELEToolStripMenuItem.Click += new System.EventHandler(this.lİSTELEToolStripMenuItem_Click_1);
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
            this.hAKKIMIZDAToolStripMenuItem1.Click += new System.EventHandler(this.hAKKIMIZDAToolStripMenuItem1_Click_1);
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
            // checkKadin
            // 
            this.checkKadin.AutoSize = true;
            this.checkKadin.Location = new System.Drawing.Point(322, 306);
            this.checkKadin.Name = "checkKadin";
            this.checkKadin.Size = new System.Drawing.Size(76, 22);
            this.checkKadin.TabIndex = 114;
            this.checkKadin.Text = "KADIN";
            this.checkKadin.UseVisualStyleBackColor = true;
            this.checkKadin.CheckedChanged += new System.EventHandler(this.checkKadin_CheckedChanged);
            // 
            // checkErkek
            // 
            this.checkErkek.AutoSize = true;
            this.checkErkek.Location = new System.Drawing.Point(234, 306);
            this.checkErkek.Name = "checkErkek";
            this.checkErkek.Size = new System.Drawing.Size(83, 22);
            this.checkErkek.TabIndex = 113;
            this.checkErkek.Text = "ERKEK";
            this.checkErkek.UseVisualStyleBackColor = true;
            this.checkErkek.CheckedChanged += new System.EventHandler(this.checkErkek_CheckedChanged_1);
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
            this.groupBox1.Location = new System.Drawing.Point(426, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(50, 267);
            this.groupBox1.TabIndex = 112;
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
            this.rndCinsiyet.CheckedChanged += new System.EventHandler(this.rndCinsiyet_CheckedChanged_1);
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
            this.rndTc.CheckedChanged += new System.EventHandler(this.rndTc_CheckedChanged_1);
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
            this.rndBolgesi.CheckedChanged += new System.EventHandler(this.rndBolgesi_CheckedChanged_1);
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
            this.rndAd.CheckedChanged += new System.EventHandler(this.rndAd_CheckedChanged_1);
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
            this.rndSifresi.CheckedChanged += new System.EventHandler(this.rndSifresi_CheckedChanged_1);
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
            this.rndSoyad.CheckedChanged += new System.EventHandler(this.rndSoyad_CheckedChanged_1);
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
            this.rndPersonelKodu.CheckedChanged += new System.EventHandler(this.rndPersonelKodu_CheckedChanged_1);
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Location = new System.Drawing.Point(140, 307);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(87, 18);
            this.lblCinsiyet.TabIndex = 111;
            this.lblCinsiyet.Text = "CİNSİYET:";
            // 
            // txtSifresi
            // 
            this.txtSifresi.Location = new System.Drawing.Point(234, 238);
            this.txtSifresi.Name = "txtSifresi";
            this.txtSifresi.PasswordChar = '*';
            this.txtSifresi.Size = new System.Drawing.Size(186, 24);
            this.txtSifresi.TabIndex = 110;
            // 
            // txtPersonelKodu
            // 
            this.txtPersonelKodu.Location = new System.Drawing.Point(234, 208);
            this.txtPersonelKodu.Name = "txtPersonelKodu";
            this.txtPersonelKodu.Size = new System.Drawing.Size(186, 24);
            this.txtPersonelKodu.TabIndex = 109;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(234, 177);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(186, 24);
            this.txtSoyadi.TabIndex = 108;
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(234, 141);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(186, 24);
            this.txtAdi.TabIndex = 107;
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(234, 105);
            this.txtTC.MaxLength = 11;
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(186, 24);
            this.txtTC.TabIndex = 106;
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
            this.cmbBolgesi.Location = new System.Drawing.Point(234, 268);
            this.cmbBolgesi.Name = "cmbBolgesi";
            this.cmbBolgesi.Size = new System.Drawing.Size(186, 26);
            this.cmbBolgesi.TabIndex = 105;
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(188, 108);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(40, 18);
            this.lblTC.TabIndex = 104;
            this.lblTC.Text = "T.C:";
            // 
            // lblBolgesi
            // 
            this.lblBolgesi.AutoSize = true;
            this.lblBolgesi.Location = new System.Drawing.Point(143, 271);
            this.lblBolgesi.Name = "lblBolgesi";
            this.lblBolgesi.Size = new System.Drawing.Size(85, 18);
            this.lblBolgesi.TabIndex = 103;
            this.lblBolgesi.Text = "BÖLGESİ:";
            // 
            // lblSifresi
            // 
            this.lblSifresi.AutoSize = true;
            this.lblSifresi.Location = new System.Drawing.Point(151, 241);
            this.lblSifresi.Name = "lblSifresi";
            this.lblSifresi.Size = new System.Drawing.Size(76, 18);
            this.lblSifresi.TabIndex = 102;
            this.lblSifresi.Text = "ŞİFRESİ:";
            // 
            // lblPersonelKodu
            // 
            this.lblPersonelKodu.AutoSize = true;
            this.lblPersonelKodu.Location = new System.Drawing.Point(71, 211);
            this.lblPersonelKodu.Name = "lblPersonelKodu";
            this.lblPersonelKodu.Size = new System.Drawing.Size(156, 18);
            this.lblPersonelKodu.TabIndex = 101;
            this.lblPersonelKodu.Text = "PERSONEL KODU:";
            // 
            // lblSoyadi
            // 
            this.lblSoyadi.AutoSize = true;
            this.lblSoyadi.Location = new System.Drawing.Point(155, 180);
            this.lblSoyadi.Name = "lblSoyadi";
            this.lblSoyadi.Size = new System.Drawing.Size(73, 18);
            this.lblSoyadi.TabIndex = 100;
            this.lblSoyadi.Text = "SOYADI:";
            // 
            // lblAdi
            // 
            this.lblAdi.AutoSize = true;
            this.lblAdi.Location = new System.Drawing.Point(188, 144);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(39, 18);
            this.lblAdi.TabIndex = 99;
            this.lblAdi.Text = "ADI:";
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(638, 176);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(97, 38);
            this.btnListele.TabIndex = 98;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click_1);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(638, 125);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(106, 37);
            this.btnGuncelle.TabIndex = 97;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click_1);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(520, 177);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(97, 37);
            this.btnSil.TabIndex = 96;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click_1);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(520, 125);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(97, 40);
            this.btnEkle.TabIndex = 95;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click_1);
            // 
            // frmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 628);
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
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmPersonel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel";
            this.Load += new System.EventHandler(this.frmPersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.CheckBox checkKadin;
        private System.Windows.Forms.CheckBox checkErkek;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rndCinsiyet;
        private System.Windows.Forms.RadioButton rndTc;
        private System.Windows.Forms.RadioButton rndBolgesi;
        private System.Windows.Forms.RadioButton rndAd;
        private System.Windows.Forms.RadioButton rndSifresi;
        private System.Windows.Forms.RadioButton rndSoyad;
        private System.Windows.Forms.RadioButton rndPersonelKodu;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.TextBox txtSifresi;
        private System.Windows.Forms.TextBox txtPersonelKodu;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.ComboBox cmbBolgesi;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label lblBolgesi;
        private System.Windows.Forms.Label lblSifresi;
        private System.Windows.Forms.Label lblPersonelKodu;
        private System.Windows.Forms.Label lblSoyadi;
        private System.Windows.Forms.Label lblAdi;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
    }
}