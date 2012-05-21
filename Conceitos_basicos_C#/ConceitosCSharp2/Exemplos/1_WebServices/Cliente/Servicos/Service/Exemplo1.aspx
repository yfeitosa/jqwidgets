<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Exemplo1.aspx.cs" Inherits="Servicos_Service_Exemplo1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Método HelloWorld"
            Width="250px" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Método Sem Retorno" 
            Width="250px" onclick="Button2_Click" />
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" Text="Método Com Retorno" 
            Width="250px" onclick="Button3_Click" />
    </div>
    </form>
</body>
</html>
