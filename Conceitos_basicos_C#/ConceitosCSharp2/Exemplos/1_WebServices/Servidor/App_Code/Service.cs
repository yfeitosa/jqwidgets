using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]

public class Service : System.Web.Services.WebService
{
    Int32 _Numero = 0;
    public Service()
    {
        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public String HelloWorld()
    {
        return "Olá Mundo Tudo bem ?";
    }

    [WebMethod]
    public String MetodoComRetorno(String pConteudo_)
    {
        return pConteudo_;
    }

    [WebMethod]
    public void MetodoSemRetorno()
    {

    }

    //[WebMethod(MessageName = "RetornarVersaoSistemaParametro")]
    //public Int32 RetornarVersaoSistema(String Nome)
    //{
    //    return 1;
    //}
}