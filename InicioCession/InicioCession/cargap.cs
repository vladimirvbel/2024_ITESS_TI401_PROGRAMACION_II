using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Examen;

namespace InicioCession
{
    public partial class cargap : Form
    {
        public cargap()
        {
            InitializeComponent();
        }

        private void cargap_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 5;
            }
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                Form1 f = new Form1();
                f.Show();
                this.Hide();
            }
        }
    }
}
