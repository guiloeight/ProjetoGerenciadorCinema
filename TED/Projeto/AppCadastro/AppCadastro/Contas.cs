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
    public partial class Contas : Form
    {
        public MySqlConnection pblCnx = new MySqlConnection();
        public MySqlCommand pblCmd = new MySqlCommand();
        public MySqlDataReader pblDados;
        public MySqlCommand pblComando = new MySqlCommand();
        public MySqlDataReader pblDataReader;
        public Contas()
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

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblcodigo_Click(object sender, EventArgs e)
        {

        }

        private void Contas_Load(object sender, EventArgs e)
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

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {

            if (cbxtipo.Text.Equals("") || mtxtvencimento.Text.Equals("") || mtxtpagamento.Text.Equals("") || txtvalor.Text.Equals("") || txtmulta.Text.Equals("") || cbxcredor.Text.Equals("") || rtxtdescricao.Text.Equals(""))
            {
                MessageBox.Show("Não se pode cadastrar uma conta sem as informações necessárias!", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {

                    string strSql = "Insert into tblcontas (tipo,vencimento,pagamento,valor,multa,credor,descricao) values(";
                    strSql += "'" + cbxtipo.Text + "',";
                    strSql += "'" + mtxtvencimento.Text + "',";
                    strSql += "'" + mtxtpagamento.Text + "',";
                    strSql += "'" + txtvalor.Text + "',";
                    strSql += "'" + txtmulta.Text + "',";
                    strSql += "'" + cbxcredor.Text + "',";
                    strSql += "'" + rtxtdescricao.Text + "')";



                    pblCmd.Connection = pblCnx;
                    pblCmd.CommandText = strSql;
                    pblCmd.ExecuteNonQuery();
                    MessageBox.Show("Nova Conta Cadastrada!", "Cadastro Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnlimpar_Click(sender, e);
                    cbxtipo.Focus();

                }
                catch (Exception Erro)
                {
                    MessageBox.Show("Erro:" + Erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            cbxcredor.Text = "";
            cbxtipo.Text = "";
            mtxtpagamento.Text = "";
            mtxtvencimento.Text = "";
            txtcodigo.Text = "";
            txtmulta.Text = "";
            rtxtdescricao.Text = "";
            txtvalor.Text = "";



        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            dgvconta.Rows.Clear();
            try
            {
                dgvconta.Enabled = true;
                string ssql;

                ssql = "Select * From tblcontas Order By codigo ";
                pblComando.CommandText = ssql;
                pblComando.Connection = pblCnx;
                pblDataReader = pblComando.ExecuteReader();
                if (!pblDataReader.HasRows)
                {
                    MessageBox.Show("Cadastre os Produtos primeiro!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    while (pblDataReader.Read())
                    {
                        dgvconta.Rows.Add(pblDataReader["codigo"].ToString(), pblDataReader["tipo"].ToString(), pblDataReader["vencimento"].ToString(), pblDataReader["pagamento"].ToString(), pblDataReader["valor"].ToString(), pblDataReader["credor"].ToString(), pblDataReader["multa"].ToString(), pblDataReader["descricao"].ToString());
                    }
                }
                pblDataReader.Close();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro:" + Erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {

            if (cbxtipo.Text.Equals("") || mtxtvencimento.Text.Equals("") || mtxtpagamento.Text.Equals("") || txtvalor.Text.Equals("") || txtmulta.Text.Equals("") || cbxcredor.Text.Equals("") || rtxtdescricao.Text.Equals(""))
            {
                MessageBox.Show("Antes de Alterar é necessário Consultar.  ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            }
            else
            {
                try
                {
                    string strSql = "Update tblcontas set ";

                    strSql += "tipo ='" + cbxtipo.Text + "',";
                    strSql += "vencimento ='" + mtxtvencimento.Text + "',";
                    strSql += "pagamento = '" + mtxtpagamento.Text + "',";
                    strSql += "valor ='" + txtvalor.Text + "',";
                    strSql += "multa ='" + txtmulta.Text + "',";
                    strSql += "credor = '" + cbxcredor.Text + "',";
                    strSql += "descricao ='" + rtxtdescricao.Text + "'";
                    strSql += "Where codigo = " + txtcodigo.Text;


                    pblCmd.Connection = pblCnx;
                    pblCmd.CommandText = strSql;
                    pblCmd.ExecuteNonQuery();
                    MessageBox.Show("Conta Alterada!", "Alterado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnlimpar_Click(sender, e);
                }
                catch (Exception Erro)
                {
                    MessageBox.Show("Erro: " + Erro.Message, "Tratamento de Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbxcredor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            if (txtcodigo.Text == "")
            {
                MessageBox.Show("Habilite o campo Código e Preencha o código que deseja excluir!", "Código Vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int usuario = 1;
                try
                {
                    

                    string strSql = "Select * From tblcontas Where codigo = " + txtcodigo.Text;
                    pblCmd.Connection = pblCnx;
                    pblCmd.CommandText = strSql;
                    pblDados = pblCmd.ExecuteReader();
                    if (pblDados.HasRows)
                    {
                        pblDados.Read();
                        txtcodigo.Text = pblDados["codigo"].ToString();
                        cbxtipo.Text = pblDados["tipo"].ToString();
                        mtxtvencimento.Text = pblDados["vencimento"].ToString();
                        mtxtpagamento.Text = pblDados["pagamento"].ToString();
                        txtvalor.Text = pblDados["valor"].ToString();
                        txtmulta.Text = pblDados["multa"].ToString();
                        cbxcredor.Text = pblDados["credor"].ToString();
                       
                   
                    }
                    else
                    {
                        MessageBox.Show("Conta Inexistente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtcodigo.Focus();
                        //limpando
                        
                        //limpado
                        usuario = 0;
                    }
                    pblDados.Close();
                    

                }
                catch (Exception Erro)
                {
                    MessageBox.Show("Erro: " + Erro.Message, "Tratamento de Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (usuario == 1)
                {
                    try
                    {
                        if (MessageBox.Show("Deseja excluir a Conta: " + cbxtipo.Text, "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            string strSql = "Delete from tblcontas Where codigo = " + txtcodigo.Text + "";
                            pblCmd.Connection = pblCnx;
                            pblCmd.CommandText = strSql;
                            pblCmd.ExecuteNonQuery();
                            MessageBox.Show("Conta eliminada!", "Excluído!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                        }
                    }
                    catch (Exception Erro)
                    {
                        MessageBox.Show("Erro: " + Erro.Message, "Tratamento de Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void lbltipo_Click(object sender, EventArgs e)
        {

        }
        }
    }





    




