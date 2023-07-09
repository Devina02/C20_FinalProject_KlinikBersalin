using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_KlinikBersalin
{
    public partial class Add_Shift : Form
    {
        public Add_Shift()
        {
            InitializeComponent();
        }

        private void Add_Shift_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'klinikBersalinDataSet.Shiftt' table. You can move, or remove it, as needed.
            this.shifttTableAdapter.Fill(this.klinikBersalinDataSet.Shiftt);

        }
    }
}
