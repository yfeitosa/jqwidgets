using System;
using System.Collections.Generic;
//Namespace para trabalhar com pastas e arquivos
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Dados_Dependencia_Arquivo_Exemplo1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Ao carregar a página pela 1 vez
        if (!Page.IsPostBack)
        {
            //Armazenei o caminho fisico do arquivo com o nome ARQUIVO.txt
            String CaminhoArquivo = Server.MapPath("") + @"\Arquivo.txt";

            //Classe responsável por fazer o acesso ao arquivo
            StreamReader Leitor = new StreamReader(CaminhoArquivo);

            //Abri o arquivo e armazenei o seu conteúdo na variável Conteudo
            String Conteudo = Leitor.ReadToEnd();
            Leitor.Close();

            //Classe responsável por criar uma dependência ao arquivo
            CacheDependency Dependencia = new CacheDependency(CaminhoArquivo);

            //Inseri o conteúdo do arquivo no cache
            Cache.Insert("ARQUIVO", Conteudo, Dependencia);
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //Se existir conteúdo no cache
        if (Cache["ARQUIVO"] != null)
            //Carrego o textbox com o conteúdo do cache
            TextBox1.Text = Cache["ARQUIVO"].ToString();
        else
            //Se não existir conteúdo no cache, limpo o textbox
            TextBox1.Text = String.Empty;
    }
}