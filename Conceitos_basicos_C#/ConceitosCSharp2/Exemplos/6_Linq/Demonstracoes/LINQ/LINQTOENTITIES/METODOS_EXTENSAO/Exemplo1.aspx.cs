using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LINQ_LINQTOSQL_METODOS_EXTENSAO_GRIDVIEW_Exemplo1 : System.Web.UI.Page
{
    //Variável apontando para o EF
    CURSOModel.CURSOEntities Contexto = new CURSOModel.CURSOEntities();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //Botão Filtrar
        //SELECT * FROM TB_DESENVOLVEDOR WHERE NM_DESENVOLVEDOR = 'Ciclano'
        GridView1.DataSource =
        Contexto.TB_DESENVOLVEDOR.Where(x => x.NM_DESENVOLVEDOR == "DESENVOLVEDOR1");
        GridView1.DataBind();

        //GridView1.DataSource = Contexto.TB_LINGUAGEM.Where(x => x.NM_LINGUAGEM.StartsWith("Visual"));
        //GridView1.DataBind();

        //GridView1.DataSource = Contexto.TB_LINGUAGEM.Where(x => x.NM_LINGUAGEM.EndsWith("#"));
        //GridView1.DataBind();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        //Ordenar
        GridView1.DataSource = 
        Contexto.TB_DESENVOLVEDOR.OrderByDescending(x => x.NM_DESENVOLVEDOR);
        GridView1.DataBind();

        //GridView1.DataSource = Contexto.TB_LINGUAGEM.OrderByDescending(x => x.NM_LINGUAGEM);
        //GridView1.DataBind();
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        //Total de registros
        Response.Write("<script>alert('Total de Registros:"
            + Contexto.TB_DESENVOLVEDOR.Count().ToString()
            + "');</script>");
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        //Maior
        Response.Write("<script>alert('Maior Código:"
        + Contexto.TB_DESENVOLVEDOR.Max(x => x.ID_DESENVOLVEDOR).ToString()
        + "');</script>");
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        //Menor
        Response.Write("<script>alert('Menor Código:" 
        + Contexto.TB_LINGUAGEM.Min(x => x.ID_LINGUAGEM).ToString() 
        + "');</script>");
    }
}