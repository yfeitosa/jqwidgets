<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Exemplo1.aspx.cs" Inherits="Dados_Simples_Exemplo1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 46%;
        }
        .style2
        {
            width: 49px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table class="style1">
            <tr>
                <td class="style2">
                    <asp:Label ID="Label1" runat="server" Text="Nome:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Width="355px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                </td>
                <td>
                    <asp:Button ID="Button3" runat="server" Text="Criar Cache" 
                        onclick="Button3_Click" />
                &nbsp;<asp:Button ID="Button4" runat="server" Text="Alterar Cache" 
                        onclick="Button4_Click" />
                &nbsp;<asp:Button ID="Button5" runat="server" Text="Remover Cache" 
                        onclick="Button5_Click" />
                    <br />
                    <asp:Button ID="Button6" runat="server" Text="Ler Cache" 
                        onclick="Button6_Click" Width="366px" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
