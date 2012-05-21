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
    /// Interaction logic for Desenvolvedores.xaml
    /// </summary>
    public partial class Desenvolvedores : Page
    {
        public Desenvolvedores()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

            CURSOEntities Contexto = new CURSOEntities();
            dataGrid1.ItemsSource = Contexto.TB_DESENVOLVEDOR;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Principal());
        }
    }
}
