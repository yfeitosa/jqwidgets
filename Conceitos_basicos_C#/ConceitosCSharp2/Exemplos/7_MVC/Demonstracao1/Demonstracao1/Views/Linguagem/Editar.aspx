<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<Demonstracao1.Models.Linguagem>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Editar</title>
</head>
<body>
    <div>
        <% Html.RenderPartial("ViewTitulo"); %>
        <%: Html.TextBox("txtCodigo", 
                         "Conteudo que vai dentro do TEXTBOX",
        new { Class = "styTextBox", Style = "width:200px; height:100px;" }) %>
        <br />
        <br />

        <% using (Html.BeginForm())
           { %>
        Código:
        <%: Html.TextBoxFor(x => x.Codigo)%>
        <br />
        Nome:
        <%: Html.TextBoxFor(x => x.Nome)%>
        <br />
        <br />
        <%: Html.ActionLink("Voltar", "Index", "Linguagem")%>
        <input type="submit" value="Enviar" class="styButton" />
        <br />
        <%} %>
        <% Html.RenderPartial("ViewRodape"); %>
    </div>
</body>
</html>
