using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Globalization;

namespace Petrol_Otomasyonu
{
    public partial class satis : Form
    {
        CultureInfo yourCulture = CultureInfo.GetCultureInfo("tr-TR");
        public satis()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("provider=microsoft.ace.oledb.12.0;data source=" + Application.StartupPath + "\\bilgiler.accdb");
        DataTable tablo = new DataTable();


        public void listele()
        {
            arac_plaka_textBox.Text = "";
            depoda_kalan_textBox.Text = "0";
            satilan_litre_textBox.Text = "";
            tc_no_comboBox.SelectedIndex = -1;
            akaryakit_comboBox.SelectedIndex = -1;
            toplam_tutar_sayi_label.Text = "0";
            litre_fiyati_sayi_label.Text = "0";
            tablo.Clear();
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter
          ("select * from satis", baglanti);
            adtr.Fill(tablo);
            Bilgi_Tablosu1.DataSource = tablo;
            Bilgi_Tablosu1.Columns[0].Visible = false;
            baglanti.Close();

            Bilgi_Tablosu1.EnableHeadersVisualStyles = false;
            Bilgi_Tablosu1.ColumnHeadersDefaultCellStyle.ForeColor = Color.DarkRed;
            Bilgi_Tablosu1.Columns[1].HeaderText = "Araç Plaka";
            Bilgi_Tablosu1.Columns[2].HeaderText = "Akaryakıt Türü";
            Bilgi_Tablosu1.Columns[3].HeaderText = "Satılan Litre";
            Bilgi_Tablosu1.Columns[4].HeaderText = "Toplam Tutar";
            Bilgi_Tablosu1.Columns[5].HeaderText = "Satış Tarihi";
        }
        private void satis_Load(object sender, EventArgs e)
        {
            listele();
            //access bağlantıyı sağladık
            OleDbCommand komut = new OleDbCommand("select * from musteri", baglanti);
            //access komutumuzu yazdık komutta veritabanındaki admin tablosunda kullanıcı adı textbox1.text olan şifresi textbox2.text olan veriyi
            // çekmesini istedik
            baglanti.Open();//bağlantıyı açdık

            OleDbDataReader oku = komut.ExecuteReader();//veriyi okutma emrini verdik
            while (oku.Read())//if eğer veriyi okumuşsa yani böyle bir kullanıcı veritabanında kayıtlıysa
            {

                tc_no_comboBox.Items.Add(oku.GetValue(1));

            }
            baglanti.Close();
            ///////////////////////////////////////////////////////////////
            //access bağlantıyı sağladık
            OleDbCommand komut2 = new OleDbCommand("select * from depo", baglanti);

            baglanti.Open();//bağlantıyı açdık

            OleDbDataReader oku2 = komut2.ExecuteReader();//veriyi okutma emrini verdik
            while (oku2.Read())//if eğer veriyi okumuşsa yani böyle bir kullanıcı veritabanında kayıtlıysa
            {

                akaryakit_comboBox.Items.Add(oku2.GetValue(1));

            }


        }

        private void tc_no_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=bilgiler.accdb;Persist Security Info=True");
                //access bağlantıyı sağladık
                OleDbCommand komut = new OleDbCommand("select * from musteri where tc='" + tc_no_comboBox.Text + "'", baglanti);
                //access komutumuzu yazdık komutta veritabanındaki admin tablosunda kullanıcı adı textbox1.text olan şifresi textbox2.text olan veriyi
                // çekmesini istedik
                baglanti.Open();//bağlantıyı açdık

