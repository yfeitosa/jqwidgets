using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Servicos_Linguagem_Exemplo1 : System.Web.UI.Page
{
    //Declarei uma variável apontando para o PROXY(Serviço)
    ProxyLinguagem.wsTB_LINGUAGEMSoapClient _Servico;

    private void CarregarGrid()
    {
        //Instanciei a variável do serviço
        _Servico = new ProxyLinguagem.wsTB_LINGUAGEMSoapClient();

        //Chamei o método Listar do WebService
        //Joguei o resultado (RETORNO, REGISTROS) dentro do grid
        GridView1.DataSource = _Servico.Listar();
        GridView1.DataBind();

        _Servico.Close();
    }

    private void ExibirMensagem(String pMensagem_)
    {
        Response.Write("<script>alert('" + pMensagem_ + "');</script>");
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            this.CarregarGrid();
        }
    }

    protected override void Render(HtmlTextWriter writer)
    {
        base.Render(writer);
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        //Botão Inserir
        _Servico = new ProxyLinguagem.wsTB_LINGUAGEMSoapClient();

        //Substituir ISSO DateTime.Now.ToString("HH:MM:SS")

        //Por isso -> DateTime.Now.ToLongTimeString()
        _Servico.Inserir(DateTime.Now.ToLongTimeString());
        _Servico.Close();

        this.CarregarGrid();
    }

    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        //Coloquei a linha corrente (QUE O USUARIO CLICOU)
        //No Modo de edição
        GridView1.EditIndex = e.NewEditIndex;

        this.CarregarGrid();
    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        //Armazenei o código e nome da linguagem que foi alterada pelo usuário
        Int32 CodigoLinguagem = Convert.ToInt32(e.Values["ID_LINGUAGEM"]);

        _Servico = new ProxyLinguagem.wsTB_LINGUAGEMSoapClient();
        _Servico.Excluir(CodigoLinguagem);
        _Servico.Close();

        this.CarregarGrid();
        this.ExibirMensagem("Registro removido com sucesso");
    }

    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        //Tirei a linha clicada do modo de edição
        //E Voltei para o modo normal
        GridView1.EditIndex = -1;

        this.CarregarGrid();
    }

    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        //Armazenei o código da linguagem que foi alterada pelo usuário
        Int32 CodigoLinguagem = Convert.ToInt32(e.NewValues["ID_LINGUAGEM"]);

        //Armazenei o nome da linguagem que foi alterada pelo usuário
        String NomeLinguagem = e.NewValues["NM_LINGUAGEM"].ToString();

        _Servico = new ProxyLinguagem.wsTB_LINGUAGEMSoapClient();

        //Chamei o método alterar do WS para alterar o nome da linguagem
        _Servico.Alterar(CodigoLinguagem, NomeLinguagem);
        _Servico.Close();

        //Tirei a linha do modo de edição e voltei ao estado normal
        GridView1.EditIndex = -1;

        this.CarregarGrid();
        this.ExibirMensagem("Registro atualizado com sucesso");
    }
}