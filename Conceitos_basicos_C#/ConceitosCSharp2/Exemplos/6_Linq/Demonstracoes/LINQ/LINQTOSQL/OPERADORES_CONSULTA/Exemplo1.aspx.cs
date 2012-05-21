using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LINQ_LINQTOENTITIES_OPERADORES_CONSULTA_GRIDVIEW_Exemplo1 : System.Web.UI.Page
{
    Modelagem_L2SDataContext Contexto = new Modelagem_L2SDataContext();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        GridView1.DataSource = from Tabela in Contexto.TB_LINGUAGEMs
                               where Tabela.NM_LINGUAGEM == "Visual C#"
                               select Tabela;
        GridView1.DataBind();

        GridView1.DataSource = from Tabela in Contexto.TB_LINGUAGEMs
                               where Tabela.NM_LINGUAGEM.StartsWith("Visual")
                               select Tabela;
        GridView1.DataBind();

        GridView1.DataSource = from Tabela in Contexto.TB_LINGUAGEMs
                               where Tabela.NM_LINGUAGEM.EndsWith("#")
                               select Tabela;
        GridView1.DataBind();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        GridView1.DataSource = from Tabela in Contexto.TB_LINGUAGEMs
                               orderby Tabela.NM_LINGUAGEM
                               select Tabela;
        GridView1.DataBind();

        //GridView1.DataSource = from Tabela in Contexto.TB_LINGUAGEMs
        //                       orderby Tabela.NM_LINGUAGEM descending
        //                       select Tabela;
        //GridView1.DataBind();
    }
}