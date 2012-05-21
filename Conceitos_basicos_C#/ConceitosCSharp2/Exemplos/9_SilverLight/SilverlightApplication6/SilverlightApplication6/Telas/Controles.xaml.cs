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

namespace SilverlightApplication6.Telas
{
    public partial class Controles : Page
    {
        public Controles()
        {
            InitializeComponent();
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            datePicker1.Text = String.Empty;
            radioButton1.IsChecked = false;
            radioButton2.IsChecked = false;
            comboBox1.SelectedIndex = -1;

            textBox1.Focus();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
