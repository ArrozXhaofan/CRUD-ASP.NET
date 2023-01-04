<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="capaPresentacion.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Inicio</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label3" runat="server" Text="Id"></asp:Label>
            <asp:TextBox ID="txtId" runat="server" ></asp:TextBox><br />

            <asp:Label ID="Label1" runat="server" Text="Nombre de categoria"></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox> <br />

            <asp:Label ID="Label2" runat="server" Text="Descripcion"></asp:Label>
            <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox><br />

            

            <asp:Button ID="btnEjecutar" runat="server" Text="Crear" OnClick="btnEjecutar_Click"/><br />
            <asp:Button ID="btnModificar" runat="server" Text="Modificar" OnClick="btnModificar_Click" />
            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
            <asp:Button ID="btnLista" runat="server" Text="Ver Categorias" OnClick="btnLista_Click" />
            
        </div>
    </form>
</body>
</html>
