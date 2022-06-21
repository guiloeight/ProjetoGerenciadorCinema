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
    public partial class gridfuncionario : Form
    {
        public MySqlConnection pblCnx = new MySqlConnection();
        public MySqlCommand pblComando = new MySqlCommand();
        public MySqlDataReader pblDataReader;
        public gridfuncionario()
        {
            InitializeComponent();
            try
            {
                pblCnx.ConnectionString = "Server=localhost;Database=bdCadastro;user=root;pwd=password";
                pblCnx.Open();
          

            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro:" + Erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridfuncionario_Load(object sender, EventArgs e)
        {

            string ssql;

            ssql = "Select * From tblfuncionario Order By codigo";
            pblComando.CommandText = ssql;
            pblComando.Connection = pblCnx;
            pblDataReader = pblComando.ExecuteReader();
            if (!pblDataReader.HasRows)
            {
                MessageBox.Show("Cadastre os Funcionários primeiro!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                while (pblDataReader.Read())
                {
                    dgvfuncionario.Rows.Add(pblDataReader["codigo"].ToString(), pblDataReader["nome"].ToString(), pblDataReader["sexo"].ToString(), pblDataReader["cpf"].ToString(), pblDataReader["rg"].ToString(), pblDataReader["endereco"].ToString(), pblDataReader["cidade"].ToString(), pblDataReader["numero"].ToString(), pblDataReader["complemento"].ToString(), pblDataReader["bairro"].ToString(), pblDataReader["estado"].ToString(), pblDataReader["estadocivil"].ToString(), pblDataReader["email"].ToString(), pblDataReader["telefone1"].ToString(), pblDataReader["telefone2"].ToString(), pblDataReader["acesso"].ToString());
                }
            }
            pblDataReader.Close();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
                Close();
        }

        private void dgvfuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
