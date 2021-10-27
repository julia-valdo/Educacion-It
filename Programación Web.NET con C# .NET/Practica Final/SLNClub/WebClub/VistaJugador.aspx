<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VistaJugador.aspx.cs" Inherits="WebClub.VistaJugador" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 190px;
        }
        .auto-style3 {
            width: 152px;
        }
    </style>
    <link href="Content/style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblId" runat="server" Text="Id:"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar" Width="69px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblApellido" runat="server" Text="Apellido"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btnEditar" runat="server" OnClick="btnEditar_Click" Text="Editar" Width="69px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblFechaNacimiento" runat="server" Text="Fecha Nacimiento:"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtFechaNacimiento" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" Width="69px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblPuesto" runat="server" Text="Puesto:"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:DropDownList ID="ddlPuesto" runat="server" AutoPostBack="True">
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblBuscarJugador" runat="server" Text="Buscar jugador por puesto"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:DropDownList ID="ddlBuscarPuesto" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlBuscarPuesto_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
        <asp:GridView ID="gridJugadores" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id"/>
                <asp:BoundField DataField="Nombre" HeaderText="Nombre"/>
                <asp:BoundField DataField="Apellido" HeaderText="Apellido"/>
                <asp:TemplateField HeaderText="Fecha Nacimiento">
                    <ItemTemplate>
                        <asp:Label Text='<%# Eval("FechaNacimiento", "{0:dd, MMM yyyy}") %>' runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Puesto" HeaderText="Puesto"/>
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
