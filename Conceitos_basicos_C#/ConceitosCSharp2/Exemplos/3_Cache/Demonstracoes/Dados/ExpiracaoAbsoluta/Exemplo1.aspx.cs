using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Dados_ExpiracaoAbsoluta_Exemplo1 : System.Web.UI.Page
{
    //Declarei uma variável apontando para o contexto do EF
    private CURSOModel.CURSOEntities Contexto = new CURSOModel.CURSOEntities();

    protected void Page_Load(object sender, EventArgs e)
    {
        //Ao carregar a página pela 1 vez
        if (!Page.IsPostBack)
        {
            //Defini a data de expiração do cache para 29/11/2011
            //ANO, MES, DIA
            DateTime DataExpiracao = new DateTime(2011, 11, 29);

            //Adicionei o conteúdo da tabela de linguagens no cache
            Cache.Insert("DESENVOLVEDORES",          //NOME VARIÁVEL
                         Contexto.TB_LINGUAGEM,      //REGISTROS DA TABELA
                         null,                       //DEPENDENCIA DE ARQUIVOS
                         DataExpiracao,              //DATA (CACHE) FICARÁ NA MEMORIA
                         Cache.NoSlidingExpiration); //INTERVALO DE TEMPO (HH:MM:SS)
        }
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        //Carreguei o grid com o conteúdo armazenado no cache
        GridView1.DataSource = Cache["DESENVOLVEDORES"];
        GridView1.DataBind();
    }
}