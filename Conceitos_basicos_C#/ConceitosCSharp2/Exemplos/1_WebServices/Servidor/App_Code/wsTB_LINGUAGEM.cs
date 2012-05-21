using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for wsTB_LINGUAGEM
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class wsTB_LINGUAGEM : System.Web.Services.WebService
{
    //Criei uma variável do tipo SQLDATAADAPTER
    //Que vai levar e buscar informações da tabela (TB_LINGUAGEM)
    //Essa é a forma visual de usar um SQLDATAADAPTER
    private dsBaseTableAdapters.TB_LINGUAGEMTableAdapter _Adaptador
    = new dsBaseTableAdapters.TB_LINGUAGEMTableAdapter();

    //Essa é a forma NÃO VISUAL DE USAR UM SQLDATAADAPTER
    //System.Data.SqlClient.SqlDataAdapter _Tabela = new System.Data.SqlClient.SqlDataAdapter

    //Criei uma variável do tipo DATATABLE
    //Que vai armazenar os registros da tabela (TB_LINGUAGEM)
    //Essa é a forma visual de usar um DataTable
    private dsBase.TB_LINGUAGEMDataTable _Tabela
    = new dsBase.TB_LINGUAGEMDataTable();

    //Essa é a forma NÃO VISUAL DE USAR UM DATATABLE
    //System.Data.DataTable _Tabela = new System.Data.DataTable();

    public wsTB_LINGUAGEM()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld()
    {
        return "Hello World";
    }

    [WebMethod]
    public dsBase.TB_LINGUAGEMDataTable Listar()
    {
        //Preenchi o DATATABLE(TIPADO) através do SQLDATAADAPTER(TIPADO)
        _Adaptador.Fill(_Tabela);

        //Retornei o DATATABLE com os registros da tabela TB_LINGUAGEM
        return _Tabela;
    }

    [WebMethod]
    public void Excluir(Int32 pCodigoLinguagem_)
    {
        //Verifiquei se o código foi preenchido
        if (pCodigoLinguagem_ == 0)
            throw new Exception("Preencha o parâmetro pCodigoLinguagem_");

        //Deletei o registro da tabela (TB_LINGUAGEM) através do código
        _Adaptador.Delete(pCodigoLinguagem_);
    }

    [WebMethod]
    public void Alterar(Int32 pCodigoLinguagem_, String pNomeLinguagem_)
    {
        //Verifiquei se o código foi preenchido
        if (pCodigoLinguagem_ == 0)
            throw new Exception("Preencha o parâmetro pCodigoLinguagem_");

        //Verifiquei se o nome foi preenchido
        if (String.IsNullOrEmpty(pNomeLinguagem_))
            throw new Exception("Preencha o parâmetro pNomeLinguagem_");

        //Atualizei o registro da tabela (TB_LINGUAGEM) através do código
        _Adaptador.Update(pNomeLinguagem_, pCodigoLinguagem_);
    }

    [WebMethod(Description = "Esse é o método Inserir")]
    public void Inserir(String pNomeLinguagem_)
    {
        //Verifiquei se o nome foi preenchido
        if (String.IsNullOrEmpty(pNomeLinguagem_))
            throw new Exception("Preencha o parâmetro pNomeLinguagem_");

        //Inseri um registro na tabela (TB_LINGUAGEM) com o nome informado
        _Adaptador.Insert(pNomeLinguagem_);
    }
}
