namespace WFA_PersonelBilgileriUygulaması_101123
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbPersonelBilgileri = new GroupBox();
            dtpIseGirisTarihi = new DateTimePicker();
            dtpDogumTarihi = new DateTimePicker();
            mtxtTelefon = new MaskedTextBox();
            btnSil = new Button();
            btnGuncelle = new Button();
            btnKaydet = new Button();
            btnResimSec = new Button();
            pbResim = new PictureBox();
            txtAdres = new TextBox();
            label8 = new Label();
            label7 = new Label();
            txtEmail = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            txtID = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lvPersonelBilgileri = new ListView();
            chPersonelID = new ColumnHeader();
            chAd = new ColumnHeader();
            chSoyad = new ColumnHeader();
            chDogumTarihi = new ColumnHeader();
            chTelefon = new ColumnHeader();
            chEmail = new ColumnHeader();
            chResimYolu = new ColumnHeader();
            chAdres = new ColumnHeader();
            chIserGirisTarihi = new ColumnHeader();
            gbPersonelBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbResim).BeginInit();
            SuspendLayout();
            // 
            // gbPersonelBilgileri
            // 
            gbPersonelBilgileri.Controls.Add(dtpIseGirisTarihi);
            gbPersonelBilgileri.Controls.Add(dtpDogumTarihi);
            gbPersonelBilgileri.Controls.Add(mtxtTelefon);
            gbPersonelBilgileri.Controls.Add(btnSil);
            gbPersonelBilgileri.Controls.Add(btnGuncelle);
            gbPersonelBilgileri.Controls.Add(btnKaydet);
            gbPersonelBilgileri.Controls.Add(btnResimSec);
            gbPersonelBilgileri.Controls.Add(pbResim);
            gbPersonelBilgileri.Controls.Add(txtAdres);
            gbPersonelBilgileri.Controls.Add(label8);
            gbPersonelBilgileri.Controls.Add(label7);
            gbPersonelBilgileri.Controls.Add(txtEmail);
            gbPersonelBilgileri.Controls.Add(txtSoyad);
            gbPersonelBilgileri.Controls.Add(txtAd);
            gbPersonelBilgileri.Controls.Add(txtID);
            gbPersonelBilgileri.Controls.Add(label6);
            gbPersonelBilgileri.Controls.Add(label5);
            gbPersonelBilgileri.Controls.Add(label4);
            gbPersonelBilgileri.Controls.Add(label3);
            gbPersonelBilgileri.Controls.Add(label2);
            gbPersonelBilgileri.Controls.Add(label1);
            gbPersonelBilgileri.Location = new Point(12, 12);
            gbPersonelBilgileri.Name = "gbPersonelBilgileri";
            gbPersonelBilgileri.Size = new Size(1229, 378);
            gbPersonelBilgileri.TabIndex = 0;
            gbPersonelBilgileri.TabStop = false;
            gbPersonelBilgileri.Text = "Personel Bilgileri";
            // 
            // dtpIseGirisTarihi
            // 
            dtpIseGirisTarihi.Location = new Point(637, 104);
            dtpIseGirisTarihi.Name = "dtpIseGirisTarihi";
            dtpIseGirisTarihi.Size = new Size(214, 23);
            dtpIseGirisTarihi.TabIndex = 24;
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Location = new Point(131, 135);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(214, 23);
            dtpDogumTarihi.TabIndex = 23;
            // 
            // mtxtTelefon
            // 
            mtxtTelefon.Location = new Point(131, 168);
            mtxtTelefon.Mask = "(999) 000-0000";
            mtxtTelefon.Name = "mtxtTelefon";
            mtxtTelefon.Size = new Size(214, 23);
            mtxtTelefon.TabIndex = 22;
            // 
            // btnSil
            // 
            btnSil.Enabled = false;
            btnSil.Location = new Point(737, 283);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(104, 37);
            btnSil.TabIndex = 21;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Enabled = false;
            btnGuncelle.Location = new Point(737, 240);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(104, 37);
            btnGuncelle.TabIndex = 20;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(737, 197);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(104, 37);
            btnKaydet.TabIndex = 19;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnResimSec
            // 
            btnResimSec.Location = new Point(737, 154);
            btnResimSec.Name = "btnResimSec";
            btnResimSec.Size = new Size(104, 37);
            btnResimSec.TabIndex = 18;
            btnResimSec.Text = "Resim Seç";
            btnResimSec.UseVisualStyleBackColor = true;
            btnResimSec.Click += btnResimSec_Click;
            // 
            // pbResim
            // 
            pbResim.Location = new Point(518, 152);
            pbResim.Name = "pbResim";
            pbResim.Size = new Size(190, 141);
            pbResim.SizeMode = PictureBoxSizeMode.StretchImage;
            pbResim.TabIndex = 17;
            pbResim.TabStop = false;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(637, 26);
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(214, 67);
            txtAdres.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(518, 106);
            label8.Name = "label8";
            label8.Size = new Size(113, 21);
            label8.TabIndex = 13;
            label8.Text = "İşe Giriş Tarihi :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(574, 24);
            label7.Name = "label7";
            label7.Size = new Size(57, 21);
            label7.TabIndex = 12;
            label7.Text = "Adres :";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(131, 205);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(214, 23);
            txtEmail.TabIndex = 11;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(131, 106);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(214, 23);
            txtSoyad.TabIndex = 8;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(131, 73);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(214, 23);
            txtAd.TabIndex = 7;
            // 
            // txtID
            // 
            txtID.Location = new Point(131, 40);
            txtID.Name = "txtID";
            txtID.Size = new Size(214, 23);
            txtID.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(70, 203);
            label6.Name = "label6";
            label6.Size = new Size(55, 21);
            label6.TabIndex = 5;
            label6.Text = "Email :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(59, 170);
            label5.Name = "label5";
            label5.Size = new Size(66, 21);
            label5.TabIndex = 4;
            label5.Text = "Telefon :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(15, 137);
            label4.Name = "label4";
            label4.Size = new Size(110, 21);
            label4.TabIndex = 3;
            label4.Text = "Doğum Tarihi :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(65, 104);
            label3.Name = "label3";
            label3.Size = new Size(60, 21);
            label3.TabIndex = 2;
            label3.Text = "Soyad :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(89, 71);
            label2.Name = "label2";
            label2.Size = new Size(36, 21);
            label2.TabIndex = 1;
            label2.Text = "Ad :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(30, 38);
            label1.Name = "label1";
            label1.Size = new Size(95, 21);
            label1.TabIndex = 0;
            label1.Text = "Personel ID :";
            // 
            // lvPersonelBilgileri
            // 
            lvPersonelBilgileri.Columns.AddRange(new ColumnHeader[] { chPersonelID, chAd, chSoyad, chDogumTarihi, chTelefon, chEmail, chResimYolu, chAdres, chIserGirisTarihi });
            lvPersonelBilgileri.GridLines = true;
            lvPersonelBilgileri.Location = new Point(12, 396);
            lvPersonelBilgileri.MultiSelect = false;
            lvPersonelBilgileri.Name = "lvPersonelBilgileri";
            lvPersonelBilgileri.Size = new Size(1229, 275);
            lvPersonelBilgileri.TabIndex = 22;
            lvPersonelBilgileri.UseCompatibleStateImageBehavior = false;
            lvPersonelBilgileri.View = View.Details;
            lvPersonelBilgileri.ItemSelectionChanged += lvPersonelBilgileri_ItemSelectionChanged;
            // 
            // chPersonelID
            // 
            chPersonelID.Text = "Personel ID";
            chPersonelID.Width = 120;
            // 
            // chAd
            // 
            chAd.Text = "Ad";
            chAd.Width = 120;
            // 
            // chSoyad
            // 
            chSoyad.Text = "Soyad";
            chSoyad.Width = 120;
            // 
            // chDogumTarihi
            // 
            chDogumTarihi.Text = "Doğum Tarihi";
            chDogumTarihi.Width = 90;
            // 
            // chTelefon
            // 
            chTelefon.Text = "Telefon";
            chTelefon.Width = 90;
            // 
            // chEmail
            // 
            chEmail.Text = "Email";
            chEmail.Width = 150;
            // 
            // chResimYolu
            // 
            chResimYolu.Text = "Resim Yolu";
            chResimYolu.Width = 120;
            // 
            // chAdres
            // 
            chAdres.Text = "Adres";
            chAdres.Width = 300;
            // 
            // chIserGirisTarihi
            // 
            chIserGirisTarihi.Text = "İşe Giriş Tarihi";
            chIserGirisTarihi.Width = 90;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1253, 683);
            Controls.Add(lvPersonelBilgileri);
            Controls.Add(gbPersonelBilgileri);
            Name = "Form1";
            Text = "Form1";
            gbPersonelBilgileri.ResumeLayout(false);
            gbPersonelBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbResim).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbPersonelBilgileri;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtEmail;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private TextBox txtID;
        private Label label7;
        private Label label8;
        private TextBox txtAdres;
        private Button btnResimSec;
        private PictureBox pbResim;
        private Button btnSil;
        private Button btnGuncelle;
        private Button btnKaydet;
        private ListView lvPersonelBilgileri;
        private ColumnHeader chPersonelID;
        private ColumnHeader chAd;
        private ColumnHeader chSoyad;
        private ColumnHeader chDogumTarihi;
        private ColumnHeader chTelefon;
        private ColumnHeader chEmail;
        private ColumnHeader chResimYolu;
        private MaskedTextBox mtxtTelefon;
        private DateTimePicker dtpDogumTarihi;
        private DateTimePicker dtpIseGirisTarihi;
        private ColumnHeader chAdres;
        private ColumnHeader chIserGirisTarihi;
    }
}