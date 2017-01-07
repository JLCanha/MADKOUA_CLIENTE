namespace MADKOUA_CLIENTE
{
    partial class RequisicoesForm
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
            this.DGV_Requisicoes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Requisicoes)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Requisicoes
            // 
            this.DGV_Requisicoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Requisicoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Requisicoes.Location = new System.Drawing.Point(0, 0);
            this.DGV_Requisicoes.Name = "DGV_Requisicoes";
            this.DGV_Requisicoes.Size = new System.Drawing.Size(783, 261);
            this.DGV_Requisicoes.TabIndex = 0;
            // 
            // RequisicoesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 261);
            this.Controls.Add(this.DGV_Requisicoes);
            this.Name = "RequisicoesForm";
            this.Text = "RequisicoesForm";
            this.Load += new System.EventHandler(this.RequisicoesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Requisicoes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Requisicoes;
    }
}