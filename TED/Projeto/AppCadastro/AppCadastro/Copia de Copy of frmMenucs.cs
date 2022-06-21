using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using MySql.Data.MySqlClient;
namespace AppCadastro
{
    public partial class frmMenucs3 : Form
    {
   public MySqlConnection pblCnx = new MySqlConnection();
   public MySqlCommand pblCmd = new MySqlCommand();
   public MySqlDataReader pblDados;
  
        public String conta;
               
        public frmMenucs3()
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


        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja realmente Sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            frmUsuario0 Usuario = new frmUsuario0();
            Usuario.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            frmCliente Cliente = new frmCliente();
            Cliente.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmUsuario0 Usuario = new frmUsuario0();
            Usuario.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmCliente Cliente = new frmCliente();
            Cliente.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja fazer Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Hide();
                frmLogin Login = new frmLogin();
                Login.ShowDialog();
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja fazer Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Hide();
                frmLogin Login = new frmLogin();
                Login.ShowDialog();
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente Sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmMenucs_Load(object sender, EventArgs e)
        {
            frmLogin log = new frmLogin();
            log.Close();

            tsslData.Text =  DateTime.Now.ToString("dd-MM-yyyy");
            timerhora.Enabled = true;
         
        



            
        }
        private void pcbVenda_Click(object sender, EventArgs e)
        {
            FrmIngresso ingresso = new FrmIngresso();
            ingresso.Show();
        }

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Cadastrosalas cadastrosalas = new Cadastrosalas();
            cadastrosalas.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AddFilme addfilme = new AddFilme();
            addfilme.Show();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            Cadastrofornecedor cadastrofornecedor = new Cadastrofornecedor();
            cadastrofornecedor.Show();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Cadastrosessoes cadastrosessoes = new Cadastrosessoes();
            cadastrosessoes.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
           Produtos formproduto = new Produtos();
            formproduto.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            cadastrofuncionario cadastrofuncionario = new cadastrofuncionario();
            cadastrofuncionario.ShowDialog();
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tsslhora.Text = "Hora: " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void tsslhora_Click(object sender, EventArgs e)
        {

        }

        private void tsslData_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            vendadeproduto vendadeproduto = new vendadeproduto();
            vendadeproduto.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Contas contas = new Contas();
            contas.ShowDialog();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\backup\\Backup.Bat", "bdcadastro C:\\PC\\BdBackup.sql");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmSplash2 frmsplash = new FrmSplash2();
            frmsplash.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
        
            
              
            }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void filmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFilme filme = new AddFilme();
            filme.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produtos produtos = new Produtos();
            produtos.Show();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastrofuncionario func = new cadastrofuncionario();
            func.ShowDialog();
        }

        private void sessõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastrosessoes sessoes = new Cadastrosessoes();
            sessoes.ShowDialog();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastrofornecedor fornecedor = new Cadastrofornecedor();
            fornecedor.ShowDialog();
        }

        private void salasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastrosalas salas = new Cadastrosalas();
            salas.ShowDialog();
        }

        private void lblcaixa_Click(object sender, EventArgs e)
        {

        }
        }


        
        

    
}
