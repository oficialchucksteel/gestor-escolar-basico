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
    public partial class TelaVerificarProfs : Form
    {
        Thread inicial;

        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private DataSet mDataSet;

        public TelaVerificarProfs()
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

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            if (rbId.Checked == true)
            {
                mDataSet = new DataSet();
                mConn = new MySqlConnection("Persist Security Info=False; server=localhost; database=escolabd; uid=root; pwd=");
                mConn.Open();

                mAdapter = new MySqlDataAdapter("SELECT * FROM professores ORDER BY ID", mConn);
                mAdapter.Fill(mDataSet, "professores");

                dgvResultado.DataSource = mDataSet;
                dgvResultado.DataMember = "professores";
            }
            else if (rbNome.Checked == true)
            {
                mDataSet = new DataSet();
                mConn = new MySqlConnection("Persist Security Info=False; server=localhost; database=escolabd; uid=root; pwd=");
                mConn.Open();

                mAdapter = new MySqlDataAdapter("SELECT * FROM professores ORDER BY NOME", mConn);
                mAdapter.Fill(mDataSet, "professores");

                dgvResultado.DataSource = mDataSet;
                dgvResultado.DataMember = "professores";
            }
            else if (rbCurso.Checked == true)
            {
                mDataSet = new DataSet();
                mConn = new MySqlConnection("Persist Security Info=False; server=localhost; database=escolabd; uid=root; pwd=");
                mConn.Open();

                mAdapter = new MySqlDataAdapter("SELECT * FROM professores ORDER BY DISCIPLINA", mConn);
                mAdapter.Fill(mDataSet, "professores");

                dgvResultado.DataSource = mDataSet;
                dgvResultado.DataMember = "professores";
            }
            else if (rbClasse.Checked == true)
            {
                mDataSet = new DataSet();
                mConn = new MySqlConnection("Persist Security Info=False; server=localhost; database=escolabd; uid=root; pwd=");
                mConn.Open();

                mAdapter = new MySqlDataAdapter("SELECT * FROM professores ORDER BY CLASSE", mConn);
                mAdapter.Fill(mDataSet, "professores");

                dgvResultado.DataSource = mDataSet;
                dgvResultado.DataMember = "professores";
            }
            else if (rbDe.Checked == true)
            {
                mDataSet = new DataSet();
                mConn = new MySqlConnection("Persist Security Info=False; server=localhost; database=escolabd; uid=root; pwd=");
                mConn.Open();

                mAdapter = new MySqlDataAdapter("SELECT * FROM professores ORDER BY DATA_DE_ENTRADA", mConn);
                mAdapter.Fill(mDataSet, "professores");

                dgvResultado.DataSource = mDataSet;
                dgvResultado.DataMember = "professores";
            }
            else if (rbDn.Checked == true)
            {
                mDataSet = new DataSet();
                mConn = new MySqlConnection("Persist Security Info=False; server=localhost; database=escolabd; uid=root; pwd=");
                mConn.Open();

                mAdapter = new MySqlDataAdapter("SELECT * FROM professores ORDER BY DATA_DE_NASCIMENTO", mConn);
                mAdapter.Fill(mDataSet, "professores");

                dgvResultado.DataSource = mDataSet;
                dgvResultado.DataMember = "professores";
            }
            else if (rbDc.Checked == true)
            {
                mDataSet = new DataSet();
                mConn = new MySqlConnection("Persist Security Info=False; server=localhost; database=escolabd; uid=root; pwd=");
                mConn.Open();

                mAdapter = new MySqlDataAdapter("SELECT * FROM professores ORDER BY DATA_DE_CRIACAO", mConn);
                mAdapter.Fill(mDataSet, "professores");

                dgvResultado.DataSource = mDataSet;
                dgvResultado.DataMember = "professores";
            }
            else
            {
                MessageBox.Show("Erro por conta do usuário! \nUse bem a App.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
