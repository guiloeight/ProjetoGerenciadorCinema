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
    public partial class Grid : Form
    {
        public MySqlConnection pblCnx = new MySqlConnection();
        public MySqlCommand pblComando = new MySqlCommand();
        public MySqlDataReader pblDataReader;
        public int lngLinha = 1;
        public Grid()
        {
            InitializeComponent();
            try
            {
                pblCnx.ConnectionString = "Server=localhost;Database=bdCadastro;user=root;pwd=";
                pblCnx.Open();
                MessageBox.Show("OK", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro:" + Erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string ssql;

            ssql = "Select * From tblcliente Order By cod_cli";
            pblComando.CommandText = ssql;
            pblComando.Connection = pblCnx;
            pblDataReader = pblComando.ExecuteReader();
            if (!pblDataReader.HasRows)
            {
                MessageBox.Show("Cadastre os Clientes primeiro!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                while (pblDataReader.Read())
                {
                    dgvDados.Rows.Add(pblDataReader["cod_cli"].ToString(), pblDataReader["nome_cli"].ToString(), pblDataReader["tel_cli"].ToString(), pblDataReader["end_cli"].ToString());
                }
            }
            pblDataReader.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Grid_Load(object sender, EventArgs e)
        {

        }
    }
}
