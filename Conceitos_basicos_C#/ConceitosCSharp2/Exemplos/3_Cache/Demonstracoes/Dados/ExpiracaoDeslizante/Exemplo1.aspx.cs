using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Dados_ExpiracaoDeslizante_Exemplo1 : System.Web.UI.Page
{
    //Declarei uma variável apontando para o contexto do EF
    private CURSOModel.CURSOEntities Contexto = new CURSOModel.CURSOEntities();

    protected void Page_Load(object sender, EventArgs e)
    {
        //Ao carregar a página pela 1 vez
        if (!Page.IsPostBack)
        {
            //Defini a tempo de expiração do cache para 1 minuto
            //Timespan (HORA, MINUTO, SEGUNDO)
            TimeSpan TempoExpiracao = new TimeSpan(0, 1, 0);

            //Adicionei o conteúdo da tabela de linguagens no cache
            Cache.Insert("DESENVOLVEDORES",     //NOME DA VARIÁVEL DE MEMÓRIA
                        Contexto.TB_LINGUAGEM,  //CONTEUDO DA MEMORIA (TABELAS)
                        null,                   //DEPENDENCIA DE ARQUIVO
                        DateTime.MaxValue,      //DATA DE EXPIRAÇÃO (DATA MAXIMA)
                        TempoExpiracao);        //INTERVALO DE EXPIRAÇÃO
        }
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        //Carreguei o grid com o conteúdo armazenado no cache
        GridView1.DataSource = Cache["DESENVOLVEDORES"];
        GridView1.DataBind();
    }
}