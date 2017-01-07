namespace MADKOUA_CLIENTE
{
    partial class LoginUtilizador_Form
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
            this.LB_CodigoUtilizador = new System.Windows.Forms.Label();
            this.LB_Password = new System.Windows.Forms.Label();
            this.TB_CodigoUtilizador = new System.Windows.Forms.TextBox();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.BTN_Login = new System.Windows.Forms.Button();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_CodigoUtilizador
            // 
            this.LB_CodigoUtilizador.AutoSize = true;
            this.LB_CodigoUtilizador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_CodigoUtilizador.Location = new System.Drawing.Point(12, 45);
            this.LB_CodigoUtilizador.Name = "LB_CodigoUtilizador";
            this.LB_CodigoUtilizador.Size = new System.Drawing.Size(139, 18);
            this.LB_CodigoUtilizador.TabIndex = 0;
            this.LB_CodigoUtilizador.Text = "Código de utilizador";
            // 
            // LB_Password
            // 
            this.LB_Password.AutoSize = true;
            this.LB_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Password.Location = new System.Drawing.Point(12, 75);
            this.LB_Password.Name = "LB_Password";
            this.LB_Password.Size = new System.Drawing.Size(75, 18);
            this.LB_Password.TabIndex = 1;
            this.LB_Password.Text = "Password";
            // 
            // TB_CodigoUtilizador
            // 
            this.TB_CodigoUtilizador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_CodigoUtilizador.Location = new System.Drawing.Point(157, 42);
            this.TB_CodigoUtilizador.Name = "TB_CodigoUtilizador";
            this.TB_CodigoUtilizador.Size = new System.Drawing.Size(164, 24);
            this.TB_CodigoUtilizador.TabIndex = 2;
            // 
            // TB_Password
            // 
            this.TB_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Password.Location = new System.Drawing.Point(157, 72);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.PasswordChar = '*';
            this.TB_Password.Size = new System.Drawing.Size(164, 24);
            this.TB_Password.TabIndex = 3;
            // 
            // BTN_Login
            // 
            this.BTN_Login.Location = new System.Drawing.Point(170, 136);
            this.BTN_Login.Name = "BTN_Login";
            this.BTN_Login.Size = new System.Drawing.Size(75, 23);
            this.BTN_Login.TabIndex = 4;
            this.BTN_Login.Text = "Login";
            this.BTN_Login.UseVisualStyleBackColor = true;
            this.BTN_Login.Click += new System.EventHandler(this.BTN_Login_Click);
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.Location = new System.Drawing.Point(251, 136);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(75, 23);
            this.BTN_Cancel.TabIndex = 5;
            this.BTN_Cancel.Text = "Cancel";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            this.BTN_Cancel.Click += new System.EventHandler(this.BTN_Cancel_Click);
            // 
            // LoginUtilizador_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 171);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.BTN_Login);
            this.Controls.Add(this.TB_Password);
            this.Controls.Add(this.TB_CodigoUtilizador);
            this.Controls.Add(this.LB_Password);
            this.Controls.Add(this.LB_CodigoUtilizador);
            this.Name = "LoginUtilizador_Form";
            this.Text = "LoginUtilizador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_CodigoUtilizador;
        private System.Windows.Forms.Label LB_Password;
        private System.Windows.Forms.TextBox TB_CodigoUtilizador;
        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.Button BTN_Login;
        private System.Windows.Forms.Button BTN_Cancel;
    }
}