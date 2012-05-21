<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Demonstracao2.Models.TB_LINGUAGEM>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Index</title>
</head>
<body>
    <table>
        <tr>
            <th></th>
            <th>
                ID_LINGUAGEM
            </th>
            <th>
                NM_LINGUAGEM
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Edit", "Edit", new { id=item.ID_LINGUAGEM }) %> |
                <%: Html.ActionLink("Details", "Details", new { id=item.ID_LINGUAGEM })%> |
                <%: Html.ActionLink("Delete", "Delete", new { id=item.ID_LINGUAGEM })%>
            </td>
            <td>
                <%: item.ID_LINGUAGEM %>
            </td>
            <td>
                <%: item.NM_LINGUAGEM %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Create New", "Create") %>
    </p>

</body>
</html>

