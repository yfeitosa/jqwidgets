<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Exemplo1.aspx.cs" Inherits="LINQ_LINQTOSQL_ASSISTENTE_Exemplo1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:LinqDataSource ID="LinqDataSource1" runat="server" 
            ContextTypeName="Modelagem_L2SDataContext" EntityTypeName="" 
            TableName="TB_LINGUAGEMs">
        </asp:LinqDataSource>
    
    </div>
    <asp:ListView ID="ListView1" runat="server" DataKeyNames="ID_LINGUAGEM" 
        DataSourceID="LinqDataSource1">
        <AlternatingItemTemplate>
            <li style="background-color: #FFF8DC;">ID_LINGUAGEM:
                <asp:Label ID="ID_LINGUAGEMLabel" runat="server" 
                    Text='<%# Eval("ID_LINGUAGEM") %>' />
                <br />
                NM_LINGUAGEM:
                <asp:Label ID="NM_LINGUAGEMLabel" runat="server" 
                    Text='<%# Eval("NM_LINGUAGEM") %>' />
                <br />
            </li>
        </AlternatingItemTemplate>
        <EditItemTemplate>
            <li style="background-color: #008A8C;color: #FFFFFF;">ID_LINGUAGEM:
                <asp:Label ID="ID_LINGUAGEMLabel1" runat="server" 
                    Text='<%# Eval("ID_LINGUAGEM") %>' />
                <br />
                NM_LINGUAGEM:
                <asp:TextBox ID="NM_LINGUAGEMTextBox" runat="server" 
                    Text='<%# Bind("NM_LINGUAGEM") %>' />
                <br />
                <asp:Button ID="UpdateButton" runat="server" CommandName="Update" 
                    Text="Update" />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" 
                    Text="Cancel" />
            </li>
        </EditItemTemplate>
        <EmptyDataTemplate>
            No data was returned.
        </EmptyDataTemplate>
        <InsertItemTemplate>
            <li style="">NM_LINGUAGEM:
                <asp:TextBox ID="NM_LINGUAGEMTextBox" runat="server" 
                    Text='<%# Bind("NM_LINGUAGEM") %>' />
                <br />
                <asp:Button ID="InsertButton" runat="server" CommandName="Insert" 
                    Text="Insert" />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" 
                    Text="Clear" />
            </li>
        </InsertItemTemplate>
        <ItemSeparatorTemplate>
<br />
        </ItemSeparatorTemplate>
        <ItemTemplate>
            <li style="background-color: #DCDCDC;color: #000000;">ID_LINGUAGEM:
                <asp:Label ID="ID_LINGUAGEMLabel" runat="server" 
                    Text='<%# Eval("ID_LINGUAGEM") %>' />
                <br />
                NM_LINGUAGEM:
                <asp:Label ID="NM_LINGUAGEMLabel" runat="server" 
                    Text='<%# Eval("NM_LINGUAGEM") %>' />
                <br />
            </li>
        </ItemTemplate>
        <LayoutTemplate>
            <ul ID="itemPlaceholderContainer" runat="server" 
                style="font-family: Verdana, Arial, Helvetica, sans-serif;">
                <li runat="server" id="itemPlaceholder" />
            </ul>
            <div style="text-align: center;background-color: #CCCCCC;font-family: Verdana, Arial, Helvetica, sans-serif;color: #000000;">
            </div>
        </LayoutTemplate>
        <SelectedItemTemplate>
            <li style="background-color: #008A8C;font-weight: bold;color: #FFFFFF;">
                ID_LINGUAGEM:
                <asp:Label ID="ID_LINGUAGEMLabel" runat="server" 
                    Text='<%# Eval("ID_LINGUAGEM") %>' />
                <br />
                NM_LINGUAGEM:
                <asp:Label ID="NM_LINGUAGEMLabel" runat="server" 
                    Text='<%# Eval("NM_LINGUAGEM") %>' />
                <br />
            </li>
        </SelectedItemTemplate>
    </asp:ListView>
    </form>
</body>
</html>
