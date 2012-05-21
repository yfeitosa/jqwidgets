using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LINQ_LINQTOIO_Exemplo1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DirectoryInfo Pasta = new DirectoryInfo(Server.MapPath(""));

        IEnumerable<FileInfo> Arquivos = from Tabela in Pasta.GetFiles()
                                         where Tabela.Extension == ".txt"
                                         select Tabela;

        foreach (FileInfo Arquivo in Arquivos)
        {
            Response.Write(String.Concat(Arquivo.Name, "<br/>"));
        }
    }
}