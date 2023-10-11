namespace WFA_PersonelBilgileriUygulaması_101123
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string dosyaYolu = string.Empty;
        private void btnResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG (.jpg)|*.jpg|PNG (.png)|*.png";
            ofd.ShowDialog();
            dosyaYolu = ofd.FileName;
            pbResim.ImageLocation = dosyaYolu;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();

            Personel personel = new Personel();
            try
            {
                personel.PersonelID = txtID.Text;
                personel.Ad = txtAd.Text;
                personel.Soyad = txtSoyad.Text;
                personel.DogumTarihi = dtpDogumTarihi.Value;
                personel.Telefon = mtxtTelefon.Text;
                personel.Email = txtEmail.Text;
                personel.Adres = txtAdres.Text;
                personel.IseGirisTarihi = dtpIseGirisTarihi.Value;
                personel.ResimDosyaYolu = dosyaYolu;

                personel.LviDoldur();

                lvPersonelBilgileri.Items.Add(personel.Lvi);
                ClearAllFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            //lvi.Text = txtID.Text;
            //lvi.SubItems.Add(txtAd.Text);
            //lvi.SubItems.Add(txtSoyad.Text);
            //lvi.SubItems.Add(dtpDogumTarihi.Text);
            //lvi.SubItems.Add(mtxtTelefon.Text);
            //lvi.SubItems.Add(txtEmail.Text);
            //lvi.SubItems.Add(dosyaYolu);

            
            
        }

        private void lvPersonelBilgileri_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            btnGuncelle.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;
            if (lvPersonelBilgileri.SelectedItems.Count > 0)
            {
                LviDenBilgileriDoldur(lvPersonelBilgileri.SelectedItems[0]);
            }

        }

        public void ClearAllFields()
        {
            txtAd.Clear();
            txtID.Clear();
            txtSoyad.Clear();
            txtEmail.Clear();
            txtAdres.Clear();
            mtxtTelefon.Clear();
            dtpDogumTarihi.Value = DateTime.Now;
            dtpIseGirisTarihi.Value = DateTime.Now;
            pbResim.Image = null;
            dosyaYolu = string.Empty;

        }

        public void LviDenBilgileriDoldur(ListViewItem lvi)
        {
            txtID.Text = lvi.SubItems[0].Text;
            txtAd.Text = lvi.SubItems[1].Text;
            txtSoyad.Text = lvi.SubItems[2].Text;
            dtpDogumTarihi.Text = lvi.SubItems[3].Text;
            mtxtTelefon.Text = lvi.SubItems[4].Text;
            txtEmail.Text = lvi.SubItems[5].Text;
            dosyaYolu = lvi.SubItems[6].Text;
            pbResim.ImageLocation = dosyaYolu;
            txtAdres.Text = lvi.SubItems[7].Text;
            dtpIseGirisTarihi.Text = lvi.SubItems[8].Text;

        }

        public void LviDoldur(ListViewItem lvi)
        {


            lvi.Text = txtID.Text;
            lvi.SubItems[1].Text = txtAd.Text;
            lvi.SubItems[2].Text = txtSoyad.Text;
            lvi.SubItems[3].Text = dtpDogumTarihi.Text;
            lvi.SubItems[4].Text = mtxtTelefon.Text;
            lvi.SubItems[5].Text = txtEmail.Text;
            lvi.SubItems[6].Text = pbResim.ImageLocation;
            lvi.SubItems[7].Text = txtAdres.Text;
            lvi.SubItems[8].Text = dtpIseGirisTarihi.Text;

            //return lvi;


        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //lvPersonelBilgileri.Items.Add(LviDoldur(lvPersonelBilgileri.SelectedItems[0]));
            //lvPersonelBilgileri.SelectedItems[0].Remove();
            LviDoldur(lvPersonelBilgileri.SelectedItems[0]);
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
            btnKaydet.Enabled = true;
            lvPersonelBilgileri.Refresh();
            ClearAllFields();
        }



        private void btnSil_Click(object sender, EventArgs e)
        {
            lvPersonelBilgileri.SelectedItems[0].Remove();
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
            btnKaydet.Enabled = true;
            ClearAllFields();
        }
    }
}