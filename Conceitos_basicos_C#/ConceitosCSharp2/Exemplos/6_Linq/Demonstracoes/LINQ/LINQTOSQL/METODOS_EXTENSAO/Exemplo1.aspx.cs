using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LINQ_LINQTOENTITIES_METODOS_EXTENSAO_GRIDVIEW_Exemplo1 : System.Web.UI.Page
{
    Modelagem_L2SDataContext Contexto = new Modelagem_L2SDataContext();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //Botão Filtrar
        GridView1.DataSource = 
        Contexto.TB_LINGUAGEMs.Where(x => x.NM_LINGUAGEM == "Visual C#");
        GridView1.DataBind();

        //Simulação de LIKE
        //GridView1.DataSource 
        //= Contexto.TB_LINGUAGEMs.Where(x => x.NM_LINGUAGEM.StartsWith("Visual"));
        //GridView1.DataBind();

        //Simulação de LIKE
        //GridView1.DataSource 
        //= Contexto.TB_LINGUAGEMs.Where(x => x.NM_LINGUAGEM.EndsWith("#"));
        //GridView1.DataBind();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        //Botão Ordenar
        GridView1.DataSource 
        = Contexto.TB_LINGUAGEMs.OrderBy(x => x.NM_LINGUAGEM);
        GridView1.DataBind();

        //GridView1.DataSource = Contexto.TB_LINGUAGEMs.OrderByDescending(x => x.NM_LINGUAGEM);
        //GridView1.DataBind();
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        //Total de Registros
        Response.Write("<script>alert('Total de Registros:" 
        + Contexto.TB_LINGUAGEMs.Count().ToString() + "');</script>");
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        //Maior Código
        Response.Write("<script>alert('Maior Código:" 
        + Contexto.TB_LINGUAGEMs.Max(x => x.ID_LINGUAGEM).ToString() 
        + "');</script>");
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        //Menor Código
        Response.Write("<script>alert('Menor Código:" 
         + Contexto.TB_LINGUAGEMs.Min(x => x.ID_LINGUAGEM).ToString()
         + "');</script>");
    }
}