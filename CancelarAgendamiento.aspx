<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CancelarAgendamiento.aspx.cs" Inherits="InpecTurnos.CancelarAgendamiento" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>



<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        
         <asp:Label ID="LNumDoc" runat="server" Text="Ingrese número de documento" Font-Size="16" ForeColor="Black"></asp:Label>
        <asp:TextBox ID="txt_IngID" runat="server" class="form-control" MaxLength="11"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btn_Ok_eliminarAgenda" class="btn btn-primary btn-lg" runat="server" Text="Cancelar Agendamiento" OnClick="btn_Ok_eliminarAgenda_Click" />

        <ajaxToolkit:ModalPopupExtender ID="ModalCancelar" runat="server"></ajaxToolkit:ModalPopupExtender>

        <asp:Button ID="btn_cancelar" class="btn btn-danger btn-lg" runat="server" Text="Regresar" OnClick="btn_cancelar_Click" />
        <br />
        <br />
        <asp:Label ID="Lrespuesta" runat="server" Text="Label" Visible="False" Font-Size="20" ForeColor="Red"></asp:Label>
    </div>

</asp:Content>
