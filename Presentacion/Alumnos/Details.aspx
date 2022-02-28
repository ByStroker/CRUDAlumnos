<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="Presentacion.Alumnos.Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <div class="form-horizontal">
	<h2>Título</h2>        
	<!-- Control asp Label para mensajes -->
	<hr />
	<dl class="dl-horizontal">
		<!-- Par de dt-dd por cada propiedad -->
		<dt>
			<!-- Nombre de la Propiedad -->
			<asp:Label ID="Label1" runat="server" Text="Id"></asp:Label>  </dt>
		<dd>
			<!-- Control asp Label para mostrar valor de la propiedad -->
			<asp:Label ID="LabelId" runat="server" Text="Label"></asp:Label>
		    </dd>
		<dt>
			<!-- Nombre de la Propiedad -->
			<asp:Label ID="Label3" runat="server" Text="Nombre"></asp:Label>  </dt>
		<dd>
			<!-- Control asp Label para mostrar valor de la propiedad -->
			<asp:Label ID="LabelNombre" runat="server" Text="Label"></asp:Label>
		    </dd>
		<dt>
			<!-- Nombre de la Propiedad -->
			<asp:Label ID="Label5" runat="server" Text="Primer Apellido"></asp:Label>  </dt>
		<dd>
			<!-- Control asp Label para mostrar valor de la propiedad -->
			<asp:Label ID="LabelPrimerApellido" runat="server" Text="Label"></asp:Label>
		    </dd>
		<dt>
			<!-- Nombre de la Propiedad -->
			<asp:Label ID="Label7" runat="server" Text="Segundo Apellido"></asp:Label>  </dt>
		<dd>
			<!-- Control asp Label para mostrar valor de la propiedad -->
			<asp:Label ID="LabelSegundoApellido" runat="server" Text="Label"></asp:Label>
		    </dd>
		<dt>
			<!-- Nombre de la Propiedad -->
			<asp:Label ID="Label2" runat="server" Text="Correo"></asp:Label>  </dt>
		<dd>
			<!-- Control asp Label para mostrar valor de la propiedad -->
			<asp:Label ID="LabelCorreo" runat="server" Text="Label"></asp:Label>
		    </dd>
		<dt>
			<!-- Nombre de la Propiedad -->
			<asp:Label ID="Label4" runat="server" Text="Telefono"></asp:Label>  </dt>
		<dd>
			<!-- Control asp Label para mostrar valor de la propiedad -->
			<asp:Label ID="LabelTelefono" runat="server" Text="Label"></asp:Label>
		    </dd>
		<dt>
			<!-- Nombre de la Propiedad -->
			<asp:Label ID="Label6" runat="server" Text="Fecha Nacimiento"></asp:Label>  </dt>
		<dd>
			<!-- Control asp Label para mostrar valor de la propiedad -->
			<asp:Label ID="LabelFechaNacimiento" runat="server" Text="Label"></asp:Label>
		    </dd>
		<dt>
			<!-- Nombre de la Propiedad -->
			<asp:Label ID="Label8" runat="server" Text="CURP"></asp:Label>  </dt>
		<dd>
			<!-- Control asp Label para mostrar valor de la propiedad -->
			<asp:Label ID="LabelCurp" runat="server" Text="Label"></asp:Label>
		    </dd>
		<dt>
			<!-- Nombre de la Propiedad -->
			<asp:Label ID="Label9" runat="server" Text="Sueldo"></asp:Label>  </dt>
		<dd>
			<!-- Control asp Label para mostrar valor de la propiedad -->
			<asp:Label ID="LabelSueldo" runat="server" Text="Label"></asp:Label>
		    </dd>
		<dt>
			<!-- Nombre de la Propiedad -->
			<asp:Label ID="Label10" runat="server" Text="Estado"></asp:Label>  </dt>
		<dd>
			<!-- Control asp Label para mostrar valor de la propiedad -->
			<asp:Label ID="LabelEstado" runat="server" Text="Label"></asp:Label>
		    </dd>
		<dt>
			<!-- Nombre de la Propiedad -->
			<asp:Label ID="Label11" runat="server" Text="Estatus"></asp:Label>  </dt>
		<dd>
			<!-- Control asp Label para mostrar valor de la propiedad -->
			<asp:Label ID="LabelEstatus" runat="server" Text="Label"></asp:Label>
		    </dd>
		
	</dl>
	<div class="form-group">
		<div class="col-md-2">
			<a href="Liga.aspx">Ir a</a>
		</div>
	</div>
	<div class="form-group">
		<div class="col-md-offset-2 col-md-2">
			<!-- Boton -->
		</div>
	</div>	
</div>
</asp:Content>
