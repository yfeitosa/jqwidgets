using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;

public partial class LINQ_LINQTOOBJECTS_Exemplo1 : System.Web.UI.Page
{
    //Essa variável vai armazenar o conteudo do DROPDOWNLIST
    Int32 CodigoCliente;

    /// <summary>
    /// Esse método vai retornar uma coleção de REGISTROS
    /// </summary>
    /// <returns></returns>
    private List<Cliente> RetornarClientes()
    {
        return new List<Cliente>()
        {
            new Cliente { Codigo = 1, Nome = "Itaú", Estado = "São Paulo"  },
            new Cliente { Codigo = 2, Nome = "Bradesco", Estado = "Rio de Janeiro" },
            new Cliente { Codigo = 3, Nome = "Safra", Estado = "Rio Grande do Sul" }
        };
    }

    private Boolean CampoFoiPreenchido(Int32 pCodigoCliente_)
    {
        //Verificar se o usuário selecionou no DropDownList
        //Se não selecionou
        if (pCodigoCliente_ == 0)
        {
            Response.Write("<script>alert('Selecione um Cliente');</script>");
            DropDownList1.Focus();
            return false;
        }

        return true;
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            //Carreguei o DropDownList com a coleção (REGISTROS DE CLIENTE)
            DropDownList1.DataSource = RetornarClientes();
            DropDownList1.DataValueField = "Codigo";
            DropDownList1.DataTextField = "Nome";
            DropDownList1.DataBind();

            //Inseri um item (SELECIONE) na posição ZERO do DropDownList
            DropDownList1.Items.Insert(0, new ListItem("Selecione...", "0"));
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //Operador Consulta
        CodigoCliente = Convert.ToInt32(DropDownList1.SelectedItem.Value);

        //Verifiquei se o usuário selecionou algum registro no COMBO
        if (CampoFoiPreenchido(CodigoCliente))
        {
            //SELECT * FROM TABELA WHERE CODIGO = 1
            GridView1.DataSource = from Tabela in RetornarClientes()
                                   where Tabela.Codigo == CodigoCliente
                                   orderby Tabela.Estado descending
                                   select Tabela;
            GridView1.DataBind();
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        //Método de Extensão
        //Armazenei o código do cliente que o usuário selecionou
        CodigoCliente = Convert.ToInt32(DropDownList1.SelectedItem.Value);

        //Verifiquei se foi selecionado algum cliente (DIFERENTE DE ZERO)
        if (CampoFoiPreenchido(CodigoCliente))
        {
            //ISSO É LINQ, fiz um FILTRO DENTRO DO MÉTODO BUSCANDO O CODIGO SELECIONADO
            //SELECT * FROM TB_CLIENTE WHERE CODIGO = 1
            GridView1.DataSource = RetornarClientes().Max(x => x.Nome.Contains("silva") || x.Estado == "São Paulo");
            GridView1.DataBind();
        }
    }
}