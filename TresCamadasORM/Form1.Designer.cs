
namespace TresCamadas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.mtxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageUsuarios = new System.Windows.Forms.TabPage();
            this.lblId = new System.Windows.Forms.Label();
            this.lblIdText = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageEnderecos = new System.Windows.Forms.TabPage();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.btnGravarEndereco = new System.Windows.Forms.Button();
            this.cbxUsuario = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPageResultado = new System.Windows.Forms.TabPage();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.cbxNomeUsuario = new System.Windows.Forms.ComboBox();
            this.dgvEnderecos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTelResult = new System.Windows.Forms.Label();
            this.lblCPFResult = new System.Windows.Forms.Label();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.tabPageEnderecos.SuspendLayout();
            this.tabPageResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnderecos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(37, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "CPF:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(97, 27);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(210, 23);
            this.txtNome.TabIndex = 3;
            // 
            // mtxtTelefone
            // 
            this.mtxtTelefone.Location = new System.Drawing.Point(97, 63);
            this.mtxtTelefone.Mask = "(99) 0000-0000";
            this.mtxtTelefone.Name = "mtxtTelefone";
            this.mtxtTelefone.Size = new System.Drawing.Size(210, 23);
            this.mtxtTelefone.TabIndex = 4;
            // 
            // mtxtCPF
            // 
            this.mtxtCPF.Location = new System.Drawing.Point(97, 98);
            this.mtxtCPF.Mask = "000,000,000-00";
            this.mtxtCPF.Name = "mtxtCPF";
            this.mtxtCPF.Size = new System.Drawing.Size(210, 23);
            this.mtxtCPF.TabIndex = 5;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(313, 96);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(112, 28);
            this.btnGravar.TabIndex = 6;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageUsuarios);
            this.tabControl1.Controls.Add(this.tabPageEnderecos);
            this.tabControl1.Controls.Add(this.tabPageResultado);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(448, 481);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPageUsuarios
            // 
            this.tabPageUsuarios.Controls.Add(this.lblId);
            this.tabPageUsuarios.Controls.Add(this.lblIdText);
            this.tabPageUsuarios.Controls.Add(this.dgvUsuarios);
            this.tabPageUsuarios.Controls.Add(this.txtNome);
            this.tabPageUsuarios.Controls.Add(this.btnGravar);
            this.tabPageUsuarios.Controls.Add(this.label1);
            this.tabPageUsuarios.Controls.Add(this.mtxtCPF);
            this.tabPageUsuarios.Controls.Add(this.label2);
            this.tabPageUsuarios.Controls.Add(this.mtxtTelefone);
            this.tabPageUsuarios.Controls.Add(this.label3);
            this.tabPageUsuarios.Location = new System.Drawing.Point(4, 24);
            this.tabPageUsuarios.Name = "tabPageUsuarios";
            this.tabPageUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUsuarios.Size = new System.Drawing.Size(440, 453);
            this.tabPageUsuarios.TabIndex = 0;
            this.tabPageUsuarios.Text = "Usuários";
            this.tabPageUsuarios.UseVisualStyleBackColor = true;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(379, 15);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 15);
            this.lblId.TabIndex = 9;
            // 
            // lblIdText
            // 
            this.lblIdText.AutoSize = true;
            this.lblIdText.Location = new System.Drawing.Point(349, 15);
            this.lblIdText.Name = "lblIdText";
            this.lblIdText.Size = new System.Drawing.Size(24, 15);
            this.lblIdText.TabIndex = 8;
            this.lblIdText.Text = "ID: ";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.Telefone,
            this.CPF});
            this.dgvUsuarios.Location = new System.Drawing.Point(3, 160);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowTemplate.Height = 25;
            this.dgvUsuarios.Size = new System.Drawing.Size(434, 290);
            this.dgvUsuarios.TabIndex = 7;
            this.dgvUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "#";
            this.Id.Name = "Id";
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Telefone
            // 
            this.Telefone.DataPropertyName = "Telefone";
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            // 
            // CPF
            // 
            this.CPF.DataPropertyName = "CPF";
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            // 
            // tabPageEnderecos
            // 
            this.tabPageEnderecos.Controls.Add(this.txtEstado);
            this.tabPageEnderecos.Controls.Add(this.txtCidade);
            this.tabPageEnderecos.Controls.Add(this.txtNumero);
            this.tabPageEnderecos.Controls.Add(this.txtLogradouro);
            this.tabPageEnderecos.Controls.Add(this.btnGravarEndereco);
            this.tabPageEnderecos.Controls.Add(this.cbxUsuario);
            this.tabPageEnderecos.Controls.Add(this.label11);
            this.tabPageEnderecos.Controls.Add(this.label10);
            this.tabPageEnderecos.Controls.Add(this.label9);
            this.tabPageEnderecos.Controls.Add(this.label8);
            this.tabPageEnderecos.Controls.Add(this.label7);
            this.tabPageEnderecos.Location = new System.Drawing.Point(4, 24);
            this.tabPageEnderecos.Name = "tabPageEnderecos";
            this.tabPageEnderecos.Size = new System.Drawing.Size(440, 453);
            this.tabPageEnderecos.TabIndex = 3;
            this.tabPageEnderecos.Text = "Endereços";
            this.tabPageEnderecos.UseVisualStyleBackColor = true;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(128, 219);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(254, 23);
            this.txtEstado.TabIndex = 11;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(128, 169);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(254, 23);
            this.txtCidade.TabIndex = 10;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(128, 124);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(254, 23);
            this.txtNumero.TabIndex = 9;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(128, 85);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(254, 23);
            this.txtLogradouro.TabIndex = 8;
            // 
            // btnGravarEndereco
            // 
            this.btnGravarEndereco.Location = new System.Drawing.Point(270, 319);
            this.btnGravarEndereco.Name = "btnGravarEndereco";
            this.btnGravarEndereco.Size = new System.Drawing.Size(112, 28);
            this.btnGravarEndereco.TabIndex = 7;
            this.btnGravarEndereco.Text = "Gravar";
            this.btnGravarEndereco.UseVisualStyleBackColor = true;
            this.btnGravarEndereco.Click += new System.EventHandler(this.btnGravarEndereco_Click);
            // 
            // cbxUsuario
            // 
            this.cbxUsuario.FormattingEnabled = true;
            this.cbxUsuario.Location = new System.Drawing.Point(128, 46);
            this.cbxUsuario.Name = "cbxUsuario";
            this.cbxUsuario.Size = new System.Drawing.Size(254, 23);
            this.cbxUsuario.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(21, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 21);
            this.label11.TabIndex = 5;
            this.label11.Text = "Logradouro:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(48, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 21);
            this.label10.TabIndex = 4;
            this.label10.Text = "Número:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(57, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 21);
            this.label9.TabIndex = 3;
            this.label9.Text = "Cidade:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(63, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 21);
            this.label8.TabIndex = 2;
            this.label8.Text = "Estado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(53, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "Usuário:";
            // 
            // tabPageResultado
            // 
            this.tabPageResultado.Controls.Add(this.btnPesquisar);
            this.tabPageResultado.Controls.Add(this.cbxNomeUsuario);
            this.tabPageResultado.Controls.Add(this.dgvEnderecos);
            this.tabPageResultado.Controls.Add(this.label4);
            this.tabPageResultado.Controls.Add(this.lblTelResult);
            this.tabPageResultado.Controls.Add(this.lblCPFResult);
            this.tabPageResultado.Location = new System.Drawing.Point(4, 24);
            this.tabPageResultado.Name = "tabPageResultado";
            this.tabPageResultado.Size = new System.Drawing.Size(440, 453);
            this.tabPageResultado.TabIndex = 2;
            this.tabPageResultado.Text = "Resultado";
            this.tabPageResultado.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(331, 27);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(67, 28);
            this.btnPesquisar.TabIndex = 9;
            this.btnPesquisar.Text = "OK";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // cbxNomeUsuario
            // 
            this.cbxNomeUsuario.FormattingEnabled = true;
            this.cbxNomeUsuario.Location = new System.Drawing.Point(101, 29);
            this.cbxNomeUsuario.Name = "cbxNomeUsuario";
            this.cbxNomeUsuario.Size = new System.Drawing.Size(194, 23);
            this.cbxNomeUsuario.TabIndex = 8;
            this.cbxNomeUsuario.SelectedIndexChanged += new System.EventHandler(this.cbxNomeUsuario_SelectedIndexChanged);
            // 
            // dgvEnderecos
            // 
            this.dgvEnderecos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnderecos.Location = new System.Drawing.Point(18, 199);
            this.dgvEnderecos.Name = "dgvEnderecos";
            this.dgvEnderecos.RowTemplate.Height = 25;
            this.dgvEnderecos.Size = new System.Drawing.Size(391, 234);
            this.dgvEnderecos.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(36, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nome:";
            // 
            // lblTelResult
            // 
            this.lblTelResult.AutoSize = true;
            this.lblTelResult.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTelResult.Location = new System.Drawing.Point(18, 124);
            this.lblTelResult.Name = "lblTelResult";
            this.lblTelResult.Size = new System.Drawing.Size(77, 21);
            this.lblTelResult.TabIndex = 5;
            this.lblTelResult.Text = "Telefone:";
            // 
            // lblCPFResult
            // 
            this.lblCPFResult.AutoSize = true;
            this.lblCPFResult.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCPFResult.Location = new System.Drawing.Point(54, 158);
            this.lblCPFResult.Name = "lblCPFResult";
            this.lblCPFResult.Size = new System.Drawing.Size(41, 21);
            this.lblCPFResult.TabIndex = 6;
            this.lblCPFResult.Text = "CPF:";
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(329, 499);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(112, 28);
            this.btnDeletar.TabIndex = 10;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 550);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageUsuarios.ResumeLayout(false);
            this.tabPageUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.tabPageEnderecos.ResumeLayout(false);
            this.tabPageEnderecos.PerformLayout();
            this.tabPageResultado.ResumeLayout(false);
            this.tabPageResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnderecos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox mtxtTelefone;
        private System.Windows.Forms.MaskedTextBox mtxtCPF;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageUsuarios;
        private System.Windows.Forms.TabPage tabPageResultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTelResult;
        private System.Windows.Forms.Label lblCPFResult;
        private System.Windows.Forms.TabPage tabPageEnderecos;
        private System.Windows.Forms.ComboBox cbxUsuario;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Button btnGravarEndereco;
        private System.Windows.Forms.DataGridView dgvEnderecos;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.ComboBox cbxNomeUsuario;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.Label lblIdText;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnDeletar;
    }
}

