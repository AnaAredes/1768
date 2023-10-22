namespace Gestao_Catalogos
{
    partial class FormVerCatalogo
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
            btnFiltrar = new Button();
            dataGrid1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            referencia = new DataGridViewTextBoxColumn();
            numDoc = new DataGridViewTextBoxColumn();
            propr = new DataGridViewTextBoxColumn();
            nLivros = new DataGridViewTextBoxColumn();
            btnCancelar = new Button();
            btnAtualizar = new Button();
            btnFiltrarLivros = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnFiltrarLivros);
            groupBox1.Controls.Add(btnFiltrar);
            groupBox1.Controls.Add(dataGrid1);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnAtualizar);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 426);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ver Catálogos";
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(208, 23);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(167, 40);
            btnFiltrar.TabIndex = 10;
            btnFiltrar.Text = "Ver lista dos catálogos com PROPRIETÁRIOS cadastrados";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // dataGrid1
            // 
            dataGrid1.AllowUserToDeleteRows = false;
            dataGrid1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid1.Columns.AddRange(new DataGridViewColumn[] { id, referencia, numDoc, propr, nLivros });
            dataGrid1.Location = new Point(24, 82);
            dataGrid1.Name = "dataGrid1";
            dataGrid1.ReadOnly = true;
            dataGrid1.RowTemplate.Height = 25;
            dataGrid1.Size = new Size(726, 338);
            dataGrid1.TabIndex = 9;
            // 
            // id
            // 
            id.HeaderText = "Id do Catálogo";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // referencia
            // 
            referencia.HeaderText = "Referência";
            referencia.Name = "referencia";
            referencia.ReadOnly = true;
            // 
            // numDoc
            // 
            numDoc.HeaderText = "N. Documento";
            numDoc.Name = "numDoc";
            numDoc.ReadOnly = true;
            // 
            // propr
            // 
            propr.HeaderText = "Proprietário";
            propr.Name = "propr";
            propr.ReadOnly = true;
            // 
            // nLivros
            // 
            nLivros.HeaderText = "N. de Livros cadastrados";
            nLivros.Name = "nLivros";
            nLivros.ReadOnly = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Yes;
            btnCancelar.Location = new Point(583, 23);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(167, 40);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(24, 23);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(167, 40);
            btnAtualizar.TabIndex = 7;
            btnAtualizar.Text = "Ver lista completa";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnFiltrarLivros
            // 
            btnFiltrarLivros.Location = new Point(396, 23);
            btnFiltrarLivros.Name = "btnFiltrarLivros";
            btnFiltrarLivros.Size = new Size(167, 41);
            btnFiltrarLivros.TabIndex = 11;
            btnFiltrarLivros.Text = "Ver lista dos catálogos com LIVROS cadastrados";
            btnFiltrarLivros.UseVisualStyleBackColor = true;
            btnFiltrarLivros.Click += btnFiltrarLivros_Click;
            // 
            // FormVerCatalogo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "FormVerCatalogo";
            Text = "FormVerCatalogo";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGrid1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Button btnCancelar;
        private Button btnAtualizar;
        private DataGridView dataGrid1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn referencia;
        private DataGridViewTextBoxColumn numDoc;
        private DataGridViewTextBoxColumn propr;
        private DataGridViewTextBoxColumn nLivros;
        private Button btnFiltrar;
        private Button btnFiltrarLivros;
    }
}