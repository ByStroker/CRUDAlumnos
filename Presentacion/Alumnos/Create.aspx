<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="Presentacion.Alumnos.Create" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="container">
    
        <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
        <div>
            <asp:RequiredFieldValidator ID="valnombre" runat="server" ErrorMessage="campo nombre requerido" ControlToValidate="TextBox1" CssClass="text-danger" ></asp:RequiredFieldValidator>
        </div> 
        <asp:Label ID="Label2" runat="server" Text="PrimerApellido"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
        <div>
            <asp:RequiredFieldValidator ID="valPapellido" runat="server" ErrorMessage="campo primer apellido requerido" ControlToValidate="TextBox2" CssClass="text-danger"></asp:RequiredFieldValidator>
        </div>
        <asp:Label ID="Label3" runat="server" Text="segundoApellido"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
        
        <asp:Label ID="Label4" runat="server" Text="Correo"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br />
        <div>
            <asp:RequiredFieldValidator ID="valcorreo" runat="server" ErrorMessage="campo correo requerido" ControlToValidate="TextBox4" CssClass="text-danger"></asp:RequiredFieldValidator>
        </div>
        <asp:Label ID="Label5" runat="server" Text="telefono"></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br />
        <div>
                    <asp:RequiredFieldValidator ID="valtelefono" runat="server" ErrorMessage="campo telefono requerido" ControlToValidate="TextBox5" CssClass="text-danger"></asp:RequiredFieldValidator>
        </div>
        <asp:Label ID="Label6" runat="server" Text="fechanacimiento"></asp:Label>
        <asp:TextBox ID="TextBox6" runat="server" TextMode="Date"></asp:TextBox><br />
        <div>
            <asp:RequiredFieldValidator ID="valfechanacimiento" runat="server" ErrorMessage="campo fecha de nacimiento requerido" ControlToValidate="TextBox6" CssClass="text-danger"></asp:RequiredFieldValidator><br />
            <asp:RangeValidator ID="RangeDate" runat="server" ErrorMessage="edad fuera de los rangos" ControlToValidate="TextBox6" CssClass="text-danger" MaximumValue="31/12/2000" MinimumValue="01/01/1990" Type="Date"></asp:RangeValidator>

        </div>
        <asp:Label ID="Label7" runat="server" Text="curp"></asp:Label>
        <asp:TextBox ID="TextBox7" runat="server" MaxLength="18"></asp:TextBox><br />
        <div>
            <asp:RequiredFieldValidator ID="valcurp" runat="server" ErrorMessage="campo CURP requerido" ControlToValidate="TextBox7" CssClass="text-danger"></asp:RequiredFieldValidator><br />
            <asp:RegularExpressionValidator ID="expresioncurp" runat="server" ErrorMessage="campo CURP no válido" ControlToValidate="TextBox7" CssClass="text-danger" ValidationExpression="[A-Z]{4}[0-9]{6}[H,M][A-Z]{5}[0-9]{2}"></asp:RegularExpressionValidator><br />
            <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="CustomValidator" ClientValidationFunction="comparar" ControlToValidate="TextBox7" CssClass="text-danger"></asp:CustomValidator>
            <br />
        </div>
        <asp:Label ID="Label8" runat="server" Text="sueldo"></asp:Label>
        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label9" runat="server" Text="estadoorigen"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList><br />
        <asp:Label ID="Label10" runat="server" Text="estatus"></asp:Label>
        <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList><br />
        <asp:Button ID="Button1" runat="server" Text="guardar" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Cancelar" style=margin-left:10px; OnClick="Button2_Click" CausesValidation="False" />
        </div>

     <%--$(document.getElementById("#TextBox6").val());--%>
    <%--$(document.getElementyId("#TextBox7").val().subString(5,6));--%>
   <script language="javascript" type="text/javascript">
       function comparar(source, arguments) {

           var fechanac = $("#<%= TextBox6.ClientID%>").val(); 
           var fechacurp = $("#<%= TextBox7.ClientID %>").val().substr(4, 6); 
           var fechanaci= fechanac.substr(2,2)+fechanac.substr(5,2)+fechanac.substr(8,2);
           arguments.isValid = fechacurp == fechanaci;
           /*alert(arguments.isValid);*/
       }
   </script>
</asp:Content>
