namespace eAgenda.WinApp.ModuloContato
{
    partial class TabelaContatoControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grid = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            nome = new DataGridViewTextBoxColumn();
            telefone = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            empresa = new DataGridViewTextBoxColumn();
            cargo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
            SuspendLayout();
            // 
            // grid
            // 
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToResizeColumns = false;
            grid.AllowUserToResizeRows = false;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid.Columns.AddRange(new DataGridViewColumn[] { id, nome, telefone, email, empresa, cargo });
            grid.Dock = DockStyle.Fill;
            grid.Location = new Point(0, 0);
            grid.Margin = new Padding(3, 2, 3, 2);
            grid.Name = "grid";
            grid.ReadOnly = true;
            grid.RowHeadersVisible = false;
            grid.RowHeadersWidth = 51;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.Size = new Size(668, 274);
            grid.TabIndex = 0;
            grid.CellContentClick += grid_CellContentClick;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // nome
            // 
            nome.HeaderText = "Nome";
            nome.MinimumWidth = 6;
            nome.Name = "nome";
            nome.ReadOnly = true;
            // 
            // telefone
            // 
            telefone.HeaderText = "Telefone";
            telefone.MinimumWidth = 6;
            telefone.Name = "telefone";
            telefone.ReadOnly = true;
            // 
            // email
            // 
            email.HeaderText = "E-mail";
            email.MinimumWidth = 6;
            email.Name = "email";
            email.ReadOnly = true;
            // 
            // empresa
            // 
            empresa.HeaderText = "Empresa";
            empresa.Name = "empresa";
            empresa.ReadOnly = true;
            // 
            // cargo
            // 
            cargo.HeaderText = "Cargo";
            cargo.MinimumWidth = 6;
            cargo.Name = "cargo";
            cargo.ReadOnly = true;
            // 
            // TabelaContatoControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grid);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TabelaContatoControl";
            Size = new Size(668, 274);
            ((System.ComponentModel.ISupportInitialize)grid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView grid;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn telefone;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn empresa;
        private DataGridViewTextBoxColumn cargo;
    }
}
