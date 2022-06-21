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
    public partial class frmLogin : Form
    {
        public string[] vtDados = new string[77], vtCodigo = new string[77];

        public MySqlConnection pblCnx = new MySqlConnection();
        public MySqlCommand pblCmd = new MySqlCommand();
        public MySqlDataReader pblDados;
        public int usuario;
        public string codfunc;
        public string acesso;
       

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {

            try
            {

                string strSql = "Select * From tblusuario Where usuario = '" + txtUsuario.Text + "' And senha = '" + Criptografar(txtSenha.Text.Trim()) + "' And AdmKey = 0";
                pblCmd.Connection = pblCnx;
                pblCmd.CommandText = strSql;
                pblDados = pblCmd.ExecuteReader();
                if (pblDados.HasRows)
                {
                    pblDados.Close();
                    this.Hide();
                    frmMenucs splash = new frmMenucs();
                    splash.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Senha ou usuários INCORRETOS!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Focus();
                }

                pblDados.Close();



            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro:" + Erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            chave ch = new chave();
            ch.Show();
            Hide();
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
            vtDados[76] = " ";




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

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                pblCnx.ConnectionString = "Server=localhost;Database=bdCadastro;user=root;pwd=root";
                pblCnx.Open();

                CarregarVetores();

            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro:" + Erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnLogar_Click(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string strSql = "Select * From tblusuario Where usuario = '" + txtUsuario.Text + "'";
                pblCmd.Connection = pblCnx;
                pblCmd.CommandText = strSql;
                pblDados = pblCmd.ExecuteReader();
                if (pblDados.HasRows)
                {
                    pblDados.Read();
                    codfunc = pblDados["codfunc"].ToString();

                    
                }
                else
                {
                    MessageBox.Show("Usuário Inexistente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                }
                pblDados.Close();

            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro: " + Erro.Message, "Tratamento de Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                string strSql = "Select * From tblfuncionario Where codigo = '" + codfunc + "'";
                pblCmd.Connection = pblCnx;
                pblCmd.CommandText = strSql;
                pblDados = pblCmd.ExecuteReader();
                if (pblDados.HasRows)
                {
                    pblDados.Read();
                    acesso = pblDados["acesso"].ToString();

                    
                }
                else
                {
                    MessageBox.Show("Funcionário Inexistente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  
                }
                pblDados.Close();

            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro: " + Erro.Message, "Tratamento de Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
                try
                {

                    string strSql = "Select * From tblusuario Where usuario = '" + txtUsuario.Text + "' And senha = '" + Criptografar(txtSenha.Text.Trim()) + "' And AdmKey = 1";
                    pblCmd.Connection = pblCnx;
                    pblCmd.CommandText = strSql;
                    pblDados = pblCmd.ExecuteReader();
                    if (pblDados.HasRows && acesso == "Administrador")
                    {
                       
                       
                            pblDados.Close();
                            usuario = 10;
                            this.Hide();
                            FrmSplash2 splash = new FrmSplash2();
                            splash.ShowDialog();
                        
                    }
                   
                    if (pblDados.HasRows && acesso == "Gerente")
                    {


                        pblDados.Close();
                        usuario = 10;
                        this.Hide();
                        frmMenucs3 menu = new frmMenucs3();
                        menu.ShowDialog();

                    }
                    if (pblDados.HasRows && acesso == "Funcionário Bilheteria")
                    {


                        pblDados.Close();
                        usuario = 10;
                        this.Hide();
                        frmMenucs4 menu = new frmMenucs4();
                        menu.ShowDialog();

                    }
                    if (pblDados.HasRows && acesso == "Funcionário Produtos")
                    {


                        pblDados.Close();
                        usuario = 10;
                        this.Hide();
                        frmMenucs4 menu = new frmMenucs4();
                        menu.ShowDialog();

                    }


                    else
                    {
                        MessageBox.Show("Senha ou usuários INCORRETOS!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsuario.Focus();
                    }

                    pblDados.Close();



                }
                catch (Exception Erro)
                {
                    MessageBox.Show("Erro:" + Erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            
            
        



        private void frmLogin_Activated(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSplash2 splash = new FrmSplash2();
            splash.ShowDialog();
        }

    }
}
