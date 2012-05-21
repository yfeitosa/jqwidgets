using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Servicos_Service_Exemplo1 : System.Web.UI.Page
{
    //Declarei uma variável apontando para o PROXY(Serviço)
    ProxyService.ServiceSoapClient _Servico = new ProxyService.ServiceSoapClient();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //Botão HelloWorld
        String Retorno = _Servico.HelloWorld();

        _Servico.Close();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        //Botão Método Sem Retorno
        _Servico.MetodoSemRetorno();

        _Servico.Close();
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        //Botão Método Com Retorno
        String Retorno = _Servico.MetodoComRetorno("Seu Nome");

        _Servico.Close();
    }
}