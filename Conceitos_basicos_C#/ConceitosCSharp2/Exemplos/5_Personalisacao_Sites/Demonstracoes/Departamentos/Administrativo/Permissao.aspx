<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Permissao.aspx.cs" Inherits="Departamentos_Administrativo_Permissao" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 92%;
        }
        .style2
        {
        }
        .style3
        {
            width: 480px;
        }
        .style4
        {
            width: 237px;
            font-family: Verdana;
            text-align: center;
        }
        .style5
        {
            width: 480px;
            font-family: Verdana;
            text-align: center;
        }
        .style6
        {
            font-family: Verdana;
            text-align: center;
        }
        .style7
        {
            width: 237px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table class="style1">
            <tr>
                <td class="style4">
                    <strong>Usuários</strong>
                </td>
                <td class="style5">
                    <strong>Páginas</strong>
                </td>
                <td class="style6">
                    <strong>Ações</strong>
                </td>
            </tr>
            <tr>
                <td class="style7">
                    <asp:ListBox ID="ListBox2" runat="server" Height="90px" Width="224px"></asp:ListBox>
                </td>
                <td class="style3">
                    <asp:ListBox ID="ListBox1" runat="server" Height="90px" Width="464px"></asp:ListBox>
                </td>
                <td>
                    <asp:CheckBoxList ID="CheckBoxList2" runat="server">
                        <asp:ListItem Value="0">Inserir</asp:ListItem>
                        <asp:ListItem Value="1">Excluir</asp:ListItem>
                        <asp:ListItem Value="2">Pesquisar</asp:ListItem>
                        <asp:ListItem Value="3">Alterar</asp:ListItem>
                    </asp:CheckBoxList>
                </td>
            </tr>
            <tr>
                <td class="style2" colspan="3">
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Gravar" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
