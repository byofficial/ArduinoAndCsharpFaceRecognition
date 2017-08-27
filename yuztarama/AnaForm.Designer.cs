namespace BuumYuzTarama
{
    partial class AnaForm
    {
        
        private System.ComponentModel.IContainer components = null;

       
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.btnYuzuEkle = new System.Windows.Forms.Button();
            this.txtBoxAd = new System.Windows.Forms.TextBox();
            this.grpBoxKisiBilgileri = new System.Windows.Forms.GroupBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.gBoxCinsiyet = new System.Windows.Forms.GroupBox();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.radioBtnKadin = new System.Windows.Forms.RadioButton();
            this.radioBtnErkek = new System.Windows.Forms.RadioButton();
            this.txtBoxSoyad = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.imgBoxYuzuEkle = new Emgu.CV.UI.ImageBox();
            this.grpBoxDurum = new System.Windows.Forms.GroupBox();
            this.lblTanimliKisiMail = new System.Windows.Forms.Label();
            this.lblMail2 = new System.Windows.Forms.Label();
            this.lblAd2 = new System.Windows.Forms.Label();
            this.lblOkulNo2 = new System.Windows.Forms.Label();
            this.lblSinif2 = new System.Windows.Forms.Label();
            this.lblBolum2 = new System.Windows.Forms.Label();
            this.lblCinsiyet2 = new System.Windows.Forms.Label();
            this.lblSoyad2 = new System.Windows.Forms.Label();
            this.lblTanimliKisiNumara = new System.Windows.Forms.Label();
            this.lblTanimliKisiSinif = new System.Windows.Forms.Label();
            this.lblTanimliKisiBolum = new System.Windows.Forms.Label();
            this.lblTanimliKisiCinsiyet = new System.Windows.Forms.Label();
            this.lblTanimliKisiSoyad = new System.Windows.Forms.Label();
            this.lblAlandakiKişiler = new System.Windows.Forms.Label();
            this.lblTanimliKisiAd = new System.Windows.Forms.Label();
            this.lblYuzSayisi2 = new System.Windows.Forms.Label();
            this.lblYuzSayisi = new System.Windows.Forms.Label();
            this.btnYuzuTara = new System.Windows.Forms.Button();
            this.grpBoxKisiOkulBilgileri = new System.Windows.Forms.GroupBox();
            this.cBoxMailGonder = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtBoxOkulNo = new System.Windows.Forms.TextBox();
            this.lblOkulNo = new System.Windows.Forms.Label();
            this.cmbBoxSinif = new System.Windows.Forms.ComboBox();
            this.gBoxBolum = new System.Windows.Forms.GroupBox();
            this.radioBtnBilgisayar = new System.Windows.Forms.RadioButton();
            this.radioBtnJeoloji = new System.Windows.Forms.RadioButton();
            this.radioBtnInsaat = new System.Windows.Forms.RadioButton();
            this.radioBtnMakina = new System.Windows.Forms.RadioButton();
            this.radioBtnEndüstri = new System.Windows.Forms.RadioButton();
            this.radioBtnElektrik = new System.Windows.Forms.RadioButton();
            this.grpBoxYuruTara = new System.Windows.Forms.GroupBox();
            this.imgBoxYuzuTara = new Emgu.CV.UI.ImageBox();
            this.picBoxBuum = new System.Windows.Forms.PictureBox();
            this.lblBuum = new System.Windows.Forms.Label();
            this.lblBolum = new System.Windows.Forms.Label();
            this.lblGuvenlikDuvariDurum = new System.Windows.Forms.Label();
            this.btnGuvenlikDuvariKapat = new System.Windows.Forms.Button();
            this.lblGuvenlikDuvari = new System.Windows.Forms.Label();
            this.gboxGuvenlikDuvari = new System.Windows.Forms.GroupBox();
            this.btnGuvenlikDuvariAc = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.lblMuzik = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer2 = new AxWMPLib.AxWindowsMediaPlayer();
            this.grpBoxKisiBilgileri.SuspendLayout();
            this.gBoxCinsiyet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBoxYuzuEkle)).BeginInit();
            this.grpBoxDurum.SuspendLayout();
            this.grpBoxKisiOkulBilgileri.SuspendLayout();
            this.gBoxBolum.SuspendLayout();
            this.grpBoxYuruTara.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBoxYuzuTara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBuum)).BeginInit();
            this.gboxGuvenlikDuvari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYuzuEkle
            // 
            resources.ApplyResources(this.btnYuzuEkle, "btnYuzuEkle");
            this.btnYuzuEkle.Name = "btnYuzuEkle";
            this.btnYuzuEkle.UseVisualStyleBackColor = true;
            this.btnYuzuEkle.Click += new System.EventHandler(this.button2_Click);
            this.btnYuzuEkle.MouseLeave += new System.EventHandler(this.btnYuzuEkle_MouseLeave);
            this.btnYuzuEkle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnYuzuEkle_MouseMove);
            // 
            // txtBoxAd
            // 
            this.txtBoxAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtBoxAd, "txtBoxAd");
            this.txtBoxAd.Name = "txtBoxAd";
            // 
            // grpBoxKisiBilgileri
            // 
            this.grpBoxKisiBilgileri.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxKisiBilgileri.Controls.Add(this.lblSoyad);
            this.grpBoxKisiBilgileri.Controls.Add(this.gBoxCinsiyet);
            this.grpBoxKisiBilgileri.Controls.Add(this.txtBoxSoyad);
            this.grpBoxKisiBilgileri.Controls.Add(this.lblAd);
            this.grpBoxKisiBilgileri.Controls.Add(this.btnYuzuEkle);
            this.grpBoxKisiBilgileri.Controls.Add(this.txtBoxAd);
            this.grpBoxKisiBilgileri.Controls.Add(this.imgBoxYuzuEkle);
            resources.ApplyResources(this.grpBoxKisiBilgileri, "grpBoxKisiBilgileri");
            this.grpBoxKisiBilgileri.Name = "grpBoxKisiBilgileri";
            this.grpBoxKisiBilgileri.TabStop = false;
            // 
            // lblSoyad
            // 
            resources.ApplyResources(this.lblSoyad, "lblSoyad");
            this.lblSoyad.Name = "lblSoyad";
            // 
            // gBoxCinsiyet
            // 
            this.gBoxCinsiyet.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.gBoxCinsiyet, "gBoxCinsiyet");
            this.gBoxCinsiyet.Controls.Add(this.lblCinsiyet);
            this.gBoxCinsiyet.Controls.Add(this.radioBtnKadin);
            this.gBoxCinsiyet.Controls.Add(this.radioBtnErkek);
            this.gBoxCinsiyet.ForeColor = System.Drawing.Color.Black;
            this.gBoxCinsiyet.Name = "gBoxCinsiyet";
            this.gBoxCinsiyet.TabStop = false;
            // 
            // lblCinsiyet
            // 
            resources.ApplyResources(this.lblCinsiyet, "lblCinsiyet");
            this.lblCinsiyet.Name = "lblCinsiyet";
            // 
            // radioBtnKadin
            // 
            resources.ApplyResources(this.radioBtnKadin, "radioBtnKadin");
            this.radioBtnKadin.BackColor = System.Drawing.Color.Transparent;
            this.radioBtnKadin.ForeColor = System.Drawing.Color.Magenta;
            this.radioBtnKadin.Name = "radioBtnKadin";
            this.radioBtnKadin.UseVisualStyleBackColor = false;
            this.radioBtnKadin.CheckedChanged += new System.EventHandler(this.radioBtnKadin_CheckedChanged);
            // 
            // radioBtnErkek
            // 
            resources.ApplyResources(this.radioBtnErkek, "radioBtnErkek");
            this.radioBtnErkek.BackColor = System.Drawing.Color.Transparent;
            this.radioBtnErkek.ForeColor = System.Drawing.Color.Blue;
            this.radioBtnErkek.Name = "radioBtnErkek";
            this.radioBtnErkek.UseVisualStyleBackColor = false;
            this.radioBtnErkek.CheckedChanged += new System.EventHandler(this.radioBtnErkek_CheckedChanged);
            // 
            // txtBoxSoyad
            // 
            this.txtBoxSoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtBoxSoyad, "txtBoxSoyad");
            this.txtBoxSoyad.Name = "txtBoxSoyad";
            // 
            // lblAd
            // 
            resources.ApplyResources(this.lblAd, "lblAd");
            this.lblAd.Name = "lblAd";
            // 
            // imgBoxYuzuEkle
            // 
            resources.ApplyResources(this.imgBoxYuzuEkle, "imgBoxYuzuEkle");
            this.imgBoxYuzuEkle.Name = "imgBoxYuzuEkle";
            this.imgBoxYuzuEkle.TabStop = false;
            // 
            // grpBoxDurum
            // 
            this.grpBoxDurum.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxDurum.Controls.Add(this.lblTanimliKisiMail);
            this.grpBoxDurum.Controls.Add(this.lblMail2);
            this.grpBoxDurum.Controls.Add(this.lblAd2);
            this.grpBoxDurum.Controls.Add(this.lblOkulNo2);
            this.grpBoxDurum.Controls.Add(this.lblSinif2);
            this.grpBoxDurum.Controls.Add(this.lblBolum2);
            this.grpBoxDurum.Controls.Add(this.lblCinsiyet2);
            this.grpBoxDurum.Controls.Add(this.lblSoyad2);
            this.grpBoxDurum.Controls.Add(this.lblTanimliKisiNumara);
            this.grpBoxDurum.Controls.Add(this.lblTanimliKisiSinif);
            this.grpBoxDurum.Controls.Add(this.lblTanimliKisiBolum);
            this.grpBoxDurum.Controls.Add(this.lblTanimliKisiCinsiyet);
            this.grpBoxDurum.Controls.Add(this.lblTanimliKisiSoyad);
            this.grpBoxDurum.Controls.Add(this.lblAlandakiKişiler);
            this.grpBoxDurum.Controls.Add(this.lblTanimliKisiAd);
            this.grpBoxDurum.Controls.Add(this.lblYuzSayisi2);
            this.grpBoxDurum.Controls.Add(this.lblYuzSayisi);
            resources.ApplyResources(this.grpBoxDurum, "grpBoxDurum");
            this.grpBoxDurum.Name = "grpBoxDurum";
            this.grpBoxDurum.TabStop = false;
            this.grpBoxDurum.Enter += new System.EventHandler(this.grpBoxDurum_Enter);
            // 
            // lblTanimliKisiMail
            // 
            resources.ApplyResources(this.lblTanimliKisiMail, "lblTanimliKisiMail");
            this.lblTanimliKisiMail.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTanimliKisiMail.Name = "lblTanimliKisiMail";
            // 
            // lblMail2
            // 
            resources.ApplyResources(this.lblMail2, "lblMail2");
            this.lblMail2.ForeColor = System.Drawing.Color.Black;
            this.lblMail2.Name = "lblMail2";
            // 
            // lblAd2
            // 
            resources.ApplyResources(this.lblAd2, "lblAd2");
            this.lblAd2.ForeColor = System.Drawing.Color.Black;
            this.lblAd2.Name = "lblAd2";
            // 
            // lblOkulNo2
            // 
            resources.ApplyResources(this.lblOkulNo2, "lblOkulNo2");
            this.lblOkulNo2.ForeColor = System.Drawing.Color.Black;
            this.lblOkulNo2.Name = "lblOkulNo2";
            // 
            // lblSinif2
            // 
            resources.ApplyResources(this.lblSinif2, "lblSinif2");
            this.lblSinif2.ForeColor = System.Drawing.Color.Black;
            this.lblSinif2.Name = "lblSinif2";
            // 
            // lblBolum2
            // 
            resources.ApplyResources(this.lblBolum2, "lblBolum2");
            this.lblBolum2.ForeColor = System.Drawing.Color.Black;
            this.lblBolum2.Name = "lblBolum2";
            // 
            // lblCinsiyet2
            // 
            resources.ApplyResources(this.lblCinsiyet2, "lblCinsiyet2");
            this.lblCinsiyet2.ForeColor = System.Drawing.Color.Black;
            this.lblCinsiyet2.Name = "lblCinsiyet2";
            // 
            // lblSoyad2
            // 
            resources.ApplyResources(this.lblSoyad2, "lblSoyad2");
            this.lblSoyad2.ForeColor = System.Drawing.Color.Black;
            this.lblSoyad2.Name = "lblSoyad2";
            // 
            // lblTanimliKisiNumara
            // 
            resources.ApplyResources(this.lblTanimliKisiNumara, "lblTanimliKisiNumara");
            this.lblTanimliKisiNumara.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTanimliKisiNumara.Name = "lblTanimliKisiNumara";
            // 
            // lblTanimliKisiSinif
            // 
            resources.ApplyResources(this.lblTanimliKisiSinif, "lblTanimliKisiSinif");
            this.lblTanimliKisiSinif.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTanimliKisiSinif.Name = "lblTanimliKisiSinif";
            // 
            // lblTanimliKisiBolum
            // 
            resources.ApplyResources(this.lblTanimliKisiBolum, "lblTanimliKisiBolum");
            this.lblTanimliKisiBolum.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTanimliKisiBolum.Name = "lblTanimliKisiBolum";
            // 
            // lblTanimliKisiCinsiyet
            // 
            resources.ApplyResources(this.lblTanimliKisiCinsiyet, "lblTanimliKisiCinsiyet");
            this.lblTanimliKisiCinsiyet.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTanimliKisiCinsiyet.Name = "lblTanimliKisiCinsiyet";
            // 
            // lblTanimliKisiSoyad
            // 
            resources.ApplyResources(this.lblTanimliKisiSoyad, "lblTanimliKisiSoyad");
            this.lblTanimliKisiSoyad.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTanimliKisiSoyad.Name = "lblTanimliKisiSoyad";
            // 
            // lblAlandakiKişiler
            // 
            resources.ApplyResources(this.lblAlandakiKişiler, "lblAlandakiKişiler");
            this.lblAlandakiKişiler.ForeColor = System.Drawing.Color.Black;
            this.lblAlandakiKişiler.Name = "lblAlandakiKişiler";
            // 
            // lblTanimliKisiAd
            // 
            resources.ApplyResources(this.lblTanimliKisiAd, "lblTanimliKisiAd");
            this.lblTanimliKisiAd.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTanimliKisiAd.Name = "lblTanimliKisiAd";
            // 
            // lblYuzSayisi2
            // 
            resources.ApplyResources(this.lblYuzSayisi2, "lblYuzSayisi2");
            this.lblYuzSayisi2.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblYuzSayisi2.Name = "lblYuzSayisi2";
            // 
            // lblYuzSayisi
            // 
            resources.ApplyResources(this.lblYuzSayisi, "lblYuzSayisi");
            this.lblYuzSayisi.Name = "lblYuzSayisi";
            // 
            // btnYuzuTara
            // 
            resources.ApplyResources(this.btnYuzuTara, "btnYuzuTara");
            this.btnYuzuTara.Name = "btnYuzuTara";
            this.btnYuzuTara.UseVisualStyleBackColor = true;
            this.btnYuzuTara.Click += new System.EventHandler(this.button1_Click);
            this.btnYuzuTara.MouseLeave += new System.EventHandler(this.btnYuzuTara_MouseLeave);
            this.btnYuzuTara.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnYuzuTara_MouseMove);
            // 
            // grpBoxKisiOkulBilgileri
            // 
            this.grpBoxKisiOkulBilgileri.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxKisiOkulBilgileri.Controls.Add(this.cBoxMailGonder);
            this.grpBoxKisiOkulBilgileri.Controls.Add(this.label1);
            this.grpBoxKisiOkulBilgileri.Controls.Add(this.txtBoxMail);
            this.grpBoxKisiOkulBilgileri.Controls.Add(this.lblMail);
            this.grpBoxKisiOkulBilgileri.Controls.Add(this.txtBoxOkulNo);
            this.grpBoxKisiOkulBilgileri.Controls.Add(this.lblOkulNo);
            this.grpBoxKisiOkulBilgileri.Controls.Add(this.cmbBoxSinif);
            this.grpBoxKisiOkulBilgileri.Controls.Add(this.gBoxBolum);
            resources.ApplyResources(this.grpBoxKisiOkulBilgileri, "grpBoxKisiOkulBilgileri");
            this.grpBoxKisiOkulBilgileri.Name = "grpBoxKisiOkulBilgileri";
            this.grpBoxKisiOkulBilgileri.TabStop = false;
            this.grpBoxKisiOkulBilgileri.Enter += new System.EventHandler(this.grpBoxKisiOkulBilgileri_Enter);
            // 
            // cBoxMailGonder
            // 
            resources.ApplyResources(this.cBoxMailGonder, "cBoxMailGonder");
            this.cBoxMailGonder.BackColor = System.Drawing.Color.Transparent;
            this.cBoxMailGonder.Name = "cBoxMailGonder";
            this.cBoxMailGonder.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtBoxMail
            // 
            this.txtBoxMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtBoxMail, "txtBoxMail");
            this.txtBoxMail.Name = "txtBoxMail";
            this.txtBoxMail.TextChanged += new System.EventHandler(this.txtBoxMail_TextChanged);
            // 
            // lblMail
            // 
            resources.ApplyResources(this.lblMail, "lblMail");
            this.lblMail.BackColor = System.Drawing.Color.Transparent;
            this.lblMail.Name = "lblMail";
            // 
            // txtBoxOkulNo
            // 
            this.txtBoxOkulNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtBoxOkulNo, "txtBoxOkulNo");
            this.txtBoxOkulNo.Name = "txtBoxOkulNo";
            // 
            // lblOkulNo
            // 
            resources.ApplyResources(this.lblOkulNo, "lblOkulNo");
            this.lblOkulNo.Name = "lblOkulNo";
            // 
            // cmbBoxSinif
            // 
            this.cmbBoxSinif.BackColor = System.Drawing.Color.White;
            this.cmbBoxSinif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxSinif.FormattingEnabled = true;
            this.cmbBoxSinif.Items.AddRange(new object[] {
            resources.GetString("cmbBoxSinif.Items"),
            resources.GetString("cmbBoxSinif.Items1"),
            resources.GetString("cmbBoxSinif.Items2"),
            resources.GetString("cmbBoxSinif.Items3")});
            resources.ApplyResources(this.cmbBoxSinif, "cmbBoxSinif");
            this.cmbBoxSinif.Name = "cmbBoxSinif";
            // 
            // gBoxBolum
            // 
            this.gBoxBolum.Controls.Add(this.radioBtnBilgisayar);
            this.gBoxBolum.Controls.Add(this.radioBtnJeoloji);
            this.gBoxBolum.Controls.Add(this.radioBtnInsaat);
            this.gBoxBolum.Controls.Add(this.radioBtnMakina);
            this.gBoxBolum.Controls.Add(this.radioBtnEndüstri);
            this.gBoxBolum.Controls.Add(this.radioBtnElektrik);
            this.gBoxBolum.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.gBoxBolum, "gBoxBolum");
            this.gBoxBolum.Name = "gBoxBolum";
            this.gBoxBolum.TabStop = false;
            // 
            // radioBtnBilgisayar
            // 
            resources.ApplyResources(this.radioBtnBilgisayar, "radioBtnBilgisayar");
            this.radioBtnBilgisayar.BackColor = System.Drawing.Color.Transparent;
            this.radioBtnBilgisayar.ForeColor = System.Drawing.Color.Black;
            this.radioBtnBilgisayar.Name = "radioBtnBilgisayar";
            this.radioBtnBilgisayar.UseVisualStyleBackColor = false;
            this.radioBtnBilgisayar.CheckedChanged += new System.EventHandler(this.radioBtnBilgisayar_CheckedChanged);
            // 
            // radioBtnJeoloji
            // 
            resources.ApplyResources(this.radioBtnJeoloji, "radioBtnJeoloji");
            this.radioBtnJeoloji.BackColor = System.Drawing.Color.Transparent;
            this.radioBtnJeoloji.ForeColor = System.Drawing.Color.Black;
            this.radioBtnJeoloji.Name = "radioBtnJeoloji";
            this.radioBtnJeoloji.UseVisualStyleBackColor = false;
            this.radioBtnJeoloji.CheckedChanged += new System.EventHandler(this.radioBtnJeoloji_CheckedChanged);
            // 
            // radioBtnInsaat
            // 
            resources.ApplyResources(this.radioBtnInsaat, "radioBtnInsaat");
            this.radioBtnInsaat.BackColor = System.Drawing.Color.Transparent;
            this.radioBtnInsaat.ForeColor = System.Drawing.Color.Black;
            this.radioBtnInsaat.Name = "radioBtnInsaat";
            this.radioBtnInsaat.UseVisualStyleBackColor = false;
            this.radioBtnInsaat.CheckedChanged += new System.EventHandler(this.radioBtnInsaat_CheckedChanged);
            // 
            // radioBtnMakina
            // 
            resources.ApplyResources(this.radioBtnMakina, "radioBtnMakina");
            this.radioBtnMakina.BackColor = System.Drawing.Color.Transparent;
            this.radioBtnMakina.ForeColor = System.Drawing.Color.Black;
            this.radioBtnMakina.Name = "radioBtnMakina";
            this.radioBtnMakina.UseVisualStyleBackColor = false;
            this.radioBtnMakina.CheckedChanged += new System.EventHandler(this.radioBtnMakina_CheckedChanged);
            // 
            // radioBtnEndüstri
            // 
            resources.ApplyResources(this.radioBtnEndüstri, "radioBtnEndüstri");
            this.radioBtnEndüstri.BackColor = System.Drawing.Color.Transparent;
            this.radioBtnEndüstri.ForeColor = System.Drawing.Color.Black;
            this.radioBtnEndüstri.Name = "radioBtnEndüstri";
            this.radioBtnEndüstri.UseVisualStyleBackColor = false;
            this.radioBtnEndüstri.CheckedChanged += new System.EventHandler(this.radioBtnEndüstri_CheckedChanged);
            // 
            // radioBtnElektrik
            // 
            resources.ApplyResources(this.radioBtnElektrik, "radioBtnElektrik");
            this.radioBtnElektrik.BackColor = System.Drawing.Color.Transparent;
            this.radioBtnElektrik.ForeColor = System.Drawing.Color.Black;
            this.radioBtnElektrik.Name = "radioBtnElektrik";
            this.radioBtnElektrik.UseVisualStyleBackColor = false;
            this.radioBtnElektrik.CheckedChanged += new System.EventHandler(this.radioBtnElektrik_CheckedChanged);
            // 
            // grpBoxYuruTara
            // 
            this.grpBoxYuruTara.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxYuruTara.Controls.Add(this.imgBoxYuzuTara);
            this.grpBoxYuruTara.Controls.Add(this.btnYuzuTara);
            resources.ApplyResources(this.grpBoxYuruTara, "grpBoxYuruTara");
            this.grpBoxYuruTara.Name = "grpBoxYuruTara";
            this.grpBoxYuruTara.TabStop = false;
            this.grpBoxYuruTara.Enter += new System.EventHandler(this.grpBoxYuruTara_Enter);
            // 
            // imgBoxYuzuTara
            // 
            this.imgBoxYuzuTara.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.imgBoxYuzuTara, "imgBoxYuzuTara");
            this.imgBoxYuzuTara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgBoxYuzuTara.Name = "imgBoxYuzuTara";
            this.imgBoxYuzuTara.TabStop = false;
            // 
            // picBoxBuum
            // 
            this.picBoxBuum.BackColor = System.Drawing.SystemColors.HighlightText;
            resources.ApplyResources(this.picBoxBuum, "picBoxBuum");
            this.picBoxBuum.Name = "picBoxBuum";
            this.picBoxBuum.TabStop = false;
            // 
            // lblBuum
            // 
            resources.ApplyResources(this.lblBuum, "lblBuum");
            this.lblBuum.BackColor = System.Drawing.Color.Transparent;
            this.lblBuum.Name = "lblBuum";
            // 
            // lblBolum
            // 
            resources.ApplyResources(this.lblBolum, "lblBolum");
            this.lblBolum.ForeColor = System.Drawing.Color.Black;
            this.lblBolum.Name = "lblBolum";
            // 
            // lblGuvenlikDuvariDurum
            // 
            resources.ApplyResources(this.lblGuvenlikDuvariDurum, "lblGuvenlikDuvariDurum");
            this.lblGuvenlikDuvariDurum.ForeColor = System.Drawing.Color.Red;
            this.lblGuvenlikDuvariDurum.Name = "lblGuvenlikDuvariDurum";
            // 
            // btnGuvenlikDuvariKapat
            // 
            resources.ApplyResources(this.btnGuvenlikDuvariKapat, "btnGuvenlikDuvariKapat");
            this.btnGuvenlikDuvariKapat.Name = "btnGuvenlikDuvariKapat";
            this.btnGuvenlikDuvariKapat.UseVisualStyleBackColor = true;
            this.btnGuvenlikDuvariKapat.Click += new System.EventHandler(this.button2_Click_2);
            this.btnGuvenlikDuvariKapat.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.btnGuvenlikDuvariKapat.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button2_MouseMove);
            // 
            // lblGuvenlikDuvari
            // 
            resources.ApplyResources(this.lblGuvenlikDuvari, "lblGuvenlikDuvari");
            this.lblGuvenlikDuvari.BackColor = System.Drawing.Color.DarkRed;
            this.lblGuvenlikDuvari.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGuvenlikDuvari.Name = "lblGuvenlikDuvari";
            // 
            // gboxGuvenlikDuvari
            // 
            this.gboxGuvenlikDuvari.BackColor = System.Drawing.Color.Transparent;
            this.gboxGuvenlikDuvari.Controls.Add(this.btnGuvenlikDuvariAc);
            this.gboxGuvenlikDuvari.Controls.Add(this.lblGuvenlikDuvariDurum);
            this.gboxGuvenlikDuvari.Controls.Add(this.lblGuvenlikDuvari);
            this.gboxGuvenlikDuvari.Controls.Add(this.btnGuvenlikDuvariKapat);
            resources.ApplyResources(this.gboxGuvenlikDuvari, "gboxGuvenlikDuvari");
            this.gboxGuvenlikDuvari.Name = "gboxGuvenlikDuvari";
            this.gboxGuvenlikDuvari.TabStop = false;
            this.gboxGuvenlikDuvari.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnGuvenlikDuvariAc
            // 
            resources.ApplyResources(this.btnGuvenlikDuvariAc, "btnGuvenlikDuvariAc");
            this.btnGuvenlikDuvariAc.Name = "btnGuvenlikDuvariAc";
            this.btnGuvenlikDuvariAc.UseVisualStyleBackColor = true;
            this.btnGuvenlikDuvariAc.Click += new System.EventHandler(this.button11_Click);
            this.btnGuvenlikDuvariAc.MouseLeave += new System.EventHandler(this.button11_MouseLeave);
            this.btnGuvenlikDuvariAc.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button11_MouseMove);
            // 
            // axWindowsMediaPlayer1
            // 
            resources.ApplyResources(this.axWindowsMediaPlayer1, "axWindowsMediaPlayer1");
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            // 
            // lblMuzik
            // 
            resources.ApplyResources(this.lblMuzik, "lblMuzik");
            this.lblMuzik.BackColor = System.Drawing.Color.DarkRed;
            this.lblMuzik.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMuzik.Name = "lblMuzik";
            // 
            // axWindowsMediaPlayer2
            // 
            resources.ApplyResources(this.axWindowsMediaPlayer2, "axWindowsMediaPlayer2");
            this.axWindowsMediaPlayer2.Name = "axWindowsMediaPlayer2";
            this.axWindowsMediaPlayer2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer2.OcxState")));
            // 
            // AnaForm
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.axWindowsMediaPlayer2);
            this.Controls.Add(this.lblMuzik);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.gboxGuvenlikDuvari);
            this.Controls.Add(this.lblBuum);
            this.Controls.Add(this.picBoxBuum);
            this.Controls.Add(this.grpBoxYuruTara);
            this.Controls.Add(this.grpBoxDurum);
            this.Controls.Add(this.grpBoxKisiBilgileri);
            this.Controls.Add(this.grpBoxKisiOkulBilgileri);
            this.Controls.Add(this.lblBolum);
            this.Name = "AnaForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnaForm_FormClosing);
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.grpBoxKisiBilgileri.ResumeLayout(false);
            this.grpBoxKisiBilgileri.PerformLayout();
            this.gBoxCinsiyet.ResumeLayout(false);
            this.gBoxCinsiyet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBoxYuzuEkle)).EndInit();
            this.grpBoxDurum.ResumeLayout(false);
            this.grpBoxDurum.PerformLayout();
            this.grpBoxKisiOkulBilgileri.ResumeLayout(false);
            this.grpBoxKisiOkulBilgileri.PerformLayout();
            this.gBoxBolum.ResumeLayout(false);
            this.gBoxBolum.PerformLayout();
            this.grpBoxYuruTara.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgBoxYuzuTara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBuum)).EndInit();
            this.gboxGuvenlikDuvari.ResumeLayout(false);
            this.gboxGuvenlikDuvari.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      

        private System.Windows.Forms.Button btnYuzuEkle;
        private Emgu.CV.UI.ImageBox imgBoxYuzuTara;
        private Emgu.CV.UI.ImageBox imgBoxYuzuEkle;
        private System.Windows.Forms.TextBox txtBoxAd;
        private System.Windows.Forms.GroupBox grpBoxKisiBilgileri;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.GroupBox grpBoxDurum;
        private System.Windows.Forms.Label lblAlandakiKişiler;
        private System.Windows.Forms.Label lblTanimliKisiAd;
        private System.Windows.Forms.Label lblYuzSayisi2;
        private System.Windows.Forms.Label lblYuzSayisi;
        private System.Windows.Forms.Button btnYuzuTara;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.TextBox txtBoxSoyad;
        private System.Windows.Forms.Label lblTanimliKisiNumara;
        private System.Windows.Forms.Label lblTanimliKisiSinif;
        private System.Windows.Forms.Label lblTanimliKisiBolum;
        private System.Windows.Forms.Label lblTanimliKisiCinsiyet;
        private System.Windows.Forms.Label lblTanimliKisiSoyad;
        private System.Windows.Forms.GroupBox grpBoxKisiOkulBilgileri;
        private System.Windows.Forms.GroupBox gBoxBolum;
        private System.Windows.Forms.GroupBox gBoxCinsiyet;
        private System.Windows.Forms.RadioButton radioBtnKadin;
        private System.Windows.Forms.RadioButton radioBtnErkek;
        private System.Windows.Forms.TextBox txtBoxOkulNo;
        private System.Windows.Forms.Label lblOkulNo;
        private System.Windows.Forms.ComboBox cmbBoxSinif;
        private System.Windows.Forms.Label lblAd2;
        private System.Windows.Forms.Label lblOkulNo2;
        private System.Windows.Forms.Label lblSinif2;
        private System.Windows.Forms.Label lblBolum2;
        private System.Windows.Forms.Label lblCinsiyet2;
        private System.Windows.Forms.Label lblSoyad2;
        private System.Windows.Forms.GroupBox grpBoxYuruTara;
        private System.Windows.Forms.Label lblMail2;
        private System.Windows.Forms.TextBox txtBoxMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTanimliKisiMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBoxBuum;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.Label lblBuum;
        private System.Windows.Forms.RadioButton radioBtnJeoloji;
        private System.Windows.Forms.RadioButton radioBtnInsaat;
        private System.Windows.Forms.RadioButton radioBtnMakina;
        private System.Windows.Forms.RadioButton radioBtnEndüstri;
        private System.Windows.Forms.RadioButton radioBtnElektrik;
        private System.Windows.Forms.RadioButton radioBtnBilgisayar;
        private System.Windows.Forms.Label lblBolum;
        private System.Windows.Forms.Label lblGuvenlikDuvariDurum;
        private System.Windows.Forms.Button btnGuvenlikDuvariKapat;
        private System.Windows.Forms.Label lblGuvenlikDuvari;
        private System.Windows.Forms.GroupBox gboxGuvenlikDuvari;
        private System.Windows.Forms.Button btnGuvenlikDuvariAc;
        private System.Windows.Forms.CheckBox cBoxMailGonder;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label lblMuzik;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer2;
    }
}

