namespace Gestao_Catalogos
{
    partial class FormEditarCatalogo
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
            groupBox1 = new GroupBox();
            listBox2 = new ListBox();
            btnCancelar = new Button();
            btnBuscar = new Button();
            listBox1 = new ListBox();
            txtNumero = new TextBox();
            label1 = new Label();
            btnApagar = new Button();
            groupBox2 = new GroupBox();
            pnlProvSim = new Panel();
            cmbProvincia = new ComboBox();
            label11 = new Label();
            pnlComarcaSim = new Panel();
            label13 = new Label();
            cmbComarca = new ComboBox();
            label100 = new Label();
            btnComarca = new Button();
            pnlComarcaNao = new Panel();
            label10 = new Label();
            rbProvNao = new RadioButton();
            radioButton2 = new RadioButton();
            pnlFregNao = new Panel();
            label9 = new Label();
            rbComarcaNao = new RadioButton();
            rdComarcaSim = new RadioButton();
            label8 = new Label();
            pnlFregSim = new Panel();
            label12 = new Label();
            label6 = new Label();
            bntFreguesia = new Button();
            drop = new ComboBox();
            rbNao1 = new RadioButton();
            rbSim1 = new RadioButton();
            txtObs = new TextBox();
            label7 = new Label();
            bntCancelar = new Button();
            btnAlterar = new Button();
            txtLocal = new TextBox();
            label5 = new Label();
            txtOcupacao = new TextBox();
            label4 = new Label();
            txtQualifica = new TextBox();
            label3 = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            pnlProvSim.SuspendLayout();
            pnlComarcaSim.SuspendLayout();
            pnlComarcaNao.SuspendLayout();
            pnlFregNao.SuspendLayout();
            pnlFregSim.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBox2);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Controls.Add(txtNumero);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(782, 145);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selecionar Catálogo";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(241, 85);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(512, 49);
            listBox2.TabIndex = 35;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(126, 93);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(85, 30);
            btnCancelar.TabIndex = 34;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(21, 93);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(85, 30);
            btnBuscar.TabIndex = 31;
            btnBuscar.Text = "Procurar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(241, 28);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(512, 49);
            listBox1.TabIndex = 30;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(96, 39);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(85, 23);
            txtNumero.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 42);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 29;
            label1.Text = "Número:";
            // 
            // btnApagar
            // 
            btnApagar.DialogResult = DialogResult.OK;
            btnApagar.Location = new Point(678, 214);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(75, 30);
            btnApagar.TabIndex = 34;
            btnApagar.Text = "Apagar";
            btnApagar.UseVisualStyleBackColor = true;
            btnApagar.Click += btnApagar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pnlProvSim);
            groupBox2.Controls.Add(pnlComarcaSim);
            groupBox2.Controls.Add(pnlComarcaNao);
            groupBox2.Controls.Add(pnlFregNao);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(pnlFregSim);
            groupBox2.Controls.Add(rbNao1);
            groupBox2.Controls.Add(rbSim1);
            groupBox2.Controls.Add(btnApagar);
            groupBox2.Controls.Add(txtObs);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(bntCancelar);
            groupBox2.Controls.Add(btnAlterar);
            groupBox2.Controls.Add(txtLocal);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtOcupacao);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtQualifica);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtNome);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(12, 163);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(782, 309);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dados do Proprietário";
            // 
            // pnlProvSim
            // 
            pnlProvSim.Controls.Add(cmbProvincia);
            pnlProvSim.Controls.Add(label11);
            pnlProvSim.Location = new Point(11, 229);
            pnlProvSim.Name = "pnlProvSim";
            pnlProvSim.Size = new Size(408, 30);
            pnlProvSim.TabIndex = 44;
            // 
            // cmbProvincia
            // 
            cmbProvincia.FormattingEnabled = true;
            cmbProvincia.Location = new Point(68, 4);
            cmbProvincia.Name = "cmbProvincia";
            cmbProvincia.Size = new Size(318, 23);
            cmbProvincia.TabIndex = 10;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 7);
            label11.Name = "label11";
            label11.Size = new Size(59, 15);
            label11.TabIndex = 11;
            label11.Text = "Província:";
            // 
            // pnlComarcaSim
            // 
            pnlComarcaSim.Controls.Add(label13);
            pnlComarcaSim.Controls.Add(cmbComarca);
            pnlComarcaSim.Controls.Add(label100);
            pnlComarcaSim.Controls.Add(btnComarca);
            pnlComarcaSim.Location = new Point(11, 195);
            pnlComarcaSim.Name = "pnlComarcaSim";
            pnlComarcaSim.Size = new Size(648, 32);
            pnlComarcaSim.TabIndex = 43;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(401, 9);
            label13.Name = "label13";
            label13.Size = new Size(24, 15);
            label13.TabIndex = 16;
            label13.Text = "OU";
            // 
            // cmbComarca
            // 
            cmbComarca.FormattingEnabled = true;
            cmbComarca.Location = new Point(68, 5);
            cmbComarca.Name = "cmbComarca";
            cmbComarca.Size = new Size(318, 23);
            cmbComarca.TabIndex = 10;
            // 
            // label100
            // 
            label100.AutoSize = true;
            label100.Location = new Point(8, 8);
            label100.Name = "label100";
            label100.Size = new Size(58, 15);
            label100.TabIndex = 11;
            label100.Text = "Comarca:";
            // 
            // btnComarca
            // 
            btnComarca.Location = new Point(438, 5);
            btnComarca.Name = "btnComarca";
            btnComarca.Size = new Size(200, 23);
            btnComarca.TabIndex = 14;
            btnComarca.Text = "Cadastrar Comarca";
            btnComarca.UseVisualStyleBackColor = true;
            // 
            // pnlComarcaNao
            // 
            pnlComarcaNao.Controls.Add(label10);
            pnlComarcaNao.Controls.Add(rbProvNao);
            pnlComarcaNao.Controls.Add(radioButton2);
            pnlComarcaNao.Location = new Point(512, 121);
            pnlComarcaNao.Name = "pnlComarcaNao";
            pnlComarcaNao.Size = new Size(259, 28);
            pnlComarcaNao.TabIndex = 42;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(2, 6);
            label10.Name = "label10";
            label10.Size = new Size(149, 15);
            label10.TabIndex = 19;
            label10.Text = "Há indicação da Província?";
            // 
            // rbProvNao
            // 
            rbProvNao.AutoSize = true;
            rbProvNao.Location = new Point(208, 4);
            rbProvNao.Name = "rbProvNao";
            rbProvNao.Size = new Size(47, 19);
            rbProvNao.TabIndex = 21;
            rbProvNao.TabStop = true;
            rbProvNao.Text = "Não";
            rbProvNao.UseVisualStyleBackColor = true;
            rbProvNao.CheckedChanged += rbProvNao_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(157, 4);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(45, 19);
            radioButton2.TabIndex = 20;
            radioButton2.TabStop = true;
            radioButton2.Text = "Sim";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // pnlFregNao
            // 
            pnlFregNao.Controls.Add(label9);
            pnlFregNao.Controls.Add(rbComarcaNao);
            pnlFregNao.Controls.Add(rdComarcaSim);
            pnlFregNao.Location = new Point(257, 121);
            pnlFregNao.Name = "pnlFregNao";
            pnlFregNao.Size = new Size(251, 28);
            pnlFregNao.TabIndex = 41;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 6);
            label9.Name = "label9";
            label9.Size = new Size(148, 15);
            label9.TabIndex = 19;
            label9.Text = "Há indicação da Comarca?";
            // 
            // rbComarcaNao
            // 
            rbComarcaNao.AutoSize = true;
            rbComarcaNao.Location = new Point(202, 4);
            rbComarcaNao.Name = "rbComarcaNao";
            rbComarcaNao.Size = new Size(47, 19);
            rbComarcaNao.TabIndex = 21;
            rbComarcaNao.TabStop = true;
            rbComarcaNao.Text = "Não";
            rbComarcaNao.UseVisualStyleBackColor = true;
            rbComarcaNao.CheckedChanged += rbComarcaNao_CheckedChanged;
            // 
            // rdComarcaSim
            // 
            rdComarcaSim.AutoSize = true;
            rdComarcaSim.Location = new Point(153, 4);
            rdComarcaSim.Name = "rdComarcaSim";
            rdComarcaSim.Size = new Size(45, 19);
            rdComarcaSim.TabIndex = 20;
            rdComarcaSim.TabStop = true;
            rdComarcaSim.Text = "Sim";
            rdComarcaSim.UseVisualStyleBackColor = true;
            rdComarcaSim.CheckedChanged += rdComarcaSim_CheckedChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(2, 127);
            label8.Name = "label8";
            label8.Size = new Size(150, 15);
            label8.TabIndex = 35;
            label8.Text = "Há indicação da Freguesia?";
            // 
            // pnlFregSim
            // 
            pnlFregSim.Controls.Add(label12);
            pnlFregSim.Controls.Add(label6);
            pnlFregSim.Controls.Add(bntFreguesia);
            pnlFregSim.Controls.Add(drop);
            pnlFregSim.Location = new Point(11, 161);
            pnlFregSim.Name = "pnlFregSim";
            pnlFregSim.Size = new Size(648, 33);
            pnlFregSim.TabIndex = 40;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(401, 9);
            label12.Name = "label12";
            label12.Size = new Size(24, 15);
            label12.TabIndex = 15;
            label12.Text = "OU";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 9);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 11;
            label6.Text = "Freguesia:";
            // 
            // bntFreguesia
            // 
            bntFreguesia.Location = new Point(438, 4);
            bntFreguesia.Name = "bntFreguesia";
            bntFreguesia.Size = new Size(200, 23);
            bntFreguesia.TabIndex = 14;
            bntFreguesia.Text = "Cadastrar Freguesia";
            bntFreguesia.UseVisualStyleBackColor = true;
            bntFreguesia.Click += bntFreguesia_Click;
            // 
            // drop
            // 
            drop.FormattingEnabled = true;
            drop.Location = new Point(68, 5);
            drop.Name = "drop";
            drop.Size = new Size(318, 23);
            drop.TabIndex = 10;
            // 
            // rbNao1
            // 
            rbNao1.AutoSize = true;
            rbNao1.Location = new Point(206, 125);
            rbNao1.Name = "rbNao1";
            rbNao1.Size = new Size(47, 19);
            rbNao1.TabIndex = 39;
            rbNao1.TabStop = true;
            rbNao1.Text = "Não";
            rbNao1.UseVisualStyleBackColor = true;
            rbNao1.CheckedChanged += rbNao1_CheckedChanged;
            // 
            // rbSim1
            // 
            rbSim1.AutoSize = true;
            rbSim1.Location = new Point(158, 125);
            rbSim1.Name = "rbSim1";
            rbSim1.Size = new Size(45, 19);
            rbSim1.TabIndex = 38;
            rbSim1.TabStop = true;
            rbSim1.Text = "Sim";
            rbSim1.UseVisualStyleBackColor = true;
            rbSim1.CheckedChanged += rbSim1_CheckedChanged;
            // 
            // txtObs
            // 
            txtObs.Location = new Point(83, 271);
            txtObs.Name = "txtObs";
            txtObs.Size = new Size(576, 23);
            txtObs.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 274);
            label7.Name = "label7";
            label7.Size = new Size(72, 15);
            label7.TabIndex = 15;
            label7.Text = "Observação:";
            // 
            // bntCancelar
            // 
            bntCancelar.Location = new Point(678, 264);
            bntCancelar.Name = "bntCancelar";
            bntCancelar.Size = new Size(75, 30);
            bntCancelar.TabIndex = 13;
            bntCancelar.Text = "Cancelar";
            bntCancelar.UseVisualStyleBackColor = true;
            bntCancelar.Click += bntCancelar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.DialogResult = DialogResult.Yes;
            btnAlterar.Location = new Point(678, 162);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(75, 30);
            btnAlterar.TabIndex = 12;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // txtLocal
            // 
            txtLocal.Location = new Point(403, 76);
            txtLocal.Name = "txtLocal";
            txtLocal.Size = new Size(350, 23);
            txtLocal.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(262, 79);
            label5.Name = "label5";
            label5.Size = new Size(138, 15);
            label5.TabIndex = 8;
            label5.Text = "Descrição da localização:";
            // 
            // txtOcupacao
            // 
            txtOcupacao.Location = new Point(84, 76);
            txtOcupacao.Name = "txtOcupacao";
            txtOcupacao.Size = new Size(161, 23);
            txtOcupacao.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 79);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 6;
            label4.Text = "Ocupação:";
            // 
            // txtQualifica
            // 
            txtQualifica.Location = new Point(84, 32);
            txtQualifica.Name = "txtQualifica";
            txtQualifica.Size = new Size(161, 23);
            txtQualifica.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 35);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 4;
            label3.Text = "Qualificação:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(303, 32);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(450, 23);
            txtNome.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(258, 35);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 2;
            label2.Text = "Nome:";
            // 
            // FormEditarCatalogo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 481);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormEditarCatalogo";
            Text = "FormEditarCatalogo";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            pnlProvSim.ResumeLayout(false);
            pnlProvSim.PerformLayout();
            pnlComarcaSim.ResumeLayout(false);
            pnlComarcaSim.PerformLayout();
            pnlComarcaNao.ResumeLayout(false);
            pnlComarcaNao.PerformLayout();
            pnlFregNao.ResumeLayout(false);
            pnlFregNao.PerformLayout();
            pnlFregSim.ResumeLayout(false);
            pnlFregSim.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox grpEditarProp;
        private Button btnBuscar;
        private ListBox listBox1;
        private TextBox txtNumero;
        private Label label1;
        private Button btnApagar;
        private GroupBox groupBox2;
        private TextBox txtObs;
        private Label label7;
        private Button bntFreguesia;
        private Button bntCancelar;
        private Button btnAlterar;
        private ComboBox drop;
        private TextBox txtLocal;
        private Label label5;
        private TextBox txtOcupacao;
        private Label label4;
        private TextBox txtQualifica;
        private Label label3;
        private TextBox txtNome;
        private Label label2;
        private Button btnCancelar;
        private ListBox listBox2;
        private Panel pnlProvSim;
        private ComboBox cmbProvincia;
        private Label label11;
        private Panel pnlComarcaSim;
        private Label label13;
        private ComboBox cmbComarca;
        private Label label100;
        private Button btnComarca;
        private Panel pnlComarcaNao;
        private Label label10;
        private RadioButton rbProvNao;
        private RadioButton radioButton2;
        private Panel pnlFregNao;
        private Label label9;
        private RadioButton rbComarcaNao;
        private RadioButton rdComarcaSim;
        private Label label8;
        private Panel pnlFregSim;
        private Label label12;
        private Label label6;
        private RadioButton rbNao1;
        private RadioButton rbSim1;
    }
}