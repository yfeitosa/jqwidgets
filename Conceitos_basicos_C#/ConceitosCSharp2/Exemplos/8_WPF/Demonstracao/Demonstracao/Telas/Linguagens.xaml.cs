using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Demonstracao.Telas
{
    /// <summary>
    /// Interaction logic for Linguagens.xaml
    /// </summary>
    public partial class Linguagens : Page
    {
        public Linguagens()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            CURSOEntities Contexto = new CURSOEntities();
            dataGrid1.ItemsSource = Contexto.TB_LINGUAGEM;
        }

        private void dataGrid1_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            //Capturei a linha que está sendo carregada
            DataGridRow Linha = (DataGridRow)e.Row;

            //Capturei o objeto
            if (Linha.DataContext.ToString() != "{NewItemPlaceholder}")
            {
                TB_LINGUAGEM linguagem = (TB_LINGUAGEM)Linha.DataContext;
                if (linguagem.ID_LINGUAGEM > 3)
                {
                    Linha.Background = Brushes.Orange;
                }
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //Botão voltar
            NavigationService.Navigate(new Principal());
        }

        private void dataGrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Verifiquei se foi selecionado pelo menos 1 registro
            if (e.AddedItems.Count != 0)
            {
                //Armazenei o registro selecionado pelo usuário
                //A propriedade AddedItems me retorna uma COLEÇÃO de OBJETOS
                //Peguei o primeiro ITEM da COLEÇÃO e CONVERTI PARA UMA CLASSE DO EF
                TB_LINGUAGEM Linguagem = (TB_LINGUAGEM)((object[])(e.AddedItems))[0];

                //Preenchei os textboxes com o conteúdo da linha selecionada pelo USER
                textBox1.Text = Linguagem.ID_LINGUAGEM.ToString();
                textBox2.Text = Linguagem.NM_LINGUAGEM;

                //Selecionei a ABA 2 (NOVO)
                tabItem2.IsSelected = true;
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            CURSOEntities Contexto = new CURSOEntities();
            TB_LINGUAGEM Linguagem = null;

            //Busquei o ID da linguagem no textbox de código
            Int32 CodigoLinguagem = Convert.ToInt32(textBox1.Text);

            //Filtrei a tabela pelo ID do registro que foi selecionado pelo usuário
            Linguagem =
            Contexto.TB_LINGUAGEM
            .Where(x => x.ID_LINGUAGEM == CodigoLinguagem).First();

            //Armazeno o nome da linguagem alterada
            Linguagem.NM_LINGUAGEM = textBox2.Text.Trim();

            //Salvei o EF
            Contexto.SaveChanges();

            //Exibi uma mensagem de sucesso na tela
            MessageBox.Show("Registro salvo com sucesso",
            "Impacta", MessageBoxButton.OK, MessageBoxImage.Information);

            //Limpei o conteudo dos textboxes
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;

            //Recarreguei o grid
            dataGrid1.ItemsSource = Contexto.TB_LINGUAGEM;

            //Selecionei a primeira guia(ABA)
            tabItem1.IsSelected = true;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            tabItem1.IsSelected = true;

            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
        }

        private void Page_LayoutUpdated(object sender, EventArgs e)
        {

        }
    }
}
