namespace eAgenda.WinApp.ModuloTarefa
{
    partial class TelaCadastroItemTarefa
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
            lblTarefa = new Label();
            lblTituloTarefa = new Label();
            lblTitulo = new Label();
            txtTitulo = new TextBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            btnAdiconar = new Button();
            listItensTarefa = new ListBox();
            SuspendLayout();
            // 
            // lblTarefa
            // 
            lblTarefa.AutoSize = true;
            lblTarefa.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTarefa.Location = new Point(43, 29);
            lblTarefa.Name = "lblTarefa";
            lblTarefa.Size = new Size(49, 20);
            lblTarefa.TabIndex = 0;
            lblTarefa.Text = "Tarefa";
            // 
            // lblTituloTarefa
            // 
            lblTituloTarefa.AutoSize = true;
            lblTituloTarefa.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloTarefa.Location = new Point(98, 29);
            lblTituloTarefa.Name = "lblTituloTarefa";
            lblTituloTarefa.Size = new Size(95, 20);
            lblTituloTarefa.TabIndex = 1;
            lblTituloTarefa.Text = "Tarefa titulo";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(32, 63);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(47, 20);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Titulo";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(98, 63);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(166, 23);
            txtTitulo.TabIndex = 3;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11.25F);
            btnGravar.Location = new Point(12, 267);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(169, 27);
            btnGravar.TabIndex = 7;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11.25F);
            btnCancelar.Location = new Point(213, 267);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(163, 27);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAdiconar
            // 
            btnAdiconar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdiconar.Location = new Point(282, 63);
            btnAdiconar.Name = "btnAdiconar";
            btnAdiconar.Size = new Size(94, 23);
            btnAdiconar.TabIndex = 9;
            btnAdiconar.Text = "Adicionar";
            btnAdiconar.UseVisualStyleBackColor = true;
            btnAdiconar.Click += btnAdiconar_Click;
            // 
            // listItensTarefa
            // 
            listItensTarefa.FormattingEnabled = true;
            listItensTarefa.ItemHeight = 15;
            listItensTarefa.Location = new Point(12, 92);
            listItensTarefa.Name = "listItensTarefa";
            listItensTarefa.Size = new Size(364, 154);
            listItensTarefa.TabIndex = 10;
            // 
            // TelaCadastroItemTarefa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 306);
            Controls.Add(listItensTarefa);
            Controls.Add(btnAdiconar);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(txtTitulo);
            Controls.Add(lblTitulo);
            Controls.Add(lblTituloTarefa);
            Controls.Add(lblTarefa);
            Name = "TelaCadastroItemTarefa";
            StartPosition = FormStartPosition.CenterParent;
            Text = "TelaCadastroItemTarefa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTarefa;
        private Label lblTituloTarefa;
        private Label lblTitulo;
        private TextBox txtTitulo;
        private Button btnGravar;
        private Button btnCancelar;
        private Button btnAdiconar;
        private ListBox listItensTarefa;
    }
}