<%@ Page Title="Agende su turno" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormAgenda.aspx.cs" Inherits="InpecTurnos.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="DivCentrado">
        <div class="form-row col-md-12">
        <div class="form-group col-md-9">
            <label for="inputState">Sede</label>
            <asp:DropDownList ID="List_sede" runat="server" class="form-control"></asp:DropDownList>
        </div>
        <div class="form-group col-md-9">
            <label for="inputState">Servicio</label>
            <asp:DropDownList ID="List_Servicios" runat="server" class="form-control form-control-lg">
            </asp:DropDownList>
        </div>
        <div class="form-group col-md-9">
            <label for="NumDoc">Ingrese Su Numero de Documento</label>
            <asp:TextBox ID="txt_IngID" runat="server" class="form-control" MaxLength="11" CausesValidation="true"></asp:TextBox>
            <asp:RegularExpressionValidator runat="server" id="rexNumber" controltovalidate="txt_IngID" validationexpression="^[0-9]{4,10}$" errormessage="Por favor ingrese un numero valido!" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Ingrese cedla" ControlToValidate="txt_IngID"></asp:RequiredFieldValidator>
        </div>
        <div class="form-group col-md-9">
            <label for="inputState">Fecha</label>
            <asp:DropDownList ID="DDLFechas" runat="server" class="form-control">
            </asp:DropDownList>
        </div>
        
        <hr />
         <div class="form-group col-md-9">
             <asp:Button ID="btn_Ok"   class="btn btn-primary"  runat="server" Text="Aceptar" OnClick="btn_Ok_Click" />
             <asp:Button ID="btn_cancelarAgenda"  class="btn btn-danger" runat="server" Text="Cancelar" OnClick="btn_cancelarAgenda_Click" />
             <br />
             <br />
       
         </div>
            <div>
                 <asp:Label ID="warning" runat="server" Text=""></asp:Label>
            </div>
    </div>
    </div>
    
</asp:Content>

