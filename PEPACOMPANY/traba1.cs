using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEPACOMPANY
{
    public partial class traba1 : Form
    {
        public traba1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            traba2 ventana1 = new traba2();
            ventana1.Show();
        }
    }
}
