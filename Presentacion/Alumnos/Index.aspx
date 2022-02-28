<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Presentacion.Alumnos.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="container">
        <h3>Lista de alumnos</h3>
                <div class="d-grid gap-2 d-md-flex justify-content-md-end"><a runat="server" href="~/Alumnos/Create" class="btn btn-primary" role="button">Agregar</a></div><br />

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="table" BorderStyle="None" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging" PageSize="5" OnRowCommand="GridView1_RowCommand" GridLines="Horizontal" >
        <Columns>
            <asp:BoundField DataField="id" HeaderText="ID" SortExpression="id" />
            <asp:BoundField DataField="nombre" HeaderText="Nombre" SortExpression="nombre" />
            <asp:BoundField DataField="primerApellido" HeaderText="Primer Apellido" SortExpression="primerApellido" />
            <asp:BoundField DataField="segundoApellido" HeaderText="Segundo Apellido" SortExpression="segundoApellido" />
            <asp:BoundField DataField="correo" HeaderText="Correo" SortExpression="correo" />
            <asp:BoundField DataField="telefono" HeaderText="Telefono" SortExpression="telefono" />
            <asp:BoundField DataField="fechaNacimiento" HeaderText="Fecha de Nacimiento" SortExpression="fechaNacimiento" DataFormatString="{0:d}" />
            <asp:BoundField DataField="curp" HeaderText="CURP" SortExpression="curp" />
            <asp:BoundField DataField="sueldo" HeaderText="Sueldo" SortExpression="sueldo" />
            <asp:BoundField DataField="idEstadoOrigen" HeaderText="Estado" SortExpression="idEstadoOrigen" />
            <asp:BoundField DataField="idEstatus" HeaderText="Estatus" SortExpression="idEstatus" />
            <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Details" ShowHeader="True" Text="Details">
            <ControlStyle CssClass="btn btn-info" />
            </asp:ButtonField>
            <asp:ButtonField ButtonType="Button" CommandName="SelectEdit" HeaderText="Edit" ShowHeader="True" Text="Edit">
            <ControlStyle CssClass="btn btn-warning" />
            </asp:ButtonField>
            <asp:ButtonField ButtonType="Button" CommandName="SelectDelete" HeaderText="Delete" ShowHeader="True" Text="Delete">
            <ControlStyle CssClass="btn btn-danger" />
            </asp:ButtonField>
        </Columns>
    </asp:GridView>
        </div>
</asp:Content>
