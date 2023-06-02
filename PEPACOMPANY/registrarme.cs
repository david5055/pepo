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
    public partial class registrarme : Form
    {
        public registrarme()
        {
            InitializeComponent();
        }

        private void registrarme_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 ventana1 = new Form1();
            ventana1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 ventana1 = new Form1();
            ventana1.Show();
        }
    }
}
