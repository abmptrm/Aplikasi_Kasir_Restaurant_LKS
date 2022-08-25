using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kasir_Restaurant
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            tbox_password.UseSystemPasswordChar = true;
        }

        void showIdUser()
        {
            Sqlserver con = new Sqlserver();
            SqlConnection conn = con.getCon();

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT level_user FROM tb_user", conn);

                SqlDataReader rd;
                rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    comboBox1.Items.Add(rd["level_user"]);
                }

            }
            catch (Exception g)
            {
                MessageBox.Show(g.ToString(), "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

        }



        private void FrmLogin_Load(object sender, EventArgs e)
        {
            showIdUser();
        }

        
        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                tbox_password.UseSystemPasswordChar = false;
            } else
            {
                tbox_password.UseSystemPasswordChar = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Kamu Yakin ? ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_login_Click_1(object sender, EventArgs e)
        {
            Sqlserver con = new Sqlserver();
            SqlConnection conn = con.getCon();

            try
            {
                conn.Open();
                string cmdSelect = "SELECT * FROM tb_user WHERE level_user='" + tbox_username.Text + "' AND pass_user='" + tbox_password.Text + "'";
                SqlCommand cmd = new SqlCommand(cmdSelect, conn);
                SqlDataReader rd;

                rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    FrmMainMenu menu = new FrmMainMenu(comboBox1.SelectedItem.ToString());
                    MessageBox.Show("Login Sukses", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    menu.Show();
                    conn.Close();
                }
            }
            catch (Exception g)
            {
                MessageBox.Show(g.ToString(), "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
