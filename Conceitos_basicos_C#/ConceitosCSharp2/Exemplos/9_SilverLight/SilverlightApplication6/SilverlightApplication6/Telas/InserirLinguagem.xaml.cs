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
    public partial class InserirLinguagem : Page
    {
        public InserirLinguagem()
        {
            InitializeComponent();
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //Criei uma variável apontando para o serviço WCF (EF)
            ProxyDados.CURSOEntities Contexto 
            = new ProxyDados.CURSOEntities(new Uri("http://localhost:1660/svcDados.svc/"));

            //Criei uma variável com a classe(TB_LINGUAGEM) ela representa minha TABELA
            //Coloquei o nome que o usuário digitou no textbox
            ProxyDados.TB_LINGUAGEM Linguagem 
            = new ProxyDados.TB_LINGUAGEM() { NM_LINGUAGEM = textBox1.Text };

            //Salvei a classe (TABELA)
            Contexto.AddToTB_LINGUAGEM(Linguagem);

            //Serviço salvou a tabela TB_LINGUAGEM de forma Assíncrona
            Contexto.BeginSaveChanges((result) => { Contexto.EndSaveChanges(result); }, null);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new Principal();
        }
    }
}
