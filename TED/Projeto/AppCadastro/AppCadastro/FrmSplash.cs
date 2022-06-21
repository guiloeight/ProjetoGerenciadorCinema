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
    public partial class FrmSplash2 : Form
    {
        
        public FrmSplash2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void pcbSplash_Click(object sender, EventArgs e)
        {

        }

        private void FrmSplash_Load(object sender, EventArgs e)
        {

      timer1.Interval = 200;
            timer1.Enabled = true;
            this.Opacity = 0;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity == 1)
            {
                //pgbsplash.Step = 1;
                //for (int i = 0; i <= 1; i++)
                //{

                //    pgbsplash.PerformStep();
                //     o = 1;

                //}
                //if (o==1)
                //{
                //    tela = false;
                timer1.Enabled = false;

                frmMenucs2 Menu = new frmMenucs2();
                Menu.Show();
                Hide();
                //}
            }
            else
            {
                this.Opacity += 0.04D;
                pgbsplash.Value += 4;
            }
        }

        private void pgbsplash_Click(object sender, EventArgs e)
        {

        }
    }
}
