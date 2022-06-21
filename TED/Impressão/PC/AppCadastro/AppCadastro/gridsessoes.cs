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
    public partial class gridsessoes : Form
    {
        public MySqlConnection pblCnx = new MySqlConnection();
        public MySqlCommand pblComando = new MySqlCommand();
        public MySqlDataReader pblDataReader;
        public gridsessoes()
        {
            InitializeComponent();
            try
            {
                pblCnx.ConnectionString = "Server=localhost;Database=bdCadastro;user=root;pwd=";
                pblCnx.Open();
              

            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro:" + Erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridsessoes_Load(object sender, EventArgs e)
        {
              string ssql;

            ssql = "Select * From tblcadastrosessoes Order By try";
            pblComando.CommandText = ssql;
            pblComando.Connection = pblCnx;
            pblDataReader = pblComando.ExecuteReader();
            if (!pblDataReader.HasRows)
            {
                MessageBox.Show("Cadastre as Sessões primeiro!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                while (pblDataReader.Read())
                {
                    dgvfornecedor.Rows.Add(pblDataReader["filme"].ToString(), pblDataReader["horario"].ToString(), pblDataReader["sala"].ToString(), pblDataReader["d3"].ToString());
                }
            }
            pblDataReader.Close();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }
        }
    }


