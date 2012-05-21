<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InserirLinguagem.aspx.cs" Inherits="Paginas_InserirLinguagem" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .style1
        {
            width: 31%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <table class="style1">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Nome:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Width="183px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="Button2" runat="server" Text="Gravar" 
                    onclick="Button2_Click" />
            </td>
        </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
