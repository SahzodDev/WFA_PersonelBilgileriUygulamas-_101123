using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_PersonelBilgileriUygulaması_101123
{
    internal class Personel
    {

        public Personel() 
        {
            Lvi = new ListViewItem();
        }
        private string personelID;

        public string PersonelID
        {
            get { return personelID; }
            set 
            { 
                if (value.Length < 5)
                {
                    throw new ArgumentException("ID uzunluğu 5'den küçük olamaz.");
                }
                else
                {
                    personelID = value;
                }
                
            }
        }
        public ListViewItem Lvi { get; set; }
        public string Ad {  get; set; }
        public string Soyad { get; set; }
        private DateTime dogumTarihi;

        public DateTime DogumTarihi
        {
            get { return dogumTarihi; }
            set 
            { 
                if ((DateTime.Now.Year - value.Year) <= 18)
                {
                    throw new Exception("Çalışan 18 yaşından küçük olamaz.");
                }
                else
                {
                    dogumTarihi = value;
                }
                
            }
        }

        public string Telefon { get; set; }
        private string email;

        public string Email
        {
            get { return email; }
            set 
            { 
                if (!value.Contains("@bilgeadam.com"))
                {
                    throw new Exception("Email uzantısı yanlış.");
                }
                else
                {
                    email = value;
                }
                
            }
        }

        public string Adres { get; set; }
        private DateTime iseGirisTarihi;

        public DateTime IseGirisTarihi
        {
            get { return iseGirisTarihi; }
            set 
            { 
                if (value.Date == DateTime.Today)
                {
                    throw new Exception("İşe giriş tarihi bugün olamaz.");
                }
                else
                {
                    iseGirisTarihi = value;
                }
                
            }
        }

        public string ResimDosyaYolu { get; set; }

        public void LviDoldur()
        {
            Lvi.Text = PersonelID;
            Lvi.SubItems.Add(Ad);
            Lvi.SubItems.Add(Soyad);
            Lvi.SubItems.Add(DogumTarihi.ToString());
            Lvi.SubItems.Add(Telefon);
            Lvi.SubItems.Add(Email);
            Lvi.SubItems.Add(ResimDosyaYolu);
            Lvi.SubItems.Add(Adres);
            Lvi.SubItems.Add(IseGirisTarihi.ToString());
            


        }

        
    }
}
