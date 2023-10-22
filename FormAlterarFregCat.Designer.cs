namespace Gestao_Catalogos
{
    partial class FormAlterarFregCat
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
            grpAlterarFreg = new GroupBox();
            grp1 = new GroupBox();
            txtNomFreguesia = new TextBox();
            label4 = new Label();
            label2 = new Label();
            btnCancelar = new Button();
            bntGravarComarca = new Button();
            checkProvincia = new CheckedListBox();
            btnAlterar = new Button();
            label3 = new Label();
            checkComarca = new CheckedListBox();
            cmbFreguesia = new ComboBox();
            label1 = new Label();
            grpAlterarFreg.SuspendLayout();
            grp1.SuspendLayout();
            SuspendLayout();
            // 
            // grpAlterarFreg
            // 
            grpAlterarFreg.Controls.Add(grp1);
            grpAlterarFreg.Controls.Add(cmbFreguesia);
            grpAlterarFreg.Controls.Add(label1);
            grpAlterarFreg.Location = new Point(12, 12);
            grpAlterarFreg.Name = "grpAlterarFreg";
            grpAlterarFreg.Size = new Size(776, 328);
            grpAlterarFreg.TabIndex = 1;
            grpAlterarFreg.TabStop = false;
            grpAlterarFreg.Text = "Alterar Freguesia";
            // 
            // grp1
            // 
            grp1.Controls.Add(txtNomFreguesia);
            grp1.Controls.Add(label4);
            grp1.Controls.Add(label2);
            grp1.Controls.Add(btnCancelar);
            grp1.Controls.Add(bntGravarComarca);
            grp1.Controls.Add(checkProvincia);
            grp1.Controls.Add(btnAlterar);
            grp1.Controls.Add(label3);
            grp1.Controls.Add(checkComarca);
            grp1.Location = new Point(18, 66);
            grp1.Name = "grp1";
            grp1.Size = new Size(738, 262);
            grp1.TabIndex = 31;
            grp1.TabStop = false;
            grp1.Text = "Insere os dados para a alteração da Freguesia";
            // 
            // txtNomFreguesia
            // 
            txtNomFreguesia.Location = new Point(198, 31);
            txtNomFreguesia.Name = "txtNomFreguesia";
            txtNomFreguesia.Size = new Size(301, 23);
            txtNomFreguesia.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 34);
            label4.Name = "label4";
            label4.Size = new Size(165, 15);
            label4.TabIndex = 30;
            label4.Text = "Informa o nome da Freguesia:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 77);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 20;
            label2.Text = "Província: ";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(642, 30);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(80, 23);
            btnCancelar.TabIndex = 24;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // bntGravarComarca
            // 
            bntGravarComarca.Location = new Point(553, 231);
            bntGravarComarca.Name = "bntGravarComarca";
            bntGravarComarca.Size = new Size(167, 23);
            bntGravarComarca.TabIndex = 26;
            bntGravarComarca.Text = "Cadastrar Comarca";
            bntGravarComarca.UseVisualStyleBackColor = true;
            bntGravarComarca.Click += bntGravarComarca_Click;
            // 
            // checkProvincia
            // 
            checkProvincia.AllowDrop = true;
            checkProvincia.FormattingEnabled = true;
            checkProvincia.Location = new Point(86, 77);
            checkProvincia.Name = "checkProvincia";
            checkProvincia.Size = new Size(156, 148);
            checkProvincia.TabIndex = 27;
            checkProvincia.SelectedIndexChanged += checkProvincia_SelectedIndexChanged;
            // 
            // btnAlterar
            // 
            btnAlterar.DialogResult = DialogResult.Yes;
            btnAlterar.Location = new Point(537, 30);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(90, 23);
            btnAlterar.TabIndex = 25;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(294, 77);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 21;
            label3.Text = "Comarca: ";
            // 
            // checkComarca
            // 
            checkComarca.FormattingEnabled = true;
            checkComarca.Location = new Point(361, 77);
            checkComarca.Name = "checkComarca";
            checkComarca.Size = new Size(359, 148);
            checkComarca.TabIndex = 23;
            // 
            // cmbFreguesia
            // 
            cmbFreguesia.FormattingEnabled = true;
            cmbFreguesia.Location = new Point(326, 28);
            cmbFreguesia.Name = "cmbFreguesia";
            cmbFreguesia.Size = new Size(333, 23);
            cmbFreguesia.TabIndex = 28;
            cmbFreguesia.SelectedIndexChanged += cmbFreguesia_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 31);
            label1.Name = "label1";
            label1.Size = new Size(268, 15);
            label1.TabIndex = 19;
            label1.Text = "Seleciona o nome da Freguesia que deseja alterar:";
            // 
            // FormAlterarFregCat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 352);
            Controls.Add(grpAlterarFreg);
            Name = "FormAlterarFregCat";
            Text = "FormAlterarFregCat";
            grpAlterarFreg.ResumeLayout(false);
            grpAlterarFreg.PerformLayout();
            grp1.ResumeLayout(false);
            grp1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox grpAlterarFreg;
        private ComboBox cmbFreguesia;
        private CheckedListBox checkProvincia;
        private Button bntGravarComarca;
        private Button btnAlterar;
        private Button btnCancelar;
        private CheckedListBox checkComarca;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private GroupBox grp1;
        private TextBox txtNomFreguesia;
    }
}