using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Configuration;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Paginas_EF : System.Web.UI.Page
{
    //Declarei uma variável apontando para o serviço (WCF DATA SERVICE)
    ProxyEF.CURSOEntities Contexto =
    new ProxyEF.CURSOEntities(new Uri("http://localhost:1418/Demonstracao1/Servicos/ServicoEF.svc"));

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //Recuperar
        GridView1.DataSource = Contexto.TB_LINGUAGEM;
        GridView1.DataBind();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        //Inserir
        Contexto.AddToTB_LINGUAGEM(
            new ProxyEF.TB_LINGUAGEM
            {
                NM_LINGUAGEM = DateTime.Now.ToLongTimeString()
            });
        Contexto.SaveChanges();
    }
}