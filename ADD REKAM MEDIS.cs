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
    public partial class ADD_REKAM_MEDIS : Form
    {
        private string stringConnection = " data source = LAPTOP-DP3PQGGM\\DEPIIII;" +
     "database=KlinikBersalin;User ID=sa;Password=123";
        private SqlConnection koneksi;
        private SqlCommand comn;
        private SqlDataAdapter adapter;
        public ADD_REKAM_MEDIS()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            LoadDokterData();
            LoadObatData();
            LoadPasienData();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ADD_REKAM_MEDIS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'klinikBersalinDataSet.RekamMedis' table. You can move, or remove it, as needed.
            this.rekamMedisTableAdapter.Fill(this.klinikBersalinDataSet.RekamMedis);

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnsimpan.Enabled = true;
            btnadd.Enabled = true;
        }
        private void dataGridView()
        {
            koneksi.Open();
            string str = "select * from dbo.RekamMedis";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }
        private void Refreshform()
        {

            cmbxiddokter.Text = "";
            cmbxidpasien.Text = "";
            cmbxidobat.Text = "";
            tbxidrm.Text = "";
            tbxriwayat.Text = "";
            tbxjumlahobat.Text = "";
            dateTimePicker1.Text = "";
            tbxtindakan.Text = "";

            btnsimpan.Enabled = false;
            btnclear.Enabled = false;

        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            string IdDokter = cmbxiddokter.SelectedValue.ToString();
            string IdPasien = cmbxidpasien.SelectedValue.ToString();
            string IdObat = cmbxidobat.SelectedValue.ToString();
            string IdRekamMedis = tbxidrm.Text;
            string RiwayatPenyakit = tbxriwayat.Text;
            string Tindakan = tbxtindakan.Text;
            string JumlahObat = tbxjumlahobat.Text;
            DateTime TglResep = dateTimePicker1.Value;
            


            if (RiwayatPenyakit == "")
            {
                MessageBox.Show("Masukan Riwayat Penyakit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string getIdQuery = "SELECT MAX(Id_Rekam_Medis) FROM dbo.RekamMedis";
                SqlCommand getIdCmd = new SqlCommand(getIdQuery, koneksi);
                object result = getIdCmd.ExecuteScalar();
                string newId = "R001";

                if (result != null && result != DBNull.Value)
                {
                    string lastId = Convert.ToString(result);
                    int lastNumber = int.Parse(lastId.Substring(1));
                    newId = "R" + (lastNumber + 1).ToString("D3");
                }
                string insertQuery = "INSERT INTO dbo.RekamMedis (Id_Dokter, Id_Pasien, Id_Obat, Riwayat_Penyakit, Tindakan, Tgl_resep, Jumlah_Obat, Id_Rekam_Medis) VALUES (@Id_Dokter, @Id_Pasien, @Id_Obat, @Riwayat_Penyakit, @Tindakan, @Tgl_resep, @Jumlah_Obat, @Id_Rekam_Medis)";
                SqlCommand cmd = new SqlCommand(insertQuery, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@Id_Dokter", IdDokter));
                cmd.Parameters.Add(new SqlParameter("@Id_Rekam_Medis", newId));
                cmd.Parameters.Add(new SqlParameter("@Id_Pasien", IdPasien));
                cmd.Parameters.Add(new SqlParameter("@Id_Obat", IdObat));
                cmd.Parameters.Add(new SqlParameter("@Riwayat_Penyakit", RiwayatPenyakit));
                cmd.Parameters.Add(new SqlParameter("@Tindakan", Tindakan));
                cmd.Parameters.Add(new SqlParameter("@Tgl_resep", TglResep));
                cmd.Parameters.Add(new SqlParameter("@Jumlah_Obat", JumlahObat));

                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                Refreshform();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            Refreshform();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string stringConnection = " data source = LAPTOP-DP3PQGGM\\DEPIIII;" +
             "database=KlinikBersalin;User ID=sa;Password=123";
            string query = "DELETE FROM RekamMedis WHERE Id_Rekam_Medis = @Id_Rekam_Medis";
            using (SqlConnection koneksi = new SqlConnection(stringConnection))
            {
                using (SqlCommand cmd = new SqlCommand(query, koneksi))
                {
                    cmd.Parameters.AddWithValue("@Id_Rekam_Medis", txbxIDRM.Text);

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

        private void LoadDokterData()
        {
            try
            {
                koneksi.Open();

                string query = "SELECT Id_Dokter, Nama_Dokter FROM Dokter";
                comn = new SqlCommand(query, koneksi);
                DataTable dokter = new DataTable();

                adapter = new SqlDataAdapter(comn);
                adapter.Fill(dokter);

                cmbxiddokter.DisplayMember = "Nama_Dokter";
                cmbxiddokter.ValueMember = "Id_Dokter";

                cmbxiddokter.DataSource = dokter;


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

                cmbxidpasien.DisplayMember = "Nama_Pasien";
                cmbxidpasien.ValueMember = "Id_Pasien";

                cmbxidpasien.DataSource = pasien;


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
        private void LoadObatData()
        {
            try
            {
                koneksi.Open();

                string query = "SELECT Id_Obat, Nama_Obat FROM Obat";
                comn = new SqlCommand(query, koneksi);
                DataTable Obat = new DataTable();

                adapter = new SqlDataAdapter(comn);
                adapter.Fill(Obat);

                cmbxidobat.DisplayMember = "Nama_Obat";
                cmbxidobat.ValueMember = "Id_Obat";

                cmbxidobat.DataSource = Obat;


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

        private void txbxIDRM_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            new ADD_DATA().Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new ADD_DATA_DOKTER().Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new ADD_PETUGAS().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new ADD_KAMAR().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Obat().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new ADD_REKAM_MEDIS().Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            new Add_Shift().Show();
        }
    }
}
