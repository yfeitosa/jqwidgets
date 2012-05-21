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

namespace SilverlightApplication6.Animacao
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

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            //Play
            Storyboard Animacao = (Storyboard)this.Resources["AnimacaoBotao"];
            Animacao.Begin();
        }

    }
}
