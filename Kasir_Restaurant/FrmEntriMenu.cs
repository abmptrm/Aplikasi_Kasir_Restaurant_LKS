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
    public partial class FrmEntriMenu : Form
    {
        public FrmEntriMenu()
        {
            InitializeComponent();
        }

        void clearData()
        {
            tbox_idmenu.Enabled = true;
            tbox_idmenu.Text = "";
            tbox_namamenu.Text = "";
            tbox_hargamenu.Text = "";
        }

        void showData()
        {
            Sqlserver con = new Sqlserver();
            SqlConnection conn = con.getCon();

            try
            {
                conn.Open();
                string cmdSelect = "SELECT * FROM tb_menu";
                SqlCommand cmd = new SqlCommand(cmdSelect, conn);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "tb_menu");

                tbl_menu.DataSource = ds;
                tbl_menu.DataMember = "tb_menu";
                tbl_menu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        void cariData()
        {
            Sqlserver con = new Sqlserver();
            SqlConnection conn = con.getCon();

            try
            {
                conn.Open();
                string cmdSelect = "SELECT * FROM tb_menu WHERE id_menu like '%"+ tbox_cari.Text+"%' OR nama_menu like '%"+ tbox_cari.Text+ "%' OR harga_menu like '%"+ tbox_cari.Text+ "%' ";
                SqlCommand cmd = new SqlCommand(cmdSelect, conn);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "tb_menu");

                tbl_menu.DataSource = ds;
                tbl_menu.DataMember = "tb_menu";
                tbl_menu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private void FrmEntriMenu_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void tbl_menu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbox_idmenu.Enabled = false;
            DataGridViewRow row = this.tbl_menu.Rows[e.RowIndex];
            tbox_idmenu.Text = row.Cells["id_menu"].Value.ToString();
            tbox_namamenu.Text = row.Cells["nama_menu"].Value.ToString();
            tbox_hargamenu.Text = row.Cells["harga_menu"].Value.ToString();
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            Sqlserver con = new Sqlserver();
            SqlConnection conn = con.getCon();

            if(tbox_idmenu.Text.Trim() == "" || tbox_namamenu.Text.Trim() == "" || tbox_hargamenu.Text.Trim() == "")
            {
                MessageBox.Show("Isi Semua Data !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            } else
            {
                try
                {
                    conn.Open();
                    string cmdSelect = "INSERT INTO tb_menu VALUES ('" + tbox_idmenu.Text + "','" + tbox_namamenu.Text + "','" + tbox_hargamenu.Text + "')";
                    SqlCommand cmd = new SqlCommand(cmdSelect, conn);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Disimpan", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showData();
                    clearData();
                    tbox_idmenu.Focus();

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
            

            

           
        }

        

        private void btn_ubah_Click(object sender, EventArgs e)
        {
            Sqlserver con = new Sqlserver();
            SqlConnection conn = con.getCon();


            if (tbox_idmenu.Text.Trim() == "" || tbox_namamenu.Text.Trim() == "" || tbox_hargamenu.Text.Trim() == "")
            {
                MessageBox.Show("Isi Semua Data !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            } else
            {
                try
                {
                    conn.Open();
                    string cmdSelect = "UPDATE tb_menu SET id_menu='" + tbox_idmenu.Text + "', nama_menu='" + tbox_namamenu.Text + "', harga_menu='" + tbox_hargamenu.Text + "' WHERE id_menu='" + tbox_idmenu.Text + "'";
                    SqlCommand cmd = new SqlCommand(cmdSelect, conn);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Diubah", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showData();
                    clearData();
                    tbox_idmenu.Focus();

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
           
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            Sqlserver con = new Sqlserver();
            SqlConnection conn = con.getCon();

            if (tbox_idmenu.Text.Trim() == "" || tbox_namamenu.Text.Trim() == "" || tbox_hargamenu.Text.Trim() == "")
            {
                MessageBox.Show("Isi Semua Data !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            } else
            {
                try
                {
                    conn.Open();
                    string cmdSelect = "DELETE tb_menu WHERE id_menu='" + tbox_idmenu.Text + "'";
                    SqlCommand cmd = new SqlCommand(cmdSelect, conn);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Dihapus", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showData();
                    clearData();
                    tbox_idmenu.Focus();

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

            
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            clearData();
            tbox_idmenu.Focus();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbox_cari_TextChanged(object sender, EventArgs e)
        {
            cariData();
        }
    }
}
