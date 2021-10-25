<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VistaAuto.aspx.cs" Inherits="WebTransport.VistaAuto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Marca: <asp:DropDownList ID="ddlMarca" runat="server" AutoPostBack="True"></asp:DropDownList>
            <br />
            Modelo: <asp:TextBox ID="txtModelo" runat="server"></asp:TextBox>
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
            <br />
            Matricula: <asp:TextBox ID="txtMatricula" runat="server"></asp:TextBox>
            <asp:Button ID="btnEditar" runat="server" Text="Editar" OnClick="btnEditar_Click" />
            <br />
            Precio: <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox>
            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" style="height: 26px" />
            <br />
            Id: <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
            <br />
            Buscar autos por Marca: <asp:DropDownList ID="ddlBuscarMarca" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlBuscarMarca_SelectedIndexChanged"></asp:DropDownList>
            <br />
            <asp:GridView ID="gridAutos" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
