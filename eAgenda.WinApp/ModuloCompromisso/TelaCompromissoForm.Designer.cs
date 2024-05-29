namespace eAgenda.WinApp.ModuloCompromisso
{
    partial class TelaCompromissoForm
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
            labelID = new Label();
            labelAssunto = new Label();
            txtAssunto = new TextBox();
            label3 = new Label();
            dateTimeData = new DateTimePicker();
            labelInicio = new Label();
            labelTermino = new Label();
            txtContato = new TextBox();
            labelContato = new Label();
            grupoLocalização = new GroupBox();
            txtLocalizacao = new TextBox();
            rdRemoto = new RadioButton();
            rdPresencial = new RadioButton();
            btnGravar = new Button();
            btnCancelar = new Button();
            txtInicio = new DateTimePicker();
            txtTermino = new DateTimePicker();
            checkBoxMarcarPessoa = new CheckBox();
            label1 = new Label();
            grupoLocalização.SuspendLayout();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI", 11.25F);
            txtId.Location = new Point(133, 51);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.Size = new Size(114, 32);
            txtId.TabIndex = 2;
            txtId.Text = "0";
            txtId.Visible = false;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Segoe UI", 11.25F);
            labelID.Location = new Point(99, 54);
            labelID.Name = "labelID";
            labelID.Size = new Size(28, 25);
            labelID.TabIndex = 3;
            labelID.Text = "Id";
            labelID.Visible = false;
            // 
            // labelAssunto
            // 
            labelAssunto.AutoSize = true;
            labelAssunto.Location = new Point(66, 102);
            labelAssunto.Name = "labelAssunto";
            labelAssunto.Size = new Size(61, 20);
            labelAssunto.TabIndex = 4;
            labelAssunto.Text = "Assunto";
            // 
            // txtAssunto
            // 
            txtAssunto.Font = new Font("Segoe UI", 11.25F);
            txtAssunto.Location = new Point(133, 95);
            txtAssunto.Margin = new Padding(3, 4, 3, 4);
            txtAssunto.Name = "txtAssunto";
            txtAssunto.Size = new Size(449, 32);
            txtAssunto.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 146);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 6;
            label3.Text = "Data";
            // 
            // dateTimeData
            // 
            dateTimeData.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimeData.Format = DateTimePickerFormat.Short;
            dateTimeData.Location = new Point(133, 141);
            dateTimeData.Name = "dateTimeData";
            dateTimeData.Size = new Size(125, 31);
            dateTimeData.TabIndex = 1;
            // 
            // labelInicio
            // 
            labelInicio.AutoSize = true;
            labelInicio.Location = new Point(82, 201);
            labelInicio.Name = "labelInicio";
            labelInicio.Size = new Size(45, 20);
            labelInicio.TabIndex = 8;
            labelInicio.Text = "Inicio";
            // 
            // labelTermino
            // 
            labelTermino.AutoSize = true;
            labelTermino.Location = new Point(388, 201);
            labelTermino.Name = "labelTermino";
            labelTermino.Size = new Size(63, 20);
            labelTermino.TabIndex = 11;
            labelTermino.Text = "Termino";
            // 
            // txtContato
            // 
            txtContato.Font = new Font("Segoe UI", 11.25F);
            txtContato.Location = new Point(133, 284);
            txtContato.Margin = new Padding(3, 4, 3, 4);
            txtContato.Name = "txtContato";
            txtContato.Size = new Size(449, 32);
            txtContato.TabIndex = 5;
            txtContato.Visible = false;
            // 
            // labelContato
            // 
            labelContato.AutoSize = true;
            labelContato.Location = new Point(65, 291);
            labelContato.Name = "labelContato";
            labelContato.Size = new Size(62, 20);
            labelContato.TabIndex = 13;
            labelContato.Text = "Contato";
            labelContato.Visible = false;
            // 
            // grupoLocalização
            // 
            grupoLocalização.Controls.Add(txtLocalizacao);
            grupoLocalização.Controls.Add(rdRemoto);
            grupoLocalização.Controls.Add(rdPresencial);
            grupoLocalização.Location = new Point(133, 334);
            grupoLocalização.Name = "grupoLocalização";
            grupoLocalização.Size = new Size(449, 121);
            grupoLocalização.TabIndex = 14;
            grupoLocalização.TabStop = false;
            grupoLocalização.Text = "Localização";
            // 
            // txtLocalizacao
            // 
            txtLocalizacao.Font = new Font("Segoe UI", 11.25F);
            txtLocalizacao.Location = new Point(37, 73);
            txtLocalizacao.Margin = new Padding(3, 4, 3, 4);
            txtLocalizacao.Name = "txtLocalizacao";
            txtLocalizacao.Size = new Size(370, 32);
            txtLocalizacao.TabIndex = 8;
            txtLocalizacao.Visible = false;
            // 
            // rdRemoto
            // 
            rdRemoto.AutoSize = true;
            rdRemoto.Checked = true;
            rdRemoto.Location = new Point(324, 26);
            rdRemoto.Name = "rdRemoto";
            rdRemoto.Size = new Size(83, 24);
            rdRemoto.TabIndex = 7;
            rdRemoto.TabStop = true;
            rdRemoto.Text = "Remoto";
            rdRemoto.UseVisualStyleBackColor = true;
            rdRemoto.CheckedChanged += rdRemoto_CheckedChanged;
            // 
            // rdPresencial
            // 
            rdPresencial.AutoSize = true;
            rdPresencial.Location = new Point(37, 27);
            rdPresencial.Name = "rdPresencial";
            rdPresencial.Size = new Size(96, 24);
            rdPresencial.TabIndex = 6;
            rdPresencial.Text = "Presencial";
            rdPresencial.UseVisualStyleBackColor = true;
            rdPresencial.CheckedChanged += rdPresencial_CheckedChanged;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11.25F);
            btnGravar.Location = new Point(133, 462);
            btnGravar.Margin = new Padding(3, 4, 3, 4);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(214, 33);
            btnGravar.TabIndex = 9;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11.25F);
            btnCancelar.Location = new Point(388, 462);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(194, 33);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtInicio
            // 
            txtInicio.CustomFormat = "HH:mm";
            txtInicio.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInicio.Format = DateTimePickerFormat.Custom;
            txtInicio.Location = new Point(133, 195);
            txtInicio.Name = "txtInicio";
            txtInicio.ShowUpDown = true;
            txtInicio.Size = new Size(125, 31);
            txtInicio.TabIndex = 2;
            // 
            // txtTermino
            // 
            txtTermino.CustomFormat = "HH:mm";
            txtTermino.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTermino.Format = DateTimePickerFormat.Custom;
            txtTermino.Location = new Point(457, 195);
            txtTermino.Name = "txtTermino";
            txtTermino.ShowUpDown = true;
            txtTermino.Size = new Size(125, 31);
            txtTermino.TabIndex = 3;
            // 
            // checkBoxMarcarPessoa
            // 
            checkBoxMarcarPessoa.AutoSize = true;
            checkBoxMarcarPessoa.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxMarcarPessoa.Location = new Point(133, 248);
            checkBoxMarcarPessoa.Name = "checkBoxMarcarPessoa";
            checkBoxMarcarPessoa.Size = new Size(154, 29);
            checkBoxMarcarPessoa.TabIndex = 4;
            checkBoxMarcarPessoa.Text = "Marcar contato";
            checkBoxMarcarPessoa.UseVisualStyleBackColor = true;
            checkBoxMarcarPessoa.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(203, 16);
            label1.Name = "label1";
            label1.Size = new Size(280, 31);
            label1.TabIndex = 22;
            label1.Text = "Cadastrar Compromisso";
            // 
            // TelaCompromissoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 508);
            Controls.Add(label1);
            Controls.Add(checkBoxMarcarPessoa);
            Controls.Add(txtTermino);
            Controls.Add(txtInicio);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(grupoLocalização);
            Controls.Add(labelContato);
            Controls.Add(txtContato);
            Controls.Add(labelTermino);
            Controls.Add(labelInicio);
            Controls.Add(dateTimeData);
            Controls.Add(label3);
            Controls.Add(txtAssunto);
            Controls.Add(labelAssunto);
            Controls.Add(labelID);
            Controls.Add(txtId);
            Name = "TelaCompromissoForm";
            Text = "TelaCompromissoForm";
            Load += TelaCompromissoForm_Load;
            grupoLocalização.ResumeLayout(false);
            grupoLocalização.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label labelID;
        private Label labelAssunto;
        private TextBox txtAssunto;
        private Label label3;
        private DateTimePicker dateTimeData;
        private Label labelInicio;
        private Label labelTermino;
        private TextBox txtContato;
        private Label labelContato;
        private GroupBox grupoLocalização;
        private RadioButton rdPresencial;
        private RadioButton rdRemoto;
        private Button btnGravar;
        private Button btnCancelar;
        private TextBox txtLocalizacao;
        private DateTimePicker txtInicio;
        private DateTimePicker txtTermino;
        private CheckBox checkBoxMarcarPessoa;
        private Label label1;
    }
}