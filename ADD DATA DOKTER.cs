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
            tbxiddokter.Text = "";
            tbxnama.Text = "";
            tbxiddokter.Enabled = false;
            button2.Enabled = false;
            button4.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //nmp.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            string namadokter = tbxnama.Text;
            string iddokter = tbxiddokter.Text;
            string email = tbxemail.Text;
            if (namadokter == "")
            {
                MessageBox.Show("Masukan nama Pasien", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (iddokter == "")
            {
                MessageBox.Show("Masukan Id Pasien", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string str = "Insert into dbo.Pasien (Nama_Dokter, Id_Dokter, Email_dokter)" + "values(@Nama_Dokter, @Id_Dokter, @Email_dokter)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("Nama_Dokter", namadokter));
                cmd.Parameters.Add(new SqlParameter("Id_Dokter", iddokter));
                cmd.Parameters.Add(new SqlParameter("Email_dokter", email));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                Refreshform();
            }
        }
    }
}
