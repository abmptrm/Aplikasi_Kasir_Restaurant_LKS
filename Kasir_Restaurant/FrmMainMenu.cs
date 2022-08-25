using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kasir_Restaurant
{
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            InitializeComponent();
        }


        string levelUser;
        public FrmMainMenu(string s)
        {
            InitializeComponent();
            levelUser = s;
        }


        void loadForm(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);

            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();

        }

        void aksesUser(string levelUser)
        {
            if (levelUser == "kasir")
            {
                btn_menu.Enabled = false;
                btn_pelanggan.Enabled = false;
                btn_pesan.Enabled = false;
                label6.Text = "Halo, Kasir";
            }
            else if (levelUser == "admin")
            {
                btn_pesan.Enabled = false;
                btn_transaksi.Enabled = false;
                btn_laporan.Enabled = false;
                label6.Text = "Halo, Admin";
            }
            else if (levelUser == "waiter")
            {
                btn_pelanggan.Enabled = false;
                btn_transaksi.Enabled = false;
                label6.Text = "Halo, Waiter";
            }
            else if (levelUser == "owner")
            {
                btn_pelanggan.Enabled = false;
                btn_transaksi.Enabled = false;
                btn_pesan.Enabled = false;
                btn_menu.Enabled = false;
                label6.Text = "Halo, Owner";

            }
        }


        private void FrmMainMenu_Load(object sender, EventArgs e)
        {
            aksesUser(levelUser);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Kamu Yakin ? ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label6.Hide();
            label4.Hide();
            label5.Hide();
            pictureBox2.Hide();
            label3.Text = "Entri Pelanggan | Aplikasi Kasir Restauran";
            loadForm(new FrmEntriPelanggan());
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label6.Hide();
            label4.Hide();
            label5.Hide();
            pictureBox2.Hide();
            label3.Text = "Entri Menu | Aplikasi Kasir Restauran";
            loadForm(new FrmEntriMenu());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Hide();
            label4.Hide();
            label5.Hide();
            pictureBox2.Hide();
            label3.Text = "Pesan Makanan | Aplikasi Kasir Restauran";
            loadForm(new FrmEntriPesanMakanan());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label6.Hide();
            label4.Hide();
            label5.Hide();
            pictureBox2.Hide();
            label3.Text = "Transaksi | Aplikasi Kasir Restauran";
            loadForm(new FrmTransaksi());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Kamu Yakin ?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                FrmLogin login = new FrmLogin();
                this.Hide();
                login.Show();
            }
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            label6.Hide();
            label4.Hide();
            label5.Hide();
            pictureBox2.Hide();
            label3.Text = "Laporan | Aplikasi Kasir Restauran";
            loadForm(new FrmReport());
        }
    }
}
