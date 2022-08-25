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
    public partial class FrmEntriPesanMakanan : Form
    {
        public FrmEntriPesanMakanan()
        {
            InitializeComponent();
            
        }

        void showIdMenu()
        {
            Sqlserver con = new Sqlserver();
            SqlConnection conn = con.getCon();

            try
            {
                conn.Open();
                string cmdSelect = "SELECT id_menu FROM tb_menu";
                SqlCommand cmd = new SqlCommand(cmdSelect, conn);

                SqlDataReader rd;
                rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    cbox_idmenu.Items.Add(rd["id_menu"]);
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

        void showIdPelanggan()
        {
            Sqlserver con = new Sqlserver();
            SqlConnection conn = con.getCon();

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT id_pelanggan FROM tb_pelanggan", conn);

                SqlDataReader rd;
                rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    cbox_idpelanggan.Items.Add(rd["id_pelanggan"]);
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

        void showIdUser()
        {
            Sqlserver con = new Sqlserver();
            SqlConnection conn = con.getCon();

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT id_user FROM tb_user", conn);

                SqlDataReader rd;
                rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    cbox_iduser.Items.Add(rd["id_user"]);
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

        void showData()
        {
            Sqlserver con = new Sqlserver();
            SqlConnection conn = con.getCon();

            try
            {
                conn.Open();
                string cmdSelect = "SELECT * FROM tb_pesanan";
                SqlCommand cmd = new SqlCommand(cmdSelect, conn);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "tb_pesanan");

                tbl_pesan.DataSource = ds;
                tbl_pesan.DataMember = "tb_pesanan";
                tbl_pesan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
                string cmdSelect = "SELECT * FROM tb_pesanan WHERE id_pesanan like '%"+tbox_cari.Text+ "%' OR id_menu like '%" + tbox_cari.Text + "%' OR id_pelanggan like '%" + tbox_cari.Text + "%' OR nama_pelanggan like '%" + tbox_cari.Text + "%' OR jumlah_pesan like '%" + tbox_cari.Text + "%' OR jumlah_harga like '%" + tbox_cari.Text + "%' OR id_user like '%" + tbox_cari.Text + "%' OR nama_user like '%" + tbox_cari.Text + "%'";
                SqlCommand cmd = new SqlCommand(cmdSelect, conn);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "tb_pesanan");

                tbl_pesan.DataSource = ds;
                tbl_pesan.DataMember = "tb_pesanan";
                tbl_pesan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        //private int jumlahPesanan(int a)
        //{

        //}

        void clearData()
        {
            tbox_idpesanan.Enabled = true;
            tbox_idpesanan.Text = "";
            cbox_idmenu.SelectedIndex = -1;
            cbox_idpelanggan.Text = tbox_namapelanggan.Text = "";
            tbox_namapelanggan.Text = "";
            tbox_hargamenu.Text = "";
            tbox_jp.Text = "";
            tbox_jh.Text = "";
            cbox_iduser.Text = tbox_namauser.Text = "";
            tbox_namamenu.Text = "";
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            btn_tambah.Hide();
            btn_hapusitem.Hide();
            btn_hitung.Hide();
            tbox_jp.Text = "1";

        }

        private void FrmEntriPesanMakanan_Load(object sender, EventArgs e)
        {
            //showNamaMenu();
            showIdMenu();
            showData();
            showIdPelanggan();
            showIdUser();
            btn_tambah.Hide();
            btn_hapusitem.Hide();
            tbox_hargamenu.Enabled = false;
            tbox_namamenu.Enabled = false;
            tbox_namapelanggan.Enabled = false;
            tbox_jh.Enabled = false;
            tbox_namauser.Enabled = false;
            btn_hitung.Hide();
            tbox_jp.Text = "1";
        }
        private void btn_simpan_Click(object sender, EventArgs e)
        {
            Sqlserver con = new Sqlserver();
            SqlConnection conn = con.getCon();

            if (tbox_idpesanan.Text.Trim() == "" || cbox_idmenu.Text.Trim() == "" || cbox_idpelanggan.Text.Trim() == "" || tbox_jp.Text.Trim() == "" || tbox_jh.Text.Trim() == "" || cbox_iduser.Text.Trim() == "")
            {
                MessageBox.Show("Isi Semua Data !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                try
                {
                    conn.Open();
                    string cmdSelect = "INSERT INTO tb_pesanan VALUES ('" + tbox_idpesanan.Text + "','" + cbox_idmenu.Text + "','" + cbox_idpelanggan.Text + "', '" + tbox_namapelanggan.Text + "', '" + tbox_jp.Text + "', '" + tbox_jh.Text + "', '" + cbox_iduser.Text + "', '" + tbox_namauser.Text + "')";
                    SqlCommand cmd = new SqlCommand(cmdSelect, conn);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Di Simpan", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showData();
                    clearData();
                    tbox_idpesanan.Focus();

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

            if (tbox_idpesanan.Text.Trim() == "" || cbox_idmenu.Text.Trim() == "" || cbox_idpelanggan.Text.Trim() == "" || tbox_jp.Text.Trim() == "" || tbox_jh.Text.Trim() == "" || cbox_iduser.Text.Trim() == "")
            {
                MessageBox.Show("Isi Semua Data !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                try
                {
                    conn.Open();
                    string cmdUpdate = "UPDATE tb_pesanan SET id_pesanan='" + tbox_idpesanan.Text + "', id_menu='" + cbox_idmenu.Text + "', id_pelanggan='" + cbox_idpelanggan.Text + "',  nama_pelanggan='" + tbox_namapelanggan.Text + "',  jumlah_pesan='" + tbox_jp.Text + "', jumlah_harga='" + tbox_jh.Text + "', id_user='" + cbox_iduser.Text + "',  nama_user='" + tbox_namauser.Text + "' WHERE id_pesanan='" + tbox_idpesanan.Text + "'";
                    SqlCommand cmd = new SqlCommand(cmdUpdate, conn);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Di Ubah !", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showData();
                    clearData();
                    tbox_idpesanan.Focus();

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

            if (tbox_idpesanan.Text.Trim() == "" || cbox_idmenu.Text.Trim() == "" || cbox_idpelanggan.Text.Trim() == "" || tbox_jp.Text.Trim() == "" || tbox_jh.Text.Trim() == "" || cbox_iduser.Text.Trim() == "")
            {
                MessageBox.Show("Isi Semua Data !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                DialogResult result = MessageBox.Show("Apakah Kamu Yakin Ingin Hapus Data Ini ?", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();
                        string cmdDelete = "DELETE tb_pesanan WHERE id_pesanan='" + tbox_idpesanan.Text + "'";
                        SqlCommand cmd = new SqlCommand(cmdDelete, conn);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Berhasil Di Hapus !", "Hapus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showData();
                        clearData();
                        tbox_idpesanan.Focus();
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




    }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

       

        

       

        private void btn_hitung_Click(object sender, EventArgs e)
        {
            if (listBox2 != null && listBox2.Items.Count == 0)
            {
                MessageBox.Show("Tambah Menu Terlebih Dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                int sum = 0;
                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    sum += int.Parse(listBox2.Items[i].ToString());
                }

                tbox_jh.Text = sum.ToString();
            }
            
        }

        

        private void cbox_idmenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sqlserver con = new Sqlserver();
            SqlConnection conn = con.getCon();

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tb_menu WHERE id_menu='" + cbox_idmenu.SelectedItem.ToString() + "'", conn);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    tbox_namamenu.Text = dr["nama_menu"].ToString();
                    tbox_hargamenu.Text = dr["harga_menu"].ToString();
                    //listBox1.Items.Add();
                    //tbox_namamenu.Text = X.ToString();
                    //listBox2.Items.Add();

                    //string menu = tambahMenu(dr["nama_menu"].ToString(), dr["harga_menu"].ToString());
                    //return menu;


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

        private void button1_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        //private void tambahMenu(string menu, string harga)
        //{
        //    listBox1.Items.Add(menu);
        //    listBox2.Items.Add(harga);

        //}
        private void button2_Click(object sender, EventArgs e)
        {
            int menu = 0;

            if (tbox_jp.Text == "1")
            {
                listBox1.Items.Add(tbox_namamenu.Text);
                listBox2.Items.Add(tbox_hargamenu.Text);
            } else
            {
                try
                {
                    while (menu < int.Parse(tbox_jp.Text))
                    {
                        listBox1.Items.Add(tbox_namamenu.Text);
                        listBox2.Items.Add(tbox_hargamenu.Text);
                        menu++;
                    }
                } catch (Exception G)
                {
                    MessageBox.Show(G.ToString(), "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

            

            //if (tbox_jp.Text = "")
            //{
            //    
            //}
            
        }

        private void cbox_idpelanggan_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sqlserver con = new Sqlserver();
            SqlConnection conn = con.getCon();

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tb_pelanggan WHERE id_pelanggan='" + cbox_idpelanggan.SelectedItem.ToString() + "'", conn);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    tbox_namapelanggan.Text = dr["nama_pelanggan"].ToString();
                    


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

        private void cbox_iduser_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sqlserver con = new Sqlserver();
            SqlConnection conn = con.getCon();

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tb_user WHERE id_user='" + cbox_iduser.SelectedItem.ToString() + "'", conn);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    tbox_namauser.Text = dr["nama_user"].ToString();



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

        private void tbox_cari_TextChanged(object sender, EventArgs e)
        {
            cariData();
            
            
        }

        private void tbox_namamenu_TextChanged(object sender, EventArgs e)
        {
            if (tbox_namamenu.Text == tbox_namamenu.Text)
            {
                btn_tambah.Show();
                btn_hapusitem.Show();
            } else
            {
                btn_tambah.Hide();
                btn_hapusitem.Hide();
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {

            clearData();
            tbox_idpesanan.Focus();

        }

        private void tbox_jp_TextChanged(object sender, EventArgs e)
        {
            if (tbox_jp.Text == tbox_jp.Text)
            {
                btn_hitung.Show();
                
            }
           
        }

        private void tbl_pesan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            DataGridViewRow row = this.tbl_pesan.Rows[e.RowIndex];
            tbox_idpesanan.Text = row.Cells["id_pesanan"].Value.ToString();
            cbox_idmenu.Text = row.Cells["id_menu"].Value.ToString();
            cbox_idpelanggan.Text = row.Cells["id_pelanggan"].Value.ToString();
            tbox_namapelanggan.Text = row.Cells["nama_pelanggan"].Value.ToString();
            tbox_jp.Text = row.Cells["jumlah_pesan"].Value.ToString();
            tbox_jh.Text = row.Cells["jumlah_harga"].Value.ToString();
            cbox_iduser.Text = row.Cells["id_user"].Value.ToString();
            tbox_namauser.Text = row.Cells["nama_user"].Value.ToString();
            tbox_idpesanan.Enabled = false;



        }

        private void tbox_jp_Leave(object sender, EventArgs e)
        {
            
        }
    }
}
