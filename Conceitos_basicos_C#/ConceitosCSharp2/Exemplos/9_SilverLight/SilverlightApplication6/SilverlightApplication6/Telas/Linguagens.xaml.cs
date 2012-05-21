using System;
using System.Collections.Generic;
using System.Data.Services.Client;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Navigation;

namespace SilverlightApplication6.Telas
{
    public partial class Linguagens : Page
    {
        public Linguagens()
        {
            InitializeComponent();
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //Verifiquei se o conteudo do textbox está preenchido
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Preencha a Linguagem",
                                "Projeto",
                                MessageBoxButton.OK);
                textBox1.Focus();
                return;
            }

            //Consumi o EF que está localizado no projeto (WEB)
            ProxyDados.CURSOEntities Contexto =
            new ProxyDados.CURSOEntities(
            new Uri("http://localhost:1660/svcDados.svc/"));

            //StartsWith = Começa com
            //EndsWith = Termina com
            //Contains = Busca a palavra em qualquer posição do texto

            //Adicionar uma referência pra DLL System.Data.Services.Client
            DataServiceQuery<ProxyDados.TB_LINGUAGEM> Registros =
                (from Tabela in Contexto.TB_LINGUAGEM
                 where Tabela.NM_LINGUAGEM.StartsWith(textBox1.Text)
                 select Tabela) as DataServiceQuery<ProxyDados.TB_LINGUAGEM>;

            //Carreguei o grid de forma ASSÍNCRONA
            Registros.BeginExecute((Zina) =>
            {
                this.dataGrid1.ItemsSource = Registros.EndExecute(Zina).ToList();
            }, null);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new Principal();
        }
    }
}
