using KolejProjesi.Entity;
using KolejProjesi.Tools;

namespace KolejProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private Kolej KolejBilgisiAl()
        {
            Kolej kolej = new();
            kolej.KolejAd = txtKolejAdi.Text;
            kolej.KolejSahibi = txtKolejSahibi.Text;
            kolej.KolejUcret = Convert.ToDecimal(txtKolejUcreti.Text);
            kolej.KolejKapasite = Convert.ToInt32( txtKolejKapasitesi.Text);

            return kolej;
        }

        private void KolejListesi(Kolej kolej)
        {
            KolejListesi kolejListesi = new();
            kolejListesi.Add(kolej);

        }

        private void Temizle()
        {
            txtKolejAdi.Clear();
            txtKolejKapasitesi.Clear();
            txtKolejSahibi.Clear();
            txtKolejUcreti.Clear();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kolej yeniKolej = KolejBilgisiAl();
            listBox1.Items.Add(yeniKolej);
            KolejListesi(yeniKolej);
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            //Islemler.Clear(this.Controls);
            Temizle();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            int secili = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(secili);
            Kolej yeniKolej = KolejBilgisiAl();
            listBox1.Items.Insert(secili, yeniKolej);
            KolejListesi(yeniKolej);

        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            KolejListesi kolej = new();

            Kolej secilen = (Kolej)listBox1.SelectedItem;
                    
           txtKolejAdi.Text = secilen.KolejAd;
           txtKolejKapasitesi.Text = secilen.KolejKapasite.ToString();
           txtKolejSahibi.Text = secilen.KolejSahibi;
           txtKolejUcreti.Text = secilen.KolejUcret.ToString();
                
                        
        }
    }
}