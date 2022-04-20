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
using MySql.Data.MySqlClient;

namespace BD_Teste_001
{
    public partial class TelaCadastramento : Form
    {
        Thread inicial;

        string nome, curso, sexo, datanascimento, dataentrada, datatual;
        decimal classe;
        
        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private DataSet mDataSet;

        public TelaCadastramento()
        {
            InitializeComponent();
        }

        private void btnTelaInicial_Click(object sender, EventArgs e)
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

        private void limparTudo(object obj)
        {
            txtNome.Clear();
            mtbDataEntrada.Clear();
            mtbDataNascimento.Clear();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            /* Verificando se existe caixas de texto vazias (...) */

            if (txtNome.Text == "" || mtbDataEntrada.Text == "" || mtbDataNascimento.Text == "")
            {
                MessageBox.Show("Caixas de texto vazias detectadas!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            /* (...) ou não */

            else
            {
                /* Dando valores as variaveis */

                nome = txtNome.Text;
                classe = numClasse.Value;
                dataentrada = mtbDataEntrada.Text;
                datanascimento = mtbDataNascimento.Text;
                datatual = DateTime.Now.Date.ToString("yyyy-MM-dd");

                /* Dando valores predefinido */

                sexo = "M";
                curso = "Informática";

                /* Inserindo o sexo do aluno */

                if (rbMasculino.Checked == true)
                {
                    sexo = "M";
                }
                else if (rbFemenino.Checked == true)
                {
                    sexo = "F";
                }

                /* Falando com o Banco de Dados */

                mConn = new MySqlConnection("Persist Security Info=False; server=localhost; database=escolabd; uid=root; pwd=");
                mConn.Open();

                MySqlCommand command = new MySqlCommand("INSERT INTO alunos (nome, sexo, curso, classe, data_de_nascimento, data_de_entrada, data_de_criacao)" + "VALUES('" + nome + "' , '" + sexo + "' , '" + curso + "' , '" + classe + "' , '" + datanascimento + "' , '" + dataentrada + "' , '" + datatual + "')", mConn);

                command.ExecuteNonQuery();
                mConn.Close();

                MessageBox.Show("Gravado com Sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                /* Limpando as caixas de texto */

                limparTudo(0);
            }
        }
    }
}
