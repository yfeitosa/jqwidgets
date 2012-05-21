using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        //Boolean teste = Membership.ValidateUser(text1.text, txsenha.text);

        //Roles.DeleteRole("Role");
        //Roles.RemoveUserFromRole("usu", "Role");
        //Roles.AddUserToRole("NomeDOUsuario", "NomeRole");

        //if (!Roles.IsUserInRole("NomeUsuario", "nomerole"))
        //{
        //    Response.Redirect("Login.aspx");
        //}
    }

    //protected void Page_PreRender(object sender, EventArgs e)
    //{
    //    ((TextBox)Login1.FindControl("UserName")).Text = "Ronaldo";
    //}

    
    protected void Login1_LoggedIn(object sender, EventArgs e)
    {
        ////Exemplo de criação de ROLES VIA CÓDIGO
        //Roles.CreateRole("GrupoDeAcesso");

        ////Exemplo de exclusão de ROLES VIA CÓDIGO
        //Roles.DeleteRole("GrupoDeAcesso");

        ////Exemplo de verificação de EXISTENCIA DE ROLES VIA CÓDIGO
        //if (Roles.RoleExists("GrupoDeAcesso"))
        //{
        //    Response.Write("Grupo Existe");
        //}
        //else
        //{
        //    Response.Write("Grupo Não Existe");
        //}

        ////Código responsável por criar um usuário
        //Membership.CreateUser("NomedoUsuario", "SenhadoUsuario");

        ////Exemplo de como exluir um usuário VIA CÓDIGO
        //Membership.DeleteUser("NomedoUsuario");

        ////Exemplo de como listar todos os usuários que possuem um determinado email
        //MembershipUserCollection Usuarios = Membership.FindUsersByEmail("EmailASerLocalizado");

        ////Exemplo de como listar todos os usuários
        //MembershipUserCollection Usuarios = Membership.GetAllUsers();

        ////Exemplo de como listar a quantidade de usuários logados
        //Int32 UsuariosLogados = Membership.GetNumberOfUsersOnline();

        ////Exemplo de como atualizar as informações dos usuários
        //MembershipUser Usuario = Membership.GetUser("RH1");
        //Usuario.Email = "Novo Email";

        ////Retorna a senha do usuários
        //String Senha = Usuario.GetPassword();

        ////Limpa a senha antiga e GERA AUTOMATICAMENTE uma nova senha
        //String NovaSenha = Usuario.ResetPassword();

        ////Altera a senha do usuário
        //Usuario.ChangePassword("SenhAntiga", "NovaSenha");

        //Membership.UpdateUser(Usuario);



        //#warning Lembrar de mostrar isso

        //Logi1.UserName -> Retorno o nome do usuário digitado no controle de login
        //Método GetRolesForUser -> Retorno TODAS AS ROLES que o usuário está cadastrado
        //Variável Pagina -> Configurei o caminho completo da página
        String Departamento
        = Roles.GetRolesForUser(Login1.UserName).GetValue(0).ToString();
        String Pagina = "~/Departamentos/" + Departamento + "/Home.aspx";

        Response.Redirect(Pagina);
    }

    protected void Login1_LoginError(object sender, EventArgs e)
    {

        //((TextBox)Login1.FindControl("UserName")).Text = "Ronaldo";
        //Retorno a mensagem de erro exibida no componente Login1
        //String MensagemErro = Login1.FailureText;
        //Response.Write("<script>alert('" + MensagemErro + "');</script>");

        //if (MensagemErro == "Your login attempt was not successful. Please try again.")
        //{
        //    //Faço determinada ação
        Response.Write("<script>alert('Login ou senha inválidos');</script>");
        ///Login1.FailureText = String.Empty;
        //}
    }
}