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
            this.DGVLivros = new System.Windows.Forms.DataGridView();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.LB_Disponibilidade = new System.Windows.Forms.Label();
            this.TB_Descricao = new System.Windows.Forms.TextBox();
            this.TB_Editora = new System.Windows.Forms.TextBox();
            this.TB_Titulo = new System.Windows.Forms.TextBox();
            this.TB_Autor = new System.Windows.Forms.TextBox();
            this.LB_Descricao = new System.Windows.Forms.Label();
            this.BTN_Requisitar = new System.Windows.Forms.Button();
            this.LB_Editora = new System.Windows.Forms.Label();
            this.LB_Autor = new System.Windows.Forms.Label();
            this.LB_Titulo = new System.Windows.Forms.Label();
            this.TBPesquisa = new System.Windows.Forms.TextBox();
            this.BTN_Login = new System.Windows.Forms.Button();
            this.PanelLeft.SuspendLayout();
            this.PanelDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLivros)).BeginInit();
            this.PanelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelLeft
            // 
            this.PanelLeft.BackColor = System.Drawing.Color.LightSteelBlue;
            this.PanelLeft.Controls.Add(this.BTN_Login);
            this.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLeft.Location = new System.Drawing.Point(0, 0);
            this.PanelLeft.Margin = new System.Windows.Forms.Padding(2);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Size = new System.Drawing.Size(53, 559);
            this.PanelLeft.TabIndex = 0;
            // 
            // PanelDGV
            // 
            this.PanelDGV.Controls.Add(this.DGVLivros);
            this.PanelDGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelDGV.Location = new System.Drawing.Point(53, 169);
            this.PanelDGV.Margin = new System.Windows.Forms.Padding(2);
            this.PanelDGV.Name = "PanelDGV";
            this.PanelDGV.Size = new System.Drawing.Size(828, 390);
            this.PanelDGV.TabIndex = 1;
            // 
            // DGVLivros
            // 
            this.DGVLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVLivros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVLivros.Location = new System.Drawing.Point(0, 0);
            this.DGVLivros.Margin = new System.Windows.Forms.Padding(2);
            this.DGVLivros.Name = "DGVLivros";
            this.DGVLivros.RowTemplate.Height = 24;
            this.DGVLivros.Size = new System.Drawing.Size(828, 390);
            this.DGVLivros.TabIndex = 0;
            this.DGVLivros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVLivros_CellClick);
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.Lavender;
            this.PanelTop.Controls.Add(this.LB_Disponibilidade);
            this.PanelTop.Controls.Add(this.TB_Descricao);
            this.PanelTop.Controls.Add(this.TB_Editora);
            this.PanelTop.Controls.Add(this.TB_Titulo);
            this.PanelTop.Controls.Add(this.TB_Autor);
            this.PanelTop.Controls.Add(this.LB_Descricao);
            this.PanelTop.Controls.Add(this.BTN_Requisitar);
            this.PanelTop.Controls.Add(this.LB_Editora);
            this.PanelTop.Controls.Add(this.LB_Autor);
            this.PanelTop.Controls.Add(this.LB_Titulo);
            this.PanelTop.Controls.Add(this.TBPesquisa);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(53, 0);
            this.PanelTop.Margin = new System.Windows.Forms.Padding(2);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(828, 165);
            this.PanelTop.TabIndex = 2;
            // 
            // LB_Disponibilidade
            // 
            this.LB_Disponibilidade.AutoSize = true;
            this.LB_Disponibilidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Disponibilidade.Location = new System.Drawing.Point(704, 31);
            this.LB_Disponibilidade.Name = "LB_Disponibilidade";
            this.LB_Disponibilidade.Size = new System.Drawing.Size(0, 18);
            this.LB_Disponibilidade.TabIndex = 12;
            // 
            // TB_Descricao
            // 
            this.TB_Descricao.Enabled = false;
            this.TB_Descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Descricao.Location = new System.Drawing.Point(92, 106);
            this.TB_Descricao.Multiline = true;
            this.TB_Descricao.Name = "TB_Descricao";
            this.TB_Descricao.Size = new System.Drawing.Size(606, 56);
            this.TB_Descricao.TabIndex = 11;
            // 
            // TB_Editora
            // 
            this.TB_Editora.Enabled = false;
            this.TB_Editora.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Editora.Location = new System.Drawing.Point(92, 80);
            this.TB_Editora.Name = "TB_Editora";
            this.TB_Editora.Size = new System.Drawing.Size(606, 24);
            this.TB_Editora.TabIndex = 10;
            // 
            // TB_Titulo
            // 
            this.TB_Titulo.Enabled = false;
            this.TB_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Titulo.Location = new System.Drawing.Point(92, 28);
            this.TB_Titulo.Name = "TB_Titulo";
            this.TB_Titulo.Size = new System.Drawing.Size(606, 24);
            this.TB_Titulo.TabIndex = 9;
            // 
            // TB_Autor
            // 
            this.TB_Autor.Enabled = false;
            this.TB_Autor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Autor.Location = new System.Drawing.Point(92, 54);
            this.TB_Autor.Name = "TB_Autor";
            this.TB_Autor.Size = new System.Drawing.Size(606, 24);
            this.TB_Autor.TabIndex = 8;
            // 
            // LB_Descricao
            // 
            this.LB_Descricao.AutoSize = true;
            this.LB_Descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Descricao.Location = new System.Drawing.Point(6, 109);
            this.LB_Descricao.Name = "LB_Descricao";
            this.LB_Descricao.Size = new System.Drawing.Size(80, 18);
            this.LB_Descricao.TabIndex = 5;
            this.LB_Descricao.Text = "Descrição:";
            // 
            // BTN_Requisitar
            // 
            this.BTN_Requisitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Requisitar.Location = new System.Drawing.Point(705, 126);
            this.BTN_Requisitar.Name = "BTN_Requisitar";
            this.BTN_Requisitar.Size = new System.Drawing.Size(120, 36);
            this.BTN_Requisitar.TabIndex = 4;
            this.BTN_Requisitar.Text = "Requisitar";
            this.BTN_Requisitar.UseVisualStyleBackColor = true;
            this.BTN_Requisitar.Click += new System.EventHandler(this.BTN_Requisitar_Click);
            // 
            // LB_Editora
            // 
            this.LB_Editora.AutoSize = true;
            this.LB_Editora.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Editora.Location = new System.Drawing.Point(6, 83);
            this.LB_Editora.Name = "LB_Editora";
            this.LB_Editora.Size = new System.Drawing.Size(63, 18);
            this.LB_Editora.TabIndex = 3;
            this.LB_Editora.Text = "Editora: ";
            // 
            // LB_Autor
            // 
            this.LB_Autor.AutoSize = true;
            this.LB_Autor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Autor.Location = new System.Drawing.Point(6, 57);
            this.LB_Autor.Name = "LB_Autor";
            this.LB_Autor.Size = new System.Drawing.Size(51, 18);
            this.LB_Autor.TabIndex = 2;
            this.LB_Autor.Text = "Autor: ";
            // 
            // LB_Titulo
            // 
            this.LB_Titulo.AutoSize = true;
            this.LB_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Titulo.Location = new System.Drawing.Point(6, 31);
            this.LB_Titulo.Name = "LB_Titulo";
            this.LB_Titulo.Size = new System.Drawing.Size(52, 18);
            this.LB_Titulo.TabIndex = 1;
            this.LB_Titulo.Text = "Título: ";
            // 
            // TBPesquisa
            // 
            this.TBPesquisa.Dock = System.Windows.Forms.DockStyle.Top;
            this.TBPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPesquisa.Location = new System.Drawing.Point(0, 0);
            this.TBPesquisa.Margin = new System.Windows.Forms.Padding(2);
            this.TBPesquisa.Multiline = true;
            this.TBPesquisa.Name = "TBPesquisa";
            this.TBPesquisa.Size = new System.Drawing.Size(828, 25);
            this.TBPesquisa.TabIndex = 0;
            this.TBPesquisa.Text = "Pesquisa";
            this.TBPesquisa.TextChanged += new System.EventHandler(this.TB_Pesquisa_TextChanged);
            this.TBPesquisa.Enter += new System.EventHandler(this.TB_Pesquisa_Enter);
            this.TBPesquisa.Leave += new System.EventHandler(this.TB_Pesquisa_Leave);
            // 
            // BTN_Login
            // 
            this.BTN_Login.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Login.Location = new System.Drawing.Point(0, 0);
            this.BTN_Login.Name = "BTN_Login";
            this.BTN_Login.Size = new System.Drawing.Size(53, 52);
            this.BTN_Login.TabIndex = 0;
            this.BTN_Login.Text = "Login";
            this.BTN_Login.UseVisualStyleBackColor = true;
            this.BTN_Login.Click += new System.EventHandler(this.BTN_Login_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 559);
            this.Controls.Add(this.PanelTop);
            this.Controls.Add(this.PanelDGV);
            this.Controls.Add(this.PanelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MADKOUA Cliente";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.PanelLeft.ResumeLayout(false);
            this.PanelDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVLivros)).EndInit();
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLeft;
        private System.Windows.Forms.Panel PanelDGV;
        private System.Windows.Forms.DataGridView DGVLivros;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.TextBox TBPesquisa;
        private System.Windows.Forms.Label LB_Descricao;
        private System.Windows.Forms.Button BTN_Requisitar;
        private System.Windows.Forms.Label LB_Editora;
        private System.Windows.Forms.Label LB_Autor;
        private System.Windows.Forms.Label LB_Titulo;
        private System.Windows.Forms.TextBox TB_Titulo;
        private System.Windows.Forms.TextBox TB_Autor;
        private System.Windows.Forms.TextBox TB_Descricao;
        private System.Windows.Forms.TextBox TB_Editora;
        private System.Windows.Forms.Label LB_Disponibilidade;
        private System.Windows.Forms.Button BTN_Login;
    }
}

