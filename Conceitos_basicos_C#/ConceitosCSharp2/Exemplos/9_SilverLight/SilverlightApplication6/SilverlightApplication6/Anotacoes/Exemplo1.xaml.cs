using System;
using System.Collections.Generic;
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

namespace SilverlightApplication6.Anotacoes
{
    public partial class Exemplo1 : Page
    {
        public Exemplo1()
        {
            InitializeComponent();
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            List<Pessoa> lstPessoa = new List<Pessoa>()
            {
                new Pessoa { Codigo = 1, Nome= "Pessoa 1", Email="Pessoa1@email.com.br", Idade=1},
                new Pessoa { Codigo = 2, Nome= "Pessoa 2", Email="Pessoa2@email.com.br", Idade=2},
                new Pessoa { Codigo = 3, Nome= "Pessoa 3", Email="Pessoa3@email.com.br", Idade=3}
            };

            dataGrid1.ItemsSource = lstPessoa;
        }
    }
}
