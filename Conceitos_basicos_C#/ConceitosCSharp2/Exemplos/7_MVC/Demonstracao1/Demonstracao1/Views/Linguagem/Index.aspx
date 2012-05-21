<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Demonstracao1.Models.Linguagem>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Página de Linguagens</title>
</head>
<body>
    <div>
        <table>
            <tr>
                <td>
                    Ação
                </td>
                <td>
                    Código
                </td>
                <td>
                    Nome
                </td>
            </tr>
            <% foreach (var Registro in Model)
               {
            %>
            <tr>
                <td>
                    <%: Html.ActionLink("Edição", "Editar", new { Codigo = Registro.Codigo })%>
                </td>
                <td>
                    <%: Registro.Codigo.ToString()%>
                </td>
                <td>
                    <%: Registro.Nome%>
                </td>
            </tr>
            <%
                }
            %>
        </table>
    </div>
</body>
</html>
