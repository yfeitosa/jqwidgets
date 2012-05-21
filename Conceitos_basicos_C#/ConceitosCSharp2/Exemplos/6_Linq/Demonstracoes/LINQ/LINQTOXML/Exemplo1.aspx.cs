using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

public partial class LINQ_LINQTOXML_Exemplo1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Ari/Carreguei o conteudo do arquivo XML
        XDocument xml = XDocument.Load(Server.MapPath("") + @"\Arquivo.xml");

        //Selecionei todos os registros do XML e ordenei pelo código de Z para A (DESC)
        var Retorno = from Tabela in xml.Descendants("DESENVOLVEDOR")
                      where Tabela.Element("NOME").Value.Contains("Desenvolvedor")
                      orderby Tabela.Element("CODIGO").Value descending
                      select Tabela;

        //Percorri registro a registro
        foreach (XElement Registro in Retorno)
        {
            //Adicionei o Item no DropDownList
            DropDownList1.Items.Add(
            new ListItem(Registro.Element("NOME").Value, 
                         Registro.Element("CODIGO").Value));
        }

        //Inseri o item SELECIONE na PRIMEIRA POSIÇÃO
        DropDownList1.Items.Insert(0, new ListItem("Selecione...", "0"));
    }
}