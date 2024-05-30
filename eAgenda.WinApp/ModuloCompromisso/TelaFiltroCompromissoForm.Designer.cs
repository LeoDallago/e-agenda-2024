namespace eAgenda.WinApp.ModuloCompromisso
{
    partial class TelaFiltroCompromissoForm
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
            btnCancelar = new Button();
            btnGravar = new Button();
            gbFiltros = new GroupBox();
            rdbTodos = new RadioButton();
            rdbPassados = new RadioButton();
            rdbFuturos = new RadioButton();
            gbFiltros.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11.25F);
            btnCancelar.Location = new Point(267, 200);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(168, 33);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11.25F);
            btnGravar.Location = new Point(12, 200);
            btnGravar.Margin = new Padding(3, 4, 3, 4);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(188, 33);
            btnGravar.TabIndex = 11;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // gbFiltros
            // 
            gbFiltros.Controls.Add(rdbFuturos);
            gbFiltros.Controls.Add(rdbPassados);
            gbFiltros.Controls.Add(rdbTodos);
            gbFiltros.Location = new Point(12, 12);
            gbFiltros.Name = "gbFiltros";
            gbFiltros.Size = new Size(423, 181);
            gbFiltros.TabIndex = 13;
            gbFiltros.TabStop = false;
            gbFiltros.Text = "Selecione um filtro";
            // 
            // rdbTodos
            // 
            rdbTodos.AutoSize = true;
            rdbTodos.Location = new Point(6, 37);
            rdbTodos.Name = "rdbTodos";
            rdbTodos.Size = new Size(189, 24);
            rdbTodos.TabIndex = 0;
            rdbTodos.TabStop = true;
            rdbTodos.Text = "Todos os compromissos";
            rdbTodos.UseVisualStyleBackColor = true;
            // 
            // rdbPassados
            // 
            rdbPassados.AutoSize = true;
            rdbPassados.Location = new Point(6, 79);
            rdbPassados.Name = "rdbPassados";
            rdbPassados.Size = new Size(193, 24);
            rdbPassados.TabIndex = 1;
            rdbPassados.TabStop = true;
            rdbPassados.Text = "Compromissos passados";
            rdbPassados.TextAlign = ContentAlignment.MiddleCenter;
            rdbPassados.UseVisualStyleBackColor = true;
            // 
            // rdbFuturos
            // 
            rdbFuturos.AutoSize = true;
            rdbFuturos.Location = new Point(6, 124);
            rdbFuturos.Name = "rdbFuturos";
            rdbFuturos.Size = new Size(178, 24);
            rdbFuturos.TabIndex = 2;
            rdbFuturos.TabStop = true;
            rdbFuturos.Text = "Compromissos futuros";
            rdbFuturos.UseVisualStyleBackColor = true;
            // 
            // TelaFiltroCompromissoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 246);
            Controls.Add(gbFiltros);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaFiltroCompromissoForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Filtro de registros";
            gbFiltros.ResumeLayout(false);
            gbFiltros.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCancelar;
        private Button btnGravar;
        private GroupBox gbFiltros;
        private RadioButton rdbFuturos;
        private RadioButton rdbPassados;
        private RadioButton rdbTodos;
    }
}