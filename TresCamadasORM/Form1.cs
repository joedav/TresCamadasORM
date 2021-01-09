using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TresCamadas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadCombos();
        }

        private void LoadCombos()
        {
            cbxNomeUsuario.DataSource = null;
            cbxUsuario.DataSource = null;
            cbxNomeUsuario.DataSource = new Usuario().Todos() ?? null;
            cbxUsuario.DataSource = new Usuario().Todos() ?? null;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario();
            usuario.Nome = txtNome.Text;
            usuario.Telefone = mtxtTelefone.Text;
            usuario.CPF = mtxtCPF.Text;
            usuario.Salvar();

            MessageBox.Show("Usuário Salvo com sucesso!");
            LoadCombos();
        }

        private void btnGravarEndereco_Click(object sender, EventArgs e)
        {
            var endereco = new Endereco();
            endereco.CPF = ((Usuario)cbxUsuario.SelectedValue).CPF;
            endereco.Logradouro = txtLogradouro.Text;
            endereco.Numero = txtNumero.Text;
            endereco.Cidade = txtCidade.Text;
            endereco.Estado = txtEstado.Text;

            endereco.Salvar();

            MessageBox.Show("Endereco Salvo com sucesso!");
            LoadCombos();
        }

        private void cbxNomeUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvEnderecos.DataSource = null;
            var usu = ((Usuario)cbxNomeUsuario.SelectedValue);
            dgvEnderecos.DataSource = usu.Enderecos;
            if (usu != null)
            {
                lblTelResult.Text = $"Telefone: {usu.Telefone}";
                lblCPFResult.Text = $"CPF: {usu.CPF}";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*var fornecedor = new Fornecedor();
            fornecedor.Nome = "Fornecedor Teste";
            fornecedor.Telefone = "112312312";
            fornecedor.Especialidades = "Concerta computadores";
            fornecedor.Salvar();*/
            LoadCombos();
        }
    }
}
