<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TP02_2.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>SDSI6 - TP02 Parte 2</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Codigo: "></asp:Label>
            <asp:DropDownList ID="DropDown1" runat="server" AutoPostBack="true"></asp:DropDownList>
            <br /><br />
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            <br /><br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Todos os voos"/>
            <br /><br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Enviar"/>
        </div>
    </form>
</body>
</html>
