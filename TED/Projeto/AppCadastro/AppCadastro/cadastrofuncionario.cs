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
    public partial class cadastrofuncionario : Form
    {
        public MySqlConnection pblCnx = new MySqlConnection();
        public MySqlCommand pblCmd = new MySqlCommand();
        public MySqlDataReader pblDados;
        public cadastrofuncionario()
        {
            InitializeComponent();
            try
            {
                pblCnx.ConnectionString = "Server=localhost;Database=bdcadastro;user=root;pwd=root";
                pblCnx.Open();

            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro:" + Erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cadastrofuncionario_Load(object sender, EventArgs e)
        {

        }

        private void lblcep_Click(object sender, EventArgs e)
        {

        }

        private void lblrg_Click(object sender, EventArgs e)
        {

        }

        private void txtrg_TextChanged(object sender, EventArgs e)
        {

        }

        private void mtxtcpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            if (txtnome.Text.Equals("") || txtbairro.Text.Equals("") || txtcidade.Text.Equals("") || txtemail.Text.Equals("") || txtendereco.Text.Equals("") || txtnumero.Text.Equals("") || txtrg.Text.Equals("") || mtxttelefone1.Text.Equals("") || mtxttelefone2.Text.Equals("") || mtxtcpf.Text.Equals("") || cbxestado.Text.Equals("") || cbxestadocivil.Text.Equals("") || cbxsexo.Text.Equals("") || txtnome.Text.Equals("") || txtcomplemento.Text.Equals("") )
            {
                MessageBox.Show("É necessário prencher todos os campos.  ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            }
            else
            {
                try
                {

                    string strSql = "Insert into tblfuncionario (bairro,cidade,complemento,cpf,email,endereco,estado,numero,nome,estadocivil,rg,sexo,telefone1,telefone2,acesso) values(";
                    strSql += "'" + txtbairro.Text + "',";
                    strSql += "'" + txtcidade.Text + "',";
                    strSql += "'" + txtcomplemento.Text + "',";
                    strSql += "'" + mtxtcpf.Text + "',";
                    strSql += "'" + txtemail.Text + "',";
                    strSql += "'" + txtendereco.Text + "',";
                    strSql += "'" + cbxestado.Text + "',";
                    strSql += "'" + txtnumero.Text + "',";
                    strSql += "'" + txtnome.Text + "',";
                    strSql += "'" + cbxestadocivil.Text + "',";
                    strSql += "'" + txtrg.Text + "',";
                    strSql += "'" + cbxsexo.Text + "',";
                    strSql += "'" + mtxttelefone1.Text + "',";
                    strSql += "'" + mtxttelefone2.Text + "',";
                    strSql += "'" + cbxestilo.Text + "')";
                    pblCmd.Connection = pblCnx;
                    pblCmd.CommandText = strSql;
                    pblCmd.ExecuteNonQuery();
                    MessageBox.Show("Novo Funcionário Cadastrado!", "Cadastro Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnlimpar_Click(sender, e);
                    txtnome.Focus();

                }
                catch (Exception Erro)
                {
                    MessageBox.Show("Erro:" + Erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }


        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtbairro.Text = "";
            txtcidade.Text = "";
            txtcodigo.Text = "";
            txtcomplemento.Text = "";
            txtemail.Text = "";
            txtendereco.Text = "";
            txtnome.Text = "";
            txtnumero.Text = "";
            txtrg.Text = "";
            mtxtcpf.Text = "";
            mtxttelefone1.Text = "";
            mtxttelefone2.Text = "";
            cbxsexo.Text = "";
            cbxestadocivil.Text = "";
            cbxestado.Text = "";
            cbxestilo.Text = "";


        }

        private void btnconsultar_Click(object sender, EventArgs e)
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


                    string strSql = "Select * From tblfuncionario Where codigo = " + txtcodigo.Text + "";
                    pblCmd.Connection = pblCnx;
                    pblCmd.CommandText = strSql;
                    pblDados = pblCmd.ExecuteReader();
                    if (pblDados.HasRows)
                    {
                        pblDados.Read();

                    }
                    else
                    {
                        MessageBox.Show("Usuario Inexistente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtnome.Focus();
                        //limpando
                        txtcodigo.Text = "";

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
                        if (MessageBox.Show("Deseja excluir o Funcionário Código número: " + txtcodigo.Text, "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            string strSql = "Delete from tblfuncionario Where codigo = " + txtcodigo.Text + "";
                            pblCmd.Connection = pblCnx;
                            pblCmd.CommandText = strSql;
                            pblCmd.ExecuteNonQuery();
                            MessageBox.Show("Funcionário eliminado!", "Excluído!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnlimpar_Click(sender, e);
                        }
                    }
                    catch (Exception Erro)
                    {
                        MessageBox.Show("Erro: " + Erro.Message, "Tratamento de Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnhabilitar_Click(object sender, EventArgs e)
        {
            txtcodigo.Enabled = true;
            txtcodigo.Focus();
        }

        private void btndesabilitar_Click(object sender, EventArgs e)
        {
            txtcodigo.Enabled = false;
            txtnome.Focus();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (txtnome.Text.Equals("") || txtbairro.Text.Equals("") || txtcidade.Text.Equals("") || txtemail.Text.Equals("") || txtendereco.Text.Equals("") || txtnumero.Text.Equals("") || txtrg.Text.Equals("") || mtxttelefone1.Text.Equals("") || mtxttelefone2.Text.Equals("") || mtxtcpf.Text.Equals("") || cbxestado.Text.Equals("") || cbxestadocivil.Text.Equals("") || cbxsexo.Text.Equals("") || txtnome.Text.Equals("") || txtcomplemento.Text.Equals("") || txtcodigo.Text.Equals(""))
            {
            MessageBox.Show("Preencha todos os campos antes de alterar.  " , "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            
            }
            else
            {

                try
                {
                    string strSql = "Update tblfuncionario set ";
                    strSql += "bairro = '" + txtbairro.Text + "',";
                    strSql += "cidade = '" + txtcidade.Text + "',";
                    strSql += "email = '" + txtemail.Text + "',";
                    strSql += "endereco = '" + txtendereco.Text + "',";
                    strSql += "numero = '" + txtnumero.Text + "',";
                    strSql += "rg = '" + txtrg.Text + "',";
                    strSql += "telefone1 = '" + mtxttelefone1.Text + "',";
                    strSql += "telefone2 = '" + mtxttelefone2.Text + "',";
                    strSql += "cpf = '" + mtxtcpf.Text + "',";
                    strSql += "estado = '" + cbxestado.Text + "',";
                    strSql += "estadocivil = '" + cbxestadocivil.Text + "',";
                    strSql += "sexo = '" + cbxsexo.Text + "',";
                    strSql += "acesso = '" + cbxestilo.Text + "',";
                    strSql += "nome = '" + txtnome.Text + "',";
                    strSql += "complemento = '" + txtcomplemento.Text + "' ";
                    strSql += "Where codigo = " + txtcodigo.Text;



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
        private void btnc_Click(object sender, EventArgs e)
        {
          
                try
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
                        cbxestilo.Text = pblDados["acesso"].ToString();
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
            }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void lblemail_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            gridfuncionario grid = new gridfuncionario();
            grid.ShowDialog();
        }

        private void cbxestilo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        }
    }

        
    


