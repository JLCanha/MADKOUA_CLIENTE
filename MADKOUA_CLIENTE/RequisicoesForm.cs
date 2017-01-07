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
    public partial class RequisicoesForm : Form
    {
        private readonly MainForm _MainForm;
        public RequisicoesForm(MainForm form)
        {
            InitializeComponent();
            _MainForm = form;
        }

        private void RequisicoesForm_Load(object sender, EventArgs e)
        {
            DataTable tabelaRequisicoes = new DataTable();

            Livro livro = new Livro(); ;

            tabelaRequisicoes.Columns.Add("Titulo", typeof(String));
            tabelaRequisicoes.Columns.Add("Data de levantamento", typeof(String));
            tabelaRequisicoes.Columns.Add("Data de entrega", typeof(String));
            tabelaRequisicoes.Columns.Add("Estado", typeof(String));

            DataTable requisicoesDB = new DataTable();

            requisicoesDB = Requisicao.ListaRequisicao("Requisitante_ID", _MainForm.GetRequisitanteID().ToString());

            foreach(DataRow linha in requisicoesDB.Rows)
            {
                livro.ID = linha.Field<int>("Livro_ID");

                tabelaRequisicoes.Rows.Add(livro.Titulo, linha.Field<DateTime>("Data_L").ToString(), linha.Field<DateTime>("Data_E").ToString(), linha.Field<String>("Estado") );
            }

            DGV_Requisicoes.DataSource = tabelaRequisicoes;
        }
    }
}
