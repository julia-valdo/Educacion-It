<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VistaMedico.aspx.cs" Inherits="WebMedico.VistaMedico" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Id: <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
            <br />
            Nombre: <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <br />
            Apellido: <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
            <br />
            Número de Matrícula:<asp:TextBox ID="txtNroMatricula" runat="server"></asp:TextBox>
            <br />
            Especialidad: <asp:DropDownList ID="dropEspecialidad" runat="server" AutoPostBack="True"></asp:DropDownList>
            <br />
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
            <asp:Button ID="btnModificar" runat="server" Text="Modificar" OnClick="btnModificar_Click" />
            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
            &nbsp;&nbsp;&nbsp;
            Traer por Especialidad: <asp:DropDownList ID="dropTraerEspecialidad" runat="server" AutoPostBack="True" OnSelectedIndexChanged="dropTraerEspecialidad_SelectedIndexChanged"></asp:DropDownList>
            <br />
            <asp:GridView ID="gridMedicos" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
