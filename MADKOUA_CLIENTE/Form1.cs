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
        Requisitante requisitante;
        AdicionaBD adiciona;        
        int livroSelecionado;
        bool RequisitanteSelecionado;
        private void MainForm_Load(object sender, EventArgs e)
        {
            livros = Livro.ListaLivros("Titulo", TBPesquisa.Text);
            tabela = new DataTable();
            requisitante = new Requisitante();
            adiciona = new AdicionaBD();
            RequisitanteSelecionado = false;

            tabela.Columns.Add("ID", typeof(int));
            tabela.Columns.Add("Titulo", typeof(String));
            tabela.Columns.Add("Autor", typeof(String));
            tabela.Columns.Add("Editora", typeof(String));

            apresenta("");

            DGVLivros.Columns[0].Width = 30;
            DGVLivros.Columns[1].Width = DGVLivros.Width / 3 - 14;
            DGVLivros.Columns[2].Width = DGVLivros.Width / 3 - 14;
            DGVLivros.Columns[3].Width = DGVLivros.Width / 3 - 45;
        }

        #region Metodos

        public void SetRequisitante(String codigoUtilizador) { requisitante.SetByCodigoUtilizador(codigoUtilizador); }

        public void SetRequisitanteSelecionado(bool estado)
        {
            RequisitanteSelecionado = estado;
            if(livroSelecionado != 0)
            {
                BTN_Requisitar.Enabled = true;
            }
        }
        private void apresenta(String pesquisa)
        {
            tabela.Clear();
            livros = Livro.ListaLivros("Titulo", pesquisa);
            Autor autor = new Autor();
            Editora editora = new Editora();

            foreach (DataRow linha in livros.Rows)
            {
                autor.ID = linha.Field<int>("Autor_ID");
                editora.ID = linha.Field<int>("Editora_ID");
                tabela.Rows.Add(linha.Field<int>("ID") ,linha.Field<String>("Titulo"), autor.Nome + " " + autor.Apelido, editora.Nome);
            }
            DGVLivros.DataSource = tabela;

        }

        private void AtualizaDisponibilidade()
        {
            if (livroSelecionado == 0) return;
            Livro livro = new Livro(livroSelecionado);
            if (livro.NLivrosDisp > 0)
            {
                LB_Disponibilidade.Text = "Disponível";
                LB_Disponibilidade.ForeColor = Color.Green;
            }
            else
            {
                LB_Disponibilidade.Text = "Indisponível";
                LB_Disponibilidade.ForeColor = Color.Red;
            }
        }
        #endregion

        #region Eventos




        private void DGVLivros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowindex = DGVLivros.SelectedCells[0].RowIndex;
                livroSelecionado = (int)DGVLivros.Rows[rowindex].Cells["ID"].Value;
                DGVLivros.ClearSelection();
                Livro livro = new Livro();

                livro.ID = livroSelecionado;
                TB_Titulo.Text = livro.Titulo;
                TB_Autor.Text = livro.autor.Nome + " " + livro.autor.Apelido;
                TB_Editora.Text = livro.editora.Nome;

                AtualizaDisponibilidade();
            }
            catch(Exception ex)
            {
                
            }

            if (RequisitanteSelecionado) BTN_Requisitar.Enabled = true;


        }

        private void TB_Pesquisa_Enter(object sender, EventArgs e)
        {
            TBPesquisa.Clear();
        }
        private void TB_Pesquisa_Leave(object sender, EventArgs e)
        {
            TBPesquisa.Text = "Pesquisa";
            apresenta("");
        }

        private void TB_Pesquisa_TextChanged(object sender, EventArgs e)
        {
            apresenta(TBPesquisa.Text);
        }

        private void BTN_Requisitar_Click(object sender, EventArgs e)
        {
            Livro.DecrementaNLivrosDisp(livroSelecionado);
            AtualizaDisponibilidade();

            if(livroSelecionado != 0 && RequisitanteSelecionado)
            {
                adiciona.AdicionaRequisicao(new Livro(livroSelecionado), requisitante, DateTime.Now, DateTime.Now.AddDays(10), "PorLevantar");
                MessageBox.Show("Requisicao adicionada. ");
            }            
        }



        #endregion

        private void BTN_Login_Click(object sender, EventArgs e)
        {
            LoginUtilizador_Form loginUtilizador = new LoginUtilizador_Form(this);
            loginUtilizador.Show();                        
        }

        private void BTN_Requisicoes_Click(object sender, EventArgs e)
        {
            
        }
    }
}