                OleDbDataReader oku = komut.ExecuteReader();//veriyi okutma emrini verdik
                if (oku.Read())//if eğer veriyi okumuşsa yani böyle bir kullanıcı veritabanında kayıtlıysa
                {

                    arac_plaka_textBox.Text = oku.GetValue(7).ToString();

                }
            }
            catch
            {

                ;
            }
        }

        private void akaryakit_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                satilan_litre_textBox.Text = "";
                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=bilgiler.accdb;Persist Security Info=True");
                //access bağlantıyı sağladık
                OleDbCommand komut = new OleDbCommand("select * from depo where akaryakit_adi='" + akaryakit_comboBox.Text + "'", baglanti);
                //access komutumuzu yazdık komutta veritabanındaki admin tablosunda kullanıcı adı textbox1.text olan şifresi textbox2.text olan veriyi
                // çekmesini istedik
                baglanti.Open();//bağlantıyı açdık

                OleDbDataReader oku = komut.ExecuteReader();//veriyi okutma emrini verdik
                if (oku.Read())//if eğer veriyi okumuşsa yani böyle bir kullanıcı veritabanında kayıtlıysa
                {

                    depoda_kalan_textBox.Text = oku.GetValue(3).ToString();
                    litre_fiyati_sayi_label.Text = oku.GetValue(2).ToString();
                }
            }
            catch
            {

                ;
            }
        }

        private void satis_yap_btn_Click(object sender, EventArgs e)
        {
            if (tc_no_comboBox.SelectedIndex == -1 || arac_plaka_textBox.Text == "" || akaryakit_comboBox.SelectedIndex == -1 || depoda_kalan_textBox.Text == "" || satilan_litre_textBox.Text == "")
            {
                MessageBox.Show("Bilgileri Eksik Girmeyiniz ! ", "Petrol Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            try
            {
                if (tc_no_comboBox.SelectedIndex != -1)
                {
                    double depodaolan, satilan, sonkalan = 0;
                    depodaolan = double.Parse(depoda_kalan_textBox.Text);
                    satilan = double.Parse(satilan_litre_textBox.Text);

                    if (depodaolan > satilan)
                    {

                        if (baglanti.State == ConnectionState.Open)
                        {

                            baglanti.Close();
                        }
                        baglanti.Open();

                        OleDbCommand kmt;

                        kmt = new OleDbCommand
                        ("INSERT INTO satis(arac_plaka,akaryakit_turu,satilan_litre,fiyat,tarih) values('" + arac_plaka_textBox.Text + "','" + akaryakit_comboBox.Text + "','" + satilan_litre_textBox.Text + "','" + double.Parse(toplam_tutar_sayi_label.Text, yourCulture) + "','" + DateTime.Now.ToShortDateString() + "')", baglanti);
                        kmt.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Satış İşlemi Başarılı.", "Petrol Otomasyonu");
                        // DEPODAN GEREKLİ MİKTARİ DÜŞÜRELİM

                        sonkalan = depodaolan - satilan;

                        OleDbCommand kmt2;
                        baglanti.Open();
                        kmt2 = new OleDbCommand("UPDATE depo SET depo_kalan='" + sonkalan.ToString() + "'where akaryakit_adi='" + akaryakit_comboBox.Text + "'", baglanti);
                        kmt2.ExecuteNonQuery();
                        baglanti.Close();
                        listele();
                    }

                        else if (this.akaryakit_comboBox.SelectedIndex == -1)
                        {
                            MessageBox.Show("Bilgileri Eksik Girmeyiniz ! ", "Petrol Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            satilan_litre_textBox.Text = "";
                            MessageBox.Show("Depoda bulunan kapasiteden daha fazla satamazsınız ! ", "Petrol Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch
            {
                ;
            }
        }

private void satilan_litre_textBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (satilan_litre_textBox.Text == "0")
                {
                    satilan_litre_textBox.Text = "";
                    MessageBox.Show("En Az 1 Litre Satın Almalısınız ! ", "Petrol Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else

                    toplam_tutar_sayi_label.Text = (double.Parse(litre_fiyati_sayi_label.Text, yourCulture) * double.Parse(satilan_litre_textBox.Text, yourCulture)).ToString(yourCulture);
                    
            }
            catch
            {

            }
        }

        private void anasayfa_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void satilan_litre_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((double)e.KeyChar == 44)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }
    }
}
