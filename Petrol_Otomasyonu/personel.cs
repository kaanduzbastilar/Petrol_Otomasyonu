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
    public partial class personel : Form
    {
        public personel()
        {
            InitializeComponent();
        }

        OleDbConnection baglan = new OleDbConnection("provider=microsoft.ace.oledb.12.0;data source=" + Application.StartupPath + "\\bilgiler.accdb");
        DataTable tablo = new DataTable();
        DataTable tablo1 = new DataTable();

        public void listele()
        {
            adi_soyadi_textbox.Text = "";
            mail_textbox.Text = "";
            maas_textbox.Text = "";
            dogum_tarihi_maskedTextBox.Text = "";
            pozisyon_comboBox.SelectedIndex = -1;
           
            tel_no_maskedTextBox.Text = "";
            tc_no_maskedTextBox.Text = "";
            tablo.Clear();
            baglan.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter
          ("select * from personel", baglan);
            adtr.Fill(tablo);
            Bilgi_Tablosu1.DataSource = tablo;
            Bilgi_Tablosu1.Columns[0].Visible = false;
            baglan.Close();

            Bilgi_Tablosu1.EnableHeadersVisualStyles = false;
            Bilgi_Tablosu1.ColumnHeadersDefaultCellStyle.ForeColor = Color.DarkRed;
            Bilgi_Tablosu1.Columns[1].HeaderText = "T.C. Kimlik Numarası";
            Bilgi_Tablosu1.Columns[2].HeaderText = "Ad Soyad";
            Bilgi_Tablosu1.Columns[3].HeaderText = "Doğum Tarihi";
            Bilgi_Tablosu1.Columns[4].HeaderText = "Telefon";
            Bilgi_Tablosu1.Columns[5].HeaderText = "Mail";
            Bilgi_Tablosu1.Columns[6].HeaderText = "Pozisyon";
            Bilgi_Tablosu1.Columns[7].HeaderText = "Maaş";
        }

        private void personel_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void ekle_pictureBox_Click(object sender, EventArgs e)
        {
            if (baglan.State == ConnectionState.Open)
            {

                baglan.Close();
            }

            if (this.tc_no_maskedTextBox.Text == "" || adi_soyadi_textbox.Text == "" || dogum_tarihi_maskedTextBox.Text == "  .  ." || tel_no_maskedTextBox.Text == "(   ) " || mail_textbox.Text == "" || pozisyon_comboBox.Text == "" || maas_textbox.Text == "")
            {
                MessageBox.Show("Bilgileri Eksik Girmeyiniz ! ", "Petrol Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                baglan.Open();

                OleDbCommand kmt;

                kmt = new OleDbCommand
                ("INSERT INTO personel(tc,adi_soyadi,dogum_tarihi,Telefon,email,pozisyon,maas) values('" + tc_no_maskedTextBox.Text + "','" + adi_soyadi_textbox.Text + "','" + dogum_tarihi_maskedTextBox.Text + "','" + tel_no_maskedTextBox.Text + "','" + mail_textbox.Text + "','" + pozisyon_comboBox.Text + "','" + maas_textbox.Text + "')", baglan);
                kmt.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Kayıt Başarılı.", "Petrol Otomasyonu");
                listele();
                tablo1.Clear();
            }
        }

        private void sil_pictureBox_Click(object sender, EventArgs e)
        {
            OleDbCommand kmt;
            baglan.Open();
            kmt = new OleDbCommand("Delete from personel where tc = '" + Bilgi_Tablosu1.CurrentRow.Cells[1].Value.ToString() + "'", baglan);
            kmt.ExecuteNonQuery();
            kmt.Dispose();
            baglan.Close();
            MessageBox.Show("İşleminiz başarılı.", "Petrol Otomasyonu");
            listele();
            tablo1.Clear();
        }

        private void guncelle_pictureBox_Click(object sender, EventArgs e)
        {
            if (tc_no_maskedTextBox.Text == "" || adi_soyadi_textbox.Text == "" || dogum_tarihi_maskedTextBox.Text == "  .  ." || tel_no_maskedTextBox.Text == "(   ) " || mail_textbox.Text == "" || pozisyon_comboBox.Text == "" || maas_textbox.Text == "")
            {
                MessageBox.Show("Bilgileri Eksik Girmeyiniz ! ", "Petrol Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                OleDbCommand kmt;
                baglan.Open();
                kmt = new OleDbCommand("UPDATE personel SET tc='" + tc_no_maskedTextBox.Text + "',adi_soyadi='" + adi_soyadi_textbox.Text + "',dogum_tarihi='" + dogum_tarihi_maskedTextBox.Text + "',Telefon='" + tel_no_maskedTextBox.Text + "',email='" + mail_textbox.Text + "',pozisyon='" + pozisyon_comboBox.Text + "',maas='" + maas_textbox.Text + "'where tc='" + Bilgi_Tablosu1.CurrentRow.Cells[1].Value.ToString() + "'", baglan);
                kmt.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("İşleminiz başarılı.", "Petrol Otomasyonu");
                listele();
                tablo1.Clear();
            }
        }
        private void tc_no_ara_btn_Click(object sender, EventArgs e)
        {
            tablo1.Clear();
            baglan.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter
          ("select * from personel where tc='" + tc_no_ara_textbox.Text + "'", baglan);
            adtr.Fill(tablo1);
            Bilgi_Tablosu2.DataSource = tablo1;
            Bilgi_Tablosu2.Columns[0].Visible = false;
            baglan.Close();
            tc_no_ara_textbox.Text = "";

            Bilgi_Tablosu2.EnableHeadersVisualStyles = false;
            Bilgi_Tablosu2.ColumnHeadersDefaultCellStyle.ForeColor = Color.DarkRed;
            Bilgi_Tablosu2.Columns[1].HeaderText = "T.C. Kimlik Numarası";
            Bilgi_Tablosu2.Columns[2].HeaderText = "Ad Soyad";
            Bilgi_Tablosu2.Columns[3].HeaderText = "Doğum Tarihi";
            Bilgi_Tablosu2.Columns[4].HeaderText = "Telefon";
            Bilgi_Tablosu2.Columns[5].HeaderText = "Mail";
            Bilgi_Tablosu2.Columns[6].HeaderText = "Pozisyon";
            Bilgi_Tablosu2.Columns[7].HeaderText = "Maaş";
        }

        private void anasayfa_pictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void anasayfa_label_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Bilgi_Tablosu1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                tc_no_maskedTextBox.Text = Bilgi_Tablosu1.Rows[e.RowIndex].Cells[1].Value.ToString();
                adi_soyadi_textbox.Text = Bilgi_Tablosu1.Rows[e.RowIndex].Cells[2].Value.ToString();
                dogum_tarihi_maskedTextBox.Text = Bilgi_Tablosu1.Rows[e.RowIndex].Cells[3].Value.ToString();
                tel_no_maskedTextBox.Text = Bilgi_Tablosu1.Rows[e.RowIndex].Cells[4].Value.ToString();
                mail_textbox.Text = Bilgi_Tablosu1.Rows[e.RowIndex].Cells[5].Value.ToString();
                pozisyon_comboBox.Text = Bilgi_Tablosu1.Rows[e.RowIndex].Cells[6].Value.ToString();
                maas_textbox.Text = Bilgi_Tablosu1.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
        }

        private void Bilgi_Tablosu2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                tc_no_maskedTextBox.Text = Bilgi_Tablosu2.Rows[e.RowIndex].Cells[1].Value.ToString();
                adi_soyadi_textbox.Text = Bilgi_Tablosu2.Rows[e.RowIndex].Cells[2].Value.ToString();
                dogum_tarihi_maskedTextBox.Text = Bilgi_Tablosu2.Rows[e.RowIndex].Cells[3].Value.ToString();
                tel_no_maskedTextBox.Text = Bilgi_Tablosu2.Rows[e.RowIndex].Cells[4].Value.ToString();
                mail_textbox.Text = Bilgi_Tablosu2.Rows[e.RowIndex].Cells[5].Value.ToString();
                pozisyon_comboBox.Text = Bilgi_Tablosu2.Rows[e.RowIndex].Cells[6].Value.ToString();
                maas_textbox.Text = Bilgi_Tablosu2.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
        }

        private void tc_no_ara_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void maas_textbox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void adi_soyadi_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void tc_no_maskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dogum_tarihi_maskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void tel_no_maskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void mail_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }
    }
}
