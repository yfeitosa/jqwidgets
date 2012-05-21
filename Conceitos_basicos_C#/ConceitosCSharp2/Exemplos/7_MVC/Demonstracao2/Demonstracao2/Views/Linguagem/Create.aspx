<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<Demonstracao2.Models.TB_LINGUAGEM>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Create</title>
    <script src="../../Scripts/jquery-1.4.1.js" type="text/javascript"></script>
    <script src="../../Scripts/jquery.validate.js" type="text/javascript"></script>
</head>
<body>
    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Fields</legend>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.ID_LINGUAGEM) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.ID_LINGUAGEM) %>
                <%: Html.ValidationMessageFor(model => model.ID_LINGUAGEM) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.NM_LINGUAGEM) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.NM_LINGUAGEM) %>
                <%: Html.ValidationMessageFor(model => model.NM_LINGUAGEM) %>
            </div>
            
            <p>
                <input type="submit" value="Create" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Back to List", "Index") %>
    </div>

</body>
</html>

