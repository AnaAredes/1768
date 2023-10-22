namespace Gestao_Catalogos
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
            groupBox1 = new GroupBox();
            btnAlterarFreguesia = new Button();
            caixaTexto = new RichTextBox();
            btnVerCatalogos = new Button();
            btnFreguesia = new Button();
            btnEditar = new Button();
            btnCadastrar = new Button();
            groupBox2 = new GroupBox();
            btnVer = new Button();
            btnLivros = new Button();
            btnLivrosCatalogo = new Button();
            titulo = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAlterarFreguesia);
            groupBox1.Controls.Add(caixaTexto);
            groupBox1.Controls.Add(btnVerCatalogos);
            groupBox1.Controls.Add(btnFreguesia);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(btnCadastrar);
            groupBox1.Location = new Point(12, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(618, 223);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Catálogos";
            // 
            // btnAlterarFreguesia
            // 
            btnAlterarFreguesia.Location = new Point(479, 170);
            btnAlterarFreguesia.Name = "btnAlterarFreguesia";
            btnAlterarFreguesia.Size = new Size(118, 27);
            btnAlterarFreguesia.TabIndex = 10;
            btnAlterarFreguesia.Text = "Alterar Freguesia";
            btnAlterarFreguesia.UseVisualStyleBackColor = true;
            btnAlterarFreguesia.Click += btnAlterarFreguesia_Click;
            // 
            // caixaTexto
            // 
            caixaTexto.Location = new Point(18, 37);
            caixaTexto.Name = "caixaTexto";
            caixaTexto.Size = new Size(317, 160);
            caixaTexto.TabIndex = 9;
            caixaTexto.Text = "";
            // 
            // btnVerCatalogos
            // 
            btnVerCatalogos.Location = new Point(353, 34);
            btnVerCatalogos.Name = "btnVerCatalogos";
            btnVerCatalogos.Size = new Size(244, 27);
            btnVerCatalogos.TabIndex = 7;
            btnVerCatalogos.Text = "Ver Lista com todos os Catálogos";
            btnVerCatalogos.UseVisualStyleBackColor = true;
            btnVerCatalogos.Click += btnVerCatalogos_Click;
            // 
            // btnFreguesia
            // 
            btnFreguesia.Location = new Point(353, 170);
            btnFreguesia.Name = "btnFreguesia";
            btnFreguesia.Size = new Size(118, 27);
            btnFreguesia.TabIndex = 5;
            btnFreguesia.Text = "Cadastrar Freguesia";
            btnFreguesia.UseVisualStyleBackColor = true;
            btnFreguesia.Click += btnFreguesia_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(353, 125);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(244, 27);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar ou Apagar Proprietário";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(353, 79);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(244, 27);
            btnCadastrar.TabIndex = 1;
            btnCadastrar.Text = "Cadastrar Proprietario";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnVer);
            groupBox2.Controls.Add(btnLivros);
            groupBox2.Controls.Add(btnLivrosCatalogo);
            groupBox2.Location = new Point(12, 279);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(618, 107);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Livros nos Catálogos";
            // 
            // btnVer
            // 
            btnVer.Location = new Point(455, 29);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(142, 54);
            btnVer.TabIndex = 15;
            btnVer.Text = "Ver Dados";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
            // 
            // btnLivros
            // 
            btnLivros.Location = new Point(240, 29);
            btnLivros.Name = "btnLivros";
            btnLivros.Size = new Size(142, 53);
            btnLivros.TabIndex = 11;
            btnLivros.Text = "Apagar ou Editar Livros Cadastrados";
            btnLivros.UseVisualStyleBackColor = true;
            btnLivros.Click += btnLivros_Click;
            // 
            // btnLivrosCatalogo
            // 
            btnLivrosCatalogo.Location = new Point(18, 29);
            btnLivrosCatalogo.Name = "btnLivrosCatalogo";
            btnLivrosCatalogo.Size = new Size(142, 53);
            btnLivrosCatalogo.TabIndex = 12;
            btnLivrosCatalogo.Text = "Cadastrar Livros em um Catálogo";
            btnLivrosCatalogo.UseVisualStyleBackColor = true;
            btnLivrosCatalogo.Click += btnLivrosCatalogo_Click;
            // 
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Underline, GraphicsUnit.Point);
            titulo.Location = new Point(119, 12);
            titulo.Name = "titulo";
            titulo.Size = new Size(410, 25);
            titulo.TabIndex = 20;
            titulo.Text = "Gestão de Catálogos de Bibliotecas Particulares";
            titulo.Click += titulo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 397);
            Controls.Add(titulo);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnEditar;
        private Button btnCadastrar;
        private Button btnFreguesia;
        private GroupBox groupBox2;
        private Button btnVer;
        private Button btnLivros;
        private Button btnLivrosCatalogo;
        private Button btnVerCatalogos;
        private RichTextBox caixaTexto;
        private Button btnAlterarFreguesia;
        private Label titulo;
    }
}