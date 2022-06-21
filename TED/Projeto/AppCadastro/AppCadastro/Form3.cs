using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppCadastro
{
    public partial class Form3 : Form
    {
        private bool tela = true;
        public Form3()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tela)
                this.Opacity += 0.2D;
            if (this.Opacity == 1)
            {
                tela = false;
                timer1.Enabled = false;

                frmMenucs menu2 = new frmMenucs();
                this.Hide();
                menu2.ShowDialog();
                
            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Interval = 200;
            timer1.Enabled = true;
            this.Opacity = 0;
        }

        private void pcbSplash_Click(object sender, EventArgs e)
        {

        }
    }
}
