namespace Gestao_Catalogos
{
    partial class FormVerLivros
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
            grp1 = new GroupBox();
            txtContar1 = new TextBox();
            btnContarLivro1 = new Button();
            cmbProp = new ComboBox();
            btnBuscar = new Button();
            lstLivrosProp = new ListBox();
            label1 = new Label();
            grp2 = new GroupBox();
            txtInfo = new TextBox();
            label3 = new Label();
            txtTitulo2 = new TextBox();
            txtAutor2 = new TextBox();
            label2 = new Label();
            bntBuscar2 = new Button();
            lst2 = new ListBox();
            grupo = new GroupBox();
            btn5 = new Button();
            btn4 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn1 = new Button();
            grp3 = new GroupBox();
            txtContagem = new TextBox();
            btnContar = new Button();
            cmbCategoria = new ComboBox();
            btnBuscar3 = new Button();
            lst3 = new ListBox();
            label4 = new Label();
            grp4 = new GroupBox();
            txtContaLivros4 = new TextBox();
            btnContarLivros = new Button();
            txtContaProp4 = new TextBox();
            btnContarProp = new Button();
            cmbProvincia = new ComboBox();
            btnBuscar4 = new Button();
            lst4 = new ListBox();
            label5 = new Label();
            grp5 = new GroupBox();
            txtContarEd = new TextBox();
            btnAutor = new Button();
            btnTitulo = new Button();
            btnBuscar5 = new Button();
            lst5 = new ListBox();
            txtAutor = new TextBox();
            label7 = new Label();
            grp1.SuspendLayout();
            grp2.SuspendLayout();
            grupo.SuspendLayout();
            grp3.SuspendLayout();
            grp4.SuspendLayout();
            grp5.SuspendLayout();
            SuspendLayout();
            // 
            // grp1
            // 
            grp1.Controls.Add(txtContar1);
            grp1.Controls.Add(btnContarLivro1);
            grp1.Controls.Add(cmbProp);
            grp1.Controls.Add(btnBuscar);
            grp1.Controls.Add(lstLivrosProp);
            grp1.Controls.Add(label1);
            grp1.Location = new Point(12, 92);
            grp1.Name = "grp1";
            grp1.Size = new Size(785, 146);
            grp1.TabIndex = 0;
            grp1.TabStop = false;
            grp1.Text = "Buscar Livros de um Proprietário:";
            // 
            // txtContar1
            // 
            txtContar1.Location = new Point(146, 107);
            txtContar1.Name = "txtContar1";
            txtContar1.Size = new Size(112, 23);
            txtContar1.TabIndex = 7;
            // 
            // btnContarLivro1
            // 
            btnContarLivro1.Location = new Point(35, 107);
            btnContarLivro1.Name = "btnContarLivro1";
            btnContarLivro1.Size = new Size(96, 23);
            btnContarLivro1.TabIndex = 6;
            btnContarLivro1.Text = "Contar Livros";
            btnContarLivro1.UseVisualStyleBackColor = true;
            btnContarLivro1.Click += btnContarLivro1_Click;
            // 
            // cmbProp
            // 
            cmbProp.FormattingEnabled = true;
            cmbProp.Location = new Point(10, 50);
            cmbProp.Name = "cmbProp";
            cmbProp.Size = new Size(210, 23);
            cmbProp.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(229, 50);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += button1_Click;
            // 
            // lstLivrosProp
            // 
            lstLivrosProp.FormattingEnabled = true;
            lstLivrosProp.ItemHeight = 15;
            lstLivrosProp.Location = new Point(310, 22);
            lstLivrosProp.Name = "lstLivrosProp";
            lstLivrosProp.Size = new Size(464, 109);
            lstLivrosProp.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 32);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome do Proprietário:";
            // 
            // grp2
            // 
            grp2.Controls.Add(txtInfo);
            grp2.Controls.Add(label3);
            grp2.Controls.Add(txtTitulo2);
            grp2.Controls.Add(txtAutor2);
            grp2.Controls.Add(label2);
            grp2.Controls.Add(bntBuscar2);
            grp2.Controls.Add(lst2);
            grp2.Location = new Point(13, 122);
            grp2.Name = "grp2";
            grp2.Size = new Size(785, 149);
            grp2.TabIndex = 2;
            grp2.TabStop = false;
            grp2.Text = "Ver os proprietários que possuem o mesmo título:";
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(91, 114);
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(213, 23);
            txtInfo.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 83);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 11;
            label3.Text = "Autor:";
            // 
            // txtTitulo2
            // 
            txtTitulo2.Location = new Point(81, 42);
            txtTitulo2.Name = "txtTitulo2";
            txtTitulo2.Size = new Size(223, 23);
            txtTitulo2.TabIndex = 10;
            // 
            // txtAutor2
            // 
            txtAutor2.Location = new Point(81, 80);
            txtAutor2.Name = "txtAutor2";
            txtAutor2.Size = new Size(223, 23);
            txtAutor2.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 45);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 8;
            label2.Text = "Título do livro:";
            // 
            // bntBuscar2
            // 
            bntBuscar2.Location = new Point(6, 115);
            bntBuscar2.Name = "bntBuscar2";
            bntBuscar2.Size = new Size(77, 23);
            bntBuscar2.TabIndex = 7;
            bntBuscar2.Text = "Buscar";
            bntBuscar2.UseVisualStyleBackColor = true;
            bntBuscar2.Click += bntBuscar2_Click;
            // 
            // lst2
            // 
            lst2.FormattingEnabled = true;
            lst2.ItemHeight = 15;
            lst2.Location = new Point(310, 29);
            lst2.Name = "lst2";
            lst2.Size = new Size(464, 109);
            lst2.TabIndex = 6;
            // 
            // grupo
            // 
            grupo.Controls.Add(btn5);
            grupo.Controls.Add(btn4);
            grupo.Controls.Add(btn2);
            grupo.Controls.Add(btn3);
            grupo.Controls.Add(btn1);
            grupo.Location = new Point(12, 3);
            grupo.Name = "grupo";
            grupo.Size = new Size(785, 83);
            grupo.TabIndex = 1;
            grupo.TabStop = false;
            grupo.Text = "Critérios";
            // 
            // btn5
            // 
            btn5.Location = new Point(646, 22);
            btn5.Name = "btn5";
            btn5.Size = new Size(123, 45);
            btn5.TabIndex = 4;
            btn5.Text = "Localizar Livros de um mesmo Autor";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(486, 22);
            btn4.Name = "btn4";
            btn4.Size = new Size(123, 45);
            btn4.TabIndex = 3;
            btn4.Text = "Ver Proprietários por Província";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(166, 22);
            btn2.Name = "btn2";
            btn2.Size = new Size(123, 45);
            btn2.TabIndex = 2;
            btn2.Text = "Ver Proprietários de um Livro";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(326, 22);
            btn3.Name = "btn3";
            btn3.Size = new Size(123, 45);
            btn3.TabIndex = 1;
            btn3.Text = "Ver Livros por Categoria";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(6, 22);
            btn1.Name = "btn1";
            btn1.Size = new Size(123, 45);
            btn1.TabIndex = 0;
            btn1.Text = "Ver Livros de um Proprietário";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // grp3
            // 
            grp3.Controls.Add(txtContagem);
            grp3.Controls.Add(btnContar);
            grp3.Controls.Add(cmbCategoria);
            grp3.Controls.Add(btnBuscar3);
            grp3.Controls.Add(lst3);
            grp3.Controls.Add(label4);
            grp3.Location = new Point(12, 153);
            grp3.Name = "grp3";
            grp3.Size = new Size(785, 155);
            grp3.TabIndex = 3;
            grp3.TabStop = false;
            grp3.Text = "Buscar Livros por Categoria:";
            // 
            // txtContagem
            // 
            txtContagem.Location = new Point(192, 105);
            txtContagem.Name = "txtContagem";
            txtContagem.Size = new Size(112, 23);
            txtContagem.TabIndex = 5;
            // 
            // btnContar
            // 
            btnContar.Location = new Point(10, 105);
            btnContar.Name = "btnContar";
            btnContar.Size = new Size(171, 23);
            btnContar.TabIndex = 4;
            btnContar.Text = "Contar Livros por Categoria";
            btnContar.UseVisualStyleBackColor = true;
            btnContar.Click += btnContar_Click;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(74, 34);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(146, 23);
            cmbCategoria.TabIndex = 1;
            // 
            // btnBuscar3
            // 
            btnBuscar3.Location = new Point(229, 34);
            btnBuscar3.Name = "btnBuscar3";
            btnBuscar3.Size = new Size(75, 23);
            btnBuscar3.TabIndex = 3;
            btnBuscar3.Text = "Buscar";
            btnBuscar3.UseVisualStyleBackColor = true;
            btnBuscar3.Click += btnBuscar3_Click;
            // 
            // lst3
            // 
            lst3.FormattingEnabled = true;
            lst3.ItemHeight = 15;
            lst3.Location = new Point(310, 20);
            lst3.Name = "lst3";
            lst3.Size = new Size(464, 124);
            lst3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 37);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 0;
            label4.Text = "Categoria:";
            // 
            // grp4
            // 
            grp4.Controls.Add(txtContaLivros4);
            grp4.Controls.Add(btnContarLivros);
            grp4.Controls.Add(txtContaProp4);
            grp4.Controls.Add(btnContarProp);
            grp4.Controls.Add(cmbProvincia);
            grp4.Controls.Add(btnBuscar4);
            grp4.Controls.Add(lst4);
            grp4.Controls.Add(label5);
            grp4.Location = new Point(12, 187);
            grp4.Name = "grp4";
            grp4.Size = new Size(785, 177);
            grp4.TabIndex = 4;
            grp4.TabStop = false;
            grp4.Text = "Buscar Proprietários por Província";
            // 
            // txtContaLivros4
            // 
            txtContaLivros4.Location = new Point(100, 136);
            txtContaLivros4.Name = "txtContaLivros4";
            txtContaLivros4.Size = new Size(200, 23);
            txtContaLivros4.TabIndex = 7;
            // 
            // btnContarLivros
            // 
            btnContarLivros.Location = new Point(6, 125);
            btnContarLivros.Name = "btnContarLivros";
            btnContarLivros.Size = new Size(88, 43);
            btnContarLivros.TabIndex = 6;
            btnContarLivros.Text = "Contar Livros";
            btnContarLivros.UseVisualStyleBackColor = true;
            btnContarLivros.Click += btnContarLivros_Click;
            // 
            // txtContaProp4
            // 
            txtContaProp4.Location = new Point(100, 78);
            txtContaProp4.Name = "txtContaProp4";
            txtContaProp4.Size = new Size(200, 23);
            txtContaProp4.TabIndex = 5;
            // 
            // btnContarProp
            // 
            btnContarProp.Location = new Point(6, 67);
            btnContarProp.Name = "btnContarProp";
            btnContarProp.Size = new Size(88, 43);
            btnContarProp.TabIndex = 4;
            btnContarProp.Text = "Contar Proprietários";
            btnContarProp.UseVisualStyleBackColor = true;
            btnContarProp.Click += btnContarProp_Click;
            // 
            // cmbProvincia
            // 
            cmbProvincia.FormattingEnabled = true;
            cmbProvincia.Location = new Point(74, 34);
            cmbProvincia.Name = "cmbProvincia";
            cmbProvincia.Size = new Size(146, 23);
            cmbProvincia.TabIndex = 1;
            // 
            // btnBuscar4
            // 
            btnBuscar4.Location = new Point(229, 34);
            btnBuscar4.Name = "btnBuscar4";
            btnBuscar4.Size = new Size(75, 23);
            btnBuscar4.TabIndex = 3;
            btnBuscar4.Text = "Buscar";
            btnBuscar4.UseVisualStyleBackColor = true;
            btnBuscar4.Click += btnBuscar4_Click;
            // 
            // lst4
            // 
            lst4.FormattingEnabled = true;
            lst4.ItemHeight = 15;
            lst4.Location = new Point(310, 22);
            lst4.Name = "lst4";
            lst4.Size = new Size(464, 139);
            lst4.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 37);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 0;
            label5.Text = "Província:";
            // 
            // grp5
            // 
            grp5.Controls.Add(txtContarEd);
            grp5.Controls.Add(btnAutor);
            grp5.Controls.Add(btnTitulo);
            grp5.Controls.Add(btnBuscar5);
            grp5.Controls.Add(lst5);
            grp5.Controls.Add(txtAutor);
            grp5.Controls.Add(label7);
            grp5.Location = new Point(12, 221);
            grp5.Name = "grp5";
            grp5.Size = new Size(785, 165);
            grp5.TabIndex = 5;
            grp5.TabStop = false;
            grp5.Text = "Localizar Edições";
            // 
            // txtContarEd
            // 
            txtContarEd.Location = new Point(106, 126);
            txtContarEd.Name = "txtContarEd";
            txtContarEd.Size = new Size(189, 23);
            txtContarEd.TabIndex = 8;
            // 
            // btnAutor
            // 
            btnAutor.Location = new Point(184, 78);
            btnAutor.Name = "btnAutor";
            btnAutor.Size = new Size(116, 23);
            btnAutor.TabIndex = 7;
            btnAutor.Text = "Ver Proprietários";
            btnAutor.UseVisualStyleBackColor = true;
            btnAutor.Click += btnAutor_Click;
            // 
            // btnTitulo
            // 
            btnTitulo.Location = new Point(6, 116);
            btnTitulo.Name = "btnTitulo";
            btnTitulo.Size = new Size(77, 43);
            btnTitulo.TabIndex = 6;
            btnTitulo.Text = "Contar edições";
            btnTitulo.UseVisualStyleBackColor = true;
            btnTitulo.Click += btnTitulo_Click;
            // 
            // btnBuscar5
            // 
            btnBuscar5.Location = new Point(16, 78);
            btnBuscar5.Name = "btnBuscar5";
            btnBuscar5.Size = new Size(119, 23);
            btnBuscar5.TabIndex = 5;
            btnBuscar5.Text = "Buscar";
            btnBuscar5.UseVisualStyleBackColor = true;
            btnBuscar5.Click += btnBuscar5_Click;
            // 
            // lst5
            // 
            lst5.FormattingEnabled = true;
            lst5.ItemHeight = 15;
            lst5.Location = new Point(310, 25);
            lst5.Name = "lst5";
            lst5.Size = new Size(459, 124);
            lst5.TabIndex = 4;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(46, 36);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(254, 23);
            txtAutor.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 39);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 1;
            label7.Text = "Autor:";
            // 
            // FormVerLivros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 396);
            Controls.Add(grp5);
            Controls.Add(grp4);
            Controls.Add(grp3);
            Controls.Add(grp2);
            Controls.Add(grupo);
            Controls.Add(grp1);
            Name = "FormVerLivros";
            Text = "FormVerLivros";
            grp1.ResumeLayout(false);
            grp1.PerformLayout();
            grp2.ResumeLayout(false);
            grp2.PerformLayout();
            grupo.ResumeLayout(false);
            grp3.ResumeLayout(false);
            grp3.PerformLayout();
            grp4.ResumeLayout(false);
            grp4.PerformLayout();
            grp5.ResumeLayout(false);
            grp5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grp1;
        private Button btnBuscar;
        private ListBox lstLivrosProp;
        private Label label1;
        private ComboBox cmbProp;
        private GroupBox grupo;
        private Button btn3;
        private Button btn1;
        private Button btn2;
        private Button btn5;
        private Button btn4;
        private GroupBox grp2;
        private Button bntBuscar2;
        private ListBox lst2;
        private Label label2;
        private Label label3;
        private TextBox txtTitulo2;
        private TextBox txtAutor2;
        private GroupBox grp3;
        private Button btnContar;
        private ComboBox cmbCategoria;
        private Button btnBuscar3;
        private ListBox lst3;
        private Label label4;
        private TextBox txtContagem;
        private GroupBox grp4;
        private TextBox txtContaProp4;
        private Button btnContarProp;
        private ComboBox cmbProvincia;
        private Button btnBuscar4;
        private ListBox lst4;
        private Label label5;
        private Button btnContarLivros;
        private TextBox txtContaLivros4;
        private TextBox txtContar1;
        private Button btnContarLivro1;
        private GroupBox grp5;
        private ListBox lst5;
        private TextBox txtAutor;
        private Label label7;
        private Button btnAutor;
        private Button btnTitulo;
        private Button btnBuscar5;
        private TextBox txtContarEd;
        private TextBox txtInfo;
    }
}