﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="Presentacion.Alumnos.Create" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="container">
    
        <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
        <div>
            <asp:RequiredFieldValidator ID="valnombre" runat="server" ErrorMessage="campo nombre requerido" ControlToValidate="TextBox1" CssClass="danger" ></asp:RequiredFieldValidator>
        </div> 
        <asp:Label ID="Label2" runat="server" Text="PrimerApellido"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
        <div>
            <asp:RequiredFieldValidator ID="valPapellido" runat="server" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
        </div>
        <asp:Label ID="Label3" runat="server" Text="segundoApellido"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
        
        <asp:Label ID="Label4" runat="server" Text="Correo"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br />
        <div>
            <asp:RequiredFieldValidator ID="valcorreo" runat="server" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
        </div>
        <asp:Label ID="Label5" runat="server" Text="telefono"></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br />
        <div>
                    <asp:RequiredFieldValidator ID="valtelefono" runat="server" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
        </div>
        <asp:Label ID="Label6" runat="server" Text="fechanacimiento"></asp:Label>
        <asp:TextBox ID="TextBox6" runat="server" TextMode="Date"></asp:TextBox><br />
        <div>
            <asp:RequiredFieldValidator ID="valfechanacimiento" runat="server" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
        </div>
        <asp:Label ID="Label7" runat="server" Text="curp"></asp:Label>
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox><br />
        <div>
            <asp:RequiredFieldValidator ID="valcurp" runat="server" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
        </div>
        <asp:Label ID="Label8" runat="server" Text="sueldo"></asp:Label>
        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label9" runat="server" Text="estadoorigen"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList><br />
        <asp:Label ID="Label10" runat="server" Text="estatus"></asp:Label>
        <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList><br />
        <asp:Button ID="Button1" runat="server" Text="guardar" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Cancelar" style=margin-left:10px; OnClick="Button2_Click" />
        </div>
</asp:Content>
