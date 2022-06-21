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
    public partial class Produtos : Form
    {
         public bool blnPrimeira = true;
        public int paginaAtual = 1;
        public string Empresa = "Chaplin";
        public string RelatorioTitulo;
        public MySqlConnection pblCnx = new MySqlConnection();
        public MySqlCommand pblCmd = new MySqlCommand();
        public MySqlDataReader pblDados;
        
        public MySqlCommand pblComando = new MySqlCommand();
        public MySqlDataReader pblDataReader;
        public int lngLinha = 1;

        public Produtos()
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

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja excluir o Produto de Código: " + txtCodigo.Text, "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    string strSql = "Delete from tblprodutos Where codigo = " + txtCodigo.Text + "";
                    pblCmd.Connection = pblCnx;
                    pblCmd.CommandText = strSql;
                    pblCmd.ExecuteNonQuery();
                    MessageBox.Show("Produto eliminado!", "Excluído!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnlimpar_Click(sender, e);
                }
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro: " + Erro.Message, "Tratamento de Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {

                string strSql = "Insert into tblprodutos (produto,quantidade,valordecompra,valordevenda) values(";
              
                strSql += "'" + txtProduto.Text + "',";
                strSql += "'" + txtQuantidade.Text + "',";
                strSql +="'" + txtValorCompra.Text + "',";
                strSql += txtValorVenda.Text + ")";


                pblCmd.Connection = pblCnx;
                pblCmd.CommandText = strSql;
                pblCmd.ExecuteNonQuery();
                MessageBox.Show("Novo Produto Adicionado!", "Adicionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnlimpar_Click(sender, e);
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro:" + Erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
            }
        private void lblproduto_Click(object sender, EventArgs e)
        {

        }

        private void txtProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblquantidade_Click(object sender, EventArgs e)
        {

        }

        private void lblvalordacompra_Click(object sender, EventArgs e)
        {

        }

        private void Produtos_Load(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {

        }

        private void btnhabilitar_Click(object sender, EventArgs e)
        {
            txtCodigo.Enabled = true;
            txtCodigo.Focus();
        }

        private void btndesabilitar_Click(object sender, EventArgs e)
        {
            txtCodigo.Enabled = false;
            txtProduto.Focus();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
             try
            {
                string strSql = "Update tblprodutos set ";
                strSql += "produto = '" + txtProduto.Text + "',";
                strSql += "quantidade = '" + txtQuantidade.Text + "',";
                strSql += "valordecompra = '" + txtValorCompra.Text + "',";
                strSql += "valordevenda = '" + txtValorVenda.Text + "' ";
                strSql += "Where codigo = " + txtCodigo.Text;

                pblCmd.Connection = pblCnx;
                pblCmd.CommandText = strSql;
                pblCmd.ExecuteNonQuery(); 
                MessageBox.Show("Produto Alterado!", "Alterado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnlimpar_Click(sender, e);
            }
              catch (Exception Erro)
            {
                MessageBox.Show("Erro:" + Erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {//Variáveis das Linhas
            float LinhasPorPagina = 0;
            float PosicaoDaLinha = 0;
            int LinhaAtual = 0;
            //Variável para Passar um Traço
            Pen Risco = new Pen(Color.Black, 1);
            //Define as Fontes
            Font FonteNegrito = new Font("Arial", 9, FontStyle.Bold);
            Font FonteTitulo = new Font("Arial", 15, FontStyle.Bold);
            Font FonteSubTitulo = new Font("Arial", 12, FontStyle.Bold);
            Font FonteRodape = new Font("Arial", 8);
            Font FonteNormal = new Font("Arial", 9);
            //Cabecalho
            e.Graphics.DrawLine(Risco, e.MarginBounds.Left, 60, e.MarginBounds.Right, 60);
            e.Graphics.DrawLine(Risco, e.MarginBounds.Left, 160, e.MarginBounds.Right, 160);
            //Nome da Empresa
            e.Graphics.DrawString(Empresa, FonteTitulo, Brushes.Red, e.MarginBounds.Left + 10, 80, new StringFormat());
            //Imagem
            e.Graphics.DrawString(RelatorioTitulo + System.DateTime.Now, FonteSubTitulo, Brushes.Black, e.MarginBounds.Left + 320, 120, new StringFormat());
            //Campos a Serem Impressos: Código, Nome e Sexo
            e.Graphics.DrawString("Código", FonteNegrito, Brushes.Black, e.MarginBounds.Left + 50, 170, new StringFormat());
            e.Graphics.DrawString("Produto", FonteNegrito, Brushes.Black, e.MarginBounds.Left + 100, 170, new StringFormat());
            e.Graphics.DrawString("Quantidade", FonteNegrito, Brushes.Black, e.MarginBounds.Left + 200, 170, new StringFormat());
            e.Graphics.DrawString("Valor de Compra ", FonteNegrito, Brushes.Black, e.MarginBounds.Left + 300, 170, new StringFormat());
            e.Graphics.DrawString("Valor de Venda ", FonteNegrito, Brushes.Black, e.MarginBounds.Left + 450, 170, new StringFormat());
            e.Graphics.DrawLine(Risco, e.MarginBounds.Left, 190, e.MarginBounds.Right, 190);
            //Linha por Página
            LinhasPorPagina = Convert.ToInt32(e.MarginBounds.Height / FonteNormal.GetHeight(e.Graphics) - 9);
            //Aqui são Lidos os Dados
            while ((LinhaAtual < LinhasPorPagina && pblDados.Read()))
            {
                //Obtém os Valores do DataReader
                string codigo = pblDados["codigo"].ToString();
                string nome = pblDados["produto"].ToString();
                string telefone = pblDados["quantidade"].ToString();
                string endereco = pblDados["valordecompra"].ToString();
                string venda = pblDados["valordevenda"].ToString();
                //Inicia a Impressão
                PosicaoDaLinha = e.MarginBounds.Top + 100 + (LinhaAtual * FonteNormal.GetHeight(e.Graphics));
                e.Graphics.DrawString(codigo.ToString(), FonteNormal, Brushes.Black, e.MarginBounds.Left + 50, PosicaoDaLinha, new StringFormat());
                e.Graphics.DrawString(nome.ToString(), FonteNormal, Brushes.Black, e.MarginBounds.Left + 100, PosicaoDaLinha, new StringFormat());
                e.Graphics.DrawString(telefone.ToString(), FonteNormal, Brushes.Black, e.MarginBounds.Left + 200, PosicaoDaLinha, new StringFormat());
                e.Graphics.DrawString(endereco.ToString(), FonteNormal, Brushes.Black, e.MarginBounds.Left + 300, PosicaoDaLinha, new StringFormat());
                e.Graphics.DrawString(endereco.ToString(), FonteNormal, Brushes.Black, e.MarginBounds.Left + 450, PosicaoDaLinha, new StringFormat());
                LinhaAtual += 1;
            }
            //Rodapé
            e.Graphics.DrawLine(Risco, e.MarginBounds.Left, e.MarginBounds.Bottom, e.MarginBounds.Right, e.MarginBounds.Bottom);
            e.Graphics.DrawString(System.DateTime.Now.ToString(), FonteRodape, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Bottom, new StringFormat());
            LinhaAtual += Convert.ToInt32(FonteNormal.GetHeight(e.Graphics));
            LinhaAtual += 1;
            e.Graphics.DrawString("Página : " + paginaAtual, FonteRodape, Brushes.Black, e.MarginBounds.Right - 50, e.MarginBounds.Bottom, new StringFormat());
            //Incrementa o Número da Pagina
            paginaAtual += 1;
            //Verifica se Continua Imprimindo
            if ((LinhaAtual > LinhasPorPagina))
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
        }


        

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //Define o Titulo do Relatório
            RelatorioTitulo = "Lista de Produtos - ";
            //Define os objetos printdocument e os Eventos Associados
            //            PrintDocument pd = new PrintDocument();
            //IMPORTANTE - Definimos 3 eventos Para Tratar a
            //Impressão : PringPage, BeginPrint e EndPrint
            //            pd.PrintPage += new PrintPageEventHandler(this.ImprimirDocumento_PrintPage);
            //            pd.BeginPrint += new PrintEventHandler(this.ImprimirDocumento_BeginPrint);
            //            pd.EndPrint += new PrintEventHandler(this.ImprimirDocumento_EndPrint);
            //Define o Objeto Para Visualizar a Impressão
            PrintPreviewDialog objPrintPreview = new PrintPreviewDialog();
            try
            {
                //Define o Formulário como Maximizado e com Zoom
                {
                    objPrintPreview.Document = printDocument1;
                    objPrintPreview.WindowState = FormWindowState.Maximized;
                    objPrintPreview.PrintPreviewControl.Zoom = 1;
                    objPrintPreview.Text = "Relação de Produtos";
                    objPrintPreview.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                string ssql = "Select * From tblprodutos Order By codigo";
                pblCmd.CommandText = ssql;
                pblCmd.Connection = pblCnx;
                pblDados = pblCmd.ExecuteReader();
                paginaAtual = 1;
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro:" + Erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
            }
        }

        private void printDocument1_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            pblDados.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
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

        private void dgProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        }
    }

