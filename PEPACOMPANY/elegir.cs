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
    public partial class elegir : Form
    {
        public elegir()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            registrarme ventana1 = new registrarme();
            ventana1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            registrarme ventana1 = new registrarme();
            ventana1.Show();
        }
    }
}
