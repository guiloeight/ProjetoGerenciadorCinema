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
using System.Drawing.Printing;
namespace AppCadastro
{

    public partial class FrmIngresso : Form
    {
        public MySqlConnection pblCnx = new MySqlConnection();
        public MySqlCommand pblCmd = new MySqlCommand();
        public MySqlDataReader pblDados;
        public string RelatorioTitulo;
        public MySqlCommand pblComando = new MySqlCommand();
        public MySqlDataReader pblDataReader;
        public string preco;
        public bool blnPrimeira = true;
        public int paginaAtual = 1;
        public string Empresa = "KineBox Cinena S/A";
        public string cnpj = "CNPJ: 00000-000";
        public int prod=1;
        public FrmIngresso()
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

        private void FrmIngresso_Load(object sender, EventArgs e)
        {
            txtQuantidadeDeIngressos.Text = "0";
            txtMeias.Text = "0";
            string strSql = "Select * From tblfilme";

            pblCmd.Connection = pblCnx;
            pblCmd.CommandText = strSql;
            pblDados = pblCmd.ExecuteReader();
            if (pblDados.HasRows)
            {
                while (pblDados.Read())
                {

                    cbxFilme.Items.Add(pblDados["filme"].ToString());
                }
            }
            pblDados.Close();

        }
        
        public void btnSessao_Click(object sender, CancelEventArgs e)
        {
            string strSql = "Select * From tblcadastrosessoes Where filme = '" + cbxFilme.Text + "'";

            pblCmd.Connection = pblCnx;
            pblCmd.CommandText = strSql;
            pblDados = pblCmd.ExecuteReader();
            if (pblDados.HasRows)
            {
                while (pblDados.Read())
                {

                    cbxSessao.Items.Add(pblDados["nome"].ToString());
                }
            }
           
        
        }
        private void cbxFilme_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cbMeia_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                
                string strSql = "Insert into tblingresso (filme,horario,sessao,preco,sala,etaria) values(";
                strSql += "'" + cbxFilme.Text + "',";
                strSql += "'" + txtHorario.Text + "',";
                strSql += "'" + cbxSessao.Text + "',";
                strSql += "'" + txtPreco.Text + "',";
                strSql += "'" + txtSala.Text + "',";
                strSql += "'" + txtEtaria.Text + "')";

