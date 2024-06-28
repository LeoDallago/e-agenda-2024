namespace eAgenda.WinApp.ModuloDespesa
{
    partial class TelaDespesaForm
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
            txtId = new TextBox();
            lblId = new Label();
            txtDescricao = new TextBox();
            lblDescricao = new Label();
            txtValor = new TextBox();
            lblValor = new Label();
            cmbFormaPagamento = new ComboBox();
            lblFormaPagamento = new Label();
            dateTimePicker = new DateTimePicker();
            lblData = new Label();
            gbCategorias = new GroupBox();
            listCategorias = new CheckedListBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            gbCategorias.SuspendLayout();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.Location = new Point(116, 31);
            txtId.Name = "txtId";
            txtId.Size = new Size(67, 27);
            txtId.TabIndex = 0;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblId.Location = new Point(88, 34);
            lblId.Name = "lblId";
            lblId.Size = new Size(22, 20);
            lblId.TabIndex = 1;
            lblId.Text = "Id";
            // 
            // txtDescricao
            // 
            txtDescricao.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescricao.Location = new Point(116, 64);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(230, 27);
            txtDescricao.TabIndex = 2;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescricao.Location = new Point(36, 67);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(74, 20);
            lblDescricao.TabIndex = 3;
            lblDescricao.Text = "Descricao";
            // 
            // txtValor
            // 
            txtValor.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtValor.Location = new Point(116, 97);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(121, 27);
            txtValor.TabIndex = 4;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblValor.Location = new Point(67, 100);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(43, 20);
            lblValor.TabIndex = 5;
            lblValor.Text = "Valor";
            // 
            // cmbFormaPagamento
            // 
            cmbFormaPagamento.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbFormaPagamento.FormattingEnabled = true;
            cmbFormaPagamento.Location = new Point(116, 130);
            cmbFormaPagamento.Name = "cmbFormaPagamento";
            cmbFormaPagamento.Size = new Size(121, 28);
            cmbFormaPagamento.TabIndex = 6;
            // 
            // lblFormaPagamento
            // 
            lblFormaPagamento.AutoSize = true;
            lblFormaPagamento.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFormaPagamento.Location = new Point(4, 133);
            lblFormaPagamento.Name = "lblFormaPagamento";
            lblFormaPagamento.Size = new Size(106, 20);
            lblFormaPagamento.TabIndex = 7;
            lblFormaPagamento.Text = "Forma de Pgto";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker.Format = DateTimePickerFormat.Short;
            dateTimePicker.Location = new Point(116, 164);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(121, 27);
            dateTimePicker.TabIndex = 8;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblData.Location = new Point(69, 169);
            lblData.Name = "lblData";
            lblData.Size = new Size(41, 20);
            lblData.TabIndex = 9;
            lblData.Text = "Data";
            // 
            // gbCategorias
            // 
            gbCategorias.Controls.Add(listCategorias);
            gbCategorias.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbCategorias.Location = new Point(12, 197);
            gbCategorias.Name = "gbCategorias";
            gbCategorias.Size = new Size(343, 176);
            gbCategorias.TabIndex = 10;
            gbCategorias.TabStop = false;
            gbCategorias.Text = "Categorias";
            // 
            // listCategorias
            // 
            listCategorias.Dock = DockStyle.Fill;
            listCategorias.FormattingEnabled = true;
            listCategorias.Location = new Point(3, 23);
            listCategorias.Name = "listCategorias";
            listCategorias.Size = new Size(337, 150);
            listCategorias.TabIndex = 0;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11.25F);
            btnGravar.Location = new Point(15, 379);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(147, 27);
            btnGravar.TabIndex = 11;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11.25F);
            btnCancelar.Location = new Point(209, 379);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(143, 27);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaDespesaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 415);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(gbCategorias);
            Controls.Add(lblData);
            Controls.Add(dateTimePicker);
            Controls.Add(lblFormaPagamento);
            Controls.Add(cmbFormaPagamento);
            Controls.Add(lblValor);
            Controls.Add(txtValor);
            Controls.Add(lblDescricao);
            Controls.Add(txtDescricao);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Name = "TelaDespesaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "TelaDespesaForm";
            gbCategorias.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label lblId;
        private TextBox txtDescricao;
        private Label lblDescricao;
        private TextBox txtValor;
        private Label lblValor;
        private ComboBox cmbFormaPagamento;
        private Label lblFormaPagamento;
        private DateTimePicker dateTimePicker;
        private Label lblData;
        private GroupBox gbCategorias;
        private CheckedListBox listCategorias;
        private Button btnGravar;
        private Button btnCancelar;
    }
}