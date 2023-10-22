namespace Gestao_Catalogos
{
    partial class FormCadastrarLivros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            grpCadastrarLivro = new GroupBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            cmbFormato = new ComboBox();
            txtEdicao = new TextBox();
            txtAno = new TextBox();
            txtLocal = new TextBox();
            txtAutor = new TextBox();
            grpLivroCadastrado = new GroupBox();
            listBox1 = new ListBox();
            btnRecusar = new Button();
            btnConfirma = new Button();
            txtTitulo = new TextBox();
            grpTitulo = new GroupBox();
            btnCancelar1 = new Button();
            btnOk = new Button();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtNumero = new TextBox();
            grpCatalogo = new GroupBox();
            label14 = new Label();
            cmbProp = new ComboBox();
            lstProp = new ListBox();
            cmbCategoria = new ComboBox();
            label13 = new Label();
            label12 = new Label();
            txtNumeroExemplares = new TextBox();
            btnCancelar2 = new Button();
            btnConfirmar1 = new Button();
            btnOk1 = new Button();
            grpCadastrarLivro.SuspendLayout();
            grpLivroCadastrado.SuspendLayout();
            grpTitulo.SuspendLayout();
            grpCatalogo.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 32);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Título:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(221, 36);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Autor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 86);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "Local:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(295, 86);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 3;
            label4.Text = "Ano:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 36);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 4;
            label5.Text = "Formato:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(466, 86);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 5;
            label6.Text = "Edição:";
            // 
            // grpCadastrarLivro
            // 
            grpCadastrarLivro.Controls.Add(btnGravar);
            grpCadastrarLivro.Controls.Add(btnCancelar);
            grpCadastrarLivro.Controls.Add(cmbFormato);
            grpCadastrarLivro.Controls.Add(txtEdicao);
            grpCadastrarLivro.Controls.Add(txtAno);
            grpCadastrarLivro.Controls.Add(txtLocal);
            grpCadastrarLivro.Controls.Add(txtAutor);
            grpCadastrarLivro.Controls.Add(label6);
            grpCadastrarLivro.Controls.Add(label2);
            grpCadastrarLivro.Controls.Add(label5);
            grpCadastrarLivro.Controls.Add(label3);
            grpCadastrarLivro.Controls.Add(label4);
            grpCadastrarLivro.Location = new Point(16, 89);
            grpCadastrarLivro.Name = "grpCadastrarLivro";
            grpCadastrarLivro.Size = new Size(782, 123);
            grpCadastrarLivro.TabIndex = 7;
            grpCadastrarLivro.TabStop = false;
            grpCadastrarLivro.Text = "Cadastrar Livro:";
            grpCadastrarLivro.Enter += grpCadastrarLivro_Enter;
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(639, 22);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(133, 41);
            btnGravar.TabIndex = 14;
            btnGravar.Text = "Gravar e Associar a um catálogo";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(639, 76);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(133, 29);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cmbFormato
            // 
            cmbFormato.FormattingEnabled = true;
            cmbFormato.Location = new Point(73, 33);
            cmbFormato.Name = "cmbFormato";
            cmbFormato.Size = new Size(110, 23);
            cmbFormato.TabIndex = 11;
            // 
            // txtEdicao
            // 
            txtEdicao.Location = new Point(517, 82);
            txtEdicao.Name = "txtEdicao";
            txtEdicao.Size = new Size(103, 23);
            txtEdicao.TabIndex = 10;
            // 
            // txtAno
            // 
            txtAno.Location = new Point(333, 83);
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(90, 23);
            txtAno.TabIndex = 9;
            // 
            // txtLocal
            // 
            txtLocal.Location = new Point(71, 83);
            txtLocal.Name = "txtLocal";
            txtLocal.Size = new Size(188, 23);
            txtLocal.TabIndex = 8;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(267, 33);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(355, 23);
            txtAutor.TabIndex = 7;
            // 
            // grpLivroCadastrado
            // 
            grpLivroCadastrado.Controls.Add(listBox1);
            grpLivroCadastrado.Controls.Add(btnRecusar);
            grpLivroCadastrado.Controls.Add(btnConfirma);
            grpLivroCadastrado.Location = new Point(16, 218);
            grpLivroCadastrado.Name = "grpLivroCadastrado";
            grpLivroCadastrado.Size = new Size(782, 107);
            grpLivroCadastrado.TabIndex = 9;
            grpLivroCadastrado.TabStop = false;
            grpLivroCadastrado.Text = "Dados do livro cadastrado";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(20, 25);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(477, 64);
            listBox1.TabIndex = 24;
            // 
            // btnRecusar
            // 
            btnRecusar.Location = new Point(647, 25);
            btnRecusar.Name = "btnRecusar";
            btnRecusar.Size = new Size(117, 64);
            btnRecusar.TabIndex = 23;
            btnRecusar.Text = "Recusar e Cadastrar outra edição";
            btnRecusar.UseVisualStyleBackColor = true;
            btnRecusar.Click += btnRecusar_Click;
            // 
            // btnConfirma
            // 
            btnConfirma.Location = new Point(518, 25);
            btnConfirma.Name = "btnConfirma";
            btnConfirma.Size = new Size(117, 64);
            btnConfirma.TabIndex = 22;
            btnConfirma.Text = "Confirmar e Associar a um catálogo";
            btnConfirma.UseVisualStyleBackColor = true;
            btnConfirma.Click += btnConfirma_Click;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(66, 29);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(490, 23);
            txtTitulo.TabIndex = 6;
            // 
            // grpTitulo
            // 
            grpTitulo.Controls.Add(btnCancelar1);
            grpTitulo.Controls.Add(btnOk);
            grpTitulo.Controls.Add(txtTitulo);
            grpTitulo.Controls.Add(label1);
            grpTitulo.Location = new Point(16, 12);
            grpTitulo.Name = "grpTitulo";
            grpTitulo.Size = new Size(782, 71);
            grpTitulo.TabIndex = 8;
            grpTitulo.TabStop = false;
            grpTitulo.Text = "Título do livro";
            // 
            // btnCancelar1
            // 
            btnCancelar1.Location = new Point(689, 28);
            btnCancelar1.Name = "btnCancelar1";
            btnCancelar1.Size = new Size(75, 23);
            btnCancelar1.TabIndex = 8;
            btnCancelar1.Text = "Cancelar";
            btnCancelar1.UseVisualStyleBackColor = true;
            btnCancelar1.Click += btnCancelar_Click;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(582, 28);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 7;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(223, 36);
            label8.Name = "label8";
            label8.Size = new Size(125, 15);
            label8.TabIndex = 12;
            label8.Text = "Nome do Proprietário:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 36);
            label9.Name = "label9";
            label9.Size = new Size(54, 15);
            label9.TabIndex = 15;
            label9.Text = "Número:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(42, 64);
            label10.Name = "label10";
            label10.Size = new Size(0, 15);
            label10.TabIndex = 13;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(71, 33);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(73, 23);
            txtNumero.TabIndex = 21;
            // 
            // grpCatalogo
            // 
            grpCatalogo.Controls.Add(label14);
            grpCatalogo.Controls.Add(cmbProp);
            grpCatalogo.Controls.Add(lstProp);
            grpCatalogo.Controls.Add(cmbCategoria);
            grpCatalogo.Controls.Add(label13);
            grpCatalogo.Controls.Add(label12);
            grpCatalogo.Controls.Add(txtNumeroExemplares);
            grpCatalogo.Controls.Add(btnCancelar2);
            grpCatalogo.Controls.Add(btnConfirmar1);
            grpCatalogo.Controls.Add(btnOk1);
            grpCatalogo.Controls.Add(txtNumero);
            grpCatalogo.Controls.Add(label10);
            grpCatalogo.Controls.Add(label9);
            grpCatalogo.Controls.Add(label8);
            grpCatalogo.Location = new Point(16, 331);
            grpCatalogo.Name = "grpCatalogo";
            grpCatalogo.Size = new Size(782, 208);
            grpCatalogo.TabIndex = 10;
            grpCatalogo.TabStop = false;
            grpCatalogo.Text = "Selecionar Catálogo";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = SystemColors.ActiveCaption;
            label14.Location = new Point(175, 36);
            label14.Name = "label14";
            label14.Size = new Size(24, 15);
            label14.TabIndex = 32;
            label14.Text = "OU";
            // 
            // cmbProp
            // 
            cmbProp.FormattingEnabled = true;
            cmbProp.Location = new Point(354, 33);
            cmbProp.Name = "cmbProp";
            cmbProp.Size = new Size(320, 23);
            cmbProp.TabIndex = 31;
            // 
            // lstProp
            // 
            lstProp.FormattingEnabled = true;
            lstProp.ItemHeight = 15;
            lstProp.Location = new Point(48, 76);
            lstProp.Name = "lstProp";
            lstProp.Size = new Size(684, 64);
            lstProp.TabIndex = 30;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(385, 157);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(188, 23);
            cmbCategoria.TabIndex = 29;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(13, 160);
            label13.Name = "label13";
            label13.Size = new Size(133, 15);
            label13.TabIndex = 28;
            label13.Text = "Número de exemplares:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(318, 160);
            label12.Name = "label12";
            label12.Size = new Size(61, 15);
            label12.TabIndex = 27;
            label12.Text = "Categoria:";
            // 
            // txtNumeroExemplares
            // 
            txtNumeroExemplares.Location = new Point(152, 157);
            txtNumeroExemplares.Name = "txtNumeroExemplares";
            txtNumeroExemplares.Size = new Size(100, 23);
            txtNumeroExemplares.TabIndex = 25;
            // 
            // btnCancelar2
            // 
            btnCancelar2.Location = new Point(691, 157);
            btnCancelar2.Name = "btnCancelar2";
            btnCancelar2.Size = new Size(75, 27);
            btnCancelar2.TabIndex = 24;
            btnCancelar2.Text = "Cancelar";
            btnCancelar2.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar1
            // 
            btnConfirmar1.DialogResult = DialogResult.Yes;
            btnConfirmar1.Location = new Point(597, 157);
            btnConfirmar1.Name = "btnConfirmar1";
            btnConfirmar1.Size = new Size(75, 27);
            btnConfirmar1.TabIndex = 15;
            btnConfirmar1.Text = "Confirmar";
            btnConfirmar1.UseVisualStyleBackColor = true;
            btnConfirmar1.Click += btnConfirmar1_Click;
            // 
            // btnOk1
            // 
            btnOk1.Location = new Point(689, 32);
            btnOk1.Name = "btnOk1";
            btnOk1.Size = new Size(75, 23);
            btnOk1.TabIndex = 23;
            btnOk1.Text = "OK";
            btnOk1.UseVisualStyleBackColor = true;
            btnOk1.Click += btnOk1_Click;
            // 
            // FormCadastrarLivros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 550);
            Controls.Add(grpCatalogo);
            Controls.Add(grpLivroCadastrado);
            Controls.Add(grpTitulo);
            Controls.Add(grpCadastrarLivro);
            Name = "FormCadastrarLivros";
            Text = "FormCadastrarLivros";
            grpCadastrarLivro.ResumeLayout(false);
            grpCadastrarLivro.PerformLayout();
            grpLivroCadastrado.ResumeLayout(false);
            grpTitulo.ResumeLayout(false);
            grpTitulo.PerformLayout();
            grpCatalogo.ResumeLayout(false);
            grpCatalogo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private GroupBox grpCadastrarLivro;
        private TextBox txtEdicao;
        private TextBox txtAno;
        private TextBox txtLocal;
        private TextBox txtAutor;
        private TextBox txtTitulo;
        private Button btnCancelar;
        private ComboBox cmbFormato;
        private Button btnGravar;
        private GroupBox grpTitulo;
        private Button btnCancelar1;
        private Button btnOk;
        private GroupBox grpLivroCadastrado;
        private TextBox txtNumero;
        private TextBox txtEdicao1;
        private TextBox txtAno1;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button btnRecusar;
        private Button btnConfirma;
        private ListBox listBox1;
        private GroupBox grpCatalogo;
        private Button btnCancelar2;
        private Button btnConfirmar1;
        private Button btnOk1;
        private ComboBox cmbCategoria;
        private Label label13;
        private Label label12;
        private TextBox txtNumeroExemplares;
        private ListBox lstProp;
        private ComboBox cmbProp;
        private Label label14;
    }
}