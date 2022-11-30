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
    public partial class akaryakit : Form
    {
        CultureInfo yourCulture = CultureInfo.GetCultureInfo("tr-TR");
        public akaryakit()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection("provider=microsoft.ace.oledb.12.0;data source=" + Application.StartupPath + "\\bilgiler.accdb");
        DataTable tablo = new DataTable();
        DataTable tablo1 = new DataTable();
        public void listele()
        {
            akaryakit_adi_textbox.Text = "";
            litre_fiyati_textbox.Text = "";
            depo_textbox.Text = "";
        
            tablo.Clear();
            baglan.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter
          ("select * from depo", baglan);
            adtr.Fill(tablo);
            Bilgi_Tablosu1.DataSource = tablo;
            Bilgi_Tablosu1.Columns[0].Visible = false;
            baglan.Close();

            Bilgi_Tablosu1.EnableHeadersVisualStyles = false;
            Bilgi_Tablosu1.ColumnHeadersDefaultCellStyle.ForeColor = Color.DarkRed;
            Bilgi_Tablosu1.Columns[1].HeaderText = "Akaryakıt Adı";
            Bilgi_Tablosu1.Columns[2].HeaderText = "Litre Fiyatı";
            Bilgi_Tablosu1.Columns[3].HeaderText = "Depoda Kalan Yakıt";
        }

        private void akaryakit_Load(object sender, EventArgs e)
        {
            listele();
        }
        private void ekle_picturebox_Click(object sender, EventArgs e)
        {
                if (akaryakit_adi_textbox.Text == "" || litre_fiyati_textbox.Text == "" || depo_textbox.Text == "")
                {
                    MessageBox.Show("Bilgileri Eksik Girmeyiniz ! ", "Petrol Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            else
            {
                if (baglan.State == ConnectionState.Open)
                {

                    baglan.Close();
                }
                baglan.Open();

                OleDbCommand kmt;

                kmt = new OleDbCommand
                ("INSERT INTO depo(akaryakit_adi,litre_fiyati,depo_kalan) values('" + akaryakit_adi_textbox.Text + "','" + litre_fiyati_textbox.Text + "','" + depo_textbox.Text + "')", baglan);
                kmt.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Kayıt Başarılı.", "Petrol Otomasyonu");
                listele();
                tablo1.Clear();
            }
        }

        private void sil_picturebox_Click(object sender, EventArgs e)
        {
                OleDbCommand kmt;
                baglan.Open();
                kmt = new OleDbCommand("Delete from depo where akaryakit_adi = '" + Bilgi_Tablosu1.CurrentRow.Cells[1].Value.ToString() + "'", baglan);
                kmt.ExecuteNonQuery();
                kmt.Dispose();
                baglan.Close();
                MessageBox.Show("İşleminiz başarılı.", "Petrol Otomasyonu");
                listele();
                tablo1.Clear();
        }

        private void guncelle_picturebox_Click(object sender, EventArgs e)
        {

            if (akaryakit_adi_textbox.Text == "" || litre_fiyati_textbox.Text == "" || depo_textbox.Text == "")
            {
                MessageBox.Show("Bilgileri Eksik Girmeyiniz ! ", "Petrol Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                OleDbCommand kmt;
                baglan.Open();
                kmt = new OleDbCommand("UPDATE depo SET akaryakit_adi='" + akaryakit_adi_textbox.Text + "',litre_fiyati='" + litre_fiyati_textbox.Text + "',depo_kalan='" + depo_textbox.Text + "'where akaryakit_adi='" + Bilgi_Tablosu1.CurrentRow.Cells[1].Value.ToString() + "'", baglan);
                kmt.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("İşleminiz başarılı.", "Petrol Otomasyonu");
                listele();
                tablo1.Clear();
            }
        }

        private void ara_btn_Click(object sender, EventArgs e)
        {

            tablo1.Clear();
            baglan.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter
          ("select * from depo where akaryakit_adi='" + akaryakit_ara_textbox.Text + "'", baglan);
            adtr.Fill(tablo1);
            Bilgi_Tablosu2.DataSource = tablo1;
            Bilgi_Tablosu2.Columns[0].Visible = false;
            baglan.Close();
            akaryakit_ara_textbox.Text = "";

            Bilgi_Tablosu2.EnableHeadersVisualStyles = false;
            Bilgi_Tablosu2.ColumnHeadersDefaultCellStyle.ForeColor = Color.DarkRed;
            Bilgi_Tablosu2.Columns[1].HeaderText = "Akaryakıt Adı";
            Bilgi_Tablosu2.Columns[2].HeaderText = "Litre Fiyatı";
            Bilgi_Tablosu2.Columns[3].HeaderText = "Depoda Kalan Yakıt";
        }

        private void anasayfa_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Bilgi_Tablosu1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                akaryakit_adi_textbox.Text = Bilgi_Tablosu1.Rows[e.RowIndex].Cells[1].Value.ToString();
                litre_fiyati_textbox.Text = Bilgi_Tablosu1.Rows[e.RowIndex].Cells[2].Value.ToString();
                depo_textbox.Text = Bilgi_Tablosu1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void Bilgi_Tablosu2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                akaryakit_adi_textbox.Text = Bilgi_Tablosu2.Rows[e.RowIndex].Cells[1].Value.ToString();
                litre_fiyati_textbox.Text = Bilgi_Tablosu2.Rows[e.RowIndex].Cells[2].Value.ToString();
                depo_textbox.Text = Bilgi_Tablosu2.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void akaryakit_adi_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void litre_fiyati_textbox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void depo_textbox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void akaryakit_ara_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
    }
}
