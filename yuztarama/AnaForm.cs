
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.IO;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Net.Mail;
using System.Net;
namespace BuumYuzTarama
{
    public partial class AnaForm : Form
    {
      

        Image<Bgr, Byte> kameraResmi;
        Capture fotoCek;
        HaarCascade yuz;
        HaarCascade goz;
        HaarCascade burun;
        HaarCascade yuz2;
        
       

        MCvFont kameraKisiAd = new MCvFont(FONT.CV_FONT_HERSHEY_COMPLEX, 0.5d, 0.5d);
        Image<Gray, byte> sonuc, tanimliKisi = null;
        Image<Gray, byte> gray = null;
        List<Image<Gray, byte>> kisiTanimla = new List<Image<Gray, byte>>();
        List<string> adlari = new List<string>();
        List<string> soyAdlari = new List<string>();
        List<string> numaralari = new List<string>();
        List<string> bolumleri = new List<string>();
        List<string> mailleri = new List<string>();
        List<string> siniflari = new List<string>();
        List<string> cinsiyetleri = new List<string>();
        List<string> kisiAdlari = new List<string>();
        List<string> kisiSoyAdlari = new List<string>();
        List<string> kisiNumaralari = new List<string>();
        List<string> kisiMailleri = new List<string>();
        List<string> kisiBolumleri = new List<string>();
        List<string> kisiSiniflari = new List<string>();
        List<string> kisiCinsiyetleri = new List<string>();
        int kisiSayisi, kisiNumarasi, t;
        string ad, adlar = null;
        string soyAd, soyAdlar = null;
        string numara, numaralar = null;
        string cinsiyet, cinsiyetler = null;
        string mail, mailler = null;
        string sinif, siniflar = null;
        string bolum, bolumler = null;
        MailMessage ePosta = new MailMessage();



        public bool Gonder(string konu, string icerik)
        {
            MailMessage ePosta = new MailMessage();
            ePosta.From = new MailAddress("buumlifes@gmail.com");
            //
            ePosta.To.Add(txtBoxMail.Text);


            //
            ePosta.Subject = konu;
            //
            ePosta.Body = icerik;
            //
            SmtpClient smtp = new SmtpClient();
            //
            smtp.Credentials = new System.Net.NetworkCredential("buumlifes@gmail.com", "+buum43+");
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            object userState = ePosta;
            bool kontrol = true;
            smtp.Send(ePosta);
            try
            {
                smtp.SendAsync(ePosta, (object)ePosta);
            }
            catch (SmtpException ex)
            {
                kontrol = false;
                System.Windows.Forms.MessageBox.Show(ex.Message, "Mail Gönderme Hatasi");
            }
            return kontrol;
        }




        public static System.IO.Ports.SerialPort baglan;
       
       // private delegate void LineReceivedEvent(string line);

