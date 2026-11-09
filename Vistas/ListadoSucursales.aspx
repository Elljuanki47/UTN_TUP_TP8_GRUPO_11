<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListadoSucursales.aspx.cs" Inherits="Vistas.ListadoSucursales" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 206px;
        }
        .auto-style3 {
            width: 263px;
        }
        .auto-style4 {
            width: 119px;
        }
    </style>
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

    <h3>Listado de sucursales</h3>
            <p>&nbsp;<table class="auto-style1">
                <tr>
                    <td class="auto-style2">Búsqueda ingrese Id sucursal:</td>
                 <td class="auto-style3">
    <asp:TextBox ID="txtFiltrar" runat="server" style="margin-left: 0px" Width="224px"></asp:TextBox>
    
    <asp:RequiredFieldValidator
        ID="rfvFiltro"
        runat="server"
        ControlToValidate="txtFiltrar"
        ErrorMessage="* Debe ingresar un ID, No puede dejar vacio"
        ForeColor="Red"
        ValidationGroup="GrupoFiltro">
    </asp:RequiredFieldValidator>


    <asp:CompareValidator ID="cvFiltro" runat="server" 
        ControlToValidate="txtFiltrar" 
        Type="Integer" 
        Operator="DataTypeCheck" 
        ErrorMessage="* Ingrese un ID numérico válido" 
        ForeColor="Red" 
        ValidationGroup="GrupoFiltro">
    </asp:CompareValidator>
</td>
<td>&nbsp;</td>
<td class="auto-style4">
    <asp:Button ID="btnFiltrar" runat="server" Text="Filtrar" OnClick="btnFiltrar_Click" ValidationGroup="GrupoFiltro"/>
</td>
                    <td>
                        <asp:Button ID="btnMostrarTodos" runat="server" Text="Mostrar Todos"
                         OnClick="btnMostrarTodos_Click" CausesValidation="false" />
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                </table>
            </p>
      <asp:GridView ID="gvSucursales" runat="server" AutoGenerateColumns="false" EmptyDataText="No se encontraron sucursales con el ID ingresado.">
    <Columns>
        <asp:BoundField DataField="Id_Sucursal" HeaderText="Id_Sucursal" />
        <asp:BoundField DataField="NombreSucursal" HeaderText="Nombre" />
        <asp:BoundField DataField="DescripcionSucursal" HeaderText="Descripción" />
        <asp:BoundField DataField="DescripcionProvincia" HeaderText="Provincia" />
        <asp:BoundField DataField="DireccionSucursal" HeaderText="Dirección" />
    </Columns>
</asp:GridView>
        </div>
    </form>
</body>
</html>
