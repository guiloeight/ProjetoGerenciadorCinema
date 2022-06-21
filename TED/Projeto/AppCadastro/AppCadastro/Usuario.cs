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
    public partial class frmUsuario0 : Form
    {
        public string[] vtDados = new string[76], vtCodigo = new string[76];
        int adm=0;
        public MySqlConnection pblCnx = new MySqlConnection();
        public MySqlCommand pblCmd = new MySqlCommand();
        public MySqlDataReader pblDados;
        public string acesso;
        public frmUsuario0()
        {
            InitializeComponent();
            try
            {
                pblCnx.ConnectionString = "Server=localhost;Database=bdCadastro;user=root;pwd=root";
                pblCnx.Open();

            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro:" + Erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCadastrarUs_Click(object sender, EventArgs e)
        {
            if (txtNvSenha.Text.Equals("") || txtNvUsuario.Text.Equals("") || txtfunc.Text.Equals(""))
            {
                MessageBox.Show("Não se pode cadastrar um usuário sem as informações necessárias!", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {

                    string strSql = "Insert into tblusuario (usuario,codfunc, AdmKey , senha) values(";
                    strSql += "'" + txtNvUsuario.Text + "',";
                    strSql += "'" + txtfunc.Text + "',";
                    strSql += adm + ",";
                    strSql += "'" + Criptografar(txtNvSenha.Text.Trim()) + "')";

                    chkAdm.Checked = false;
                    adm = 0;
                    pblCmd.Connection = pblCnx;
                    pblCmd.CommandText = strSql;
                    pblCmd.ExecuteNonQuery();
                    MessageBox.Show("Novo Usuario cadastrado!", "Cadastro Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLimparUs_Click(sender, e);
                }
                catch (Exception Erro)
                {
                    MessageBox.Show("Erro:" + Erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

               // try
               // {
                 //   MessageBox.Show(acesso);
                    // string strSql = "Insert into tblusuario (acesso) values ('" + acesso + "')";
                   // string strSql = "Insert into tblusuario (acesso) values ('";
                    //strSql += acesso + "')";

              //  }
                //catch (Exception Erro)
               // {
               //     MessageBox.Show("Erro:" + Erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
               // }
            }

        }
            
            /*
            SqlConnection cnnBase = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["TestesConnectionString"].ConnectionString);
            SqlCommand cmd = new SqlCommand("Select nome from aluno ", cnnBase);
            cmd.CommandType = CommandType.Text;

            DataTable dt = new DataTable();
            try
            {

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                da.Dispose();
                string nome_do_aluno = "";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    nome_do_aluno = dt.Rows[i]["nome"].ToString();
                }
            }
            catch
            {

            }

            finally
            {
                cmd.Dispose();
                cnnBase.Close();
            }*/
        
     
        private void btnLimparUs_Click(object sender, EventArgs e)
        {
            txtNvSenha.Text = "";
            txtNvUsuario.Text = "";
            txtNvUsuario.Focus();
        }

        private void btnConsultarUs_Click(object sender, EventArgs e)
        {
            try
            {
                string strSql = "Select * From tblusuario Where usuario = '" + txtNvUsuario.Text + "'";
                pblCmd.Connection = pblCnx;
                pblCmd.CommandText = strSql;
                pblDados = pblCmd.ExecuteReader();
                if (pblDados.HasRows)
                {
                    pblDados.Read();
                    txtNvUsuario.Text = pblDados["usuario"].ToString();
                    txtfunc.Text = pblDados["codfunc"].ToString();
                    txtNvSenha.Text = Decriptografar(pblDados["senha"].ToString());
                }
                else
                {
                    MessageBox.Show("Usuario Inexistente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNvUsuario.Focus();
                }
                pblDados.Close();

            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro: " + Erro.Message, "Tratamento de Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                    pblCnx.Close();
                    Close();
            }

        
            catch
            {
                MessageBox.Show("erro");
            }

    }

        private void btnExcluirUs_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja excluir o Usuário: " + txtNvUsuario.Text, "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    string strSql = "Delete from tblusuario Where usuario = '" + txtNvUsuario.Text + "'";
                    pblCmd.Connection = pblCnx;
                    pblCmd.CommandText = strSql;
                    pblCmd.ExecuteNonQuery();
                    MessageBox.Show("Usuario eliminado!", "Excluído!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLimparUs_Click(sender, e);
                }
                else {
                    MessageBox.Show("Usuario Inexistente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro: " + Erro.Message, "Tratamento de Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterarUs_Click(object sender, EventArgs e)
        {
            try
            {
                string strSql = "Update tblusuario set ";
                strSql += "senha = '" + Criptografar(txtNvSenha.Text.Trim()) + "',  ";
                strSql += "codfunc = '" + txtfunc.Text + "',";
                strSql += "AdmKey = " +adm;
                strSql += " Where usuario = '" + txtNvUsuario.Text+"'";

                pblCmd.Connection = pblCnx;
                pblCmd.CommandText = strSql;
                pblCmd.ExecuteNonQuery();
                MessageBox.Show("Usuario Alterado!", "Alterado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLimparUs_Click(sender, e);
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro: " + Erro.Message, "Tratamento de Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            CarregarVetores();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmCliente Cliente = new frmCliente();
            Cliente.ShowDialog();
        }

        private void lblVoltarMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmLogin Login = new frmLogin();
            Login.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmMenucs Menu = new frmMenucs();
            Menu.ShowDialog();
        }
        private void CarregarVetores()
        {
            vtDados[0] = "A";
            vtDados[1] = "B";
            vtDados[2] = "C";
            vtDados[3] = "D";
            vtDados[4] = "E";
            vtDados[5] = "F";
            vtDados[6] = "G";
            vtDados[7] = "H";
            vtDados[8] = "I";
            vtDados[9] = "J";
            vtDados[10] = "K";
            vtDados[11] = "L";
            vtDados[12] = "M";
            vtDados[13] = "N";
            vtDados[14] = "O";
            vtDados[15] = "P";
            vtDados[16] = "Q";
            vtDados[17] = "R";
            vtDados[18] = "S";
            vtDados[19] = "T";
            vtDados[20] = "U";
            vtDados[21] = "V";
            vtDados[22] = "X";
            vtDados[23] = "Y";
            vtDados[24] = "Z";
            vtDados[24] = "a";
            vtDados[25] = "b";
            vtDados[26] = "c";
            vtDados[27] = "d";
            vtDados[28] = "f";
            vtDados[29] = "g";
            vtDados[30] = "h";
            vtDados[31] = "i";
            vtDados[32] = "j";
            vtDados[33] = "k";
            vtDados[34] = "l";
            vtDados[35] = "m";
            vtDados[36] = "n";
            vtDados[37] = "o";
            vtDados[38] = "p";
            vtDados[39] = "q";
            vtDados[40] = "r";
            vtDados[41] = "s";
            vtDados[42] = "t";
            vtDados[43] = "u";
            vtDados[44] = "v";
            vtDados[45] = "w";
            vtDados[46] = "x";
            vtDados[47] = "y";
            vtDados[48] = "z";
            vtDados[49] = "0";
            vtDados[50] = "1";
            vtDados[51] = "2";
            vtDados[52] = "3";
            vtDados[53] = "4";
            vtDados[54] = "5";
            vtDados[55] = "6";
            vtDados[56] = "7";
            vtDados[57] = "8";
            vtDados[58] = "9";
            vtDados[59] = "!";
            vtDados[60] = "@";
            vtDados[61] = "#";
            vtDados[62] = "$";
            vtDados[63] = "%";
            vtDados[64] = "&";
            vtDados[65] = "*";
            vtDados[66] = "(";
            vtDados[67] = "_";
            vtDados[68] = "-";
            vtDados[69] = ")";
            vtDados[70] = "=";
            vtDados[71] = "+";
            vtDados[72] = "/";
            vtDados[73] = ".";
            vtDados[74] = ",";
            vtDados[75] = "'";
            



            int lngValor = 12;
            for (int lngPos = 0; lngPos <= (vtCodigo.Length - 1); lngPos++)
            {
                vtCodigo[lngPos] = lngValor.ToString();
                lngValor += 1;
            }
        }

        private string Criptografar(string strTexto)
        {
            string strCodificacao = "";

            //Ler os caracteres do texto digitado txtDecriptografado
            for (int lngPos = 0; lngPos <= (strTexto.Length - 1); lngPos++)
            {
                //Buscar a posição do caracter extraído do txtDecriptografado
                for (int lngPos2 = 0; lngPos2 <= (vtDados.Length - 1); lngPos2++)
                {
                    if (strTexto.Substring(lngPos, 1) == vtDados[lngPos2])
                    {
                        strCodificacao += vtCodigo[lngPos2];
                        break;
                    }
                }
            }
            return strCodificacao;
        }

        private string Decriptografar(string strTexto)
        {
            string strDecodificacao = "";

            //Ler os caracteres do texto digitado txtDecriptografado
            for (int lngPos = 0; lngPos <= (strTexto.Length - 1); lngPos += 2)
            {
                //Buscar a posição do caracter extraído do txtDecriptografado
                for (int lngPos2 = 0; lngPos2 <= (vtCodigo.Length - 1); lngPos2++)
                {
                    if (strTexto.Substring(lngPos, 2) == vtCodigo[lngPos2])
                    {
                        strDecodificacao += vtDados[lngPos2];
                        break;
                    }
                }
            }
            return strDecodificacao;
        }

        private void chkAdm_CheckedChanged(object sender, EventArgs e)
        {
            adm = 1;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            gridfuncionario func = new gridfuncionario();
            func.Show();

        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {/*
            try
            {
                string strSql = "Select * From tblfuncionario Where codigo = 1";
                pblCmd.Connection = pblCnx;
                pblCmd.CommandText = strSql;
                pblDados = pblCmd.ExecuteReader();
                if (pblDados.HasRows)
                {
                    while (pblDados.HasRows)
                    {
                        pblDados.Read();
                        acesso = pblDados["acesso"].ToString();
                    }
                }

                txtNvSenha.Enabled = true;
                txtNvUsuario.Enabled = true;
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro:" + Erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

            pblDados.Close();
            */
            
            try
            {
                string strSql = "Select * From tblfuncionario Where codigo = '" + txtfunc.Text + "'";
                pblCmd.Connection = pblCnx; 
                pblCmd.CommandText = strSql;
                pblDados = pblCmd.ExecuteReader();
                if (pblDados.HasRows)
                {
                    pblDados.Read();

                    txtNvSenha.Enabled = true;
                    txtNvUsuario.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Funcionário Inexistente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtfunc.Text = "";
                    txtfunc.Focus();
                }
                pblDados.Close();

            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro: " + Erro.Message, "Tratamento de Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        
        }


        
        

    }
}

