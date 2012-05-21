<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Exemplo1.aspx.cs" Inherits="LINQ_LINQTOENTITIES_ASSISTENTE_Exemplo1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:EntityDataSource ID="EntityDataSource1" runat="server" 
            ConnectionString="name=CURSOEntities" DefaultContainerName="CURSOEntities" 
            EnableFlattening="False" EntitySetName="TB_LINGUAGEM">
        </asp:EntityDataSource>
    
    </div>
    <asp:ListView ID="ListView1" runat="server" DataKeyNames="ID_LINGUAGEM" 
        DataSourceID="EntityDataSource1">
        <AlternatingItemTemplate>
            <span style="background-color: #FFFFFF;color: #284775;">ID_LINGUAGEM:
            <asp:Label ID="ID_LINGUAGEMLabel" runat="server" 
                Text='<%# Eval("ID_LINGUAGEM") %>' />
            <br />
            NM_LINGUAGEM:
            <asp:Label ID="NM_LINGUAGEMLabel" runat="server" 
                Text='<%# Eval("NM_LINGUAGEM") %>' />
            <br />
<br /></span>
        </AlternatingItemTemplate>
        <EditItemTemplate>
            <span style="background-color: #999999;">ID_LINGUAGEM:
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
            <br /><br /></span>
        </EditItemTemplate>
        <EmptyDataTemplate>
            <span>No data was returned.</span>
        </EmptyDataTemplate>
        <InsertItemTemplate>
            <span style="">ID_LINGUAGEM:
            <asp:TextBox ID="ID_LINGUAGEMTextBox" runat="server" 
                Text='<%# Bind("ID_LINGUAGEM") %>' />
            <br />NM_LINGUAGEM:
            <asp:TextBox ID="NM_LINGUAGEMTextBox" runat="server" 
                Text='<%# Bind("NM_LINGUAGEM") %>' />
            <br />
            <asp:Button ID="InsertButton" runat="server" CommandName="Insert" 
                Text="Insert" />
            <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" 
                Text="Clear" />
            <br /><br /></span>
        </InsertItemTemplate>
        <ItemTemplate>
            <span style="background-color: #E0FFFF;color: #333333;">ID_LINGUAGEM:
            <asp:Label ID="ID_LINGUAGEMLabel" runat="server" 
                Text='<%# Eval("ID_LINGUAGEM") %>' />
            <br />
            NM_LINGUAGEM:
            <asp:Label ID="NM_LINGUAGEMLabel" runat="server" 
                Text='<%# Eval("NM_LINGUAGEM") %>' />
            <br />
<br /></span>
        </ItemTemplate>
        <LayoutTemplate>
            <div ID="itemPlaceholderContainer" runat="server" 
                style="font-family: Verdana, Arial, Helvetica, sans-serif;">
                <span runat="server" id="itemPlaceholder" />
            </div>
            <div style="text-align: center;background-color: #5D7B9D;font-family: Verdana, Arial, Helvetica, sans-serif;color: #FFFFFF;">
            </div>
        </LayoutTemplate>
        <SelectedItemTemplate>
            <span style="background-color: #E2DED6;font-weight: bold;color: #333333;">
            ID_LINGUAGEM:
            <asp:Label ID="ID_LINGUAGEMLabel" runat="server" 
                Text='<%# Eval("ID_LINGUAGEM") %>' />
            <br />
            NM_LINGUAGEM:
            <asp:Label ID="NM_LINGUAGEMLabel" runat="server" 
                Text='<%# Eval("NM_LINGUAGEM") %>' />
            <br />
<br /></span>
        </SelectedItemTemplate>
    </asp:ListView>
    </form>
</body>
</html>
