﻿namespace e_Agenda.WinApp.Telas_Contatos
{
    partial class TelaListagemContatos
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnVisualizarPorCargo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listaContatos = new System.Windows.Forms.ListBox();
            this.btnVisualizacaoComum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.White;
            this.btnInserir.Location = new System.Drawing.Point(248, 13);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(117, 28);
            this.btnInserir.TabIndex = 0;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(371, 13);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(117, 28);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(493, 13);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(117, 28);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnVisualizarPorCargo
            // 
            this.btnVisualizarPorCargo.BackColor = System.Drawing.Color.White;
            this.btnVisualizarPorCargo.Location = new System.Drawing.Point(615, 13);
            this.btnVisualizarPorCargo.Name = "btnVisualizarPorCargo";
            this.btnVisualizarPorCargo.Size = new System.Drawing.Size(210, 28);
            this.btnVisualizarPorCargo.TabIndex = 3;
            this.btnVisualizarPorCargo.Text = "Visualização agrupada por cargos";
            this.btnVisualizarPorCargo.UseVisualStyleBackColor = false;
            this.btnVisualizarPorCargo.Click += new System.EventHandler(this.btnVisualizarPorCargo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Contatos";
            // 
            // listaContatos
            // 
            this.listaContatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listaContatos.FormattingEnabled = true;
            this.listaContatos.HorizontalScrollbar = true;
            this.listaContatos.ItemHeight = 15;
            this.listaContatos.Location = new System.Drawing.Point(14, 51);
            this.listaContatos.Name = "listaContatos";
            this.listaContatos.Size = new System.Drawing.Size(1026, 332);
            this.listaContatos.TabIndex = 5;
            // 
            // btnVisualizacaoComum
            // 
            this.btnVisualizacaoComum.BackColor = System.Drawing.Color.White;
            this.btnVisualizacaoComum.Location = new System.Drawing.Point(830, 13);
            this.btnVisualizacaoComum.Name = "btnVisualizacaoComum";
            this.btnVisualizacaoComum.Size = new System.Drawing.Size(210, 28);
            this.btnVisualizacaoComum.TabIndex = 4;
            this.btnVisualizacaoComum.Text = "Visualização comum";
            this.btnVisualizacaoComum.UseVisualStyleBackColor = false;
            this.btnVisualizacaoComum.Click += new System.EventHandler(this.btnVisualizacaoComum_Click);
            // 
            // TelaListagemContatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.btnVisualizacaoComum);
            this.Controls.Add(this.listaContatos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVisualizarPorCargo);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnInserir);
            this.Name = "TelaListagemContatos";
            this.Size = new System.Drawing.Size(1053, 394);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnVisualizarPorCargo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listaContatos;
        private System.Windows.Forms.Button btnVisualizacaoComum;
    }
}
