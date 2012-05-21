using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Departamentos_Administrativo_Permissao : System.Web.UI.Page
{
    //Variável apontando para o EF
    ASPNETDBModel.ASPNETDBEntities Contexto = new ASPNETDBModel.ASPNETDBEntities();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            //Carreguei a lista de USUARIOS COM OS REGISTROS DA TABELA (aspnet_Users)
            ListBox2.DataSource = Contexto.aspnet_Users;
            ListBox2.DataValueField = "UserId";
            ListBox2.DataTextField = "UserName";
            ListBox2.DataBind();

            //Carreguei a lista de PAGINAS COM OS REGISTROS DA TABELA (aspnet_Paths)
            ListBox1.DataSource = Contexto.aspnet_Paths;
            ListBox1.DataValueField = "PathId";
            ListBox1.DataTextField = "Path";
            ListBox1.DataBind();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //Onde estiver isso ListBox2 coloque isso ListBox1
        //VICE VERSA
        //Inicializei o perfil para o usuário SELECIONADO NA PÁGINA
        Profile.Initialize(ListBox2.SelectedItem.Text, true);

        //Percorri TODAS AS AÇÕES DISPONIVEIS (INSERIR, ALTERAR, LISTAR, PESQUISAR)
        foreach (ListItem Acao in CheckBoxList2.Items)
        {
            //Seleciono TUDO QUE EXISTE NO PERFIL DO USUÁRIO SELECIONADO
            //Para verificar se já foi adicionado essa permissão ANTERIORMENTE
            var AcaoExiste = from Tabela in Profile.ControlePermissao
                             where Tabela.NomePagina == ListBox1.SelectedItem.Text
                             && Tabela.NomeAcao == Acao.Text
                             select Tabela;

            //CASO JÁ EXISTA EU DELETO PARA INSERIR NOVAMENTE
            if (AcaoExiste.Count() > 0)
            {
                //DELETO DO PERFIL
                Profile.ControlePermissao.Remove(AcaoExiste.First());
                Profile.Save();
            }

            //Verifico APENAS as AÇÕES QUE FORAM SELECIONADAS (CHECADAS, MARCADAS)
            if (Acao.Selected)
            {

                //Adicionei a PÁGINA x PERMISSÕES PARA O USUARIO SELECIONADO NA LISTA
                Profile.ControlePermissao.Add(new Permissao
                                        {
                                            NomePagina = ListBox1.SelectedItem.Text,
                                            NomeAcao = Acao.Text
                                        });
                Profile.Save();
            }
        }
    }
}