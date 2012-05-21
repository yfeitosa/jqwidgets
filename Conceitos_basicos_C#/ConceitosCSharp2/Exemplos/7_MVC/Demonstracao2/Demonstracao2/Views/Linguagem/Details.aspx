<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<Demonstracao2.Models.TB_LINGUAGEM>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Details</title>
</head>
<body>
    <fieldset>
        <legend>Fields</legend>
        
        <div class="display-label">ID_LINGUAGEM</div>
        <div class="display-field"><%: Model.ID_LINGUAGEM %></div>
        
        <div class="display-label">NM_LINGUAGEM</div>
        <div class="display-field"><%: Model.NM_LINGUAGEM %></div>
        
    </fieldset>
    <p>

        <%: Html.ActionLink("Edit", "Edit", new { id=Model.ID_LINGUAGEM }) %> |
        <%: Html.ActionLink("Back to List", "Index") %>
    </p>

</body>
</html>

