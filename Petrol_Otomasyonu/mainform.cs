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
namespace Petrol_Otomasyonu
{
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("provider=microsoft.ace.oledb.12.0;data source=" + Application.StartupPath + "\\bilgiler.accdb");
        DataTable tablo = new DataTable();
        private void giris_btn_Click(object sender, EventArgs e)
        {
            OleDbCommand komut = new OleDbCommand("select * from admin where kullanici_adi='" + kullanici_adi_textbox.Text + "' and sifre ='" + sifre_textbox.Text + "'", baglanti);
            //access komutumuzu yazdık komutta veritabanındaki admin tablosunda kullanıcı adı textbox1.text olan şifresi textbox2.text olan veriyi
            // çekmesini istedik
            baglanti.Open();//bağlantıyı açdık

            OleDbDataReader oku = komut.ExecuteReader();//veriyi okutma emrini verdik
            if (oku.Read())//if eğer veriyi okumuşsa yani böyle bir kullanıcı veritabanında kayıtlıysa
            {
                MessageBox.Show("Hoşgeldiniz ...", "Petrol Otomasyonu");//giriş başarılı diye uyari verir
                baglanti.Close();//bağlantıyı kapar
                menu menu = new menu();//yeni bir menü sayfası oluşturur
                menu.Show();//menü sayfasını açar
                this.Hide();////mevcut sayfayı gizler

            }
            else
            {
                MessageBox.Show("Kullanıcı Bilgileriniz Yanlış veya Eksik !", "Petrol Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);//hayır veri okuyamadıysa uyarı verir
                kullanici_adi_textbox.Text = "";
                sifre_textbox.Text = "";
                baglanti.Close();//bağlantıyı kapar
                //verileri temizler
            }
        }

        private void cikis_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kullanici_adi_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void sifre_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void mainform_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void mainform_Load(object sender, EventArgs e)
        {

        }

        private void uye_ol_btn_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Open)
            {

                baglanti.Close();
            }

            if (kullanici_adi_textbox.Text == "" || sifre_textbox.Text == "" )
            {
                MessageBox.Show("Bilgileri Eksik Girmeyiniz ! ", "Petrol Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                baglanti.Open();

                OleDbCommand kmt;

                kmt = new OleDbCommand
                ("INSERT INTO admin (kullanici_adi,sifre) values('" + kullanici_adi_textbox.Text + "','" + sifre_textbox.Text + "')", baglanti);
                kmt.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Başarılı.", "Petrol Otomasyonu");
            }
        }
    }
}
