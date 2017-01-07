using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MADKOUA;

namespace MADKOUA_CLIENTE
{
    public partial class LoginUtilizador_Form : Form
    {

        private readonly MainForm _MainForm;
        public LoginUtilizador_Form(MainForm form)
        {
            InitializeComponent();
            _MainForm = form;
        }

        private void BTN_Login_Click(object sender, EventArgs e)
        {
            if(Requisitante.Verifica(TB_CodigoUtilizador.Text, TB_Password.Text))
            {
                _MainForm.SetRequisitante(TB_CodigoUtilizador.Text);
                Close();
            }
            else
            {
                MessageBox.Show("Código de utilizador ou password incorretos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
