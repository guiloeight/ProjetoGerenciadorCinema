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
    public partial class dtvfornecedor : Form
    {
        public MySqlConnection pblCnx = new MySqlConnection();
        public MySqlCommand pblComando = new MySqlCommand();
        public MySqlDataReader pblDataReader;
        public int lngLinha = 1;
        public dtvfornecedor()
        {
            InitializeComponent();
             try
            {
                pblCnx.ConnectionString = "Server=localhost;Database=bdCadastro;user=root;pwd=";
                pblCnx.Open();
             

            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro:" + Erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
                 Close();
        }

        private void dtvfornecedor_Load(object sender, EventArgs e)
        {
             
            string ssql;

            ssql = "Select * From tblcadastrofornecedor Order By codigo";
            pblComando.CommandText = ssql;
            pblComando.Connection = pblCnx;
            pblDataReader = pblComando.ExecuteReader();
            if (!pblDataReader.HasRows)
            {
                MessageBox.Show("Cadastre os Fornecedores primeiro!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                while (pblDataReader.Read())
                {
                    dgvfornecedor.Rows.Add(pblDataReader["codigo"].ToString(), pblDataReader["nome"].ToString(), pblDataReader["natureza"].ToString(), pblDataReader["nomefantasia"].ToString(),pblDataReader["cnpj"].ToString(),pblDataReader["endereco"].ToString(),pblDataReader["cidade"].ToString(),pblDataReader["complemento"].ToString(),pblDataReader["bairro"].ToString(),pblDataReader["estado"].ToString(),pblDataReader["cep"].ToString(),pblDataReader["email"].ToString(),pblDataReader["telefone1"].ToString(),pblDataReader["telefone2"].ToString());
                }
            }
            pblDataReader.Close();
        }
        }

        }
    