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
    public partial class Add_Shift : Form
    {
        private string stringConnection = " data source = LAPTOP-DP3PQGGM\\DEPIIII;" +
      "database=KlinikBersalin;User ID=sa;Password=123";
        private SqlConnection koneksi;
        private SqlCommand comn;
        private SqlDataAdapter adapter;
        public Add_Shift()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            LoadPetugasData();
            LoadKamarData();
        }

        private void Add_Shift_Load(object sender, EventArgs e)
        {

            dataGridView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnSimpan.Enabled = true;
            btnAdd.Enabled = true;
        }
        private void Refreshform()
        {

            tbxjamtugas.Text = "";
            txbxIdShift.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";

            btnSimpan.Enabled = false;
            btnClear.Enabled = false;

        }
        private void dataGridView()
        {
            koneksi.Open();
            string str = "select * from dbo.Shiftt";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string jamtugas = tbxjamtugas.Text;
            string IdKamar = comboBox2.SelectedValue.ToString();
            string IdPetugas = comboBox1.SelectedValue.ToString();
           

            if (IdPetugas == "")
            {
                MessageBox.Show("Pilih Id Petugas", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string getIdQuery = "SELECT MAX(Id_Shift) FROM dbo.Shiftt";
                SqlCommand getIdCmd = new SqlCommand(getIdQuery, koneksi);
                object result = getIdCmd.ExecuteScalar();
                string newId = "S001";

                if (result != null && result != DBNull.Value)
                {
                    string lastId = Convert.ToString(result);
                    int lastNumber = int.Parse(lastId.Substring(1));
                    newId = "S" + (lastNumber + 1).ToString("D3");
                }
                string insertQuery = "INSERT INTO dbo.Shiftt (Id_Kamar, Id_Petugas, Jam_Tugas, Id_Shift) VALUES (@Id_Kamar, @Id_Petugas, @Jam_Tugas, @Id_Shift)";
                SqlCommand cmd = new SqlCommand(insertQuery, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@Id_Kamar", IdKamar));
                cmd.Parameters.Add(new SqlParameter("@Id_Petugas", IdPetugas));
                cmd.Parameters.Add(new SqlParameter("@Jam_Tugas", jamtugas));
                cmd.Parameters.Add(new SqlParameter("@Id_Shift", newId));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                Refreshform();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadPetugasData()
        {
            try
            {
                koneksi.Open();

                string query = "SELECT Id_Petugas, Nama_Petugas FROM Petugas";
                comn = new SqlCommand(query, koneksi);
                DataTable petugas = new DataTable();

                adapter = new SqlDataAdapter(comn);
                adapter.Fill(petugas);

                comboBox1.DisplayMember = "Nama_Petugas";
                comboBox1.ValueMember = "Id_Petugas";

                comboBox1.DataSource = petugas;
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
        private void LoadKamarData()
        {
            try
            {
                koneksi.Open();

                string query = "SELECT Id_Kamar, Nama_Kamar FROM Kamar";
                comn = new SqlCommand(query, koneksi);
                DataTable Kamar = new DataTable();

                adapter = new SqlDataAdapter(comn);
                adapter.Fill(Kamar);

                comboBox2.DisplayMember = "Nama_Kamar";
                comboBox2.ValueMember = "Id_Kamar";

                comboBox2.DataSource = Kamar;
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
            string query = "DELETE FROM Shiftt WHERE Id_Shift = @Id_Shift";
            using (SqlConnection koneksi = new SqlConnection(stringConnection))
            {
                using (SqlCommand cmd = new SqlCommand(query, koneksi))
                {
                    cmd.Parameters.AddWithValue("@Id_Shift", txbxIdShift.Text);

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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string IdKamar = comboBox2.SelectedValue.ToString(); ;
            string IdPetugas = comboBox1.SelectedValue.ToString(); ;
            string JamTugas = tbxjamtugas.Text;
            string IdShift = txbxIdShift.Text;

            string updateQuery = "UPDATE dbo.Shiftt SET Jam_Tugas = @Jam_Tugas, Id_Kamar = @Id_Kamar, Id_Petugas = @Id_Petugas WHERE Id_Shift = @Id_Shift";
            SqlCommand cmd = new SqlCommand(updateQuery, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("@Jam_Tugas", tbxjamtugas.Text));
            cmd.Parameters.Add(new SqlParameter("@Id_Shift", txbxIdShift.Text));
            cmd.Parameters.Add(new SqlParameter("@Id_Kamar", comboBox2.SelectedValue.ToString()));
            cmd.Parameters.Add(new SqlParameter("@Id_Petugas", comboBox1.SelectedValue.ToString()));


            koneksi.Open();
            cmd.ExecuteNonQuery();
            koneksi.Close();
            MessageBox.Show("Data Shift updated successfully.");
            dataGridView();
            Refreshform();
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
    }
}
