using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Departamentos_RH_TestarPermissao : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            //Fui dentro da propriedade de perfil (ControlePermissao)
            //Fiz uma pesquisa pelo método WHERE, para buscar o nome da página corrente
            //Página corrente é o nome desse página
            var Permissoes = 
            Profile.ControlePermissao.Where(x => x.NomePagina.ToLower() == Request.Url.LocalPath.ToLower());

            Button1.Enabled = (Permissoes.Where(x => x.NomeAcao == "Inserir").Count() > 0 ? true : false);
            Button2.Enabled = (Permissoes.Where(x => x.NomeAcao == "Excluir").Count() > 0 ? true : false);
            Button3.Enabled = (Permissoes.Where(x => x.NomeAcao == "Pesquisar").Count() > 0 ? true : false);
            Button4.Enabled = (Permissoes.Where(x => x.NomeAcao == "Alterar").Count() > 0 ? true : false);
        }
    }
}