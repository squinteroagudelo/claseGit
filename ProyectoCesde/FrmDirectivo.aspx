<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmDirectivo.aspx.cs" Inherits="ProyectoCesde.FrmDirectivo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">


        .auto-style1 {
            width: 1617px;
        }
        .auto-style8 {
            width: 219px;
        }
        .auto-style14 {
            width: 263px;
        }
        .auto-style2 {
            text-align: center;
        }
        .auto-style9 {
            width: 220px;
        }
        .auto-style12 {
            width: 344px;
        }
        .auto-style10 {
            width: 219px;
            height: 26px;
        }
        .auto-style15 {
            width: 263px;
            height: 26px;
        }
        .auto-style13 {
            width: 344px;
            height: 26px;
        }
        .auto-style11 {
            width: 220px;
            height: 26px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style14">&nbsp;</td>
                    <td class="auto-style2" colspan="2">
                        &nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style14">&nbsp;</td>
                    <td class="auto-style2" colspan="2">
                        <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="ADMINISTRACIÓN DE DIRECTIVOS"></asp:Label>
                    </td>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style14">&nbsp;</td>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style14">&nbsp;</td>
                    <td class="auto-style8">
                        <asp:Label ID="lblnombreDirect" runat="server" Font-Names="Arial" Text="Nombre"></asp:Label>
                    </td>
                    <td class="auto-style12">
                        <asp:TextBox ID="txtNombreDirect" runat="server" Font-Names="Arial" AutoCompleteType="Disabled"></asp:TextBox>
                    </td>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style14">&nbsp;</td>
                    <td class="auto-style8">
                        <asp:Label ID="lblApellidoDirect" runat="server" Font-Names="Arial" Text="Apellido"></asp:Label>
                    </td>
                    <td class="auto-style12">
                        <asp:TextBox ID="txtApellidoDirect" runat="server" Font-Names="Arial" AutoCompleteType="Disabled"></asp:TextBox>
                    </td>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style14">&nbsp;</td>
                    <td class="auto-style8">
                        <asp:Label ID="lblDocDirect" runat="server" Font-Names="Arial" Text="Documento"></asp:Label>
                    </td>
                    <td class="auto-style12">
                        <asp:TextBox ID="txtDocDirect" runat="server" Font-Names="Arial" AutoCompleteType="Disabled"></asp:TextBox>
                    </td>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style14">&nbsp;</td>
                    <td class="auto-style8">
                        <asp:Label ID="lblSexoDirect" runat="server" Font-Names="Arial" Text="Sexo"></asp:Label>
                    </td>
                    <td class="auto-style12">
                        <asp:TextBox ID="txtSexoDirect" runat="server" Font-Names="Arial" AutoCompleteType="Disabled"></asp:TextBox>
                    </td>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style14">&nbsp;</td>
                    <td class="auto-style8">
                        <asp:Label ID="lblDirDirect" runat="server" Font-Names="Arial" Text="Dirección"></asp:Label>
                    </td>
                    <td class="auto-style12">
                        <asp:TextBox ID="txtDirDirect" runat="server" Font-Names="Arial" AutoCompleteType="Disabled"></asp:TextBox>
                    </td>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style14">&nbsp;</td>
                    <td class="auto-style8">
                        <asp:Label ID="lblTelDirect" runat="server" Font-Names="Arial" Text="Teléfono"></asp:Label>
                    </td>
                    <td class="auto-style12">
                        <asp:TextBox ID="txtTelDirect" runat="server" Font-Names="Arial" AutoCompleteType="Disabled"></asp:TextBox>
                    </td>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style10"></td>
                    <td class="auto-style15"></td>
                    <td class="auto-style10">
                        <asp:Label ID="lblProfesion" runat="server" Font-Names="Arial" Text="Profesión / Cargo"></asp:Label>
                    </td>
                    <td class="auto-style13">
                        <asp:TextBox ID="txtProfesion" runat="server" Font-Names="Arial" AutoCompleteType="Disabled"></asp:TextBox>
                    </td>
                    <td class="auto-style11"></td>
                    <td class="auto-style11"></td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style14">&nbsp;</td>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style14">&nbsp;</td>
                    <td class="auto-style8">
                        <asp:Button ID="btnLimpiar" runat="server" Font-Bold="True" Font-Names="Arial" Text="Limpiar" OnClick="btnLimpiar_Click" />
                    </td>
                    <td class="auto-style12">
                        <asp:Button ID="btnAgregarDirect" runat="server" Font-Bold="True" Font-Names="Arial" Text="Agregar" Width="80px" OnClick="btnAgregarDirect_Click" />
&nbsp;&nbsp;
                        <asp:Button ID="btnActualDirect" runat="server" Font-Bold="True" Font-Names="Arial" Text="Actualizar" Width="80px" OnClick="btnActualDirect_Click" />
&nbsp;&nbsp;
                        <asp:Button ID="btnEliminarDirect" runat="server" Font-Bold="True" Font-Names="Arial" Text="Eliminar" Width="80px" OnClick="btnEliminarDirect_Click" />
                    </td>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style14">&nbsp;</td>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style14">&nbsp;</td>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style12">
                        <asp:TextBox ID="txtBuscarDirect" runat="server" Font-Names="Arial" Width="170px" AutoCompleteType="Disabled"></asp:TextBox>
&nbsp;&nbsp;
                        <asp:Button ID="btnBuscarDirect" runat="server" Font-Bold="True" Font-Names="Arial" Text="Buscar" Width="80px" OnClick="btnBuscarDirect_Click" />
                    </td>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style14">&nbsp;</td>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style12">
                        <asp:Label ID="lblErrorBuscar" runat="server" Font-Names="Arial" ForeColor="#CC0000"></asp:Label>
                    </td>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td colspan="4">
                        <asp:GridView ID="gvDirectivos" runat="server" CellPadding="4" Font-Names="Arial" Font-Size="Small" HorizontalAlign="Center" PageSize="5" OnSelectedIndexChanged="gvDirectivos_SelectedIndexChanged">
                            <Columns>
                                <asp:CommandField ButtonType="Image" SelectImageUrl="~/img/editar.png" SelectText="" ShowSelectButton="True" />
                            </Columns>
                        </asp:GridView>
                    </td>
                    <td class="auto-style9">&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
