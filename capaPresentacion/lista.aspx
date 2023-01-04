<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="lista.aspx.cs" Inherits="capaPresentacion.lista" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Lista de categoria</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Categorias listas"></asp:Label>

            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Ir a CRUD categoria >" Onclick="Button1_Click"/>

        </div>
    </form>
</body>
</html>
