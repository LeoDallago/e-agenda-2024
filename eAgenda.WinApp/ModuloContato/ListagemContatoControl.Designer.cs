﻿namespace eAgenda.WinApp.ModuloContato
{
    partial class ListagemContatoControl
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
            listContatos = new ListBox();
            SuspendLayout();
            // 
            // listContatos
            // 
            listContatos.Dock = DockStyle.Fill;
            listContatos.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listContatos.FormattingEnabled = true;
            listContatos.ItemHeight = 21;
            listContatos.Location = new Point(0, 0);
            listContatos.Margin = new Padding(3, 4, 3, 4);
            listContatos.Name = "listContatos";
            listContatos.Size = new Size(630, 431);
            listContatos.TabIndex = 0;
            listContatos.SelectedIndexChanged += listContatos_SelectedIndexChanged;
            // 
            // ListagemContatoControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listContatos);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ListagemContatoControl";
            Size = new Size(630, 431);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listContatos;
    }
}
