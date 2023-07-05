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
    public partial class ADD_DATA_SHIFT : Form
    {
        public ADD_DATA_SHIFT()
        {
            InitializeComponent();
        }

        private void ADD_DATA_SHIFT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'klinikBersalinDataSet.Shiftt' table. You can move, or remove it, as needed.
            this.shifttTableAdapter.Fill(this.klinikBersalinDataSet.Shiftt);

        }
    }
}
