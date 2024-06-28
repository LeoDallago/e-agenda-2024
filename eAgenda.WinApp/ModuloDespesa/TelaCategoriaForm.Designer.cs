namespace eAgenda.WinApp.ModuloDespesa
{
    partial class TelaCategoriaForm
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
            txtTitulo = new TextBox();
            lblTitulo = new Label();
            btnGravar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblId.Location = new Point(76, 27);
            lblId.Name = "lblId";
            lblId.Size = new Size(22, 20);
            lblId.TabIndex = 0;
            lblId.Text = "Id";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.Location = new Point(104, 24);
            txtId.Name = "txtId";
            txtId.Size = new Size(75, 27);
            txtId.TabIndex = 1;
            // 
            // txtTitulo
            // 
            txtTitulo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitulo.Location = new Point(104, 76);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(270, 27);
            txtTitulo.TabIndex = 2;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(51, 79);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(47, 20);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Titulo";
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11.25F);
            btnGravar.Location = new Point(101, 163);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(195, 27);
            btnGravar.TabIndex = 6;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11.25F);
            btnCancelar.Location = new Point(302, 163);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(195, 27);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaCategoriaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 202);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(lblTitulo);
            Controls.Add(txtTitulo);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Name = "TelaCategoriaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "TelaCategoriaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private TextBox txtId;
        private TextBox txtTitulo;
        private Label lblTitulo;
        private Button btnGravar;
        private Button btnCancelar;
    }
}