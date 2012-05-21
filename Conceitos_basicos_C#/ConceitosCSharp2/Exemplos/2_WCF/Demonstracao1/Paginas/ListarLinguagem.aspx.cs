using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ListarLinguagem : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //Criei uma variável apontando para o serviço WCF
        ProxyLinguagem.IsvcLinguagemClient Servico = new ProxyLinguagem.IsvcLinguagemClient();

        //Chamei o método listar do serviço para carregar o grid
        GridView1.DataSource = Servico.Listar();
        GridView1.DataBind();

        //Fechei a conexão com o serviço
        Servico.Close();
    }
}