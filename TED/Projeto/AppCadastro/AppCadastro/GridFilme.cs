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
    public partial class GridFilme : Form

    {
        public MySqlConnection pblCnx = new MySqlConnection();
        public MySqlCommand pblComando = new MySqlCommand();
        public MySqlDataReader pblDataReader;
        public int lngLinha = 1;
        public GridFilme()
        {
            InitializeComponent();
            try
            {
                pblCnx.ConnectionString = "Server=localhost;Database=bdcadastro;user=root;pwd=";
                pblCnx.Open();
                btnConsultar_Click();

            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro:" + Erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConsultar_Click()
        {
            string ssql;

            ssql = "Select * From tblfilme Order By filme ";
            pblComando.CommandText = ssql;
            pblComando.Connection = pblCnx;
            pblDataReader = pblComando.ExecuteReader();
            if (!pblDataReader.HasRows)
            {
                MessageBox.Show("Cadastre os Filmes primeiro!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                while (pblDataReader.Read())
                {
                    dvgfilme.Rows.Add(pblDataReader["filme"].ToString(), pblDataReader["genero"].ToString(), pblDataReader["preco"].ToString());
                }
            }
            pblDataReader.Close();
        }

        private void dvgfilme_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
