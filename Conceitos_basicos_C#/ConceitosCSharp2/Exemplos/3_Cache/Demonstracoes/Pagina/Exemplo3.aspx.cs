using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pagina_Exemplo3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Busquei o caminho completo do arquivo TEXTO
        String CaminhoArquivo = Server.MapPath("") + @"\Arquivo.txt";

        //Abri o arquivo TEXTO na MEMÓRIA
        StreamReader Leitor = new StreamReader(CaminhoArquivo);

        //Lí TODO O CONTEUDO DO ARQUIVO TEXTO E JOGUEI EM UMA VARIAVEL
        String Conteudo = Leitor.ReadToEnd();
        Leitor.Close();

        //Joguei o conteudo do arquivo no textbox
        TextBox1.Text = Conteudo;

        //Estou definindo o cache de página (VIA LINHA DE CÓDIGO)
        //Defini um CACHE DE 10 SEGUNDOS
        Response.Cache.SetExpires(DateTime.Now.AddSeconds(10));

        //ARMAZENEI O CACHE NO CLIENTE e SERVIDOR PROXY
        Response.Cache.SetCacheability(HttpCacheability.Public);

        Label1.Text = "Última atualização: " + DateTime.Now.ToLongTimeString();
    }
}