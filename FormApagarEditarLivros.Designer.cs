namespace Gestao_Catalogos
{
    partial class FormApagarEditarLivros
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
            grp4 = new GroupBox();
            cmbTitulo = new ComboBox();
            btnBuscarT = new Button();
            listBox2 = new ListBox();
            btnEditarLivroCatalogo = new Button();
            label2 = new Label();
            btnApagarLivroCatalogo = new Button();
            cmbProp = new ComboBox();
            lstProp = new ListBox();
            btnOk1 = new Button();
            label10 = new Label();
            label8 = new Label();
            cmbCategoria = new ComboBox();
            label13 = new Label();
            label12 = new Label();
            txtNumeroExemplares = new TextBox();
            grp2 = new GroupBox();
            btnBuscar = new Button();
            btnEditarLivro = new Button();
            btnApagarLivro = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            txtTitulo = new TextBox();
            grp1 = new GroupBox();
            button1 = new Button();
            btnCancelar1 = new Button();
            btnApEdLivro = new Button();
            grp3 = new GroupBox();
            label11 = new Label();
            grp5 = new GroupBox();
            button2 = new Button();
            txtTitulo2 = new TextBox();
            btnGravar = new Button();
            btnCancel4 = new Button();
            cmbFormato = new ComboBox();
            txtEdicao = new TextBox();
            txtAno = new TextBox();
            txtLocal = new TextBox();
            txtAutor = new TextBox();
            label6 = new Label();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            label7 = new Label();
            grp4.SuspendLayout();
            grp2.SuspendLayout();
            grp1.SuspendLayout();
            grp3.SuspendLayout();
            grp5.SuspendLayout();
            SuspendLayout();
            // 
            // grp4
            // 
            grp4.Controls.Add(cmbTitulo);
            grp4.Controls.Add(btnBuscarT);
            grp4.Controls.Add(listBox2);
            grp4.Controls.Add(btnEditarLivroCatalogo);
            grp4.Controls.Add(label2);
            grp4.Controls.Add(btnApagarLivroCatalogo);
            grp4.Controls.Add(cmbProp);
            grp4.Controls.Add(lstProp);
            grp4.Controls.Add(btnOk1);
            grp4.Controls.Add(label10);
            grp4.Controls.Add(label8);
            grp4.Location = new Point(8, 388);
            grp4.Name = "grp4";
            grp4.Size = new Size(782, 243);
            grp4.TabIndex = 14;
            grp4.TabStop = false;
            grp4.Text = "Selecionar Catálogo";
            // 
            // cmbTitulo
            // 
            cmbTitulo.FormattingEnabled = true;
            cmbTitulo.Location = new Point(52, 140);
            cmbTitulo.Name = "cmbTitulo";
            cmbTitulo.Size = new Size(496, 23);
            cmbTitulo.TabIndex = 36;
            // 
            // btnBuscarT
            // 
            btnBuscarT.Location = new Point(572, 142);
            btnBuscarT.Name = "btnBuscarT";
            btnBuscarT.Size = new Size(192, 23);
            btnBuscarT.TabIndex = 32;
            btnBuscarT.Text = "Buscar";
            btnBuscarT.UseVisualStyleBackColor = true;
            btnBuscarT.Click += btnbtnBuscarT;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(54, 178);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(494, 49);
            listBox2.TabIndex = 35;
            // 
            // btnEditarLivroCatalogo
            // 
            btnEditarLivroCatalogo.Location = new Point(680, 184);
            btnEditarLivroCatalogo.Name = "btnEditarLivroCatalogo";
            btnEditarLivroCatalogo.Size = new Size(84, 43);
            btnEditarLivroCatalogo.TabIndex = 30;
            btnEditarLivroCatalogo.Text = "Editar Livro no Catálogo";
            btnEditarLivroCatalogo.UseVisualStyleBackColor = true;
            btnEditarLivroCatalogo.Click += btnEditarLivroCatalogo_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 143);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 33;
            label2.Text = "Título:";
            // 
            // btnApagarLivroCatalogo
            // 
            btnApagarLivroCatalogo.Location = new Point(572, 184);
            btnApagarLivroCatalogo.Name = "btnApagarLivroCatalogo";
            btnApagarLivroCatalogo.Size = new Size(88, 43);
            btnApagarLivroCatalogo.TabIndex = 29;
            btnApagarLivroCatalogo.Text = "Apagar Livro no Catálogo";
            btnApagarLivroCatalogo.UseVisualStyleBackColor = true;
            btnApagarLivroCatalogo.Click += btnApagarLivroCatalogo_Click;
            // 
            // cmbProp
            // 
            cmbProp.FormattingEnabled = true;
            cmbProp.Location = new Point(179, 24);
            cmbProp.Name = "cmbProp";
            cmbProp.Size = new Size(495, 23);
            cmbProp.TabIndex = 31;
            // 
            // lstProp
            // 
            lstProp.FormattingEnabled = true;
            lstProp.ItemHeight = 15;
            lstProp.Location = new Point(48, 61);
            lstProp.Name = "lstProp";
            lstProp.Size = new Size(684, 64);
            lstProp.TabIndex = 30;
            lstProp.SelectedIndexChanged += lstProp_SelectedIndexChanged;
            // 
            // btnOk1
            // 
            btnOk1.Location = new Point(689, 23);
            btnOk1.Name = "btnOk1";
            btnOk1.Size = new Size(75, 23);
            btnOk1.TabIndex = 23;
            btnOk1.Text = "OK";
            btnOk1.UseVisualStyleBackColor = true;
            btnOk1.Click += btnOk1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(42, 55);
            label10.Name = "label10";
            label10.Size = new Size(0, 15);
            label10.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(48, 27);
            label8.Name = "label8";
            label8.Size = new Size(125, 15);
            label8.TabIndex = 12;
            label8.Text = "Nome do Proprietário:";
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(430, 20);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(188, 23);
            cmbCategoria.TabIndex = 39;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(17, 23);
            label13.Name = "label13";
            label13.Size = new Size(133, 15);
            label13.TabIndex = 38;
            label13.Text = "Número de exemplares:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(363, 23);
            label12.Name = "label12";
            label12.Size = new Size(61, 15);
            label12.TabIndex = 37;
            label12.Text = "Categoria:";
            // 
            // txtNumeroExemplares
            // 
            txtNumeroExemplares.Location = new Point(156, 20);
            txtNumeroExemplares.Name = "txtNumeroExemplares";
            txtNumeroExemplares.Size = new Size(100, 23);
            txtNumeroExemplares.TabIndex = 36;
            // 
            // grp2
            // 
            grp2.Controls.Add(btnBuscar);
            grp2.Controls.Add(btnEditarLivro);
            grp2.Controls.Add(btnApagarLivro);
            grp2.Controls.Add(listBox1);
            grp2.Controls.Add(label1);
            grp2.Controls.Add(txtTitulo);
            grp2.Location = new Point(8, 77);
            grp2.Name = "grp2";
            grp2.Size = new Size(786, 129);
            grp2.TabIndex = 13;
            grp2.TabStop = false;
            grp2.Text = "Dados do livro cadastrado";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(572, 24);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(184, 23);
            btnBuscar.TabIndex = 28;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnEditarLivro
            // 
            btnEditarLivro.Location = new Point(680, 66);
            btnEditarLivro.Name = "btnEditarLivro";
            btnEditarLivro.Size = new Size(75, 43);
            btnEditarLivro.TabIndex = 26;
            btnEditarLivro.Text = "Editar Livro";
            btnEditarLivro.UseVisualStyleBackColor = true;
            btnEditarLivro.Click += btnEditarLivro_Click;
            // 
            // btnApagarLivro
            // 
            btnApagarLivro.Location = new Point(572, 66);
            btnApagarLivro.Name = "btnApagarLivro";
            btnApagarLivro.Size = new Size(75, 43);
            btnApagarLivro.TabIndex = 25;
            btnApagarLivro.Text = "Apagar Livro";
            btnApagarLivro.UseVisualStyleBackColor = true;
            btnApagarLivro.Click += btnApagarLivro_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(52, 54);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(490, 64);
            listBox1.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Título:";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(52, 25);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(490, 23);
            txtTitulo.TabIndex = 6;
            // 
            // grp1
            // 
            grp1.Controls.Add(button1);
            grp1.Controls.Add(btnCancelar1);
            grp1.Controls.Add(btnApEdLivro);
            grp1.Location = new Point(8, 12);
            grp1.Name = "grp1";
            grp1.Size = new Size(786, 56);
            grp1.TabIndex = 12;
            grp1.TabStop = false;
            grp1.Text = "Seleciona a operação desejada";
            // 
            // button1
            // 
            button1.Location = new Point(280, 20);
            button1.Name = "button1";
            button1.Size = new Size(288, 25);
            button1.TabIndex = 9;
            button1.Text = "Apagar ou Editar Livros registados em um Catálogo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnCancelar1
            // 
            btnCancelar1.Location = new Point(613, 20);
            btnCancelar1.Name = "btnCancelar1";
            btnCancelar1.Size = new Size(167, 25);
            btnCancelar1.TabIndex = 8;
            btnCancelar1.Text = "Cancelar";
            btnCancelar1.UseVisualStyleBackColor = true;
            btnCancelar1.Click += btnCancelar1_Click;
            // 
            // btnApEdLivro
            // 
            btnApEdLivro.Location = new Point(27, 21);
            btnApEdLivro.Name = "btnApEdLivro";
            btnApEdLivro.Size = new Size(207, 25);
            btnApEdLivro.TabIndex = 7;
            btnApEdLivro.Text = "Apagar ou Editar Livros Cadastrados";
            btnApEdLivro.UseVisualStyleBackColor = true;
            btnApEdLivro.Click += btnApEdLivro_Click;
            // 
            // grp3
            // 
            grp3.Controls.Add(label11);
            grp3.Controls.Add(grp5);
            grp3.Controls.Add(txtTitulo2);
            grp3.Controls.Add(btnGravar);
            grp3.Controls.Add(btnCancel4);
            grp3.Controls.Add(cmbFormato);
            grp3.Controls.Add(txtEdicao);
            grp3.Controls.Add(txtAno);
            grp3.Controls.Add(txtLocal);
            grp3.Controls.Add(txtAutor);
            grp3.Controls.Add(label6);
            grp3.Controls.Add(label3);
            grp3.Controls.Add(label5);
            grp3.Controls.Add(label4);
            grp3.Controls.Add(label7);
            grp3.Location = new Point(8, 217);
            grp3.Name = "grp3";
            grp3.Size = new Size(786, 160);
            grp3.TabIndex = 36;
            grp3.TabStop = false;
            grp3.Text = "Dados do Livro:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(25, 25);
            label11.Name = "label11";
            label11.Size = new Size(40, 15);
            label11.TabIndex = 29;
            label11.Text = "Título:";
            // 
            // grp5
            // 
            grp5.BackColor = SystemColors.Control;
            grp5.Controls.Add(button2);
            grp5.Controls.Add(txtNumeroExemplares);
            grp5.Controls.Add(cmbCategoria);
            grp5.Controls.Add(label13);
            grp5.Controls.Add(label12);
            grp5.Location = new Point(2, 111);
            grp5.Name = "grp5";
            grp5.Size = new Size(782, 48);
            grp5.TabIndex = 40;
            grp5.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDark;
            button2.Location = new Point(645, 15);
            button2.Name = "button2";
            button2.Size = new Size(131, 28);
            button2.TabIndex = 40;
            button2.Text = "Gravar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // txtTitulo2
            // 
            txtTitulo2.Location = new Point(71, 22);
            txtTitulo2.Name = "txtTitulo2";
            txtTitulo2.Size = new Size(549, 23);
            txtTitulo2.TabIndex = 30;
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(647, 26);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(133, 29);
            btnGravar.TabIndex = 14;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancel4
            // 
            btnCancel4.Location = new Point(645, 74);
            btnCancel4.Name = "btnCancel4";
            btnCancel4.Size = new Size(133, 29);
            btnCancel4.TabIndex = 13;
            btnCancel4.Text = "Cancelar";
            btnCancel4.UseVisualStyleBackColor = true;
            btnCancel4.Click += btnCancelar1_Click;
            // 
            // cmbFormato
            // 
            cmbFormato.FormattingEnabled = true;
            cmbFormato.Location = new Point(71, 56);
            cmbFormato.Name = "cmbFormato";
            cmbFormato.Size = new Size(110, 23);
            cmbFormato.TabIndex = 11;
            // 
            // txtEdicao
            // 
            txtEdicao.Location = new Point(517, 84);
            txtEdicao.Name = "txtEdicao";
            txtEdicao.Size = new Size(103, 23);
            txtEdicao.TabIndex = 10;
            // 
            // txtAno
            // 
            txtAno.Location = new Point(333, 84);
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(90, 23);
            txtAno.TabIndex = 9;
            // 
            // txtLocal
            // 
            txtLocal.Location = new Point(71, 85);
            txtLocal.Name = "txtLocal";
            txtLocal.Size = new Size(188, 23);
            txtLocal.TabIndex = 8;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(264, 53);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(355, 23);
            txtAutor.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(466, 87);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 5;
            label6.Text = "Edição:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(218, 56);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 1;
            label3.Text = "Autor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 59);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 4;
            label5.Text = "Formato:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 88);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 2;
            label4.Text = "Local:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(295, 87);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 3;
            label7.Text = "Ano:";
            // 
            // FormApagarEditarLivros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 642);
            Controls.Add(grp3);
            Controls.Add(grp4);
            Controls.Add(grp2);
            Controls.Add(grp1);
            Name = "FormApagarEditarLivros";
            Text = "FormApagarEditarLivros";
            grp4.ResumeLayout(false);
            grp4.PerformLayout();
            grp2.ResumeLayout(false);
            grp2.PerformLayout();
            grp1.ResumeLayout(false);
            grp3.ResumeLayout(false);
            grp3.PerformLayout();
            grp5.ResumeLayout(false);
            grp5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grp4;
        private ComboBox cmbProp;
        private ListBox lstProp;
        private Button btnCancelar2;
        private Button btnConfirmar1;
        private Button btnOk1;
        private Label label10;
        private Label label8;
        private GroupBox grp2;
        private ListBox listBox1;
        private GroupBox grp1;
        private Button btnCancelar1;
        private Button btnApEdLivro;
        private TextBox txtTitulo;
        private Label label1;
        private Button btnEditarLivro;
        private Button btnApagarLivro;
        private Button button1;
        private Label label2;
        private Button btnBuscar;
        private GroupBox grp3;
        private Button btnGravar;
        private Button btnCancel4;
        private ComboBox cmbFormato;
        private TextBox txtEdicao;
        private TextBox txtAno;
        private TextBox txtLocal;
        private TextBox txtAutor;
        private Label label6;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label7;
        private Button btnBuscarT;
        private Button btnEditarLivroCatalogo;
        private Button btnApagarLivroCatalogo;
        private ComboBox cmbCategoria;
        private Label label13;
        private Label label12;
        private TextBox txtNumeroExemplares;
        private GroupBox grp5;
        private Button button2;
        private ComboBox cmbTitulo;
        private ListBox listBox2;
        private Label label11;
        private TextBox txtTitulo2;
    }
}