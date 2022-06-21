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
    public partial class Cadastrosalas : Form
    {
        public MySqlConnection pblCnx = new MySqlConnection();
        public MySqlCommand pblCmd = new MySqlCommand();
        public MySqlDataReader pblDados;
        public MySqlCommand pblComando = new MySqlCommand();
        public MySqlDataReader pblDataReader;
  
    
        public Cadastrosalas()
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

        private void btnadicionar_Click(object sender, EventArgs e)
        {

            if (txtnumerodasala.Text.Equals("") || txtnumerodelugares.Text.Equals(""))
            {
                MessageBox.Show("Não se pode cadastrar uma sala sem as informações necessárias!", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {

                 
                    
                        string strSql = "Insert into tblsalas (ndesalas,ndelugares) values(";
                        strSql += "'" + txtnumerodasala.Text + "',";
                        strSql += txtnumerodelugares.Text + ")";

                        pblCmd.Connection = pblCnx;
                        pblCmd.CommandText = strSql;
                        pblCmd.ExecuteNonQuery();
                        MessageBox.Show("Nova Sala Cadastrada!", "Cadastro Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnLimpar_Click(sender, e);
                        txtnumerodasala.Focus();
                    
                }
                catch
                {
                    MessageBox.Show("Cadastro já existente", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void Cadastrosalas_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            btnLimpar_Click(sender, e);
            Hide();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtnumerodasala.Text == "")
            {
                MessageBox.Show("Preencha o Número da Sala que deseja excluir!", "Código Vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int usuario = 1;
                try
                {


                    string strSql = "Select * From tblsalas Where codigo = " + txtnumerodasala.Text + "";
                    pblCmd.Connection = pblCnx;
                    pblCmd.CommandText = strSql;
                    pblDados = pblCmd.ExecuteReader();
                    if (pblDados.HasRows)
                    {
                        pblDados.Read();
                        txtnumerodasala.Text = pblDados["ndesalas"].ToString();
                        txtnumerodelugares.Text = pblDados["ndelugares"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Usuario Inexistente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtnumerodasala.Focus();
                        //limpando
                        txtnumerodasala.Text = "";
                        txtnumerodelugares.Text = "";

                        //limpado
                        usuario = 0;
                    }
                    pblDados.Close(); ;

                }
                catch (Exception Erro)
                {
                    MessageBox.Show("Erro: " + Erro.Message, "Tratamento de Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (usuario == 1)
                {
                    try
                    {
                        if (MessageBox.Show("Deseja excluir a sala: " + txtnumerodasala.Text, "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            string strSql = "Delete from tblsalas Where ndesalas = " + txtnumerodasala.Text + "";
                            pblCmd.Connection = pblCnx;
                            pblCmd.CommandText = strSql;
                            pblCmd.ExecuteNonQuery();
                            MessageBox.Show("Sala excluída!", "Excluído!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnLimpar_Click(sender, e);
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
            if (txtnumerodasala.Text.Equals("") || txtnumerodelugares.Text.Equals(""))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            }
            else
            {
                try
                {
                    string strSql = "Update tblsalas  set ";
                    strSql += "ndelugares = " + txtnumerodelugares.Text;

                    strSql += " Where ndesalas = " + txtnumerodasala.Text;

                    pblCmd.Connection = pblCnx;
                    pblCmd.CommandText = strSql;
                    pblCmd.ExecuteNonQuery();
                    MessageBox.Show("Sala Alterada!", "Alterada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLimpar_Click(sender, e);
                }
                catch (Exception Erro)
                {
                    MessageBox.Show("Prenchar o Campo Número da Sala" + Erro.Message, "Tratamento de Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            
             try
            {
                dgvsala.Rows.Clear();
                dgvsala.Enabled = true;
                string ssql;

                ssql = "Select * From tblsalas Order By ndesalas ";
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
                        dgvsala.Rows.Add( pblDataReader["ndesalas"].ToString(), pblDataReader["ndelugares"].ToString());
                    }
                }
                pblDataReader.Close();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro:" + Erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }

        private void dgvsala_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    
        }
    }
