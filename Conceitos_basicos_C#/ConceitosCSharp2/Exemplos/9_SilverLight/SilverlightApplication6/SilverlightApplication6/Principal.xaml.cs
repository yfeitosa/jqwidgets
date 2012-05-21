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

namespace SilverlightApplication6
{
    public partial class Principal : Page
    {
        public Principal()
        {
            InitializeComponent();
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //Pesquisar
            this.Content = new Telas.Linguagens();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            //Inserir
            this.Content = new Telas.InserirLinguagem();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            //Controles
            this.Content = new Telas.Controles();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new Anotacoes.Exemplo1();
        }

        private void button5_Click_1(object sender, RoutedEventArgs e)
        {
            this.Content = new Animacao.Exemplo1();
        }
    }
}
