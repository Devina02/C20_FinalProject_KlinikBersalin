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
    public partial class ADD_KAMAR : Form
    {
        private string stringConnection = " data source = LAPTOP-DP3PQGGM\\DEPIIII;" +
      "database=KlinikBersalin;User ID=sa;Password=123";
        private SqlConnection koneksi;
        public ADD_KAMAR()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
        }

        private void ADD_KAMAR_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'klinikBersalinDataSet.Kamar' table. You can move, or remove it, as needed.
            this.kamarTableAdapter.Fill(this.klinikBersalinDataSet.Kamar);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            Refreshform();
        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            string nmKamar = tbxnmkamar.Text;
            string IdKamar = tbxidkamar.Text;
            string JenisKamar = tbxjeniskmr.Text;
            string HargaKamar = tbxhargakamar.Text;

            if (nmKamar == "")
            {
                MessageBox.Show("Masukan nama Pasien", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string getIdQuery = "SELECT MAX(Id_Kamar) FROM dbo.Kamar";
                SqlCommand getIdCmd = new SqlCommand(getIdQuery, koneksi);
                object result = getIdCmd.ExecuteScalar();
                string newId = "K001";

                if (result != null && result != DBNull.Value)
                {
                    string lastId = Convert.ToString(result);
                    int lastNumber = int.Parse(lastId.Substring(1));
                    newId = "K" + (lastNumber + 1).ToString("D3");
                }
                string insertQuery = "INSERT INTO dbo.Kamar (Nama_Kamar, Id_Kamar, Harga_Kamar, Jenis_Kamar) VALUES (@Nama_Kamar, @Id_Kamar, @Harga_Kamar, @Jenis_Kamar)";
                SqlCommand cmd = new SqlCommand(insertQuery, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@Nama_Kamar", nmKamar));
                cmd.Parameters.Add(new SqlParameter("@Id_Kamar", newId));
                cmd.Parameters.Add(new SqlParameter("@Jenis_Kamar", JenisKamar));
                cmd.Parameters.Add(new SqlParameter("@Harga_Kamar", HargaKamar));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                Refreshform();
            }
        }

        private void tbxidkamar_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView ()
        {
            koneksi.Open();
            string str = "select * from dbo.Kamar";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }
        private void Refreshform()
        {

            tbxnmkamar.Text = "";
            tbxidkamar.Text = "";
            tbxhargakamar.Text = "";
            tbxjeniskmr.Text = "";

            btnsimpan.Enabled = false;
            btnclear.Enabled = false;

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            btnsimpan.Enabled = true;
            btnadd.Enabled = true;
        }
    }
}
