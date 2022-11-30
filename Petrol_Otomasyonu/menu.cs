using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petrol_Otomasyonu
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void akaryakit_depo_btn_Click(object sender, EventArgs e)
        {
            akaryakit akar = new akaryakit();
            akar.Show();
        }

        private void akaryakit_satis_btn_Click(object sender, EventArgs e)
        {
            satis sat = new satis();
            sat.Show();
        }

        private void musteri_islemleri_btn_Click(object sender, EventArgs e)
        {
            musteri must = new musteri();
            must.Show();
        }

        private void personel_islemleri_btn_Click(object sender, EventArgs e)
        {
            personel perso = new personel();
            perso.Show();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
