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
    public partial class TelaCadastramentoProfs : Form
    {
        Thread inicial;

        string nome, disciplina, classe, sexo, datanascimento, dataentrada, datatual;
        
        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private DataSet mDataSet;

        public TelaCadastramentoProfs()
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

        private void limparTudo(object obj)
        {
            txtNome.Clear();
            mtbDataEntrada.Clear();
            mtbDataNascimento.Clear();
        }

        private void telaInicial(object obj)
        {
            Application.Run(new TelaInicial());
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            /* Verificando se existe caixas de texto vazias (...) */

            if (txtNome.Text == "" || txtDisciplina.Text == "" || mtbDataEntrada.Text == "" || mtbDataNascimento.Text == "")
            {
                MessageBox.Show("Caixas de texto vazias detectadas!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            /* (...) ou não */

            else
            {
                /* Dando valores as variaveis */

                nome = txtNome.Text;
                disciplina = txtDisciplina.Text;
                dataentrada = mtbDataEntrada.Text;
                datanascimento = mtbDataNascimento.Text;
                datatual = DateTime.Now.Date.ToString("yyyy-MM-dd");

                /* Dando valores predefinido */

                classe = "10º";
                sexo = "M";

                /* Inserindo as classes que o prof. trabalha */

                if (cb10.Checked == true && cb11.Checked == false && cb12.Checked == false && cb13.Checked == false)
                {
                    classe = "10º";
                }
                else if (cb11.Checked == true && cb10.Checked == false && cb12.Checked == false && cb13.Checked == false)
                {
                    classe = "11º";
                }
                else if (cb12.Checked == true && cb11.Checked == false && cb10.Checked == false && cb13.Checked == false)
                {
                    classe = "12º";
                }
                else if (cb13.Checked == true && cb11.Checked == false && cb12.Checked == false && cb10.Checked == false)
                {
                    classe = "13º";
                }
                else if (cb10.Checked == true && cb11.Checked == true && cb12.Checked == false && cb13.Checked == false)
                {
                    classe = "10º e 11º";
                }
                else if (cb10.Checked == true && cb12.Checked == true && cb11.Checked == false && cb13.Checked == false)
                {
                    classe = "10º e 12º";
                }
                else if (cb10.Checked == true && cb13.Checked == true && cb11.Checked == false && cb12.Checked == false)
                {
                    classe = "10º e 13º";
                }
                else if (cb11.Checked == true && cb12.Checked == true && cb10.Checked == false && cb13.Checked == false)
                {
                    classe = "11º e 12º";
                }
                else if (cb11.Checked == true && cb13.Checked == true && cb10.Checked == false && cb12.Checked == false)
                {
                    classe = "11º e 13º";
                }
                else if (cb12.Checked == true && cb13.Checked == true && cb11.Checked == false && cb10.Checked == false)
                {
                    classe = "12º e 13º";
                }
                else if (cb10.Checked == true && cb11.Checked == true && cb12.Checked == true && cb13.Checked == false)
                {
                    classe = "10º e 11º e 12º";
                }
                else if (cb10.Checked == true && cb11.Checked == true && cb13.Checked == true && cb12.Checked == false)
                {
                    classe = "10º e 11º e 13º";
                }
                else if (cb11.Checked == true && cb12.Checked == true && cb13.Checked == true && cb10.Checked == false)
                {
                    classe = "11º e 12º e 13º";
                }
                else if (cb10.Checked == true && cb12.Checked == true && cb13.Checked == true && cb11.Checked == false)
                {
                    classe = "10º e 12º e 13º";
                }
                else if (cb10.Checked == true && cb11.Checked == true && cb12.Checked == true && cb13.Checked == true)
                {
                    classe = "10º e 11º e 12º e 13º";
                }

                /* Inserindo o sexo do prof. */

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

                MySqlCommand command = new MySqlCommand("INSERT INTO professores (nome, disciplina, classe, sexo, data_de_nascimento, data_de_entrada, data_de_criacao)" + "VALUES('" + nome + "' , '" + disciplina + "' , '" + classe + "' , '" + sexo + "' , '" + datanascimento + "' , '" + dataentrada + "' , '" + datatual + "')", mConn);

                command.ExecuteNonQuery();
                mConn.Close();

                MessageBox.Show("Gravado com Sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                /* Limpando as caixas de texto */

                limparTudo(0);
            }
        }
    }
}