        private void radioBtnElektrik_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnElektrik.Checked == true)
                lblBolum.Text = "Elektrik Elektronik Mühendisliği";
        }

        private void radioBtnEndüstri_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnEndüstri.Checked == true)
                lblBolum.Text = "Endüstri Mühendisliği";
        }

        private void radioBtnInsaat_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnInsaat.Checked == true)
                lblBolum.Text = "İnşaat Mühendisliği";
        }


        private void radioBtnMakina_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnMakina.Checked == true)
                lblBolum.Text = "Makina Mühendisliği";
        }

        private void radioBtnJeoloji_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnJeoloji.Checked == true)
                lblBolum.Text = "Jeoloji Mühendisliği";
        }


        private void radioBtnBilgisayar_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnBilgisayar.Checked == true)
                lblBolum.Text = "Bilgisayar Mühendisliği";
        }

 

        private void radioBtnKadin_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnKadin.Checked == true)
                lblCinsiyet.Text = "Kadın";
           
        }

        private void grpBoxKisiOkulBilgileri_Enter(object sender, EventArgs e)
        {

        }

        private void grpBoxYuruTara_Enter(object sender, EventArgs e)
        {

        }

       

      

        private void grpBoxDurum_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            lblGuvenlikDuvariDurum.Text = "Kapalı";
            lblGuvenlikDuvariDurum.ForeColor = Color.Red;
            //baglan.Write("0");
        }

        private void txtBoxMail_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

      

        private void button11_Click(object sender, EventArgs e)
        {

            lblGuvenlikDuvariDurum.Text = "Açık";
            lblGuvenlikDuvariDurum.ForeColor = Color.Green;
        }

        private void button11_MouseLeave(object sender, EventArgs e)
        {
            btnGuvenlikDuvariAc.BackColor = Color.Transparent;
            btnGuvenlikDuvariAc.ForeColor = Color.Black;
        }

        private void button11_MouseMove(object sender, MouseEventArgs e)
        {
            btnGuvenlikDuvariAc.BackColor = Color.DodgerBlue;
            btnGuvenlikDuvariAc.ForeColor = Color.White;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            btnGuvenlikDuvariKapat.BackColor = Color.DodgerBlue;
            btnGuvenlikDuvariKapat.ForeColor = Color.White;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            btnGuvenlikDuvariKapat.BackColor = Color.Transparent;
            btnGuvenlikDuvariKapat.ForeColor = Color.Black;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           //baglan.Write("3");
           // baglan.Write("9");
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            //baglan.Write("2");
            //baglan.Write("6");
            axWindowsMediaPlayer1.URL = Application.StartupPath + "/tema.mp3";
           

        }

        private void radioBtnErkek_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnErkek.Checked == true)
                lblCinsiyet.Text = "Erkek";
        
        }

        private void btnYuzuTara_MouseMove(object sender, MouseEventArgs e)
        {
            btnYuzuTara.BackColor = Color.DodgerBlue;
            btnYuzuTara.ForeColor = Color.White;
        }

        private void btnYuzuTara_MouseLeave(object sender, EventArgs e)
        {
            btnYuzuTara.BackColor = Color.Transparent;
            btnYuzuTara.ForeColor = Color.Black;
        }

        private void btnYuzuEkle_MouseMove(object sender, MouseEventArgs e)
        {
            btnYuzuEkle.BackColor = Color.DodgerBlue;
            btnYuzuEkle.ForeColor = Color.White;
        }

        private void btnYuzuEkle_MouseLeave(object sender, EventArgs e)
        {
            btnYuzuEkle.BackColor = Color.Transparent;
            btnYuzuEkle.ForeColor = Color.Black;
        }
        public AnaForm()
        {
            InitializeComponent();


            /*
             * Arduino
             */

            /*
            System.ComponentModel.IContainer components = new System.ComponentModel.Container();
            baglan = new System.IO.Ports.SerialPort(components);
            baglan.PortName = "COM5";
            baglan.BaudRate = 9600;

            baglan.Open();
            */


            yuz = new HaarCascade("haarcascade_frontalface_alt2.xml");
            goz = new HaarCascade("haarcascade_eye.xml");
            burun = new HaarCascade("haarcascade_mcs_nose.xml");
            yuz2=new HaarCascade("haarcascade_frontalface_default.xml");   
            //yuzProfil = new HaarCascade("lbpcascade_frontalcatface.xml");
            try
            {

                string kisiAd = File.ReadAllText(Application.StartupPath + "/Kisiler/Adlar.txt");
                string[] KisiAdlari = kisiAd.Split('&');
                string kisiSoyAd = File.ReadAllText(Application.StartupPath + "/Kisiler/Soyadlar.txt");
                string[] KisiSoyadlari = kisiSoyAd.Split('&');
                string kisiNumara = File.ReadAllText(Application.StartupPath + "/Kisiler/Numaralar.txt");
                string[] KisiNumaralari = kisiNumara.Split('&');
                string kisiMail = File.ReadAllText(Application.StartupPath + "/Kisiler/Mailler.txt");
                string[] KisiMailleri = kisiMail.Split('&');   
                string kisiBolum = File.ReadAllText(Application.StartupPath + "/Kisiler/Bolumler.txt");
                string[] KisiBolumleri = kisiBolum.Split('&');
                string kisiSinif = File.ReadAllText(Application.StartupPath + "/Kisiler/Siniflar.txt");
                string[] KisiSiniflari = kisiSinif.Split('&');
                string kisiCinsiyet = File.ReadAllText(Application.StartupPath + "/Kisiler/Cinsiyetler.txt");
                string[] KisiCinsiyetleri = kisiCinsiyet.Split('&');

                kisiNumarasi = Convert.ToInt32(KisiAdlari[0]);
                kisiSayisi = kisiNumarasi;
                string tanimliKisi;

                for (int i = 1; i < kisiNumarasi+1; i++)
                {
                    tanimliKisi = "kisi" + i + ".bmp";
                    kisiTanimla.Add(new Image<Gray, byte>(Application.StartupPath + "/Kisiler/" + tanimliKisi));

                    adlari.Add(KisiAdlari[i]);
                    soyAdlari.Add(KisiSoyadlari[i]);
                    numaralari.Add(KisiNumaralari[i]);
                    mailleri.Add(KisiMailleri[i]);
                    bolumleri.Add(KisiBolumleri[i]);
                    siniflari.Add(KisiSiniflari[i]);
                    cinsiyetleri.Add(KisiCinsiyetleri[i]);
                }

            }
            catch(Exception e)
            {
                
                MessageBox.Show("Kayıtlı bir kullanıcı bulunamadı."
                    + "\n" + "" + "Yeni Bİr Kayıt Oluştururken Aşagıdaki İşlemleri İzleyiniz."
                    + "\n" + "" + "\n" + "1.Yüzü Tara Butonuna Tıklayarak Yeni Bir Yüz Tarayınız."
                    + "\n" + "" + "\n" + "2.Yüzü Ekle Butonuna Tıklayarak Yüz Tanımlamayı Bitiriniz."
                    , "Yüz Tanımlama İşlemi: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
           
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            
            fotoCek = new Capture();
            fotoCek.QueryFrame();
            
            Application.Idle += new EventHandler(FrameGrabber);
            btnYuzuTara.Visible = false;

        }


        private void button2_Click(object sender, System.EventArgs e)
        {
            //baglan.Write("4");
            //baglan.Write("7");
            axWindowsMediaPlayer2.URL = Application.StartupPath + "/foto.mp3";
            try
            {
                
                kisiSayisi = kisiSayisi + 1;

              
                gray = fotoCek.QueryGrayFrame().Resize(150, 150, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

                MCvAvgComp[][] tanimliYuzler = gray.DetectHaarCascade(
                yuz,
                1.1,
                5,
                Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                Size.Empty);

                MCvAvgComp[][] yuzTarama2 = gray.DetectHaarCascade(
                   yuz2,
                   1.1,
                   5,
                   Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                   Size.Empty);
                gray.ROI = Rectangle.Empty;

                MCvAvgComp[][] burunTarama = gray.DetectHaarCascade(
                  burun,
                  1.1,
                  5,
                  Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                  Size.Empty);
                gray.ROI = Rectangle.Empty;


                MCvAvgComp[][] gozTarama = gray.DetectHaarCascade(
                 goz,
                 1.1,
                 10,
                 Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                 Size.Empty);
                gray.ROI = Rectangle.Empty;



                foreach (MCvAvgComp f in tanimliYuzler[0])
                {
                    tanimliKisi = kameraResmi.Copy(f.rect).Convert<Gray, byte>();
                    break;
                }


                tanimliKisi = sonuc.Resize(150, 150, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                
                kisiTanimla.Add(tanimliKisi);

                adlari.Add(txtBoxAd.Text);
                soyAdlari.Add(txtBoxSoyad.Text);
                numaralari.Add(txtBoxOkulNo.Text);
                mailleri.Add(txtBoxMail.Text);
                bolumleri.Add(lblBolum.Text);
                siniflari.Add(cmbBoxSinif.Text);
                cinsiyetleri.Add(lblCinsiyet.Text);

                imgBoxYuzuEkle.Image = tanimliKisi;

                File.WriteAllText(Application.StartupPath + "/Kisiler/Adlar.txt", kisiTanimla.ToArray().Length.ToString() + "&");
                File.WriteAllText(Application.StartupPath + "/Kisiler/Soyadlar.txt", kisiTanimla.ToArray().Length.ToString() + "&");
                File.WriteAllText(Application.StartupPath + "/Kisiler/Numaralar.txt", kisiTanimla.ToArray().Length.ToString() + "&");
                File.WriteAllText(Application.StartupPath + "/Kisiler/Mailler.txt", kisiTanimla.ToArray().Length.ToString() + "&");
                File.WriteAllText(Application.StartupPath + "/Kisiler/Bolumler.txt", kisiTanimla.ToArray().Length.ToString() + "&");
                File.WriteAllText(Application.StartupPath + "/Kisiler/Siniflar.txt", kisiTanimla.ToArray().Length.ToString() + "&");
                File.WriteAllText(Application.StartupPath + "/Kisiler/Cinsiyetler.txt", kisiTanimla.ToArray().Length.ToString() + "&");

                for (int i = 1; i < kisiTanimla.ToArray().Length + 1; i++)
                {

                    kisiTanimla.ToArray()[i - 1].Save(Application.StartupPath + "/Kisiler/Kisi" + i + ".bmp");

                    File.AppendAllText(Application.StartupPath + "/Kisiler/Adlar.txt", adlari.ToArray()[i - 1] + "&");
                    File.AppendAllText(Application.StartupPath + "/Kisiler/Soyadlar.txt", soyAdlari.ToArray()[i - 1] + "&");
                    File.AppendAllText(Application.StartupPath + "/Kisiler/Numaralar.txt", numaralari.ToArray()[i - 1] + "&");
                    File.AppendAllText(Application.StartupPath + "/Kisiler/Mailler.txt", mailleri.ToArray()[i - 1] + "&");
                    File.AppendAllText(Application.StartupPath + "/Kisiler/Bolumler.txt", bolumleri.ToArray()[i - 1] + "&");
                    File.AppendAllText(Application.StartupPath + "/Kisiler/Siniflar.txt", siniflari.ToArray()[i - 1] + "&");
                    File.AppendAllText(Application.StartupPath + "/Kisiler/Cinsiyetler.txt", cinsiyetleri.ToArray()[i - 1] + "&");
                }
                MessageBox.Show(txtBoxAd.Text +" "+txtBoxSoyad.Text+ " adlı kişi eklendi.", "Ekleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
            catch
            {
                MessageBox.Show("Önce yüz taramayı etkinleştir.", "Ekleme Başarısız.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (cBoxMailGonder.Checked)
            {
                Gonder("BuuM Yuz Tanıma Programı", "Merhaba " + txtBoxAd.Text +" "+txtBoxSoyad+ "!\n\n" +
                    "Seni aramızda gördüğümüze sevindik!\n" +
                    "Bu programın beta aşamasına katıldığın için çok mutluyuz!" + "\n" +
                    "Merak etme; Aslında bu bir başlangıç!" + "\n" +
                    "Biz senin için çalışmaya devam ederken sende ürünlerimizi kullanmaya başlayabilirsin!\n\n\n" +
                    "İyi Eğlenceler!" + "\n\n\n" +
                    "@author; byoffical " + "\n\n\n" +
                    "Saygılarımızla" + "\n" +
                    "BuuM Ekibi"

                    );

            }

        }


        void FrameGrabber(object sender, EventArgs e)
        {
            lblYuzSayisi2.Text = "0";

            kisiAdlari.Add("");
            kisiSoyAdlari.Add("");
            kisiNumaralari.Add("");
            kisiMailleri.Add("");
            kisiBolumleri.Add("");
            kisiSiniflari.Add("");
            kisiCinsiyetleri.Add("");

            

            kameraResmi = fotoCek.QueryFrame().Resize(300, 280, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
           
            gray = kameraResmi.Convert<Gray, Byte>();

                    MCvAvgComp[][] tanimliYuz = gray.DetectHaarCascade(
                  yuz,
                  1.1,
                  5,
                  Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                  Size.Empty);



            foreach (MCvAvgComp f in tanimliYuz[0])
            {
                t = t + 1;
                sonuc = kameraResmi.Copy(f.rect).Convert<Gray, byte>().Resize(150, 150, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);




                kameraResmi.Draw(f.rect, new Bgr(Color.Red), 2);


                if (kisiTanimla.ToArray().Length != 0)
                {

                    MCvTermCriteria tc = new MCvTermCriteria(kisiSayisi, 0.001);

                    EigenObjectRecognizer rec = new EigenObjectRecognizer(
                       kisiTanimla.ToArray(),
                       adlari.ToArray(),

                       3000,
                       ref tc);

                    ad = rec.Recognize(sonuc);


                    kameraResmi.Draw(ad, ref kameraKisiAd, new Point(f.rect.X - 5, f.rect.Y - 5), new Bgr(Color.Lime));

                    if ((!lblGuvenlikDuvariDurum.Text.Equals("Kapalı")&&ad!=""))
                    {
                        //baglan.Write("1");
                        //baglan.Write("5");
                        //baglan.Write("8");
                    }



                    MCvTermCriteria tc1 = new MCvTermCriteria(kisiSayisi, 0.001);
                    EigenObjectRecognizer rec1 = new EigenObjectRecognizer(
                          kisiTanimla.ToArray(),
                          soyAdlari.ToArray(),

                          3000,
                          ref tc1);
                    soyAd = rec1.Recognize(sonuc);

                    MCvTermCriteria tc2 = new MCvTermCriteria(kisiSayisi, 0.001);
                    EigenObjectRecognizer rec2 = new EigenObjectRecognizer(
                          kisiTanimla.ToArray(),
                          numaralari.ToArray(),

                          3000,
                          ref tc2);
                    numara = rec2.Recognize(sonuc);

                    MCvTermCriteria tc3 = new MCvTermCriteria(kisiSayisi, 0.001);
                    EigenObjectRecognizer rec3 = new EigenObjectRecognizer(
                          kisiTanimla.ToArray(),
                          mailleri.ToArray(),

                          3000,
                          ref tc3);
                    mail = rec3.Recognize(sonuc);


                    MCvTermCriteria tc4 = new MCvTermCriteria(kisiSayisi, 0.001);
                    EigenObjectRecognizer rec4 = new EigenObjectRecognizer(
                          kisiTanimla.ToArray(),
                          bolumleri.ToArray(),

                          3000,
                          ref tc4);
                    bolum = rec4.Recognize(sonuc);


                    MCvTermCriteria tc5 = new MCvTermCriteria(kisiSayisi, 0.001);
                    EigenObjectRecognizer rec5 = new EigenObjectRecognizer(
                          kisiTanimla.ToArray(),
                          siniflari.ToArray(),

                          3000,
                          ref tc5);
                    sinif = rec5.Recognize(sonuc);


                    MCvTermCriteria tc6 = new MCvTermCriteria(kisiSayisi, 0.001);
                    EigenObjectRecognizer rec6 = new EigenObjectRecognizer(
                          kisiTanimla.ToArray(),
                          cinsiyetleri.ToArray(),

                          3000,
                          ref tc6);
                    cinsiyet = rec6.Recognize(sonuc);
                }

                kisiAdlari[t - 1] = ad;
                kisiAdlari.Add("");
                kisiSoyAdlari[t - 1] = soyAd;
                kisiSoyAdlari.Add("");
                kisiNumaralari[t - 1] = numara;
                kisiNumaralari.Add("");
                kisiMailleri[t - 1] = mail;
                kisiMailleri.Add("");
                kisiBolumleri[t - 1] = bolum;
                kisiBolumleri.Add("");
                kisiSiniflari[t - 1] = sinif;
                kisiSiniflari.Add("");
                kisiCinsiyetleri[t - 1] = cinsiyet;
                kisiCinsiyetleri.Add("");

                lblYuzSayisi2.Text = tanimliYuz[0].Length.ToString();






                if ((adlar == "Alanda Kimse Yok" ||
                                  adlar == "" ||
                                  adlar == "örn: BuuM" ||
                             numaralar == "Alanda Kimse Yok" ||

                             mailler == "Alanda Kimse Yok" ||
                             soyAdlar == "Alanda Kimse Yok" ||
                              soyAdlar == "örn: BuuM" ||
                              soyAdlar == "" ||
                             bolumler == "Alanda Kimse Yok" ||
                             siniflar == "Alanda Kimse Yok" ||

                             cinsiyetler == "Alanda Kimse Yok") &&


                             lblGuvenlikDuvariDurum.Text.Equals("Açık"))
                             /*
                {
                    baglan.Write("0");
                }
               */
                    
               

                //Göz Tarama
                gray.ROI = f.rect;
                MCvAvgComp[][] gozTarama = gray.DetectHaarCascade(
                   goz,
                   1.1,
                   2,
                   Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                   Size.Empty);
                gray.ROI = Rectangle.Empty;

                foreach (MCvAvgComp g in gozTarama[0])
                {
                    Rectangle gozKayit = g.rect;
                    gozKayit.Offset(f.rect.X, f.rect.Y);
                    kameraResmi.Draw(gozKayit, new Bgr(Color.Blue), 2);
                }

                //Burun Tarama
                gray.ROI = f.rect;
                MCvAvgComp[][] burunTarama = gray.DetectHaarCascade(
                   burun,
                   1.1,
                   2,
                   Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                   Size.Empty);
                gray.ROI = Rectangle.Empty;

                foreach (MCvAvgComp b in burunTarama[0])
                {
                    Rectangle burunKayit = b.rect;
                    burunKayit.Offset(f.rect.X, f.rect.Y);
                    kameraResmi.Draw(burunKayit, new Bgr(Color.Orange), 2);
                }



                //Yuz2 Tarama
                gray.ROI = f.rect;
                MCvAvgComp[][] yuzTarama2 = gray.DetectHaarCascade(
                   yuz2,
                   1.1,
                   3,
                   Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                   Size.Empty);
                gray.ROI = Rectangle.Empty;

                foreach (MCvAvgComp y in yuzTarama2[0])
                {
                    Rectangle yuzKayit2 = y.rect;
                    yuzKayit2.Offset(f.rect.X, f.rect.Y);
                    kameraResmi.Draw(yuzKayit2, new Bgr(Color.SkyBlue), 1);
                }


            }


          t = 0;


            for (int i = 0; i < tanimliYuz[0].Length; i++)
            {
                adlar = kisiAdlari[i];
            }
            for (int i = 0; i < tanimliYuz[0].Length; i++)
            {
                soyAdlar = kisiSoyAdlari[i];
            }
            for (int i = 0; i < tanimliYuz[0].Length; i++)
            {
                numaralar = kisiNumaralari[i];
            }
            for (int i = 0; i < tanimliYuz[0].Length; i++)
            {
                mailler = kisiMailleri[i];
            }
            for (int i = 0; i < tanimliYuz[0].Length; i++)
            {
                bolumler = kisiBolumleri[i];
            }
            for (int i = 0; i < tanimliYuz[0].Length; i++)
            {
                siniflar = kisiSiniflari[i];
            }
            for (int i = 0; i < tanimliYuz[0].Length; i++)
            {
                cinsiyetler = kisiCinsiyetleri[i];
            }

            imgBoxYuzuTara.Image = kameraResmi;
            lblTanimliKisiAd.Text = adlar;
            lblTanimliKisiSoyad.Text = soyAdlar;
            lblTanimliKisiNumara.Text = numaralar;
            lblTanimliKisiMail.Text = mailler;
            lblTanimliKisiBolum.Text = bolumler;
            lblTanimliKisiSinif.Text = siniflar;
            lblTanimliKisiCinsiyet.Text = cinsiyetler;

            adlar = "Alanda Kimse Yok";
            numaralar = "Alanda Kimse Yok";
            mailler = "Alanda Kimse Yok";
            soyAdlar = "Alanda Kimse Yok";
            bolumler = "Alanda Kimse Yok";
            siniflar = "Alanda Kimse Yok";
            cinsiyetler = "Alanda Kimse Yok";


            kisiAdlari.Clear();
            kisiSoyAdlari.Clear();
            kisiNumaralari.Clear();
            kisiMailleri.Clear();
            kisiBolumleri.Clear();
            kisiSiniflari.Clear();
            kisiCinsiyetleri.Clear();
           
        }
        
    }
}