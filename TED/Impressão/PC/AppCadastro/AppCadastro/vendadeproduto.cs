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
    public partial class vendadeproduto : Form
    {
        public MySqlConnection pblCnx = new MySqlConnection();
        public MySqlCommand pblCmd = new MySqlCommand();
        public MySqlDataReader pblDados;
        public MySqlCommand pblComando = new MySqlCommand();
        public MySqlDataReader pblDataReader;
        private double ValorAPagar;
        public int c = 0;
        private double estoque;
        private String e;
        public vendadeproduto()
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            
                try
                {
                    string strSql = "Select * From tblprodutos Where codigo = " + txtcodigoproduto.Text + "";
                    pblCmd.Connection = pblCnx;
                    pblCmd.CommandText = strSql;
                    pblDados = pblCmd.ExecuteReader();
                    if (pblDados.HasRows)
                    {
                        pblDados.Read();
                        txtdescricao.Text = pblDados["produto"].ToString();
                        txtvalorproduto.Text = pblDados["valordevenda"].ToString();
                                                                    
                    }
                    else
                    {
                        MessageBox.Show("Código Inexistente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    pblDados.Close();
                    txtquantidade.Enabled = true;
                    cbxformadepagamento.Enabled = true;
                    txtvalorpago.Enabled = true;
                    txtcodigoproduto.Enabled = false;
                }
                catch (Exception Erro)
                {
                    MessageBox.Show("Erro: " + Erro.Message, "Tratamento de Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        private void vendadeproduto_Load(object sender, EventArgs e)
        {
            try
            {
                dgProdutos.Enabled = true;
                string ssql;

                ssql = "Select * From tblprodutos Order By codigo ";
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
                        dgProdutos.Rows.Add(pblDataReader["codigo"].ToString(), pblDataReader["produto"].ToString(), pblDataReader["quantidade"].ToString(), pblDataReader["valordecompra"].ToString(), pblDataReader["valordevenda"].ToString());
                    }
                }
                pblDataReader.Close();
                
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro:" + Erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        
        private void txtvalortotal_TextChanged(object sender, EventArgs e)
        {
            if (txtquantidade.Equals(""))
            {
                txtquantidade.Text = ""+0;
            }
            else
            {
                Convert.ToDouble(txtvalortotal.Text = Convert.ToString(Convert.ToDouble(txtvalorproduto.Text) * (Convert.ToDouble(txtquantidade.Text))));
            }
        }

        private void txtquantidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtvalorpago_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttroco_TextChanged(object sender, EventArgs e)
        {
            txttroco.Text = Convert.ToString((Convert.ToDouble(txtvalorpago.Text)) - (Convert.ToDouble(txtvalortotal.Text)));
        }

        private void vendadeproduto_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente Cancelar a venda?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Hide();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
                if (txtquantidade.Text.Equals("1"))
                {
                    lbl1.Text = "" + txtdescricao.Text;
                    pcb1.Image = AppCadastro.Properties.Resources.X;
                    c = 1;

                }
                if (txtquantidade.Text.Equals("2"))
                {
                    lbl1.Text = "" + txtdescricao.Text;
                    lbl2.Text = "" + txtdescricao.Text;
                    pcb1.Image = AppCadastro.Properties.Resources.X;
                    pcb2.Image = AppCadastro.Properties.Resources.X;
                    c = 2;
                }
                if (txtquantidade.Text.Equals("3"))
                {
                    lbl1.Text = "" + txtdescricao.Text;
                    lbl2.Text = "" + txtdescricao.Text;
                    lbl3.Text = "" + txtdescricao.Text;
                    pcb1.Image = AppCadastro.Properties.Resources.X;
                    pcb2.Image = AppCadastro.Properties.Resources.X;
                    pcb3.Image = AppCadastro.Properties.Resources.X;
                    c = 3;
                }
                if (txtquantidade.Text.Equals("4"))
                {
                    lbl1.Text = "" + txtdescricao.Text;
                    lbl2.Text = "" + txtdescricao.Text;
                    lbl3.Text = "" + txtdescricao.Text;
                    lbl4.Text = "" + txtdescricao.Text;
                    pcb1.Image = AppCadastro.Properties.Resources.X;
                    pcb2.Image = AppCadastro.Properties.Resources.X;
                    pcb3.Image = AppCadastro.Properties.Resources.X;
                    pcb4.Image = AppCadastro.Properties.Resources.X;
                    c = 4;
                }
                if (txtquantidade.Text.Equals("5"))
                {
                    lbl1.Text = "" + txtdescricao.Text;
                    lbl2.Text = "" + txtdescricao.Text;
                    lbl3.Text = "" + txtdescricao.Text;
                    lbl4.Text = "" + txtdescricao.Text;
                    lbl5.Text = "" + txtdescricao.Text;
                    pcb1.Image = AppCadastro.Properties.Resources.X;
                    pcb2.Image = AppCadastro.Properties.Resources.X;
                    pcb3.Image = AppCadastro.Properties.Resources.X;
                    pcb4.Image = AppCadastro.Properties.Resources.X;
                    pcb5.Image = AppCadastro.Properties.Resources.X;
                    c = 5;

                }
                if (txtquantidade.Text.Equals("6"))
                {
                    lbl1.Text = "" + txtdescricao.Text;
                    lbl2.Text = "" + txtdescricao.Text;
                    lbl3.Text = "" + txtdescricao.Text;
                    lbl4.Text = "" + txtdescricao.Text;
                    lbl5.Text = "" + txtdescricao.Text;
                    lbl6.Text = "" + txtdescricao.Text;
                    pcb1.Image = AppCadastro.Properties.Resources.X;
                    pcb2.Image = AppCadastro.Properties.Resources.X;
                    pcb3.Image = AppCadastro.Properties.Resources.X;
                    pcb4.Image = AppCadastro.Properties.Resources.X;
                    pcb5.Image = AppCadastro.Properties.Resources.X;
                    pcb6.Image = AppCadastro.Properties.Resources.X;
                    c = 6;

                }
                if (txtquantidade.Text.Equals("7"))
                {
                    lbl1.Text = "" + txtdescricao.Text;
                    lbl2.Text = "" + txtdescricao.Text;
                    lbl3.Text = "" + txtdescricao.Text;
                    lbl4.Text = "" + txtdescricao.Text;
                    lbl5.Text = "" + txtdescricao.Text;
                    lbl6.Text = "" + txtdescricao.Text;
                    lbl7.Text = "" + txtdescricao.Text;
                    pcb1.Image = AppCadastro.Properties.Resources.X;
                    pcb2.Image = AppCadastro.Properties.Resources.X;
                    pcb3.Image = AppCadastro.Properties.Resources.X;
                    pcb4.Image = AppCadastro.Properties.Resources.X;
                    pcb5.Image = AppCadastro.Properties.Resources.X;
                    pcb6.Image = AppCadastro.Properties.Resources.X;
                    pcb7.Image = AppCadastro.Properties.Resources.X;
                    c = 7;

                }
                if (txtquantidade.Text.Equals("8"))
                {
                    lbl1.Text = "" + txtdescricao.Text;
                    lbl2.Text = "" + txtdescricao.Text;
                    lbl3.Text = "" + txtdescricao.Text;
                    lbl4.Text = "" + txtdescricao.Text;
                    lbl5.Text = "" + txtdescricao.Text;
                    lbl6.Text = "" + txtdescricao.Text;
                    lbl7.Text = "" + txtdescricao.Text;
                    lbl8.Text = "" + txtdescricao.Text;
                    pcb1.Image = AppCadastro.Properties.Resources.X;
                    pcb2.Image = AppCadastro.Properties.Resources.X;
                    pcb3.Image = AppCadastro.Properties.Resources.X;
                    pcb4.Image = AppCadastro.Properties.Resources.X;
                    pcb5.Image = AppCadastro.Properties.Resources.X;
                    pcb6.Image = AppCadastro.Properties.Resources.X;
                    pcb7.Image = AppCadastro.Properties.Resources.X;
                    pcb8.Image = AppCadastro.Properties.Resources.X;
                    c = 8;

                }
                if (txtquantidade.Text.Equals("9"))
                {
                    lbl1.Text = "" + txtdescricao.Text;
                    lbl2.Text = "" + txtdescricao.Text;
                    lbl3.Text = "" + txtdescricao.Text;
                    lbl4.Text = "" + txtdescricao.Text;
                    lbl5.Text = "" + txtdescricao.Text;
                    lbl6.Text = "" + txtdescricao.Text;
                    lbl7.Text = "" + txtdescricao.Text;
                    lbl8.Text = "" + txtdescricao.Text;
                    lbl9.Text = "" + txtdescricao.Text;
                    pcb1.Image = AppCadastro.Properties.Resources.X;
                    pcb2.Image = AppCadastro.Properties.Resources.X;
                    pcb3.Image = AppCadastro.Properties.Resources.X;
                    pcb4.Image = AppCadastro.Properties.Resources.X;
                    pcb5.Image = AppCadastro.Properties.Resources.X;
                    pcb6.Image = AppCadastro.Properties.Resources.X;
                    pcb7.Image = AppCadastro.Properties.Resources.X;
                    pcb8.Image = AppCadastro.Properties.Resources.X;
                    pcb9.Image = AppCadastro.Properties.Resources.X;
                    c = 9;

                }
                if (txtquantidade.Text.Equals("10"))
                {
                    lbl1.Text = "" + txtdescricao.Text;
                    lbl2.Text = "" + txtdescricao.Text;
                    lbl3.Text = "" + txtdescricao.Text;
                    lbl4.Text = "" + txtdescricao.Text;
                    lbl5.Text = "" + txtdescricao.Text;
                    lbl6.Text = "" + txtdescricao.Text;
                    lbl7.Text = "" + txtdescricao.Text;
                    lbl8.Text = "" + txtdescricao.Text;
                    lbl9.Text = "" + txtdescricao.Text;
                    lbl10.Text = "" + txtdescricao.Text;
                    pcb1.Image = AppCadastro.Properties.Resources.X;
                    pcb2.Image = AppCadastro.Properties.Resources.X;
                    pcb3.Image = AppCadastro.Properties.Resources.X;
                    pcb4.Image = AppCadastro.Properties.Resources.X;
                    pcb5.Image = AppCadastro.Properties.Resources.X;
                    pcb6.Image = AppCadastro.Properties.Resources.X;
                    pcb7.Image = AppCadastro.Properties.Resources.X;
                    pcb8.Image = AppCadastro.Properties.Resources.X;
                    pcb9.Image = AppCadastro.Properties.Resources.X;
                    pcb10.Image = AppCadastro.Properties.Resources.X;
                    c = 10;

                }
                if (txtquantidade.Text.Equals("11"))
                {
                    lbl1.Text = "" + txtdescricao.Text;
                    lbl2.Text = "" + txtdescricao.Text;
                    lbl3.Text = "" + txtdescricao.Text;
                    lbl4.Text = "" + txtdescricao.Text;
                    lbl5.Text = "" + txtdescricao.Text;
                    lbl6.Text = "" + txtdescricao.Text;
                    lbl7.Text = "" + txtdescricao.Text;
                    lbl8.Text = "" + txtdescricao.Text;
                    lbl9.Text = "" + txtdescricao.Text;
                    lbl10.Text = "" + txtdescricao.Text;
                    lbl11.Text = "" + txtdescricao.Text;
                    pcb1.Image = AppCadastro.Properties.Resources.X;
                    pcb2.Image = AppCadastro.Properties.Resources.X;
                    pcb3.Image = AppCadastro.Properties.Resources.X;
                    pcb4.Image = AppCadastro.Properties.Resources.X;
                    pcb5.Image = AppCadastro.Properties.Resources.X;
                    pcb6.Image = AppCadastro.Properties.Resources.X;
                    pcb7.Image = AppCadastro.Properties.Resources.X;
                    pcb8.Image = AppCadastro.Properties.Resources.X;
                    pcb9.Image = AppCadastro.Properties.Resources.X;
                    pcb10.Image = AppCadastro.Properties.Resources.X;
                    pcb11.Image = AppCadastro.Properties.Resources.X;
                    c = 11;


                }
                if (txtquantidade.Text.Equals("12"))
                {
                    lbl1.Text = "" + txtdescricao.Text;
                    lbl2.Text = "" + txtdescricao.Text;
                    lbl3.Text = "" + txtdescricao.Text;
                    lbl4.Text = "" + txtdescricao.Text;
                    lbl5.Text = "" + txtdescricao.Text;
                    lbl6.Text = "" + txtdescricao.Text;
                    lbl7.Text = "" + txtdescricao.Text;
                    lbl8.Text = "" + txtdescricao.Text;
                    lbl9.Text = "" + txtdescricao.Text;
                    lbl11.Text = "" + txtdescricao.Text;
                    lbl12.Text = "" + txtdescricao.Text;
                    pcb1.Image = AppCadastro.Properties.Resources.X;
                    pcb2.Image = AppCadastro.Properties.Resources.X;
                    pcb3.Image = AppCadastro.Properties.Resources.X;
                    pcb4.Image = AppCadastro.Properties.Resources.X;
                    pcb5.Image = AppCadastro.Properties.Resources.X;
                    pcb6.Image = AppCadastro.Properties.Resources.X;
                    pcb7.Image = AppCadastro.Properties.Resources.X;
                    pcb8.Image = AppCadastro.Properties.Resources.X;
                    pcb9.Image = AppCadastro.Properties.Resources.X;
                    pcb10.Image = AppCadastro.Properties.Resources.X;
                    pcb11.Image = AppCadastro.Properties.Resources.X;
                    pcb12.Image = AppCadastro.Properties.Resources.X;
                    c = 12;
                }



                estoque = Convert.ToDouble(txtquantidade.Text);
                ValorAPagar += Convert.ToDouble(txtvalortotal.Text);
                txtValorAPagar.Text = Convert.ToString(ValorAPagar);
                //Limpa produto
                txtdescricao.Text = "";
                txtcodigoproduto.Text = "";
                txtcodigoproduto.Enabled = true;
                txtquantidade.Text = "";
                txtquantidade.Enabled = false;
                txtvalorproduto.Text = "";
                txtvalortotal.Text = "";
        }

        private void pcb1_Click(object sender, EventArgs e)
        {
            try
            {
                string strSql = "Update tblcliente set ";
                strSql += "estoque = '" + estoque + "' ";
                strSql += "Where descricao = " + txtdescricao.Text;

                pblCmd.Connection = pblCnx;
                pblCmd.CommandText = strSql;
                pblCmd.ExecuteNonQuery();
                MessageBox.Show("Cliente Alterado!", "Alterado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Impossível excluir. Cancele a compra.", "Tratamento de Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        }
        }
    

