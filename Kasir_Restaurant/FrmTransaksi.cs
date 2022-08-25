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
using System.Globalization;

namespace Kasir_Restaurant
{
    public partial class FrmTransaksi : Form
    {
        public FrmTransaksi()
        {
            InitializeComponent();
        }

        void showData()
        {
            Sqlserver con = new Sqlserver();
            SqlConnection conn = con.getCon();

            try
            {
                conn.Open();
                string cmdSelect = "SELECT * FROM tb_transaksi";
                SqlCommand cmd = new SqlCommand(cmdSelect, conn);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "tb_transaksi");

                tbl_transaksi.DataSource = ds;
                tbl_transaksi.DataMember = "tb_transaksi";
                tbl_transaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
                string cmdSelect = "SELECT * FROM tb_pesanan WHERE id_transaksi like '%" + tbox_cari.Text + "%' OR id_pesanan like '%" + tbox_cari.Text + "%' OR jumlah_harga like '%" + tbox_cari.Text + "%' OR nama_pelanggan like '%" + tbox_cari.Text + "%' OR bayar like '%" + tbox_cari.Text + "%' OR kembalian like '%" + tbox_cari.Text + "%' ";
                SqlCommand cmd = new SqlCommand(cmdSelect, conn);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "tb_pesanan");

                tbl_transaksi.DataSource = ds;
                tbl_transaksi.DataMember = "tb_pesanan";
                tbl_transaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        void showIdPesanan()
        {
            Sqlserver con = new Sqlserver();
            SqlConnection conn = con.getCon();

            try
            {
                conn.Open();
                string cmdSelect = "SELECT id_pesanan FROM tb_pesanan";
                SqlCommand cmd = new SqlCommand(cmdSelect, conn);

                SqlDataReader rd;
                rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    cbox_idpesanan.Items.Add(rd["id_pesanan"]);
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

        void clearData()
        {
            btn_hitung.Hide();
            tbox_idtransaksi.Text = "";
            cbox_idpesanan.Text = tbox_idtransaksi.Text;
            tbox_namapelanggan.Text = "";
            tbox_jh.Text = "";
            tbox_kembalian.Text = "";
            tbox_bayar.Text = "";
            label3.Text = "";
            label8.Text = "";
        }

        private void FrmTransaksi_Load(object sender, EventArgs e)
        {
            showIdPesanan();
            showData();
            btn_hitung.Hide();
            tbox_kembalian.Enabled = false;
            tbox_jh.Enabled = false;
            tbox_namapelanggan.Enabled = false;

        }

        private int hitungBayar(int a, int b)
        {
            int total = a - b;
            return total;
        }

        private void cbox_jk_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sqlserver con = new Sqlserver();
            SqlConnection conn = con.getCon();

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tb_pesanan WHERE id_pesanan='" + cbox_idpesanan.SelectedItem.ToString() + "'", conn);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    tbox_namapelanggan.Text = dr["nama_pelanggan"].ToString();
                    
                    tbox_jh.Text = dr["jumlah_harga"].ToString();
                    //tbox_bayar.Text = dr["bayar"].ToString();
                    //tbox_kembalian.Text = dr["kembalian"].ToString();



                    int total = int.Parse(tbox_jh.Text);

                    label8.Text = total.ToString("C", CultureInfo.CreateSpecificCulture("id-ID"));





                   


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

        private int hitungKembalian(int a, int b)
        {
            int total = a - b;
            return total;
        }

        private void btn_hitung_Click(object sender, EventArgs e)
        {
            int total = hitungKembalian(int.Parse(tbox_bayar.Text), int.Parse(tbox_jh.Text));
            tbox_kembalian.Text = total.ToString();
            label3.Text = total.ToString("C", CultureInfo.CreateSpecificCulture("id-ID"));
        }

        private void tbox_cari_TextChanged(object sender, EventArgs e)
        {
            cariData();
        }

        private void tbl_transaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbox_idtransaksi.Enabled = false;
            DataGridViewRow row = this.tbl_transaksi.Rows[e.RowIndex];
            tbox_idtransaksi.Text = row.Cells["id_transaksi"].Value.ToString();
            cbox_idpesanan.Text = row.Cells["id_pesanan"].Value.ToString();
            tbox_namapelanggan.Text = row.Cells["nama_pelanggan"].Value.ToString();
            tbox_jh.Text = row.Cells["jumlah_harga"].Value.ToString();
            tbox_bayar.Text = row.Cells["bayar"].Value.ToString();
            tbox_kembalian.Text = row.Cells["kembalian"].Value.ToString();

        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            Sqlserver con = new Sqlserver();
            SqlConnection conn = con.getCon();

            if (tbox_idtransaksi.Text.Trim() == "" || cbox_idpesanan.Text.Trim() == "" || tbox_bayar.Text.Trim() == "")
            {
                MessageBox.Show("Isi Semua Data !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    conn.Open();
                    string cmdSelect = "INSERT INTO tb_transaksi VALUES ('" + tbox_idtransaksi.Text + "','" + cbox_idpesanan.Text + "', '" + tbox_namapelanggan.Text + "', '" + tbox_jh.Text + "', '" + tbox_bayar.Text + "', '" + tbox_kembalian.Text + "')";
                    SqlCommand cmd = new SqlCommand(cmdSelect, conn);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Di Simpan", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showData();
                    clearData();
                    tbox_idtransaksi.Focus();

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

        private void tbox_bayar_TextChanged(object sender, EventArgs e)
        {
            if (tbox_bayar.Text == tbox_bayar.Text)
            {
                btn_hitung.Show();

            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            Sqlserver con = new Sqlserver();
            SqlConnection conn = con.getCon();


            if (tbox_idtransaksi.Text.Trim() == "" || cbox_idpesanan.Text.Trim() == "" || tbox_bayar.Text.Trim() == "")
            {
                MessageBox.Show("Isi Semua Data !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult result = MessageBox.Show("Apa kamu yakin ingin menghapus Data Ini ?", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();
                        string cmdSelect = "DELETE FROM tb_transaksi WHERE id_transaksi='" + tbox_idtransaksi.Text + "'";
                        SqlCommand cmd = new SqlCommand(cmdSelect, conn);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Berhasil Dihapus", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showData();
                        clearData();
                        tbox_idtransaksi.Focus();

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
    }
}
