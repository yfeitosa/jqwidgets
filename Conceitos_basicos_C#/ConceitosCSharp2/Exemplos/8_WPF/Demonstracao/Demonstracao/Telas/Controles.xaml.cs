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
    /// Interaction logic for Controles.xaml
    /// </summary>
    public partial class Controles : Page
    {
        public Controles()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            radioButton1.IsChecked = false;
            radioButton2.IsChecked = false;
            comboBox1.SelectedIndex = 0;

            textBox1.Focus();
        }
    }
}
