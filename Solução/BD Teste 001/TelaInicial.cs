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
    public partial class TelaInicial : Form
    {
        Thread cadastrar, verificar, sair;

        public TelaInicial()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.Close();
            cadastrar = new Thread(telaCadastramento);
            cadastrar.SetApartmentState(ApartmentState.STA);
            cadastrar.Start();
        }

        private void telaCadastramento(object obj)
        {
            Application.Run(new TelaCadastramento());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            verificar = new Thread(telaDeProcura);
            verificar.SetApartmentState(ApartmentState.STA);
            verificar.Start();
        }

        private void telaDeProcura(object obj)
        {
            Application.Run(new TelaVerificar());
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastrarProfs_Click(object sender, EventArgs e)
        {
            this.Close();
            cadastrar = new Thread(telaCadastramentoProfs);
            cadastrar.SetApartmentState(ApartmentState.STA);
            cadastrar.Start();
        }

        private void telaCadastramentoProfs(object obj)
        {
            Application.Run(new TelaCadastramentoProfs());
        }

        private void btnVerificarProfs_Click(object sender, EventArgs e)
        {
            this.Close();
            verificar = new Thread(telaVerificarProfs);
            verificar.SetApartmentState(ApartmentState.STA);
            verificar.Start();
        }

        private void telaVerificarProfs(object obj)
        {
            Application.Run(new TelaVerificarProfs());
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            sair = new Thread(telaLogin);
            sair.SetApartmentState(ApartmentState.STA);
            sair.Start();
        }

        private void telaLogin(object obj)
        {
            Application.Run(new TelaLogin());
        }
    }
}
