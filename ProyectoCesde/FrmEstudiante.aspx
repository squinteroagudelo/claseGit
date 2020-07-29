<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmEstudiante.aspx.cs" Inherits="ProyectoCesde.FrmEstudiante" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 1617px;
        }
        .auto-style2 {
            text-align: center;
        }
        .auto-style8 {
            width: 219px;
        }
        .auto-style9 {
            width: 220px;
        }
        .auto-style10 {
            width: 219px;
            height: 26px;
        }
        .auto-style11 {
            width: 220px;
            height: 26px;
        }
        .auto-style12 {
            width: 344px;
        }
        .auto-style13 {
            width: 344px;
            height: 26px;
        }
        .auto-style14 {
            width: 263px;
        }
        .auto-style15 {
            width: 263px;
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
                        <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="ADMINISTRACIÓN DE ESTUDIANTES"></asp:Label>
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
                        <asp:Label ID="lblnombre" runat="server" Font-Names="Arial" Text="Nombre"></asp:Label>
                    </td>
                    <td class="auto-style12">
                        <asp:TextBox ID="txtNombreEst" runat="server" Font-Names="Arial" AutoCompleteType="Disabled"></asp:TextBox>
                    </td>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style14">&nbsp;</td>
                    <td class="auto-style8">
                        <asp:Label ID="lblApellido" runat="server" Font-Names="Arial" Text="Apellido"></asp:Label>
                    </td>
                    <td class="auto-style12">
                        <asp:TextBox ID="txtApellidoEst" runat="server" Font-Names="Arial" AutoCompleteType="Disabled"></asp:TextBox>
                    </td>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style14">&nbsp;</td>
                    <td class="auto-style8">
                        <asp:Label ID="lblDocEstud" runat="server" Font-Names="Arial" Text="Documento"></asp:Label>
                    </td>
                    <td class="auto-style12">
                        <asp:TextBox ID="txtDocEst" runat="server" Font-Names="Arial" AutoCompleteType="Disabled"></asp:TextBox>
                    </td>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style14">&nbsp;</td>
                    <td class="auto-style8">
                        <asp:Label ID="lblSexoEst" runat="server" Font-Names="Arial" Text="Sexo"></asp:Label>
                    </td>
                    <td class="auto-style12">
                        <asp:TextBox ID="txtSexoEst" runat="server" Font-Names="Arial" AutoCompleteType="Disabled"></asp:TextBox>
                    </td>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style14">&nbsp;</td>
                    <td class="auto-style8">
                        <asp:Label ID="lblDirEst" runat="server" Font-Names="Arial" Text="Dirección"></asp:Label>
                    </td>
                    <td class="auto-style12">
                        <asp:TextBox ID="txtDirEst" runat="server" Font-Names="Arial" AutoCompleteType="Disabled"></asp:TextBox>
                    </td>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style14">&nbsp;</td>
                    <td class="auto-style8">
                        <asp:Label ID="lblTelEst" runat="server" Font-Names="Arial" Text="Teléfono"></asp:Label>
                    </td>
                    <td class="auto-style12">
                        <asp:TextBox ID="txtTelEst" runat="server" Font-Names="Arial" AutoCompleteType="Disabled"></asp:TextBox>
                    </td>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style10"></td>
                    <td class="auto-style15"></td>
                    <td class="auto-style10">
                        <asp:Label ID="lblNacim" runat="server" Font-Names="Arial" Text="Fecha nacimiento"></asp:Label>
                    </td>
                    <td class="auto-style13">
                        <asp:TextBox ID="txtFechaNac" runat="server" Font-Names="Arial" AutoCompleteType="Disabled"></asp:TextBox>
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
                        <asp:Button ID="btnAgregarEst" runat="server" Font-Bold="True" Font-Names="Arial" Text="Agregar" Width="80px" OnClick="btnAgregarEst_Click" />
&nbsp;&nbsp;
                        <asp:Button ID="btnActualEst" runat="server" Font-Bold="True" Font-Names="Arial" Text="Actualizar" Width="80px" OnClick="btnActualEst_Click" />
&nbsp;&nbsp;
                        <asp:Button ID="btnEliminarEst" runat="server" Font-Bold="True" Font-Names="Arial" Text="Eliminar" Width="80px" OnClick="btnEliminarEst_Click" />
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
                        <asp:TextBox ID="txtBuscarEst" runat="server" Font-Names="Arial" Width="170px" AutoCompleteType="Disabled"></asp:TextBox>
&nbsp;&nbsp;
                        <asp:Button ID="btnBuscarEst" runat="server" Font-Bold="True" Font-Names="Arial" Text="Buscar" Width="80px" OnClick="btnBuscarEst_Click" />
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
                        <asp:GridView ID="gvEstudiantes" runat="server" CellPadding="4" Font-Names="Arial" Font-Size="Small" HorizontalAlign="Center" PageSize="5" OnSelectedIndexChanged="gvEstudiantes_SelectedIndexChanged">
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
