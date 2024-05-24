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
            label1 = new Label();
            label2 = new Label();
            txtAssunto = new TextBox();
            label3 = new Label();
            dateTimeData = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            txtContato = new TextBox();
            label6 = new Label();
            grupoLocalização = new GroupBox();
            rdRemoto = new RadioButton();
            rdPresencial = new RadioButton();
            btnGravar = new Button();
            btnCancelar = new Button();
            txtInicio = new TextBox();
            txtTermino = new TextBox();
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
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(99, 54);
            label1.Name = "label1";
            label1.Size = new Size(28, 25);
            label1.TabIndex = 3;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 102);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 4;
            label2.Text = "Assunto";
            // 
            // txtAssunto
            // 
            txtAssunto.Font = new Font("Segoe UI", 11.25F);
            txtAssunto.Location = new Point(133, 95);
            txtAssunto.Margin = new Padding(3, 4, 3, 4);
            txtAssunto.Name = "txtAssunto";
            txtAssunto.Size = new Size(449, 32);
            txtAssunto.TabIndex = 5;
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
            dateTimeData.Location = new Point(133, 141);
            dateTimeData.Name = "dateTimeData";
            dateTimeData.Size = new Size(250, 27);
            dateTimeData.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(82, 201);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 8;
            label4.Text = "Inicio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(388, 204);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 11;
            label5.Text = "Termino";
            // 
            // txtContato
            // 
            txtContato.Font = new Font("Segoe UI", 11.25F);
            txtContato.Location = new Point(133, 252);
            txtContato.Margin = new Padding(3, 4, 3, 4);
            txtContato.Name = "txtContato";
            txtContato.Size = new Size(449, 32);
            txtContato.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(65, 264);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 13;
            label6.Text = "Contato";
            // 
            // grupoLocalização
            // 
            grupoLocalização.Controls.Add(rdRemoto);
            grupoLocalização.Controls.Add(rdPresencial);
            grupoLocalização.Location = new Point(133, 309);
            grupoLocalização.Name = "grupoLocalização";
            grupoLocalização.Size = new Size(449, 62);
            grupoLocalização.TabIndex = 14;
            grupoLocalização.TabStop = false;
            grupoLocalização.Text = "Localização";
            // 
            // rdRemoto
            // 
            rdRemoto.AutoSize = true;
            rdRemoto.Location = new Point(324, 26);
            rdRemoto.Name = "rdRemoto";
            rdRemoto.Size = new Size(83, 24);
            rdRemoto.TabIndex = 1;
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
            rdPresencial.TabIndex = 0;
            rdPresencial.TabStop = true;
            rdPresencial.Text = "Presencial";
            rdPresencial.UseVisualStyleBackColor = true;
            rdPresencial.CheckedChanged += rdPresencial_CheckedChanged;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11.25F);
            btnGravar.Location = new Point(348, 446);
            btnGravar.Margin = new Padding(3, 4, 3, 4);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(114, 49);
            btnGravar.TabIndex = 17;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11.25F);
            btnCancelar.Location = new Point(468, 446);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 49);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtInicio
            // 
            txtInicio.Location = new Point(133, 201);
            txtInicio.Name = "txtInicio";
            txtInicio.Size = new Size(125, 27);
            txtInicio.TabIndex = 19;
            // 
            // txtTermino
            // 
            txtTermino.Location = new Point(457, 201);
            txtTermino.Name = "txtTermino";
            txtTermino.Size = new Size(125, 27);
            txtTermino.TabIndex = 20;
            // 
            // TelaCompromissoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 508);
            Controls.Add(txtTermino);
            Controls.Add(txtInicio);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(grupoLocalização);
            Controls.Add(label6);
            Controls.Add(txtContato);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dateTimeData);
            Controls.Add(label3);
            Controls.Add(txtAssunto);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
        private TextBox txtAssunto;
        private Label label3;
        private DateTimePicker dateTimeData;
        private Label label4;
        private Label label5;
        private TextBox txtContato;
        private Label label6;
        private GroupBox grupoLocalização;
        private RadioButton rdPresencial;
        private RadioButton rdRemoto;
        private Button btnGravar;
        private Button btnCancelar;
        private TextBox txtInicio;
        private TextBox txtTermino;
    }
}