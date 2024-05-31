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
            txtTermino = new DateTimePicker();
            labelTermino = new Label();
            txtInicio = new DateTimePicker();
            labelInicio = new Label();
            rdbPeriodo = new RadioButton();
            rdbFuturos = new RadioButton();
            rdbPassados = new RadioButton();
            rdbTodos = new RadioButton();
            gbFiltros.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11.25F);
            btnCancelar.Location = new Point(267, 273);
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
            btnGravar.Location = new Point(8, 273);
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
            gbFiltros.Controls.Add(txtTermino);
            gbFiltros.Controls.Add(labelTermino);
            gbFiltros.Controls.Add(txtInicio);
            gbFiltros.Controls.Add(labelInicio);
            gbFiltros.Controls.Add(rdbPeriodo);
            gbFiltros.Controls.Add(rdbFuturos);
            gbFiltros.Controls.Add(rdbPassados);
            gbFiltros.Controls.Add(rdbTodos);
            gbFiltros.Location = new Point(12, 12);
            gbFiltros.Name = "gbFiltros";
            gbFiltros.Size = new Size(423, 254);
            gbFiltros.TabIndex = 13;
            gbFiltros.TabStop = false;
            gbFiltros.Text = "Selecione um filtro";
            // 
            // txtTermino
            // 
            txtTermino.CustomFormat = "HH:mm";
            txtTermino.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTermino.Format = DateTimePickerFormat.Short;
            txtTermino.Location = new Point(292, 217);
            txtTermino.Name = "txtTermino";
            txtTermino.ShowUpDown = true;
            txtTermino.Size = new Size(125, 31);
            txtTermino.TabIndex = 12;
            txtTermino.Visible = false;
            // 
            // labelTermino
            // 
            labelTermino.AutoSize = true;
            labelTermino.Location = new Point(223, 223);
            labelTermino.Name = "labelTermino";
            labelTermino.Size = new Size(63, 20);
            labelTermino.TabIndex = 13;
            labelTermino.Text = "Termino";
            labelTermino.Visible = false;
            // 
            // txtInicio
            // 
            txtInicio.CustomFormat = "HH:mm";
            txtInicio.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInicio.Format = DateTimePickerFormat.Short;
            txtInicio.Location = new Point(59, 217);
            txtInicio.Name = "txtInicio";
            txtInicio.ShowUpDown = true;
            txtInicio.Size = new Size(125, 31);
            txtInicio.TabIndex = 9;
            txtInicio.Visible = false;
            // 
            // labelInicio
            // 
            labelInicio.AutoSize = true;
            labelInicio.Location = new Point(8, 223);
            labelInicio.Name = "labelInicio";
            labelInicio.Size = new Size(45, 20);
            labelInicio.TabIndex = 10;
            labelInicio.Text = "Inicio";
            labelInicio.Visible = false;
            // 
            // rdbPeriodo
            // 
            rdbPeriodo.AutoSize = true;
            rdbPeriodo.Location = new Point(6, 165);
            rdbPeriodo.Name = "rdbPeriodo";
            rdbPeriodo.Size = new Size(212, 24);
            rdbPeriodo.TabIndex = 3;
            rdbPeriodo.TabStop = true;
            rdbPeriodo.Text = "Compromissos por periodo";
            rdbPeriodo.UseVisualStyleBackColor = true;
            rdbPeriodo.CheckedChanged += radioButton1_CheckedChanged;
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
            // TelaFiltroCompromissoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 319);
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
        private RadioButton rdbPeriodo;
        private DateTimePicker txtInicio;
        private Label labelInicio;
        private DateTimePicker txtTermino;
        private Label labelTermino;
    }
}