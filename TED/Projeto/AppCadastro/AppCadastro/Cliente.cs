using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Data.OleDb;
using System.IO;
using MySql.Data.MySqlClient;

namespace AppCadastro
{
    public partial class frmCliente : Form
    {
        public MySqlConnection pblCnx = new MySqlConnection();
        public MySqlCommand pblCmd = new MySqlCommand();
        public MySqlDataReader pblDados;
        public bool blnPrimeira = true;
        public int paginaAtual = 1;
        public string Empresa = "Chaplin";
        public string RelatorioTitulo;
        public frmCliente()
        {
            InitializeComponent();
            try
            {
                pblCnx.ConnectionString = "Server=localhost;Database=bdCadastro;user=root;pwd=password";
                pblCnx.Open();

            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro:" + Erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
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
            if (txtCodCli.Text == "")
            {
                MessageBox.Show("Habilite o campo Código e Preencha o código que deseja excluir!", "Código Vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int usuario = 1;
                try
                {
                    

                    string strSql = "Select * From tblcliente Where cod_cli = " + txtCodCli.Text + "";
                    pblCmd.Connection = pblCnx;
                    pblCmd.CommandText = strSql;
                    pblDados = pblCmd.ExecuteReader();
                    if (pblDados.HasRows)
                    {
                        pblDados.Read();
                        txtCodCli.Text = pblDados["cod_cli"].ToString();
                        txtNomeCli.Text = pblDados["nome_cli"].ToString();
                        txtTelCli.Text = pblDados["tel_cli"].ToString();
                        txtEndCli.Text = pblDados["end_cli"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Usuario Inexistente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNomeCli.Focus();
                        //limpando
                        txtCodCli.Text = "";
                        txtNomeCli.Text = "";
                        txtTelCli.Text = "";
                        txtEndCli.Text = "";
                        txtNomeCli.Focus();
                        //limpado
                        usuario = 0;
                    }
                    pblDados.Close();
                    bntDesabilitar_Click(sender, e);

                }
                catch (Exception Erro)
                {
                    MessageBox.Show("Erro: " + Erro.Message, "Tratamento de Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (usuario == 1)
                {
                    try
                    {
                        if (MessageBox.Show("Deseja excluir o Cliente: " + txtNomeCli.Text, "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            string strSql = "Delete from tblcliente Where cod_cli = " + txtCodCli.Text + "";
                            pblCmd.Connection = pblCnx;
                            pblCmd.CommandText = strSql;
                            pblCmd.ExecuteNonQuery();
                            MessageBox.Show("Cliente eliminado!", "Excluído!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnLimparCli_Click(sender, e);
                        }
                    }
                    catch (Exception Erro)
                    {
                        MessageBox.Show("Erro: " + Erro.Message, "Tratamento de Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        

        private void btnLimparCli_Click(object sender, EventArgs e)
        {
            txtCodCli.Text = "";
            txtNomeCli.Text = "";
            txtTelCli.Text = "";
            txtEndCli.Text = "";
            txtNomeCli.Focus();
        }

        private void btnCadastrarUs_Click(object sender, EventArgs e)
        {
            if (txtNomeCli.Text.Equals("") || txtTelCli.Text.Equals("(  )    -") || txtEndCli.Text.Equals(""))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            }
            else
            {
                try
                {
                    bntDesabilitar_Click(sender, e);
                    string strSql = "Insert into tblcliente (nome_cli,tel_cli,end_cli) values(";
                    strSql += "'" + txtNomeCli.Text + "',";
                    strSql += "'" + txtTelCli.Text + "',";
                    strSql += "'" + txtEndCli.Text + "')";

                    pblCmd.Connection = pblCnx;
                    pblCmd.CommandText = strSql;
                    pblCmd.ExecuteNonQuery();
                    MessageBox.Show("Novo Cliente cadastrado!", "Cadastro Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLimparCli_Click(sender, e);
                }
                catch (Exception Erro)
                {
                    MessageBox.Show("Erro: " + Erro.Message, "Tratamento de Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnConsultarUs_Click(object sender, EventArgs e)
        {
            if (txtCodCli.Text == "")
            {
                MessageBox.Show("Habilite o campo Código e Preencha o código que deseja consultar!", "Código Vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {


                    string strSql = "Select * From tblcliente Where cod_cli = " + txtCodCli.Text + "";
                    pblCmd.Connection = pblCnx;
                    pblCmd.CommandText = strSql;
                    pblDados = pblCmd.ExecuteReader();
                    if (pblDados.HasRows)
                    {
                        pblDados.Read();
                        txtCodCli.Text = pblDados["cod_cli"].ToString();
                        txtNomeCli.Text = pblDados["nome_cli"].ToString();
                        txtTelCli.Text = pblDados["tel_cli"].ToString();
                        txtEndCli.Text = pblDados["end_cli"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Usuario Inexistente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNomeCli.Focus();
                    }
                    pblDados.Close();
                    bntDesabilitar_Click(sender, e);

                }
                catch (Exception Erro)
                {
                    MessageBox.Show("Erro: " + Erro.Message, "Tratamento de Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAlterarUs_Click(object sender, EventArgs e)
        {
            if (txtCodCli.Text.Equals("") || txtNomeCli.Text.Equals("") || txtTelCli.Text.Equals("") || txtEndCli.Text.Equals(""))
            {
                MessageBox.Show("Antes de Alterar é necessário Consultar o cliente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            }
            else
            {
                if (txtNomeCli.Text.Equals("") || txtTelCli.Text.Equals("(  )    -") || txtEndCli.Text.Equals(""))
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                }
                else
                {
                    try
                    {
                        string strSql = "Update tblcliente set ";
                        strSql += "tel_cli = '" + txtTelCli.Text + "',";
                        strSql += "end_cli = '" + txtEndCli.Text + "',";
                        strSql += "nome_cli = '" + txtNomeCli.Text + "' ";
                        strSql += "Where cod_cli = " + txtCodCli.Text;

                        pblCmd.Connection = pblCnx;
                        pblCmd.CommandText = strSql;
                        pblCmd.ExecuteNonQuery();
                        MessageBox.Show("Cliente Alterado!", "Alterado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnLimparCli_Click(sender, e);
                    }
                    catch (Exception Erro)
                    {
                        MessageBox.Show("Erro: " + Erro.Message, "Tratamento de Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            txtCodCli.Enabled = true;
            txtCodCli.Focus();
        }

        private void bntDesabilitar_Click(object sender, EventArgs e)
        {
            txtCodCli.Enabled = false;
            txtCodCli.Focus();
        }

        private void lblVoltarMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmMenucs Menu = new frmMenucs();
            Menu.ShowDialog();

        }

        private void btnGrid_Click(object sender, EventArgs e)
        {
            Grid Grid = new Grid();
            Grid.ShowDialog();
        }
        
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //Define o Titulo do Relatório
            RelatorioTitulo = "Lista de Clientes - ";
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
                    objPrintPreview.Text = "Relação de Clientes";
                    objPrintPreview.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            string ssql = "Select * From tblcliente Order By cod_cli";
            pblCmd.CommandText = ssql;
            pblCmd.Connection = pblCnx;
            pblDados = pblCmd.ExecuteReader();
            paginaAtual = 1;
        }

        private void printDocument1_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //Fecha o DataReader
            pblDados.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Variáveis das Linhas
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
            e.Graphics.DrawString("Nome", FonteNegrito, Brushes.Black, e.MarginBounds.Left + 100, 170, new StringFormat());
            e.Graphics.DrawString("Telefone", FonteNegrito, Brushes.Black, e.MarginBounds.Left + 200, 170, new StringFormat());
            e.Graphics.DrawString("Endereço", FonteNegrito, Brushes.Black, e.MarginBounds.Left + 300, 170, new StringFormat());
            e.Graphics.DrawLine(Risco, e.MarginBounds.Left, 190, e.MarginBounds.Right, 190);
            //Linha por Página
            LinhasPorPagina = Convert.ToInt32(e.MarginBounds.Height / FonteNormal.GetHeight(e.Graphics) - 9);
            //Aqui são Lidos os Dados
            while ((LinhaAtual < LinhasPorPagina && pblDados.Read()))
            {
                //Obtém os Valores do DataReader
                string codigo = pblDados["cod_cli"].ToString();
                string nome = pblDados["nome_cli"].ToString();
                string telefone = pblDados["tel_cli"].ToString();
                string endereco = pblDados["end_cli"].ToString();
                //Inicia a Impressão
                PosicaoDaLinha = e.MarginBounds.Top + 100 + (LinhaAtual * FonteNormal.GetHeight(e.Graphics));
                e.Graphics.DrawString(codigo.ToString(), FonteNormal, Brushes.Black, e.MarginBounds.Left + 50, PosicaoDaLinha, new StringFormat());
                e.Graphics.DrawString(nome.ToString(), FonteNormal, Brushes.Black, e.MarginBounds.Left + 100, PosicaoDaLinha, new StringFormat());
                e.Graphics.DrawString(telefone.ToString(), FonteNormal, Brushes.Black, e.MarginBounds.Left + 200, PosicaoDaLinha, new StringFormat());
                e.Graphics.DrawString(endereco.ToString(), FonteNormal, Brushes.Black, e.MarginBounds.Left + 300, PosicaoDaLinha, new StringFormat());
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

        private void frmCliente_Load(object sender, EventArgs e)
        {

        }

        private void lblCodCli_Click(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}
