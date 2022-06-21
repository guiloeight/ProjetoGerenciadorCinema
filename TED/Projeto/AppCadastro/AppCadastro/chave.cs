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
    public partial class chave : Form
    {
        public chave()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (txtchave.Text == "123456" )
            {

                MessageBox.Show("A chave está correta.", "Chave", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                frmUsuario0 Usuario = new frmUsuario0();
                Usuario.Show();
                Hide();
            }

            else
                if (MessageBox.Show("Chave inválida.Por favor digite novamente.", "Chave", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
                    txtchave.Clear();
                    txtchave.Focus();
                }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());


       }

        private void chave_Load(object sender, EventArgs e)
        {
            linkLabel1.Links.Add(0, 39, "http://www.baixaki.com.br");
        }
    }
}
