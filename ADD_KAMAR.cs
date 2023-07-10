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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalProject_KlinikBersalin
{
    public partial class ADD_KAMAR : Form
    {
        private string stringConnection = " data source = LAPTOP-DP3PQGGM\\DEPIIII;" +
      "database=KlinikBersalin;User ID=sa;Password=123";
        private SqlConnection koneksi;
        private SqlCommand comn;
        private SqlDataAdapter adapter;
        public ADD_KAMAR()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            LoadPasienData();

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
            string idpasien = comboBox1.SelectedValue.ToString();

            if (nmKamar == "")
            {
                MessageBox.Show("Masukan Nama Kamar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                string insertQuery = "INSERT INTO dbo.Kamar (Nama_Kamar, Id_Kamar, Harga_Kamar, Jenis_Kamar, Id_Pasien) VALUES (@Nama_Kamar, @Id_Kamar, @Harga_Kamar, @Jenis_Kamar, @Id_Pasien)";
                SqlCommand cmd = new SqlCommand(insertQuery, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@Nama_Kamar", nmKamar));
                cmd.Parameters.Add(new SqlParameter("@Id_Kamar", newId));
                cmd.Parameters.Add(new SqlParameter("@Jenis_Kamar", JenisKamar));
                cmd.Parameters.Add(new SqlParameter("@Harga_Kamar", HargaKamar));
                cmd.Parameters.Add(new SqlParameter("Id_Pasien", idpasien));
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
        private void LoadPasienData()
        {
            try
            {
                koneksi.Open();

                string query = "SELECT Id_Pasien, Nama_Pasien FROM Pasien";
                comn = new SqlCommand(query, koneksi);
                DataTable pasien = new DataTable();

                adapter = new SqlDataAdapter(comn);
                adapter.Fill(pasien);

                comboBox1.DisplayMember = "Nama_Pasien";
                comboBox1.ValueMember = "Id_Pasien";

                comboBox1.DataSource = pasien;
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                koneksi.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string stringConnection = " data source = LAPTOP-DP3PQGGM\\DEPIIII;" +
             "database=KlinikBersalin;User ID=sa;Password=123";
            string query = "DELETE FROM Kamar WHERE Id_Kamar = @Id_Kamar";
            using (SqlConnection koneksi = new SqlConnection(stringConnection))
            {
                using (SqlCommand cmd = new SqlCommand(query, koneksi))
                {
                    cmd.Parameters.AddWithValue("@Id_Kamar", txbxIDKamar.Text);

                    try
                    {
                        koneksi.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show("Data successfully deleted.");
                        dataGridView();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message + " (Error Code: " + ex.Number + ")");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
