<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarSucursal.aspx.cs" Inherits="Vistas.AgregarSucursal" %>

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
    
        <h2>GRUPO 11</h2>
        <h3>Agregar Sucursal</h3>
    
        <asp:Label ID="lblNombre" runat="server"
            Text="Nombre Sucursal:" />
        <asp:TextBox ID="txtNombre" runat="server" />
    
        <asp:RequiredFieldValidator
            ID="rfvNombre" runat="server"
            ControlToValidate="txtNombre"
            ErrorMessage="Ingrese el nombre"
            ForeColor="Red" />
        <br /><br />
    
        <asp:Label ID="lblDescripcion" runat="server"
            Text="Descripción:" />
        <asp:TextBox ID="txtDescripcion" runat="server" />
    
        <asp:RequiredFieldValidator
            ID="rfvDescripcion" runat="server"
            ControlToValidate="txtDescripcion"
            ErrorMessage="Ingrese la descripción"
            ForeColor="Red" />
        <br /><br />
    
        <asp:Label ID="lblProvincia" runat="server"
            Text="Provincia:" />
        <asp:DropDownList ID="ddlProvincia"
            runat="server" />
        <br /><br />
    
        <asp:Label ID="lblDireccion" runat="server"
            Text="Dirección:" />
        <asp:TextBox ID="txtDireccion" runat="server" />
    
        <asp:RequiredFieldValidator
            ID="rfvDireccion" runat="server"
            ControlToValidate="txtDireccion"
            ErrorMessage="Ingrese la dirección"
            ForeColor="Red" />
        <br /><br />
    
        <asp:Button ID="btnGuardar" runat="server"
            Text="Aceptar" />
    
        <br /><br />
    
        <asp:Label ID="lblMensaje" runat="server" />
    </div>
    </form>
</body>
</html>
