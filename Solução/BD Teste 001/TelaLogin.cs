using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace BD_Teste_001
{
    public partial class TelaLogin : Form
    {
        // Iniciando funcões a serem usuadas futuramente
        Thread inicial;
        private MySqlConnection mConn;
        private MySqlDataReader reader;

        public TelaLogin()
        {
            InitializeComponent();
        }

        // Criando a função para redirecionar o usuário na tela inical
        private void Tinicial(object obj)
        {
            this.Close();
            inicial = new Thread(telaInicial);
            inicial.SetApartmentState(ApartmentState.STA);
            inicial.Start();
        }

        private void telaInicial(object obj)
        {
            Application.Run(new TelaInicial());
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            // Iniciando as string
            string usuario = tb_login.Text;
            string senha = tb_password.Text;
            string comando = "SELECT usuario, senha FROM admin WHERE usuario = '" + usuario + "' and senha = md5('" + senha + "')";

            // Iniciando as conexões
            mConn = new MySqlConnection("Persist Security Info=False; server=localhost; database=escolabd; uid=root; pwd=");
            mConn.Open();

            MySqlCommand command = new MySqlCommand(comando, mConn);

            reader = command.ExecuteReader();

            // Se o sistema encontrar o login no BD, ele retorna uma linha
            if (reader.HasRows)
            {
                reader.Read();
                if (tb_login.Text.Equals(reader["usuario"].ToString()) || tb_password.Text.Equals(reader["senha"].ToString()))
                {
                    Tinicial(0);
                }
                else
                {
                    MessageBox.Show("Usuário e senha não confere.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //Se ele não encontrar o login no BD, ele não retorna linha alguma!
            else
            {
                MessageBox.Show("Usuário e senha não confere.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Fechando as conexões
            reader.Close();
            mConn.Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            // Fechando o aplicativo
            this.Close();
        }
    }
}
