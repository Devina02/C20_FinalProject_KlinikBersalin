using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_KlinikBersalin
{
    public partial class Obat : Form
    {
        private string stringConnection = " data source = LAPTOP-DP3PQGGM\\DEPIIII;" +
      "database=KlinikBersalin;User ID=sa;Password=123";
        private SqlConnection koneksi;
        public Obat()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Obat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'klinikBersalinDataSet.Obat' table. You can move, or remove it, as needed.
            this.obatTableAdapter.Fill(this.klinikBersalinDataSet.Obat);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView()
        {
            koneksi.Open();
            string str = "select * from dbo.Obat";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }
        private void Refreshform()
        {

            tbxNamaObat.Text = "";
            tbxJenisObat.Text = "";
            tbxHargaObat.Text = "";

            btnSimpan.Enabled = false;
            btnClear.Enabled = false;

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string nmObat = tbxNamaObat.Text;
            string JnsObat = tbxJenisObat.Text;
            string HargaObat = tbxHargaObat.Text;

            if (nmObat == "")
            {
                MessageBox.Show("Masukan nama Obat", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string getIdQuery = "SELECT MAX(Id_Obat) FROM dbo.Obat";
                SqlCommand getIdCmd = new SqlCommand(getIdQuery, koneksi);
                object result = getIdCmd.ExecuteScalar();
                string newId = "B001";

                if (result != null && result != DBNull.Value)
                {
                    string lastId = Convert.ToString(result);
                    int lastNumber = int.Parse(lastId.Substring(1));
                    newId = "B" + (lastNumber + 1).ToString("D3");
                }
                string insertQuery = "INSERT INTO dbo.Kamar (Nama_Obat, Id_Obat, Harga_Obat, Jenis_Obat) VALUES (@Nama_Obat, @Id_Obat, @Harga_Obat, @Jenis_Obat)";
                SqlCommand cmd = new SqlCommand(insertQuery, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@Nama_Obat", nmObat));
                cmd.Parameters.Add(new SqlParameter("@Id_Obat", newId));
                cmd.Parameters.Add(new SqlParameter("@Jenis_Obat", JnsObat));
                cmd.Parameters.Add(new SqlParameter("@Harga_Obat", HargaObat));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                Refreshform();
            }
        }
    }
}
