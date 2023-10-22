namespace Gestao_Catalogos
{
    partial class FormCadastrarFreguesia
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label2 = new Label();
            txtNomeFreguesia = new TextBox();
            label3 = new Label();
            label1 = new Label();
            checkComarca = new CheckedListBox();
            btnCancelar = new Button();
            btnGravar = new Button();
            bntGravarComarca = new Button();
            checkProvincia = new CheckedListBox();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 72);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "Província: ";
            // 
            // txtNomeFreguesia
            // 
            txtNomeFreguesia.Location = new Point(127, 25);
            txtNomeFreguesia.Name = "txtNomeFreguesia";
            txtNomeFreguesia.Size = new Size(431, 23);
            txtNomeFreguesia.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(332, 72);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 2;
            label3.Text = "Comarca: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 28);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome da Freguesia: ";
            // 
            // checkComarca
            // 
            checkComarca.FormattingEnabled = true;
            checkComarca.Location = new Point(399, 68);
            checkComarca.Name = "checkComarca";
            checkComarca.Size = new Size(359, 166);
            checkComarca.TabIndex = 9;
            checkComarca.SelectedIndexChanged += checkComarca_SelectedIndexChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(683, 25);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.Yes;
            btnGravar.Location = new Point(582, 25);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 23);
            btnGravar.TabIndex = 11;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // bntGravarComarca
            // 
            bntGravarComarca.Location = new Point(591, 240);
            bntGravarComarca.Name = "bntGravarComarca";
            bntGravarComarca.Size = new Size(167, 23);
            bntGravarComarca.TabIndex = 14;
            bntGravarComarca.Text = "Cadastrar Comarca";
            bntGravarComarca.UseVisualStyleBackColor = true;
            bntGravarComarca.Click += bntGravarComarca_Click;
            // 
            // checkProvincia
            // 
            checkProvincia.AllowDrop = true;
            checkProvincia.FormattingEnabled = true;
            checkProvincia.Location = new Point(103, 72);
            checkProvincia.Name = "checkProvincia";
            checkProvincia.Size = new Size(156, 148);
            checkProvincia.TabIndex = 18;
            checkProvincia.SelectedIndexChanged += checkProvincia_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkProvincia);
            groupBox1.Controls.Add(bntGravarComarca);
            groupBox1.Controls.Add(btnGravar);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(checkComarca);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNomeFreguesia);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 273);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastrar Freguesia";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // FormCadastrarFreguesia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 307);
            Controls.Add(groupBox1);
            Name = "FormCadastrarFreguesia";
            Text = "FormCadastrarFreguesia";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private TextBox textBox3;
        private Label label2;
        private TextBox txtNomeFreguesia;
        private Label label3;
        private Label label1;
        private CheckedListBox checkComarca;
        private Button btnCancelar;
        private Button btnGravar;
        private Button bntGravarComarca;
        private CheckedListBox checkProvincia;
        private GroupBox groupBox1;
    }
}