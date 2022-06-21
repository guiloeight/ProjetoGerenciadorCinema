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
    public partial class frmMenucs : Form
    {
         
               
        public frmMenucs()
        {
            InitializeComponent();
            
        }


        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja realmente Sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            frmUsuario0 Usuario = new frmUsuario0();
            Usuario.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            frmCliente Cliente = new frmCliente();
            Cliente.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmUsuario0 Usuario = new frmUsuario0();
            Usuario.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmCliente Cliente = new frmCliente();
            Cliente.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja fazer Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Hide();
                frmLogin Login = new frmLogin();
                Login.ShowDialog();
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja fazer Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Hide();
                frmLogin Login = new frmLogin();
                Login.ShowDialog();
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente Sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmMenucs_Load(object sender, EventArgs e)
        {
            
        }

        private void pcbVenda_Click(object sender, EventArgs e)
        {
            FrmIngresso ingresso = new FrmIngresso();
            ingresso.ShowDialog();
        }

       

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            FrmIngresso ingresso = new FrmIngresso();
            ingresso.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmUsuario0 Usuario = new frmUsuario0();
            Usuario.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmCliente Cliente = new frmCliente();
            Cliente.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void tooladm1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
