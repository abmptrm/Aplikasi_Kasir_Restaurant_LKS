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
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
        }

        void showDataMenu()
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

        void showDataPelanggan()
        {
            Sqlserver con = new Sqlserver();
            SqlConnection conn = con.getCon();

            try
            {
                conn.Open();
                string cmdSelect = "SELECT * FROM tb_pelanggan";
                SqlCommand cmd = new SqlCommand(cmdSelect, conn);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "tb_pelanggan");

                tbl_pelanggan.DataSource = ds;
                tbl_pelanggan.DataMember = "tb_pelanggan";
                tbl_pelanggan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        void showDataPesanan()
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

                tbl_pesanan.DataSource = ds;
                tbl_pesanan.DataMember = "tb_pesanan";
                tbl_pesanan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        void showDataTransaksi()
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Data Menu Makanan")
            {
                dataGridView1.Hide();
                tbl_menu.Show();
            } else if (comboBox1.SelectedItem == "Data Pelanggan")
            {
                dataGridView1.Hide();
                tbl_pelanggan.Show();
            } else if (comboBox1.SelectedItem == "Data Pesanan")
            {
                dataGridView1.Hide();
                tbl_pesanan.Show();
            } else if (comboBox1.SelectedItem == "Data Transaksi")
            {
                dataGridView1.Hide();
                tbl_transaksi.Show();
            } 
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            showDataMenu();
            showDataPelanggan();
            showDataPesanan();
            showDataTransaksi();
            tbl_menu.Hide();
            tbl_pelanggan.Hide();
            tbl_pesanan.Hide();
            tbl_transaksi.Hide();
            dateTimePicker1.Value = DateTime.UtcNow;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            for (int i = 1; i < tbl_pelanggan.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = tbl_pelanggan.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < tbl_pelanggan.Rows.Count - 1; i++)
            {
                for (int j = 0; j < tbl_pelanggan.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = tbl_pelanggan.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  
            workbook.SaveAs("c:\\output.xls");
            // Exit from the application  
            app.Quit();
        }
    }
}
