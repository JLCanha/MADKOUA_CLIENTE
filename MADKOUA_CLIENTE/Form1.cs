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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
        }

        DataTable tabela;
        DataTable livros;

        private void MainForm_Load(object sender, EventArgs e)
        {
            livros = Livro.ListaLivros("Titulo", TBPesquisa.Text);
            tabela = new DataTable();

            tabela.Columns.Add("Titulo",typeof(String));
            tabela.Columns.Add("Autor", typeof(String));
            tabela.Columns.Add("Editora", typeof(String));

            apresenta(TBPesquisa.Text);

            DGVLivros.Columns[0].Width = DGVLivros.Width / 3 - 14;
            DGVLivros.Columns[1].Width = DGVLivros.Width / 3 - 14;
            DGVLivros.Columns[2].Width = DGVLivros.Width / 3 - 15;
        }

        private void apresenta(String pesquisa)
        {
            tabela.Clear();
            livros = Livro.ListaLivros("Titulo", TBPesquisa.Text);
            Autor autor = new Autor();
            Editora editora = new Editora();

            foreach (DataRow linha in livros.Rows)
            {                
                autor.ID = linha.Field<int>("Autor_ID");                
                editora.ID = linha.Field<int>("Editora_ID");
                tabela.Rows.Add(linha.Field<String>("Titulo"), autor.Nome + " " + autor.Apelido, editora.Nome);
            }
            DGVLivros.DataSource = tabela;

        }

        private void TBPesquisa_TextChanged(object sender, EventArgs e)
        {

            apresenta("");
                                  
            

        }

        
    }
}
