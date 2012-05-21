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
using System.Windows.Media.Animation;

namespace Demonstracao.Telas
{
    /// <summary>
    /// Interaction logic for Animacao.xaml
    /// </summary>
    public partial class Animacao : Page
    {
        public Animacao()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            //Botão Play
            Storyboard SambaBotao = this.Resources["AnimacaoBotao"] as Storyboard;
            SambaBotao.Begin();
        }
    }
}
