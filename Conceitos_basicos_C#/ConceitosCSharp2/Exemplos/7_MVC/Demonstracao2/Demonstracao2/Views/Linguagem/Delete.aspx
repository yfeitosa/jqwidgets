<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<Demonstracao2.Models.TB_LINGUAGEM>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Delete</title>
</head>
<body>
    <h3>Are you sure you want to delete this?</h3>
    <fieldset>
        <legend>Fields</legend>
        
        <div class="display-label">ID_LINGUAGEM</div>
        <div class="display-field"><%: Model.ID_LINGUAGEM %></div>
        
        <div class="display-label">NM_LINGUAGEM</div>
        <div class="display-field"><%: Model.NM_LINGUAGEM %></div>
        
    </fieldset>
    <% using (Html.BeginForm()) { %>
        <p>
		    <input type="submit" value="Delete" /> |
		    <%: Html.ActionLink("Back to List", "Index") %>
        </p>
    <% } %>

</body>
</html>

