using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
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
        private SqlCommand comn;
        private SqlDataAdapter adapter;
        public Obat()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            LoadDokterData();
            LoadPasienData();
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
            string iddokter = comboBox1.SelectedValue.ToString();
            string idpasien = comboBox2.SelectedValue.ToString();

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
                string insertQuery = "INSERT INTO dbo.Obat (Nama_Obat, Id_Obat, Harga_Obat, Jenis_Obat, Id_Pasien, Id_Dokter) VALUES (@Nama_Obat, @Id_Obat, @Harga_Obat, @Jenis_Obat, @Id_Pasien, @Id_Dokter)";
                SqlCommand cmd = new SqlCommand(insertQuery, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@Nama_Obat", nmObat));
                cmd.Parameters.Add(new SqlParameter("@Id_Obat", newId));
                cmd.Parameters.Add(new SqlParameter("@Harga_Obat", HargaObat));
                cmd.Parameters.Add(new SqlParameter("@Jenis_Obat", JnsObat));
                cmd.Parameters.Add(new SqlParameter("@Id_Dokter", iddokter));
                cmd.Parameters.Add(new SqlParameter("@Id_Pasien", idpasien));

                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                Refreshform();
            }
        }

        private void btnObat_Click(object sender, EventArgs e)
        {
            btnSimpan.Enabled = true;
            btnObat.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Add_Shift().Show();
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

        private void button5_Click(object sender, EventArgs e)
        {
            new ADD_REKAM_MEDIS().Show();
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

                comboBox1.DisplayMember = "Nama_Dokter";
                comboBox1.ValueMember = "Id_Dokter";

                comboBox1.DataSource = dokter;


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

                comboBox2.DisplayMember = "Nama_Pasien";
                comboBox2.ValueMember = "Id_Pasien";

                comboBox2.DataSource = pasien;


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
            string query = "DELETE FROM Obat WHERE Id_Obat = @Id_Obat";
            using (SqlConnection koneksi = new SqlConnection(stringConnection))
            {
                using (SqlCommand cmd = new SqlCommand(query, koneksi))
                {
                    cmd.Parameters.AddWithValue("@Id_Obat", txbxobat.Text);

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            Refreshform();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string nmObat = tbxNamaObat.Text;
            string JnsObat = tbxJenisObat.Text;
            string HargaObat = tbxHargaObat.Text;
            string idObat = txbxobat.Text;
            string iddokter = comboBox1.SelectedValue.ToString();
            string idpasien = comboBox2.SelectedValue.ToString();

            string updateQuery = "UPDATE Obat SET Nama_Obat = @Nama_Obat, Jenis_Obat = @Jenis_Obat, Id_Dokter = @Id_Dokter, Id_Pasien = @Id_Pasien, Harga_Obat = @Harga_Obat WHERE Id_Obat = @Id_Obat";
            SqlCommand cmd = new SqlCommand(updateQuery, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Nama_Obat", nmObat);
            cmd.Parameters.Add(new SqlParameter("@Jenis_Obat", tbxJenisObat.Text));
            cmd.Parameters.Add(new SqlParameter("@Id_Obat", txbxobat.Text));
            cmd.Parameters.Add(new SqlParameter("@Id_Dokter", comboBox1.SelectedValue.ToString()));
            cmd.Parameters.Add(new SqlParameter("@Id_Pasien", comboBox2.SelectedValue.ToString()));
            cmd.Parameters.Add(new SqlParameter("@Harga_Obat", tbxHargaObat.Text));

            koneksi.Open();
            cmd.ExecuteNonQuery();
            koneksi.Close();
            MessageBox.Show("Data Petugas updated successfully.");
            dataGridView();
            Refreshform();


        }

        }
    }

