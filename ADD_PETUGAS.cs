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
    public partial class ADD_PETUGAS : Form
    {
        private string stringConnection = " data source = LAPTOP-DP3PQGGM\\DEPIIII;" +
      "database=KlinikBersalin;User ID=sa;Password=123";
        private SqlConnection koneksi;
        private SqlCommand comn;
        private SqlDataAdapter adapter;
        public ADD_PETUGAS()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            LoadKamarData();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ADD_PETUGAS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'klinikBersalinDataSet.Petugas' table. You can move, or remove it, as needed.
            this.petugasTableAdapter.Fill(this.klinikBersalinDataSet.Petugas);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            BtnSimpan.Enabled = true;
            BtnAdd.Enabled = true;
        }
        private void dataGridView()
        {
            koneksi.Open();
            string str = "select * from dbo.Petugas";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }
        private void Refreshform()
        {

            tbxEmail.Text = "";
            tbxnama.Text = "";
            tbxPetugas.Text = "";
            BtnSimpan.Enabled = false;
            BtnClear.Enabled = false;

        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            string nmPetugas = tbxnama.Text;
            string Email = tbxEmail.Text;
            string idkamar = cbxkamar.SelectedValue.ToString();

            if (nmPetugas == "")
            {
                MessageBox.Show("Masukan Nama Petugas", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string getIdQuery = "SELECT MAX(Id_Petugas) FROM dbo.Petugas";
                SqlCommand getIdCmd = new SqlCommand(getIdQuery, koneksi);
                object result = getIdCmd.ExecuteScalar();
                string newId = "G001";

                if (result != null && result != DBNull.Value)
                {
                    string lastId = Convert.ToString(result);
                    int lastNumber = int.Parse(lastId.Substring(1));
                    newId = "G" + (lastNumber + 1).ToString("D3");
                }
                string insertQuery = "INSERT INTO dbo.Petugas (Nama_Petugas, Id_Petugas, Email_Petugas, Id_Kamar) VALUES (@Nama_Petugas, @Id_Petugas, @Email_Petugas, @Id_Kamar)";
                SqlCommand cmd = new SqlCommand(insertQuery, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@Nama_Petugas", nmPetugas));
                cmd.Parameters.Add(new SqlParameter("@Id_Petugas", newId));
                cmd.Parameters.Add(new SqlParameter("@Email_Petugas", Email));
                cmd.Parameters.Add(new SqlParameter("@Id_Kamar", idkamar));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                Refreshform();
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

                cbxkamar.DisplayMember = "Nama_Kamar";
                cbxkamar.ValueMember = "Id_Kamar";

                cbxkamar.DataSource = Kamar;
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

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string stringConnection = " data source = LAPTOP-DP3PQGGM\\DEPIIII;" +
             "database=KlinikBersalin;User ID=sa;Password=123";
            string query = "DELETE FROM Petugas WHERE Id_Petugas = @Id_Petugas";
            using (SqlConnection koneksi = new SqlConnection(stringConnection))
            {
                using (SqlCommand cmd = new SqlCommand(query, koneksi))
                {
                    cmd.Parameters.AddWithValue("@Id_Petugas", tbxPetugas.Text);

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

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Refreshform();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string nmpetugas = tbxnama.Text; 
            string idpetugas = tbxPetugas.Text;
            string Idkamar = cbxkamar.SelectedValue.ToString();
            string email = tbxEmail.Text;

            string updateQuery = "UPDATE dbo.Petugas SET Nama_Petugas = @Nama_Petugas, Id_Kamar = @Id_Kamar, Email_Petugas = @Email_Petugas WHERE Id_Petugas = @Id_Petugas";
            SqlCommand cmd = new SqlCommand(updateQuery, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("@Nama_Petugas", tbxnama.Text));
            cmd.Parameters.Add(new SqlParameter("@Id_Kamar", cbxkamar.SelectedValue.ToString()));
            cmd.Parameters.Add(new SqlParameter("@Email_Petugas", tbxEmail.Text));
            cmd.Parameters.Add(new SqlParameter("@Id_Petugas", tbxPetugas.Text));


            koneksi.Open();
            cmd.ExecuteNonQuery();
            koneksi.Close();
            MessageBox.Show("Data Petugas updated successfully.");
            dataGridView();
            Refreshform();
        }
    }
}
