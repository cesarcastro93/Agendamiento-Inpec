<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgendaHorario.aspx.cs" Inherits="InpecTurnos.AgendaHorario" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">

         <asp:Label ID="LDatos" runat="server" Text="Datos del agendamiento:"  Font-Bold="True" Font-Size="16"></asp:Label>
        <br /> <br /> 
        <asp:Label ID="Loficina" runat="server" Text="Label"  Font-Bold="True" Font-Size="16"></asp:Label>
        <br />
        <asp:Label ID="Lservicio" runat="server" Text="Label"  Font-Bold="True" Font-Size="16"></asp:Label>
        <br />
        <asp:Label ID="Lhorario" runat="server" Text="Label"  Font-Bold="True" Font-Size="16"></asp:Label>
        <br />
        <asp:Label ID="Ldocumento" runat="server" Text="Label"  Font-Bold="True" Font-Size="16"></asp:Label>
        <br /> <br /> <br />
        <asp:Label ID="LHora" runat="server" Text="Horario"  Font-Bold="True" Font-Size="16pt"  ForeColor="#FF3300"></asp:Label>
        <asp:DropDownList ID="DDLHorario" runat="server" class="form-control"></asp:DropDownList>
        <br />
        <br />
        
        <asp:Button ID="AceptoAgenda" runat="server" Text="Agendar" OnClick="Acepto_Click" class="btn btn-primary btn-lg " />
        <asp:Button ID="btn_cancelarAgenda" class="btn btn-danger btn-lg " runat="server" Text="Cancelar" OnClick="btn_cancelarAgenda_Click" />
    </div>
    <div>
        <asp:Label ID="Msn" runat="server" Text="Label" Visible="False"></asp:Label>
    </div>
  

</asp:Content>
