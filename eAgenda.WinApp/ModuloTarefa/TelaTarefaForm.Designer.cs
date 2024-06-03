namespace eAgenda.WinApp.ModuloTarefa
{
    partial class TelaTarefaForm
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
            lblId = new Label();
            txtId = new TextBox();
            lblTitulo = new Label();
            txtTitulo = new TextBox();
            lblPrioridade = new Label();
            comboBoxPrioridades = new ComboBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblId.Location = new Point(75, 27);
            lblId.Name = "lblId";
            lblId.Size = new Size(22, 20);
            lblId.TabIndex = 0;
            lblId.Text = "Id";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(103, 28);
            txtId.Name = "txtId";
            txtId.Size = new Size(123, 23);
            txtId.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(50, 58);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(47, 20);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Titulo";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(103, 59);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(186, 23);
            txtTitulo.TabIndex = 3;
            // 
            // lblPrioridade
            // 
            lblPrioridade.AutoSize = true;
            lblPrioridade.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrioridade.Location = new Point(19, 91);
            lblPrioridade.Name = "lblPrioridade";
            lblPrioridade.Size = new Size(78, 20);
            lblPrioridade.TabIndex = 4;
            lblPrioridade.Text = "Prioridade";
            // 
            // comboBoxPrioridades
            // 
            comboBoxPrioridades.FormattingEnabled = true;
            comboBoxPrioridades.Location = new Point(103, 91);
            comboBoxPrioridades.Name = "comboBoxPrioridades";
            comboBoxPrioridades.Size = new Size(123, 23);
            comboBoxPrioridades.TabIndex = 5;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11.25F);
            btnGravar.Location = new Point(12, 161);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(195, 27);
            btnGravar.TabIndex = 6;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.OK;
            btnCancelar.Font = new Font("Segoe UI", 11.25F);
            btnCancelar.Location = new Point(223, 161);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(195, 27);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaTarefaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 200);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(comboBoxPrioridades);
            Controls.Add(lblPrioridade);
            Controls.Add(txtTitulo);
            Controls.Add(lblTitulo);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Name = "TelaTarefaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "TelaTarefaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private TextBox txtId;
        private Label lblTitulo;
        private TextBox txtTitulo;
        private Label lblPrioridade;
        private ComboBox comboBoxPrioridades;
        private Button btnGravar;
        private Button btnCancelar;
    }
}