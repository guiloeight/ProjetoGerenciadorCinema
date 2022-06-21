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
    public partial class Cadastrofornecedor : Form
    {
        public MySqlConnection pblCnx = new MySqlConnection();
        public MySqlCommand pblCmd = new MySqlCommand();
        public MySqlDataReader pblDados;
        public Cadastrofornecedor()
        {

            InitializeComponent();
            try
            {
                pblCnx.ConnectionString = "Server=localhost;Database=bdcadastro;user=root;pwd=password";
                pblCnx.Open();

            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro:" + Erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtcomplemento_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtbairro.Text = "";
            txtcidade.Text = "";
            txtcomplemento.Text = "";
            mtxtcnpj.Text = "";
            txtemail.Text = "";
            txtendereco.Text = "";
            cbxestado.Text = "";
            txtnatureza.Text = "";
            txtnome.Text = "";
            txtnomefantasia.Text = "";
            mtxtcep.Text = "";
            mtxttelefone1.Text = "";
            mtxttelefone2.Text = "";
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {

            if (txtnome.Text.Equals("") || txtnomefantasia.Text.Equals(""))
            {
                MessageBox.Show("Não se pode cadastrar um fornecedor sem as informações necessárias!", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {



                    string strSql = "Insert into tblcadastrofornecedor (bairro,cidade,complemento,cnpj,email,endereco,estado,natureza,nome,nomefantasia,cep,telefone1,telefone2) values(";
                    strSql += "'" + txtbairro.Text + "',";
                    strSql += "'" + txtcidade.Text + "',";
                    strSql += "'" + txtcomplemento.Text + "',";
                    strSql += "'" + mtxtcnpj.Text + "',";
                    strSql += "'" + txtemail.Text + "',";
                    strSql += "'" + txtendereco.Text + "',";
                    strSql += "'" + cbxestado.Text + "',";
                    strSql += "'" + txtnatureza.Text + "',";
                    strSql += "'" + txtnome.Text + "',";
                    strSql += "'" + txtnomefantasia.Text + "',";
                    strSql += "'" + mtxtcep.Text + "',";
                    strSql += "'" + mtxttelefone1.Text + "',";
                    strSql += "'" + mtxttelefone2.Text + "')";
                    pblCmd.Connection = pblCnx;
                    pblCmd.CommandText = strSql;
                    pblCmd.ExecuteNonQuery();
                    MessageBox.Show("Novo Fornecedor Cadastrado!", "Cadastro Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnlimpar_Click(sender, e);
                    txtnome.Focus();

                }
                catch (Exception Erro)
                {
                    MessageBox.Show("Erro:" + Erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void mtxtcnpj_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnhabilitar_Click(object sender, EventArgs e)
        {
            txtcodigo.Enabled = true;
            txtcodigo.Focus();
        }

        private void btndesabilitar_Click(object sender, EventArgs e)
        {
            txtcodigo.Enabled = false;
            txtcodigo.Focus();
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            dtvfornecedor gridfornecedor = new dtvfornecedor();
            gridfornecedor.Show();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja excluir o Fornecedor Código número: " + txtcodigo.Text, "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    string strSql = "Delete from tblcadastrofornecedor Where codigo = " + txtcodigo.Text + "";
                    pblCmd.Connection = pblCnx;
                    pblCmd.CommandText = strSql;
                    pblCmd.ExecuteNonQuery();
                    MessageBox.Show("Fornecedor eliminado!", "Excluído!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnlimpar_Click(sender, e);
                }
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro: " + Erro.Message, "Tratamento de Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cadastrofornecedor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            if (txtnome.Text.Equals("") || txtbairro.Text.Equals("") || txtcidade.Text.Equals("") || txtemail.Text.Equals("") || txtendereco.Text.Equals("") || mtxttelefone1.Text.Equals("") || mtxttelefone2.Text.Equals("") || mtxtcnpj.Text.Equals("") || cbxestado.Text.Equals("") || txtnome.Text.Equals("") || txtcomplemento.Text.Equals("") || txtcodigo.Text.Equals(""))
            {
                MessageBox.Show("Antes de Alterar é necessário Consultar.  ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            }
            else
            {
                try
                {
                    string strSql = "Update tblcadastrofornecedor set ";


                    strSql += "bairro ='" + txtbairro.Text + "',";
                    strSql += "cidade ='" + txtcidade.Text + "',";
                    strSql += "complemento ='" + txtcomplemento.Text + "',";
                    strSql += "cnpj ='" + mtxtcnpj.Text + "',";
                    strSql += "email = '" + txtemail.Text + "',";
                    strSql += "endereco ='" + txtendereco.Text + "',";
                    strSql += "estado = '" + cbxestado.Text + "',";
                    strSql += " natureza ='" + txtnatureza.Text + "',";
                    strSql += " nome = '" + txtnome.Text + "',";
                    strSql += " nomefantasia ='" + txtnomefantasia.Text + "',";
                    strSql += "cep ='" + mtxtcep.Text + "',";
                    strSql += "telefone1 ='" + mtxttelefone1.Text + "',";
                    strSql += "telefone2 ='" + mtxttelefone2.Text + "')";

                    pblCmd.Connection = pblCnx;
                    pblCmd.CommandText = strSql;
                    pblCmd.ExecuteNonQuery();
                    MessageBox.Show("Funcionário Alterado!", "Alterado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnlimpar_Click(sender, e);
                }
                catch (Exception Erro)
                {
                    MessageBox.Show("Erro: " + Erro.Message, "Tratamento de Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void txtcidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblcpf_Click(object sender, EventArgs e)
        {

        }

        private void btnconsultar_Click_1(object sender, EventArgs e)
        {
            /*     try
                 {


                     string strSql = "Select * From tblfuncionario Where codigo = " + txtcodigo.Text + "";
                     pblCmd.Connection = pblCnx;
                     pblCmd.CommandText = strSql;
                     pblDados = pblCmd.ExecuteReader();
                     if (pblDados.HasRows)
                     {
                         pblDados.Read();
                         txtbairro.Text = pblDados["bairro"].ToString();
                         txtcidade.Text = pblDados["cidade"].ToString();
                         txtemail.Text = pblDados["email"].ToString();
                         txtendereco.Text = pblDados["endereco"].ToString();
                         txtnumero.Text = pblDados["numero"].ToString();
                         txtrg.Text = pblDados["rg"].ToString();
                         mtxttelefone1.Text = pblDados["telefone1"].ToString();
                         mtxttelefone2.Text = pblDados["telefone2"].ToString();
                         mtxtcpf.Text = pblDados["cpf"].ToString();
                         txtnome.Text = pblDados["nome"].ToString();
                         txtcomplemento.Text = pblDados["complemento"].ToString();
                         cbxestado.Text = pblDados["estado"].ToString();
                         cbxestadocivil.Text = pblDados["estadocivil"].ToString();
                         cbxsexo.Text = pblDados["sexo"].ToString();

                     }
                     else
                     {
                         MessageBox.Show("Funcionário Inexistente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                         txtnome.Focus();
                     }
                     pblDados.Close();
                     btndesabilitar_Click(sender, e);

                 }
                 catch (Exception Erro)
                 {
                     MessageBox.Show("Erro: " + Erro.Message, "Tratamento de Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
             }*/

        }
    }

}