﻿
namespace Restaurante
{
    partial class FormRegistrarPrato
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
            this.lblAdicional = new System.Windows.Forms.Label();
            this.clbAdicional = new System.Windows.Forms.CheckedListBox();
            this.clbRetirar = new System.Windows.Forms.CheckedListBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblRetirar = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblPratoProduto = new System.Windows.Forms.Label();
            this.lblQualidade = new System.Windows.Forms.Label();
            this.txtOBS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPP = new System.Windows.Forms.ComboBox();
            this.nQuantidade = new System.Windows.Forms.NumericUpDown();
            this.lblPedido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdicional
            // 
            this.lblAdicional.AutoSize = true;
            this.lblAdicional.Location = new System.Drawing.Point(152, 195);
            this.lblAdicional.Name = "lblAdicional";
            this.lblAdicional.Size = new System.Drawing.Size(50, 13);
            this.lblAdicional.TabIndex = 0;
            this.lblAdicional.Text = "Adicional";
            // 
            // clbAdicional
            // 
            this.clbAdicional.FormattingEnabled = true;
            this.clbAdicional.Location = new System.Drawing.Point(118, 221);
            this.clbAdicional.Name = "clbAdicional";
            this.clbAdicional.Size = new System.Drawing.Size(120, 94);
            this.clbAdicional.TabIndex = 1;
            // 
            // clbRetirar
            // 
            this.clbRetirar.FormattingEnabled = true;
            this.clbRetirar.Location = new System.Drawing.Point(297, 221);
            this.clbRetirar.Name = "clbRetirar";
            this.clbRetirar.Size = new System.Drawing.Size(120, 94);
            this.clbRetirar.TabIndex = 2;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfirmar.Location = new System.Drawing.Point(118, 333);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(120, 27);
            this.btnConfirmar.TabIndex = 3;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblRetirar
            // 
            this.lblRetirar.AutoSize = true;
            this.lblRetirar.Location = new System.Drawing.Point(330, 195);
            this.lblRetirar.Name = "lblRetirar";
            this.lblRetirar.Size = new System.Drawing.Size(38, 13);
            this.lblRetirar.TabIndex = 4;
            this.lblRetirar.Text = "Retirar";
            // 
            // txtTipo
            // 
            this.txtTipo.Enabled = false;
            this.txtTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.Location = new System.Drawing.Point(228, 33);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(189, 20);
            this.txtTipo.TabIndex = 6;
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Location = new System.Drawing.Point(297, 333);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(120, 27);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(115, 36);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 9;
            this.lblTipo.Text = "Tipo";
            // 
            // lblPratoProduto
            // 
            this.lblPratoProduto.AutoSize = true;
            this.lblPratoProduto.Location = new System.Drawing.Point(115, 66);
            this.lblPratoProduto.Name = "lblPratoProduto";
            this.lblPratoProduto.Size = new System.Drawing.Size(74, 13);
            this.lblPratoProduto.TabIndex = 10;
            this.lblPratoProduto.Text = "Prato/Produto";
            // 
            // lblQualidade
            // 
            this.lblQualidade.AutoSize = true;
            this.lblQualidade.Location = new System.Drawing.Point(115, 92);
            this.lblQualidade.Name = "lblQualidade";
            this.lblQualidade.Size = new System.Drawing.Size(55, 13);
            this.lblQualidade.TabIndex = 11;
            this.lblQualidade.Text = "Qualidade";
            // 
            // txtOBS
            // 
            this.txtOBS.Location = new System.Drawing.Point(184, 125);
            this.txtOBS.Multiline = true;
            this.txtOBS.Name = "txtOBS";
            this.txtOBS.Size = new System.Drawing.Size(233, 50);
            this.txtOBS.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "OBS";
            // 
            // cbPP
            // 
            this.cbPP.FormattingEnabled = true;
            this.cbPP.Location = new System.Drawing.Point(228, 59);
            this.cbPP.Name = "cbPP";
            this.cbPP.Size = new System.Drawing.Size(189, 21);
            this.cbPP.TabIndex = 14;
            this.cbPP.SelectedIndexChanged += new System.EventHandler(this.cbPP_SelectedIndexChanged);
            // 
            // nQuantidade
            // 
            this.nQuantidade.Location = new System.Drawing.Point(228, 90);
            this.nQuantidade.Name = "nQuantidade";
            this.nQuantidade.Size = new System.Drawing.Size(120, 20);
            this.nQuantidade.TabIndex = 15;
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedido.Location = new System.Drawing.Point(3, 9);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(110, 29);
            this.lblPedido.TabIndex = 16;
            this.lblPedido.Text = "Pedido #";
            // 
            // FormRegistrarPrato
            // 
            this.AcceptButton = this.btnConfirmar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(522, 391);
            this.Controls.Add(this.lblPedido);
            this.Controls.Add(this.nQuantidade);
            this.Controls.Add(this.cbPP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOBS);
            this.Controls.Add(this.lblQualidade);
            this.Controls.Add(this.lblPratoProduto);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.lblRetirar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.clbRetirar);
            this.Controls.Add(this.clbAdicional);
            this.Controls.Add(this.lblAdicional);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRegistrarPrato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Prato";
            this.Load += new System.EventHandler(this.FormRegistrarPrato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdicional;
        private System.Windows.Forms.CheckedListBox clbAdicional;
        private System.Windows.Forms.CheckedListBox clbRetirar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblRetirar;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblPratoProduto;
        private System.Windows.Forms.Label lblQualidade;
        private System.Windows.Forms.TextBox txtOBS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPP;
        private System.Windows.Forms.NumericUpDown nQuantidade;
        private System.Windows.Forms.Label lblPedido;
    }
}