namespace MADKOUA_CLIENTE
{
    partial class MainForm
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
            this.PanelLeft = new System.Windows.Forms.Panel();
            this.PanelDGV = new System.Windows.Forms.Panel();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.DGVLivros = new System.Windows.Forms.DataGridView();
            this.TBPesquisa = new System.Windows.Forms.TextBox();
            this.PanelDGV.SuspendLayout();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelLeft
            // 
            this.PanelLeft.BackColor = System.Drawing.Color.LightSteelBlue;
            this.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLeft.Location = new System.Drawing.Point(0, 0);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Size = new System.Drawing.Size(71, 688);
            this.PanelLeft.TabIndex = 0;
            // 
            // PanelDGV
            // 
            this.PanelDGV.Controls.Add(this.DGVLivros);
            this.PanelDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDGV.Location = new System.Drawing.Point(71, 0);
            this.PanelDGV.Name = "PanelDGV";
            this.PanelDGV.Size = new System.Drawing.Size(1104, 688);
            this.PanelDGV.TabIndex = 1;
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.Lavender;
            this.PanelTop.Controls.Add(this.TBPesquisa);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(71, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(1104, 169);
            this.PanelTop.TabIndex = 2;
            // 
            // DGVLivros
            // 
            this.DGVLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVLivros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVLivros.Location = new System.Drawing.Point(0, 0);
            this.DGVLivros.Name = "DGVLivros";
            this.DGVLivros.RowTemplate.Height = 24;
            this.DGVLivros.Size = new System.Drawing.Size(1104, 688);
            this.DGVLivros.TabIndex = 0;
            // 
            // TBPesquisa
            // 
            this.TBPesquisa.Dock = System.Windows.Forms.DockStyle.Top;
            this.TBPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPesquisa.Location = new System.Drawing.Point(0, 0);
            this.TBPesquisa.Multiline = true;
            this.TBPesquisa.Name = "TBPesquisa";
            this.TBPesquisa.Size = new System.Drawing.Size(1104, 30);
            this.TBPesquisa.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 688);
            this.Controls.Add(this.PanelTop);
            this.Controls.Add(this.PanelDGV);
            this.Controls.Add(this.PanelLeft);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "MADKOUA Cliente";
            this.PanelDGV.ResumeLayout(false);
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLivros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLeft;
        private System.Windows.Forms.Panel PanelDGV;
        private System.Windows.Forms.DataGridView DGVLivros;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.TextBox TBPesquisa;
    }
}

