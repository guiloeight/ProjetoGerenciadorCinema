using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace AppCadastro
{

    public partial class FrmIngresso : Form
    {
        public MySqlConnection pblCnx = new MySqlConnection();
        public MySqlCommand pblCmd = new MySqlCommand();
        public MySqlDataReader pblDados;
     
        public MySqlCommand pblComando = new MySqlCommand();
        public MySqlDataReader pblDataReader;
        public FrmIngresso()
        {
            InitializeComponent();
            try
            {
                pblCnx.ConnectionString = "Server=localhost;Database=bdcadastro;user=root;pwd=";
                pblCnx.Open();

            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro:" + Erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void FrmIngresso_Load(object sender, EventArgs e)
        {
            string strSql = "Select * From tblfilme";

            pblCmd.Connection = pblCnx;
            pblCmd.CommandText = strSql;
            pblDados = pblCmd.ExecuteReader();
            if (pblDados.HasRows)
            {
                while (pblDados.Read())
                {

                    cbxFilme.Items.Add(pblDados["filme"].ToString());
                }
            }
            pblDados.Close();
            
        }

        public void btnSessao_Click(object sender, CancelEventArgs e)
        {
            string strSql = "Select * From tblcadastrosessoes Where filme = '" + cbxFilme.Text + "'";

            pblCmd.Connection = pblCnx;
            pblCmd.CommandText = strSql;
            pblDados = pblCmd.ExecuteReader();
            if (pblDados.HasRows)
            {
                while (pblDados.Read())
                {

                    cbxSessao.Items.Add(pblDados["nome"].ToString());
                }
            }
            pblDados.Close();
        }
        private void cbxFilme_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cbMeia_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnSessao_Click(object sender, EventArgs e)
        {
            cbxSessao.Items.Clear();
            string strSql = "Select * From tblcadastrosessoes Where filme = '" + cbxFilme.Text + "'";

            pblCmd.Connection = pblCnx;
            pblCmd.CommandText = strSql;
            pblDados = pblCmd.ExecuteReader();
            if (pblDados.HasRows)
            {
                while (pblDados.Read())
                {
                    
                    cbxSessao.Items.Add(pblDados["nome"].ToString());
                }
            }
            pblDados.Close();
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            string strSql = "Select * From tblcadastrosessoes Where nome = '" + cbxSessao.Text + "'";

            pblCmd.Connection = pblCnx;
            pblCmd.CommandText = strSql;
            pblDados = pblCmd.ExecuteReader();
            if (pblDados.HasRows)
            {
                pblDados.Read();
               txtHorario.Text = pblDados["horario"].ToString();
               txtSala.Text = pblDados["sala"].ToString();
            }
            pblDados.Close();
        }

        private void btnSessao2(object sender, EventArgs e)
        {
            string strSql = "Select * From tblcadastrosessoes Where nome = '" + cbxSessao.Text + "'";

            pblCmd.Connection = pblCnx;
            pblCmd.CommandText = strSql;
            pblDados = pblCmd.ExecuteReader();
            if (pblDados.HasRows)
            {
                pblDados.Read();
                txtHorario.Text = pblDados["horario"].ToString();
                txtSala.Text = pblDados["sala"].ToString();
            }
            pblDados.Close();
        }

        private void txtQuantidadeDeIngressos_Click(object sender, EventArgs e)
        {

        }

        private void txtQuantidadeDeIngressos_Click()
        {

        }



    }
}
