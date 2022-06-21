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
        public int blnSaida = 0;
        private double ValorAPagar;
        public int c = 0;
        private double estoque;
        private double qnt;
        private int prod = 1;
        
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
                    qnt = pblDados["quantidade"].GetHashCode();
                    txtquantidade.Enabled = true;
                    cbxformadepagamento.Enabled = true;
                    txtvalorpago.Enabled = true;
                    txtcodigoproduto.Enabled = false;

                }
                else
                {
                    MessageBox.Show("Código Inexistente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                pblDados.Close();
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
                blnSaida = 0;
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
            prod = 1;
            //Limpa produto
            txtdescricao.Text = "";
            txtcodigoproduto.Text = "";
            txtcodigoproduto.Enabled = true;
            txtquantidade.Text = "0";
            txtquantidade.Enabled = false;
            txtvalorproduto.Text = "0";
            txtvalortotal.Text = "0";
            txtcodigoproduto.Focus();

            lbl1.Text = "";
            lbl2.Text = "";
            lbl3.Text = "";
            lbl4.Text = "";
            lbl5.Text = "";
            lbl6.Text = "";
            lbl7.Text = "";
            lbl8.Text = "";
            lbl9.Text = "";
            lbl10.Text = "";
            lbl11.Text = "";
            lbl12.Text = "";
            lbl13.Text = "";
            lbl14.Text = "";
            lbl15.Text = "";
            lbl16.Text = "";
            lbl17.Text = "";
            lbl18.Text = "";
            lbl19.Text = "";
            lbl20.Text = "";
            lbl21.Text = "";
            lbl22.Text = "";
            lbl23.Text = "";
            lbl24.Text = "";
            lbl25.Text = "";
            lbl26.Text = "";
            lbl27.Text = "";
            lbl28.Text = "";
            lbl29.Text = "";
            lbl30.Text = "";

        }

        private void txtvalortotal_TextChanged(object sender, EventArgs e)
        {
            if (txtquantidade.Equals(""))
            {
                txtquantidade.Text = "" + 0;
            }
            else
            {
                double eu = Convert.ToDouble(txtquantidade.Text);

                if (eu <= qnt)
                {
                    Convert.ToDouble(txtvalortotal.Text = Convert.ToString(Convert.ToDouble(txtvalorproduto.Text) * (Convert.ToDouble(txtquantidade.Text))));
                }
                else
                {
                    MessageBox.Show("Não há produto suficiente para esta quantidade.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
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
            if (blnSaida == 0)
            {
                blnSaida = 1;
                if (MessageBox.Show("Deseja realmente Cancelar a venda?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {


                    if (prod == 1)
                    {
                        Close();
                    }
                    else if (prod == 2)
                    {
                        try
                        {

                            qnt = Convert.ToDouble(lbl3.Text);
                            string strSql = "Update tblprodutos set ";
                            strSql += "quantidade = quantidade +" + qnt;
                            strSql += " Where codigo = " + lbl1.Text;

                            pblCmd.Connection = pblCnx;
                            pblCmd.CommandText = strSql;
                            pblCmd.ExecuteNonQuery();
                            MessageBox.Show("Venda Cancelada!", "Alterado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        catch (Exception Erro)
                        {

                            MessageBox.Show("-1Erro:" + Erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else if (prod == 3)
                    {
                        try
                        {

                            qnt = Convert.ToDouble(lbl3.Text);
                            string strSql = "Update tblprodutos set ";
                            strSql += "quantidade = quantidade + " + qnt;
                            strSql += " Where codigo = " + lbl1.Text;

                            pblCmd.Connection = pblCnx;
                            pblCmd.CommandText = strSql;
                            pblCmd.ExecuteNonQuery();
                            //MessageBox.Show("Parabens Bruno!", "Alterado!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        catch (Exception Erro)
                        {

                            MessageBox.Show("0Erro:" + Erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        } try
                        {

                            qnt = Convert.ToDouble(lbl6.Text);
                            string strSql = "Update tblprodutos set ";
                            strSql += "quantidade = quantidade +" + qnt;
                            strSql += " Where codigo = " + lbl4.Text;

                            pblCmd.Connection = pblCnx;
                            pblCmd.CommandText = strSql;
                            pblCmd.ExecuteNonQuery();
                            MessageBox.Show("Venda Cancelada! 2 Itens.", "Alterado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        catch (Exception Erro)
                        {

                            MessageBox.Show("1Erro:" + Erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else if (prod == 4)
                    {
                        try
                        {

                            qnt = Convert.ToDouble(lbl3.Text);
                            string strSql = "Update tblprodutos set ";
                            strSql += "quantidade = quantidade +" + qnt;
                            strSql += " Where codigo = " + lbl1.Text;

                            pblCmd.Connection = pblCnx;
                            pblCmd.CommandText = strSql;
                            pblCmd.ExecuteNonQuery();
                            //MessageBox.Show("Parabens Bruno!", "Alterado!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        catch (Exception Erro)
                        {

                            MessageBox.Show("2Erro:" + Erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        } try
                        {

                            qnt = Convert.ToDouble(lbl6.Text);
                            string strSql = "Update tblprodutos set ";
                            strSql += "quantidade = quantidade +" + qnt;
                            strSql += " Where codigo = " + lbl4.Text;

                            pblCmd.Connection = pblCnx;
                            pblCmd.CommandText = strSql;
                            pblCmd.ExecuteNonQuery();
                            //MessageBox.Show("Parabens Bruno!", "Alterado!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        catch (Exception Erro)
                        {

                            MessageBox.Show("3Erro:" + Erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        try
                        {

                            qnt = Convert.ToDouble(lbl9.Text);
                            string strSql = "Update tblprodutos set ";
                            strSql += "quantidade = quantidade +" + qnt;
                            strSql += " Where codigo = " + lbl7.Text;

                            pblCmd.Connection = pblCnx;
                            pblCmd.CommandText = strSql;
                            pblCmd.ExecuteNonQuery();
                            MessageBox.Show("Venda Cancelada! 3 Itens.", "Alterado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        catch (Exception Erro)
                        {

                            MessageBox.Show("4Erro:" + Erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (prod == 5)
                    {
                        try
                        {

                            qnt = Convert.ToDouble(lbl3.Text);
                            string strSql = "Update tblprodutos set ";
                            strSql += "quantidade = quantidade +" + qnt;
                            strSql += " Where codigo = " + lbl1.Text;

                            pblCmd.Connection = pblCnx;
                            pblCmd.CommandText = strSql;
                            pblCmd.ExecuteNonQuery();
                            //MessageBox.Show("Parabens Bruno!", "Alterado!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        catch (Exception Erro)
                        {

                            MessageBox.Show("5Erro:" + Erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        try
                        {

                            qnt = Convert.ToDouble(lbl6.Text);
                            string strSql = "Update tblprodutos set ";
                            strSql += "quantidade = quantidade +" + qnt;
                            strSql += " Where codigo = " + lbl4.Text;

                            pblCmd.Connection = pblCnx;
                            pblCmd.CommandText = strSql;
                            pblCmd.ExecuteNonQuery();
                            //MessageBox.Show("Parabens Bruno!", "Alterado!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        catch (Exception Erro)
                        {

                            MessageBox.Show("6Erro:" + Erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        try
                        {

                            qnt = Convert.ToDouble(lbl9.Text);
                            string strSql = "Update tblprodutos set ";
                            strSql += "quantidade = quantidade +" + qnt;
                            strSql += " Where codigo = " + lbl7.Text;

                            pblCmd.Connection = pblCnx;
                            pblCmd.CommandText = strSql;
                            pblCmd.ExecuteNonQuery();
                            //MessageBox.Show("Parabens Bruno!", "Alterado!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        catch (Exception Erro)
                        {

                            MessageBox.Show("7Erro:" + Erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        try
                        {

                            qnt = Convert.ToDouble(lbl12.Text);
                            string strSql = "Update tblprodutos set ";
                            strSql += "quantidade = quantidade +" + qnt;
                            strSql += " Where codigo = " + lbl10.Text;

                            pblCmd.Connection = pblCnx;
                            pblCmd.CommandText = strSql;
                            pblCmd.ExecuteNonQuery();
                            MessageBox.Show("Venda Cancelada! 4 Itens", "Alterado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        catch (Exception Erro)
                        {

                            MessageBox.Show("8Erro:" + Erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }

            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //lbl12.Text = "Quantidade: " + qnt;
            /*if (txtquantidade.Text.Equals("1"))
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
            */
            if (Convert.ToDouble(txtquantidade.Text) == 0 || txtquantidade.Equals(""))
            {
                MessageBox.Show("Digite a quantidade do produto.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                double eu = Convert.ToDouble(txtquantidade.Text);
                int pode = 0;
                if (eu <= qnt)
                {
                    Convert.ToDouble(txtvalortotal.Text = Convert.ToString(Convert.ToDouble(txtvalorproduto.Text) * (Convert.ToDouble(txtquantidade.Text))));
                }
                else
                {
                    MessageBox.Show("Não há produto suficiente para esta quantidade.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pode = 1;

                }
                if (pode == 0)
                {
                    int a = 1;
                    estoque = Convert.ToDouble(txtquantidade.Text);
                    ValorAPagar += Convert.ToDouble(txtvalortotal.Text);
                    txtValorAPagar.Text = Convert.ToString(ValorAPagar);
                    if (prod == 1)
                    {
                        lbl1.Text = "" + txtcodigoproduto.Text; ;
                        lbl2.Text = "" + txtdescricao.Text;
                        lbl3.Text = "" + txtquantidade.Text;
                        prod += 1;
                    }
                    else if (prod == 2)
                    {
                        lbl4.Text = "" + txtcodigoproduto.Text; ;
                        lbl5.Text = "" + txtdescricao.Text;
                        lbl6.Text = "" + txtquantidade.Text;
                        prod += 1;
                    }
                    else if (prod == 3)
                    {
                        lbl7.Text = "" + txtcodigoproduto.Text; ;
                        lbl8.Text = "" + txtdescricao.Text;
                        lbl9.Text = "" + txtquantidade.Text;
                        prod += 1;
                    }
                    else if (prod == 4)
                    {
                        lbl10.Text = "" + txtcodigoproduto.Text; ;
                        lbl11.Text = "" + txtdescricao.Text;
                        lbl12.Text = "" + txtquantidade.Text;
                        prod += 1;
                    }
                    else if (prod == 5)
                    {
                        lbl13.Text = "" + txtcodigoproduto.Text; ;
                        lbl14.Text = "" + txtdescricao.Text;
                        lbl15.Text = "" + txtquantidade.Text;
                        prod += 1;
                    }
                    else if (prod == 6)
                    {
                        lbl16.Text = "" + txtcodigoproduto.Text; ;
                        lbl17.Text = "" + txtdescricao.Text;
                        lbl18.Text = "" + txtquantidade.Text;
                        prod += 1;
                    }
                    else if (prod == 7)
                    {
                        lbl19.Text = "" + txtcodigoproduto.Text; ;
                        lbl20.Text = "" + txtdescricao.Text;
                        lbl21.Text = "" + txtquantidade.Text;
                        prod += 1;
                    }
                    else if (prod == 8)
                    {
                        lbl22.Text = "" + txtcodigoproduto.Text; ;
                        lbl23.Text = "" + txtdescricao.Text;
                        lbl24.Text = "" + txtquantidade.Text;
                        prod += 1;
                    }
                    else if (prod == 9)
                    {
                        lbl25.Text = "" + txtcodigoproduto.Text; ;
                        lbl26.Text = "" + txtdescricao.Text;
                        lbl27.Text = "" + txtquantidade.Text;
                        prod += 1;
                    }
                    else if (prod == 10)
                    {
                        lbl28.Text = "" + txtcodigoproduto.Text; ;
                        lbl29.Text = "" + txtdescricao.Text;
                        lbl30.Text = "" + txtquantidade.Text;
                        prod += 1;
                    }
                    
                    else if(prod > 10)
                    {
                        MessageBox.Show("Não é possivel inserir mais produtos a esta venda, finalize esta venda e crie uma nova.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        a = 0;

                    }
                    if (a == 1)
                    {
                        try
                        {

                            qnt = qnt - Convert.ToDouble(txtquantidade.Text);
                            string strSql = "Update tblprodutos set ";
                            strSql += "quantidade = " + qnt;
                            strSql += " Where codigo = " + txtcodigoproduto.Text;

                            pblCmd.Connection = pblCnx;
                            pblCmd.CommandText = strSql;
                            pblCmd.ExecuteNonQuery();
                            MessageBox.Show("Item inserido na compra.", "Inserido!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            gbVenda.Enabled= true;
                        }
                        catch (Exception Erro)
                        {

                            MessageBox.Show("Erro:" + Erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }



                    //Limpa produto
                    txtdescricao.Text = "";
                    txtcodigoproduto.Text = "";
                    txtcodigoproduto.Enabled = true;
                    txtquantidade.Text = "0";
                    txtquantidade.Enabled = false;
                    txtvalorproduto.Text = "0";
                    txtvalortotal.Text = "0";

                }


            }
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

        private void btnCancelarProd_Click(object sender, EventArgs e)
        {
            txtcodigoproduto.Enabled = true;
            txtdescricao.Enabled = false;
            txtvalorproduto.Enabled = false;
            txtquantidade.Enabled = false;
            txtcodigoproduto.Text = "";
            txtdescricao.Text = "";
            txtvalorproduto.Text = "0";
            txtquantidade.Text = "0";
            txtvalortotal.Text = "0";
            txtcodigoproduto.Focus();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
            /*if (MessageBox.Show("Deseja realmente Cancelar a venda?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                                

                if (prod == 1)
                {
                    Close();
                }
                else if (prod == 2)
                {
                    try
                    {

                        qnt = Convert.ToDouble(lbl3.Text);
                        string strSql = "Update tblprodutos set ";
                        strSql += "quantidade = quantidade +" + qnt;
                        strSql += " Where codigo = " + lbl1.Text;

                        pblCmd.Connection = pblCnx;
                        pblCmd.CommandText = strSql;
                        pblCmd.ExecuteNonQuery();
                        MessageBox.Show("Venda Cancelada!", "Alterado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    catch (Exception Erro)
                    {

                        MessageBox.Show("-1Erro:" + Erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else if (prod == 3)
                {
                    try
                    {

                        qnt = Convert.ToDouble(lbl3.Text);
                        string strSql = "Update tblprodutos set ";
                        strSql += "quantidade = quantidade + " + qnt;
                        strSql += " Where codigo = " + lbl1.Text;

                        pblCmd.Connection = pblCnx;
                        pblCmd.CommandText = strSql;
                        pblCmd.ExecuteNonQuery();
                        //MessageBox.Show("Parabens Bruno!", "Alterado!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception Erro)
                    {

                        MessageBox.Show("0Erro:" + Erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    } try
                    {

                        qnt = Convert.ToDouble(lbl6.Text);
                        string strSql = "Update tblprodutos set ";
                        strSql += "quantidade = quantidade +" + qnt;
                        strSql += " Where codigo = " + lbl4.Text;

                        pblCmd.Connection = pblCnx;
                        pblCmd.CommandText = strSql;
                        pblCmd.ExecuteNonQuery();
                        MessageBox.Show("Venda Cancelada! 2 Itens.", "Alterado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    catch (Exception Erro)
                    {

                        MessageBox.Show("1Erro:" + Erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else if (prod == 4)
                {
                    try
                    {

                        qnt = Convert.ToDouble(lbl3.Text);
                        string strSql = "Update tblprodutos set ";
                        strSql += "quantidade = quantidade +" + qnt;
                        strSql += " Where codigo = " + lbl1.Text;

                        pblCmd.Connection = pblCnx;
                        pblCmd.CommandText = strSql;
                        pblCmd.ExecuteNonQuery();
                        //MessageBox.Show("Parabens Bruno!", "Alterado!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception Erro)
                    {

                        MessageBox.Show("2Erro:" + Erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    } try
                    {

                        qnt = Convert.ToDouble(lbl6.Text);
                        string strSql = "Update tblprodutos set ";
                        strSql += "quantidade = quantidade +" + qnt;
                        strSql += " Where codigo = " + lbl4.Text;

                        pblCmd.Connection = pblCnx;
                        pblCmd.CommandText = strSql;
                        pblCmd.ExecuteNonQuery();
                        //MessageBox.Show("Parabens Bruno!", "Alterado!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception Erro)
                    {

                        MessageBox.Show("3Erro:" + Erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    try
                    {

                        qnt = Convert.ToDouble(lbl9.Text);
                        string strSql = "Update tblprodutos set ";
                        strSql += "quantidade = quantidade +" + qnt;
                        strSql += " Where codigo = " + lbl7.Text;

                        pblCmd.Connection = pblCnx;
                        pblCmd.CommandText = strSql;
                        pblCmd.ExecuteNonQuery();
                        MessageBox.Show("Venda Cancelada! 3 Itens.", "Alterado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    catch (Exception Erro)
                    {

                        MessageBox.Show("4Erro:" + Erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (prod == 5)
                {
                    try
                    {

                        qnt = Convert.ToDouble(lbl3.Text);
                        string strSql = "Update tblprodutos set ";
                        strSql += "quantidade = quantidade +" + qnt;
                        strSql += " Where codigo = " + lbl1.Text;

                        pblCmd.Connection = pblCnx;
                        pblCmd.CommandText = strSql;
                        pblCmd.ExecuteNonQuery();
                        //MessageBox.Show("Parabens Bruno!", "Alterado!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception Erro)
                    {

                        MessageBox.Show("5Erro:" + Erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    try
                    {

                        qnt = Convert.ToDouble(lbl6.Text);
                        string strSql = "Update tblprodutos set ";
                        strSql += "quantidade = quantidade +" + qnt;
                        strSql += " Where codigo = " + lbl4.Text;

                        pblCmd.Connection = pblCnx;
                        pblCmd.CommandText = strSql;
                        pblCmd.ExecuteNonQuery();
                        //MessageBox.Show("Parabens Bruno!", "Alterado!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception Erro)
                    {

                        MessageBox.Show("6Erro:" + Erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    try
                    {

                        qnt = Convert.ToDouble(lbl9.Text);
                        string strSql = "Update tblprodutos set ";
                        strSql += "quantidade = quantidade +" + qnt;
                        strSql += " Where codigo = " + lbl7.Text;

                        pblCmd.Connection = pblCnx;
                        pblCmd.CommandText = strSql;
                        pblCmd.ExecuteNonQuery();
                        //MessageBox.Show("Parabens Bruno!", "Alterado!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception Erro)
                    {

                        MessageBox.Show("7Erro:" + Erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    try
                    {

                        qnt = Convert.ToDouble(lbl12.Text);
                        string strSql = "Update tblprodutos set ";
                        strSql += "quantidade = quantidade +" + qnt;
                        strSql += " Where codigo = " + lbl10.Text;

                        pblCmd.Connection = pblCnx;
                        pblCmd.CommandText = strSql;
                        pblCmd.ExecuteNonQuery();
                        MessageBox.Show("Venda Cancelada! 4 Itens", "Alterado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    catch (Exception Erro)
                    {

                        MessageBox.Show("8Erro:" + Erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dgProdutos.Enabled = true;
                dgProdutos.Rows.Clear();
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

        private void btnConsultar_Click()
        {

        }

        private void btnTroco(object sender, EventArgs e)
        {
            txttroco.Text = ""+(Convert.ToDouble(txtvalorpago.Text) - (Convert.ToDouble(txtValorAPagar.Text)));
            if (Convert.ToDouble(txttroco.Text) < 0)
            {
                MessageBox.Show("O valor pago é insuficiente.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txttroco.Text = "";
                txtvalorpago.Focus();
            }
        }


    }
}