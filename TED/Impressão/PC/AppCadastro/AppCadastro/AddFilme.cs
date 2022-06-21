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
    public partial class AddFilme : Form
    {
        public MySqlConnection pblCnx = new MySqlConnection();
        public MySqlCommand pblCmd = new MySqlCommand();
        public MySqlDataReader pblDados;
        public double d=0, dub=0, leg=0;
        public AddFilme()
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
        public void Limpar()
        {
            txtNomeFilme.Text = "";
            txtPreco.Text = "";
            txtGenero.Text = "";
           
        }



        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtNomeFilme.Text.Equals("") || txtGenero.Text.Equals("") || txtPreco.Text.Equals(""))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            }
            else
            {
                try
                {

                    string strSql = "Insert into tblfilme (filme, genero, preco ) values(";
                    strSql += "'" + txtNomeFilme.Text + "',";
                    strSql += "'" + txtGenero.Text + "',";
                    strSql += txtPreco.Text + ")";



                    pblCmd.Connection = pblCnx;
                    pblCmd.CommandText = strSql;
                    pblCmd.ExecuteNonQuery();
                    MessageBox.Show("Novo Filme Adicionado!", "Adicionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpar();
                }
                catch (Exception Erro)
                {
                    MessageBox.Show("Erro:" + Erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtNomeFilme.Text == "")
            {
                MessageBox.Show("Digite o Filme que deseja excluir!", "Filme Vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int usuario = 1;
                try
                {


                    string strSql = "Select * From tblfilme Where filme = '" + txtNomeFilme.Text + "'";
                    pblCmd.Connection = pblCnx;
                    pblCmd.CommandText = strSql;
                    pblDados = pblCmd.ExecuteReader();
                    if (pblDados.HasRows)
                    {
                        pblDados.Read();
                        txtNomeFilme.Text = pblDados["filme"].ToString();
                        txtGenero.Text = pblDados["genero"].ToString();
                        txtPreco.Text = pblDados["preco"].ToString();

                    }
                    else
                    {
                        MessageBox.Show("Filme Inexistente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNomeFilme.Focus();
                        //limpando
                        txtNomeFilme.Text = "";
                        txtGenero.Text = "";
                        txtPreco.Text = "";
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
                        if (MessageBox.Show("Deseja excluir o filme: " + txtNomeFilme.Text, "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            string strSql = "Delete from tblfilme Where filme = '" + txtNomeFilme.Text + "'";
                            pblCmd.Connection = pblCnx;
                            pblCmd.CommandText = strSql;
                            pblCmd.ExecuteNonQuery();

                            MessageBox.Show("Filme Excluido!", "Excluído!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpar();
                        }
                        else
                        {
                            MessageBox.Show("Filme Inexistente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception Erro)
                    {
                        MessageBox.Show("Erro: " + Erro.Message, "Tratamento de Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtNomeFilme.Text.Equals("") || txtGenero.Text.Equals("") || txtPreco.Text.Equals(""))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            }
            else
            {
                try
                {
                    string strSql = "Update tblfilme set ";
                    strSql += "genero = '" + txtGenero.Text + "',  ";
                    strSql += "preco = '" + txtPreco.Text + "'";
                    strSql += "Where filme = '" + txtNomeFilme.Text + "'";

                    pblCmd.Connection = pblCnx;
                    pblCmd.CommandText = strSql;
                    pblCmd.ExecuteNonQuery();
                    MessageBox.Show("Filme Alterado!", "Alterado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpar();
                }
                catch (Exception Erro)
                {
                    MessageBox.Show("Erro: " + Erro.Message, "Tratamento de Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AddFilme_Load(object sender, EventArgs e)
        {
           
        }

      

        private void btngrid_Click(object sender, EventArgs e)
        {
            GridFilme gridfilme = new GridFilme();
            gridfilme.Show();
        }

        private void lbsala_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
