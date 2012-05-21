using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.UI;
using System.Web.UI.WebControls;
//NAMESPACE para trabalhar com arquivos XML
using System.Xml;

public partial class Dados_Dependencia_Arquivo_Exemplo2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Ao carregar a página pela 1 vez
        if (!Page.IsPostBack)
        {
        //if (Cache["ARQUIVOS"] != null)
        //{
            //Armazenei o caminho fisico do arquivo com o nome ARQUIVO.xml
            String CaminhoArquivo = Server.MapPath("") + @"\Arquivo.xml";

            //Classe responsável por fazer o acesso ao arquivo
            XmlDocument Leitor = new XmlDocument();
            Leitor.Load(CaminhoArquivo);

            //Abri e armazenei o seu conteúdo do xml
            String ConteudoXml = Leitor.OuterXml;

            //Classe responsável por criar uma dependência ao arquivo
            CacheDependency Dependencia = new CacheDependency(CaminhoArquivo);

            //Inseri o conteúdo do arquivo no cache
            Cache.Insert("CONTEUDO", ConteudoXml, Dependencia);
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //Se existir conteúdo no cache
        if (Cache["CONTEUDO"] != null)
            //Escrevo na página o conteúdo do cache
            Response.Write(Server.HtmlEncode(Cache["CONTEUDO"].ToString()));
    }
}