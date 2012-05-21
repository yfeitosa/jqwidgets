using System;
using System.Collections.Generic;
//Namespace utilizada pra monitorar aplicações
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Dados_Simples_Exemplo2 : System.Web.UI.Page
{
    //Declarei uma variável apontando para o contexto do EF
    private CURSOModel.CURSOEntities Contexto = new CURSOModel.CURSOEntities();

    protected void Page_Load(object sender, EventArgs e)
    {
        Debugger.Break();

        //Classe CRONOMETRO
        Stopwatch Contador = new Stopwatch();
        Contador.Start(); //Liguei o cronometro

        //Ao carregar a página pela 1 vez
        if (!Page.IsPostBack)
        {
            //Adicionei o conteúdo da tabela de linguagem no cache
            Cache.Insert("LINGUAGENS", Contexto.TB_LINGUAGEM);
        }

        Contador.Stop(); //Desliguei o cronometro
        
        //Exibi o tempo de CARREGAMENTO
        Response.Write(Contador.Elapsed.ToString()); 
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        //Carreguei o grid com o conteúdo armazenado no cache
        GridView1.DataSource = Cache["LINGUAGENS"];
        GridView1.DataBind();
    }
}