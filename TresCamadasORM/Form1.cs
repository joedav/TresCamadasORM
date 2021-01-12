using Business;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace TresCamadas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadCombos()
        {
            cbxNomeUsuario.DataSource = null;
            cbxUsuario.DataSource = null;
            dgvUsuarios.DataSource = null;
            dgvUsuarios.AutoGenerateColumns = false;
            cbxNomeUsuario.DataSource = new Usuario().Todos() ?? null;
            cbxUsuario.DataSource = new Usuario().Todos() ?? null;
            dgvUsuarios.DataSource = new Usuario().Todos() ?? null;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario();
            usuario.Nome = txtNome.Text;
            usuario.Telefone = mtxtTelefone.Text;
            usuario.CPF = mtxtCPF.Text;
            usuario.Id = int.Parse(string.IsNullOrEmpty(lblId.Text) ? "0" : lblId.Text);
            usuario.Salvar();

            Limpar();
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

            Limpar();
            MessageBox.Show("Endereco Salvo com sucesso!");
            LoadCombos();
        }

        private void cbxNomeUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvEnderecos.DataSource = null;
            var usu = ((Usuario)cbxNomeUsuario.SelectedValue);
            dgvEnderecos.DataSource = usu?.Enderecos;
            if (usu != null)
            {
                lblTelResult.Text = $"Telefone: {usu.Telefone}";
                lblCPFResult.Text = $"CPF: {usu.CPF}";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var carro = new Carro { Nome = "GLA 250 Sport", Disponivel = true, Marca = "Mercedes", Quantidade = 15, Valor = 300000.000 };
            // carro.CriarTabela(); // faz chamada para criação da tabela
            carro.Salvar();



            /*var fornecedor = new Fornecedor();
            fornecedor.Nome = "Fornecedor Teste";
            fornecedor.Telefone = "112312312";
            fornecedor.Especialidades = "Concerta computadores";
            fornecedor.Salvar();*/
            LoadCombos();
        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Usuario usuario = (Usuario)dgvUsuarios.Rows[e.RowIndex].DataBoundItem;
            txtNome.Text = usuario.Nome;
            mtxtTelefone.Text = usuario.Telefone;
            mtxtCPF.Text = usuario.CPF;
            lblId.Text = usuario.Id.ToString();
            btnGravar.Text = "Alterar";
        }

        private void Limpar()
        {
            txtNome.Clear();
            mtxtTelefone.Clear();
            mtxtCPF.Clear();
            lblId.Text = "";
            btnGravar.Text = "Gravar";
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in dgvUsuarios.SelectedCells)
            {
                if (cell.RowIndex != -1)
                {
                    Usuario usuario = ((Usuario)(dgvUsuarios.Rows[cell.RowIndex].DataBoundItem));
                    var retorno = MessageBox.Show($"Tem certeza que deseja excluir o usuário {usuario.Nome}?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (retorno == DialogResult.Yes)
                    {
                        usuario.Deletar();
                        MessageBox.Show($"Usuario {usuario.Nome} deletado com sucesso!");
                        LoadCombos();
                    }
                    break;
                }
            }
        }
    }
}
