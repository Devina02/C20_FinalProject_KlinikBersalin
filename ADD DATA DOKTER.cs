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
    public partial class ADD_DATA_DOKTER : Form
    {
        private string stringConnection = " data source = LAPTOP-DP3PQGGM\\DEPIIII;" +
      "database=KlinikBersalin;User ID=sa;Password=123";
        private SqlConnection koneksi;
        public ADD_DATA_DOKTER()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ADD_DATA_DOKTER_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'klinikBersalinDataSet.Dokter' table. You can move, or remove it, as needed.
            this.dokterTableAdapter.Fill(this.klinikBersalinDataSet.Dokter);

        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select * from dbo.Dokter";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void Refreshform()
        {

 
            tbxnama.Text = "";
            tbxemail.Text = "";
            button2.Enabled = false;
            button4.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //nmp.Enabled = true;
            button2.Enabled = true;
            button4.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string namadokter = tbxnama.Text;
            string email = tbxemail.Text;

            if (namadokter == "")
            {
                MessageBox.Show("Masukan nama Dokter", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string getIdQuery = "SELECT MAX(Id_Dokter) FROM dbo.Dokter";
                SqlCommand getIdCmd = new SqlCommand(getIdQuery, koneksi);
                object result = getIdCmd.ExecuteScalar();
                string newId = "D001";

                if (result != null && result != DBNull.Value)
                {
                    string lastId = Convert.ToString(result);
                    int lastNumber = int.Parse(lastId.Substring(1));
                    newId = "D" + (lastNumber + 1).ToString("D3");
                }

                string insertQuery = "INSERT INTO dbo.Dokter (Nama_Dokter, Id_Dokter, Email_dokter) VALUES (@Nama_Dokter, @Id_Dokter, @Email_dokter)";
                SqlCommand cmd = new SqlCommand(insertQuery, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@Nama_Dokter", namadokter));
                cmd.Parameters.Add(new SqlParameter("@Email_dokter", email));
                cmd.Parameters.Add(new SqlParameter("@Id_Dokter", newId));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                Refreshform();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Refreshform();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new ADD_DATA().Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new ADD_PETUGAS().Show();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button10_Click(object sender, EventArgs e)
        {
            string stringConnection = " data source = LAPTOP-DP3PQGGM\\DEPIIII;" +
             "database=KlinikBersalin;User ID=sa;Password=123";
            string query = "DELETE FROM Dokter WHERE Id_Dokter = @Id_Dokter";
            using (SqlConnection koneksi = new SqlConnection(stringConnection))
            {
                using (SqlCommand cmd = new SqlCommand(query, koneksi))
                {
                    cmd.Parameters.AddWithValue("@Id_Dokter", txbxIdDokter.Text);

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

        private void button11_Click(object sender, EventArgs e)
        {
            new Add_Shift().Show();
        }
    }
   
}
