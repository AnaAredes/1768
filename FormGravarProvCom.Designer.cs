namespace Gestao_Catalogos
{
    partial class FormGravarProvCom
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
            txtComarca = new TextBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            label4 = new Label();
            groupBox2 = new GroupBox();
            label1 = new Label();
            cmbProvincia = new ComboBox();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtComarca
            // 
            txtComarca.Location = new Point(153, 82);
            txtComarca.Name = "txtComarca";
            txtComarca.Size = new Size(249, 23);
            txtComarca.TabIndex = 3;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.Yes;
            btnGravar.Location = new Point(481, 57);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(130, 23);
            btnGravar.TabIndex = 6;
            btnGravar.Text = "Gravar Comarca";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(639, 57);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(130, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 85);
            label4.Name = "label4";
            label4.Size = new Size(113, 15);
            label4.TabIndex = 10;
            label4.Text = "Nome da Comarca: ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(cmbProvincia);
            groupBox2.Controls.Add(btnGravar);
            groupBox2.Controls.Add(btnCancelar);
            groupBox2.Controls.Add(txtComarca);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(7, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(785, 130);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Comarca";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 37);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 11;
            label1.Text = "Nome da Província:";
            // 
            // cmbProvincia
            // 
            cmbProvincia.FormattingEnabled = true;
            cmbProvincia.Location = new Point(153, 33);
            cmbProvincia.Name = "cmbProvincia";
            cmbProvincia.Size = new Size(249, 23);
            cmbProvincia.TabIndex = 10;
            // 
            // FormGravarProvCom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 154);
            Controls.Add(groupBox2);
            Name = "FormGravarProvCom";
            Text = "FormGravarProvCom";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtComarca;
        private Button btnGravar;
        private Button btnCancelar;
        private Label label4;
        private GroupBox groupBox2;
        private Label label1;
        private ComboBox cmbProvincia;
    }
}