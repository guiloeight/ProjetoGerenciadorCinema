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
    public partial class Cadastrosessoes : Form
    {
        public MySqlConnection pblCnx = new MySqlConnection();
        public MySqlCommand pblCmd = new MySqlCommand();
        public MySqlDataReader pblDados;
        public String genero;
        public String preco;
        public Cadastrosessoes()
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

        private void Cadastrosessoes_Load(object sender, EventArgs e)
        {
            string strSql = "Select * From tblsalas";
          
            pblCmd.Connection = pblCnx;
            pblCmd.CommandText = strSql;
            pblDados = pblCmd.ExecuteReader();
            if (pblDados.HasRows)
            {
                while (pblDados.Read())
                {
                    lbsala.Items.Add(pblDados["ndesalas"].ToString());
                    
                }
            }
            pblDados.Close();
            strSql = "Select * From tblfilme";

            pblCmd.Connection = pblCnx;
            pblCmd.CommandText = strSql;
            pblDados = pblCmd.ExecuteReader();
            if (pblDados.HasRows)
            {
                while (pblDados.Read())
                {
                    
                    cbxfilme.Items.Add(pblDados["filme"].ToString());
                    
                }
            }
            pblDados.Close();

  


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            if (cbxfilme.Text.Equals("") || txthorario.Text.Equals("") || lbsala.Text.Equals("") || cbx3d.Text.Equals("") || cbxfaixa.Text.Equals(""))
            {
                MessageBox.Show("Não se pode cadastrar uma sessão sem as informações necessárias!", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {



                    string
                       
                    strSql = "Insert into tblcadastrosessoes (filme,d3,horario,sala,nome,try,faixa) values(";
                    strSql += "'" + cbxfilme.Text + "',";
                    strSql += "'" + cbx3d.Text + "',";
                    strSql +="'"+ txthorario.Text + "',";
                    strSql += "'" + lbsala.Text + "',";
                    strSql += "'" + txtNome.Text + "',";
                    strSql += "'" + txtTRY.Text + "',";
                    strSql += "'" + cbxfaixa.Text + "')";

                    pblCmd.Connection = pblCnx;
                    pblCmd.CommandText = strSql;
                    pblCmd.ExecuteNonQuery();
                    MessageBox.Show("Nova Sessão Cadastrada!", "Cadastro Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    
                    pblDados.Close();
                    }


                catch (Exception Erro)
                {
                    MessageBox.Show("Erro:" + Erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnLimpar_Click();
                }

            }
        }

        private void cbx3d_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btngrid_Click(object sender, EventArgs e)
        {

        }

        public void btnLimpar_Click()
        {
            cbxfilme.Text = "";
            txthorario.Text = "";
            lbsala.Text = "";
            cbx3d.Text = "";
            txtTRY.Text = "";
            txtNome.Text = "";
            cbxfaixa.Text = "";


        }
        private void cbxfilme_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        public void gerarNome_Click(object sender, EventArgs e)
        {
            string strSql = "Select * From tblfilme Where filme ='"+cbxfilme.Text+"'";

            pblCmd.Connection = pblCnx;
            pblCmd.CommandText = strSql;
            pblDados = pblCmd.ExecuteReader();
            if (pblDados.HasRows)
            {
                pblDados.Read();
                genero = pblDados["genero"].ToString();
                    
                
            }
            pblDados.Close();
            txtNome.Text = cbxfilme.Text + " ("+genero+") às " + txthorario.Text + " na Sala " + lbsala.Text + " - 3D(" + cbx3d.Text+")";
            txtNome.Focus();
        }

        private void gerarNome_Click()
        {
        
        }

        public void TRY_Click(object sender, EventArgs e)
        {
            txtTRY.Text = txthorario.Text + "-" + lbsala.Text;
 
        }
        private void lbsala_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TRY_Click()
        {
        
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Preencha o nome da sessão que deseja excluir!", "Código Vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int usuario = 1;
                try
                {                
                    string strSql = "Select * From tblcadastrosessoes Where nome ='" + txtNome.Text + "'";
                    pblCmd.Connection = pblCnx;
                    pblCmd.CommandText = strSql;
                    pblDados = pblCmd.ExecuteReader();
                    if (pblDados.HasRows)
                    {
                        pblDados.Read();
                        cbxfilme.Text = pblDados["filme"].ToString();
                        txthorario.Text = pblDados["horario"].ToString();
                        cbx3d.Text = pblDados["d3"].ToString();
                        lbsala.Text = pblDados["sala"].ToString();
                        cbxfaixa.Text = pblDados["faixa"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Sessão Inexistente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        if (MessageBox.Show("Deseja excluir a Sessão: " + txtNome.Text, "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            string strSql = "Delete from tblcadastrosessoes Where nome = '" + txtNome.Text + "'";
                            pblCmd.Connection = pblCnx;
                            pblCmd.CommandText = strSql;
                            pblCmd.ExecuteNonQuery();
                            MessageBox.Show("Sessão eliminada!", "Excluído!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                        }
                    }
                    catch (Exception Erro)
                    {
                        MessageBox.Show("Erro: " + Erro.Message, "Tratamento de Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (cbxfilme.Text.Equals("") || txthorario.Text.Equals("") || lbsala.Text.Equals("") || cbx3d.Text.Equals("") || txtNome.Text.Equals(""))
            {
                MessageBox.Show("Não se pode cadastrar uma sessão sem as informações necessárias!", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                {
                    try
                    {
                        string strSql = "Update tblcadastrosessoes set ";
                        strSql += "faixa = '" + cbxfaixa.Text + "',";
                        strSql += "d3 = '" + cbx3d.Text + "',";
                        strSql += "sala = '" + lbsala.Text + "',";
                        strSql += "try = '" + txtTRY.Text + "',";
                        strSql += "filme = '" + cbxfilme.Text + "' ";
                        strSql += "horario = '" + txthorario.Text + "',";
                        strSql += "Where nome = '" + txtNome.Text;

                        pblCmd.Connection = pblCnx;
                        pblCmd.CommandText = strSql;
                        pblCmd.ExecuteNonQuery();
                        MessageBox.Show("Sessão Alterado!", "Alterado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    catch (Exception Erro)
                    {
                        MessageBox.Show("Erro: " + Erro.Message, "Tratamento de Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        private void cbxfaixa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        }

        
        

        
    }

