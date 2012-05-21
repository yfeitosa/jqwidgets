using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Dados_Dependencia_Tabela_Exemplo1 : System.Web.UI.Page
{
    //Declarei uma variável apontando para o contexto do EF
    CURSOModel.CURSOEntities Contexto = new CURSOModel.CURSOEntities();

    protected void Page_Load(object sender, EventArgs e)
    {
        //Ao carregar a página pela 1 vez
        if (!Page.IsPostBack)
        {
            //Habilitar o serviço aspnet_regsql -ed -E -d CURSO
            //Habilitar a tabela aspnet_regsql -et -E -d CURSO -t TB_LINGUAGEM

            //Habilitei o serviço de notificação na base(CURSO)
            SqlCacheDependencyAdmin.EnableNotifications(
                WebConfigurationManager
                .ConnectionStrings["CURSO"].ConnectionString);

            //Habilitei o monitoramento na tabela(TB_LINGUAGEM) localizada na base(CURSO)
            SqlCacheDependencyAdmin.EnableTableForNotifications(
                WebConfigurationManager
                .ConnectionStrings["CURSO"].ConnectionString,
                "TB_LINGUAGEM");

            //Classe responsável por criar uma dependência com a tabela(TB_LINGUAGEM) 
            //localizada na base(CURSO)
            SqlCacheDependency Dependencia = new SqlCacheDependency("CURSO", "TB_LINGUAGEM");

            //Inseri o conteúdo da tabela(TB_LINGUAGEM) no cache
            Cache.Insert("TABELA", Contexto.TB_LINGUAGEM);
        }
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        //Carreguei o grid com o conteúdo armazenado no cache
        GridView1.DataSource = Cache["TABELA"];
        GridView1.DataBind();
    }
}