                pblCmd.Connection = pblCnx;
                pblCmd.CommandText = strSql;
                pblCmd.ExecuteNonQuery();
                
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro: " + Erro.Message, "Tratamento de Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            if ((cbxFilme.SelectedIndex.Equals("0")) || (cbxSessao.SelectedIndex.Equals("0")) || (txtHorario.Text.Equals("")) || (txtSala.Text.Equals("")) || (txtPreco.Text.Equals("")) || (txtQuantidadeDeIngressos.Text.Equals("")) || (txtMeias.Text.Equals("")))
            {
                MessageBox.Show("Impossível vender os ingressos sem as informações necessárias", "Erro na venda!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((txtQuantidadeDeIngressos.Text.Equals("")) || (txtMeias.Text.Equals("")))
            {
                txtQuantidadeDeIngressos.Text = "0";
                txtMeias.Text = "0";
            }
            else if ((Convert.ToDouble(txtQuantidadeDeIngressos.Text) < 1))
            {
                MessageBox.Show("Modifique a quantidade de ingressos.", "Erro na venda!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (prod == 1)
                {
                    filme1.Text = "" + cbxFilme.Text;
                    horario1.Text = "" + txtHorario.Text;
                    sala1.Text = "" + txtSala.Text;
                    preco1.Text = "" + txtPreco.Text;
                    int1.Text = "" + txtQuantidadeDeIngressos.Text;
                    meia1.Text = "" + txtMeias.Text;
                    total1.Text = "" + txttotal.Text + " reais";
                    prod += 1;
                }
                else if (prod == 2)
                {
                    filme2.Text = "" + cbxFilme.Text;
                    horario2.Text = "" + txtHorario.Text;
                    sala2.Text = "" + txtSala.Text;
                    preco2.Text = "" + txtPreco.Text;
                    int2.Text = "" + txtQuantidadeDeIngressos.Text;
                    meia2.Text = "" + txtMeias.Text;
                    total2.Text = "" + txttotal.Text + " reais";
                    prod += 1;
                }

            }
        }


        private void btnSessao_Click(object sender, EventArgs e)
        {
            cbxSessao.Items.Clear();
            string strSql = "Select * From tblcadastrosessoes Where filme = '" + cbxFilme.Text + "'";

            pblCmd.Connection = pblCnx;
            pblCmd.CommandText = strSql;
            pblDados = pblCmd.ExecuteReader();
            if (pblDados.HasRows)
            {
                while (pblDados.Read())
                {
                    
                    cbxSessao.Items.Add(pblDados["nome"].ToString());
                }
            }
            pblDados.Close();
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            string strSql = "Select * From tblcadastrosessoes Where nome = '" + cbxSessao.Text + "'";

            pblCmd.Connection = pblCnx;
            pblCmd.CommandText = strSql;
            pblDados = pblCmd.ExecuteReader();
            if (pblDados.HasRows)
            {
                pblDados.Read();
               txtHorario.Text = pblDados["horario"].ToString();
               txtSala.Text = pblDados["sala"].ToString();
            }
            pblDados.Close();
        }

        private void btnSessao2(object sender, EventArgs e)
        {
            string strSql = "Select * From tblcadastrosessoes Where nome = '" + cbxSessao.Text + "'";

            pblCmd.Connection = pblCnx;
            pblCmd.CommandText = strSql;
            pblDados = pblCmd.ExecuteReader();
            if (pblDados.HasRows)
            {
                pblDados.Read();
                txtHorario.Text = pblDados["horario"].ToString();
                txtSala.Text = pblDados["sala"].ToString();
                    txtEtaria.Text = pblDados["faixa"].ToString();
              
            }
            pblDados.Close();
            strSql = "Select * From tblfilme Where filme = '" + cbxFilme.Text + "'";

            pblCmd.Connection = pblCnx;
            pblCmd.CommandText = strSql;
            pblDados = pblCmd.ExecuteReader();
            if (pblDados.HasRows)
            {
                while (pblDados.Read())
                {

                   txtPreco.Text = (pblDados["preco"].ToString());
                }
            }
            pblDados.Close();


           
        }

        
      
        private void txtQuantidadeDeIngressos_Click(object sender, EventArgs e)
        {

        }

        private void txtQuantidadeDeIngressos_Click()
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
         
            float LinhasPorPagina = 0;
            float PosicaoDaLinha = 0;
            int LinhaAtual = 0;
       
            Pen Risco = new Pen(Color.Black, 1);
   
            Font FonteNegrito = new Font("Arial", 9, FontStyle.Bold);
            Font FonteTitulo = new Font("Arial", 15, FontStyle.Bold);
            Font FonteSubTitulo = new Font("Arial", 12, FontStyle.Bold);
            Font FonteRodape = new Font("Arial", 8);
            Font FonteNormal = new Font("Arial", 9);
   
            e.Graphics.DrawLine(Risco, e.MarginBounds.Left, 60, e.MarginBounds.Right, 60);
            e.Graphics.DrawLine(Risco, e.MarginBounds.Left, 160, e.MarginBounds.Right, 160);
      
            e.Graphics.DrawString(Empresa, FonteTitulo, Brushes.Red, e.MarginBounds.Left + 10, 80, new StringFormat());
         
            
            
            e.Graphics.DrawString(RelatorioTitulo + dtmdia.Text, FonteNormal, Brushes.Black, e.MarginBounds.Left + 10, 120, new StringFormat());
           
            e.Graphics.DrawString("Filme ", FonteNegrito, Brushes.Black, e.MarginBounds.Left + 50, 170, new StringFormat());
            e.Graphics.DrawString("Horário", FonteNegrito, Brushes.Black, e.MarginBounds.Left + 100, 170, new StringFormat());
            e.Graphics.DrawString("Preço", FonteNegrito, Brushes.Black, e.MarginBounds.Left + 150, 170, new StringFormat());
            e.Graphics.DrawString("Sala", FonteNegrito, Brushes.Black, e.MarginBounds.Left + 200, 170, new StringFormat());
            e.Graphics.DrawString("Classificação Etária", FonteNegrito, Brushes.Black, e.MarginBounds.Left + 300, 170, new StringFormat());
            e.Graphics.DrawLine(Risco, e.MarginBounds.Left, 190, e.MarginBounds.Right, 190);
           
            LinhasPorPagina = Convert.ToInt32(e.MarginBounds.Height / FonteNormal.GetHeight(e.Graphics) - 4);
        
            while ((LinhaAtual < LinhasPorPagina && pblDados.Read()))
            {
               
                string filme = pblDados["filme"].ToString();
                string horario = pblDados["horario"].ToString();
                string preco = pblDados["preco"].ToString();
                string sala = pblDados["sala"].ToString();
                string etaria = pblDados["etaria"].ToString();
              
                PosicaoDaLinha = e.MarginBounds.Top + 100 + (LinhaAtual * FonteNormal.GetHeight(e.Graphics));
                e.Graphics.DrawString(filme.ToString(), FonteNormal, Brushes.Black, e.MarginBounds.Left + 50, PosicaoDaLinha, new StringFormat());
                e.Graphics.DrawString(horario.ToString(), FonteNormal, Brushes.Black, e.MarginBounds.Left + 100, PosicaoDaLinha, new StringFormat());
                e.Graphics.DrawString(preco.ToString(), FonteNormal, Brushes.Black, e.MarginBounds.Left + 150, PosicaoDaLinha, new StringFormat());
                e.Graphics.DrawString(sala.ToString(), FonteNormal, Brushes.Black, e.MarginBounds.Left + 200, PosicaoDaLinha, new StringFormat());
                e.Graphics.DrawString(etaria.ToString(), FonteNormal, Brushes.Black, e.MarginBounds.Left + 300, PosicaoDaLinha, new StringFormat());
                
            
                LinhaAtual += 1;
            }
            //Rodapé
            LinhasPorPagina = Convert.ToInt32(e.MarginBounds.Height / FonteNormal.GetHeight(e.Graphics) - 4);
        
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

        private void cbxSessao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        double totalcompra=0.0;
        
        
        
        private void btnqnt_Click(object sender, EventArgs e)
        {
            if (txtQuantidadeDeIngressos.Equals(""))
            {
                txtQuantidadeDeIngressos.Text = "0";
            }

            double inteira;
            inteira = Convert.ToDouble(txtQuantidadeDeIngressos.Text);
            totalcompra = totalcompra + (Convert.ToDouble(txtPreco.Text) * (inteira));
            txttotal.Text = "" + totalcompra;
        }

        private void btnmeia_Click(object sender, EventArgs e)
        {
            if (txtMeias.Equals(""))
            {
                txtMeias.Text = "0";
            }
            double meia;
            meia = Convert.ToDouble(txtMeias.Text);
            totalcompra = totalcompra + (Convert.ToDouble(txtPreco.Text) * (meia / 2));
            txttotal.Text = "" + totalcompra;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
           
            RelatorioTitulo = "Ingresso - ";
          
            PrintPreviewDialog objPrintPreview = new PrintPreviewDialog();
            try
            {
               
                {
                    objPrintPreview.Document = printDocument1;
                    objPrintPreview.WindowState = FormWindowState.Maximized;
                    objPrintPreview.PrintPreviewControl.Zoom = 1;
                    objPrintPreview.Text = "KINEBOX CINEMAS S/A.";
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
            string ssql = "Select * From tblingresso Order By filme";
            pblCmd.CommandText = ssql;
            pblCmd.Connection = pblCnx;
            pblDados = pblCmd.ExecuteReader();
            paginaAtual = 1;
            PageSetupDialog psd = new PageSetupDialog();
            psd.Document = printDocument1;
            psd.PageSettings.PaperSize = new PaperSize ("My Custom", 800, 350);
        }

        private void printDocument1_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            pblDados.Close();
        }

        private void txtEtaria_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPreco_TextChanged_1(object sender, EventArgs e)
        {

        }

        

        

        



    }
}
