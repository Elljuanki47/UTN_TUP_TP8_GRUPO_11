<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EliminarSucursales.aspx.cs" Inherits="Vistas.EliminarSucursales" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="hlAgregar" runat="server"
        NavigateUrl="~/AgregarSucursal.aspx"
        Text="Agregar Sucursal" />

    &nbsp;&nbsp;&nbsp;

    <asp:HyperLink ID="hlListado" runat="server"
        NavigateUrl="~/ListadoSucursales.aspx"
        Text="Listado de Sucursales" />

    &nbsp;&nbsp;&nbsp;

    <asp:HyperLink ID="hlEliminar" runat="server"
        NavigateUrl="~/EliminarSucursales.aspx"
        Text="Eliminar Sucursal" />

    <h3>Eliminar Sucursal</h3>

    <asp:Label ID="lblIdSucursal" runat="server" Text="Ingresar ID Sucursal: " />
    <asp:TextBox ID="txtIdSucursal" runat="server" />

    <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />

    
        </div>
        <p>
            <asp:Label ID="lblMensaje" runat="server"></asp:Label>
        </p>
        <asp:Label ID="lblIds" runat="server"></asp:Label>
    </form>

</body>
</html>
