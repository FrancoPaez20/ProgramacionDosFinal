<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HTMLAlquileres.aspx.cs" Inherits="Cada_de_prensentacion.HTMLAlquileres" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<meta name="viewport" content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0"/>
<title>PROGRAMACION</title>
<link href="StyleSheet1.css" rel="stylesheet" />
</head>
<body>

    <header>

        <div>
            <h2>INMOBILIARIA - PROGRA 2</h2>
        </div>

        <div class="contenedorEnlaces">
            <a href="Index.aspx" class="enlaces" runat="server">Registrar Alquiler</a>
            <a href="HTMLDuenios.aspx" class="enlaces" runat="server">Datos Dueños</a>
            <a href="HTMLInquilinos.aspx" class="enlaces" runat="server">Datos Inquilinos</a>
            <a href="HTMLAlquileres.aspx" class="enlaces" runat="server">Datos Alquiler</a>
        </div>

    </header>

    <form id="form1" runat="server">

         <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:CommandField SelectText="elegir" ShowSelectButton="true"/>
            </Columns>
        </asp:GridView>

        <h3>DATOS DE GARANTE</h3>
        <br/><br/>
        <input type="number" runat="server" placeholder="INGRESAR DNI DEL GARANTE" id="text6" />
        <br/>
        <input type="text" runat="server" placeholder="APELLIDO" disabled id="text7" />
        <br/>
        <input type="text" runat="server" placeholder="NOMBRE" disabled id="text8" />
        <br/>
        <input type="text" runat="server" placeholder="DIRECCION" disabled id="text9" />
        <br/>
        <input type="text" runat="server" placeholder="TELEFONO" disabled id="text10" />
        <br/>
        <input type="text" runat="server" placeholder="MAIL" disabled id="text11" />
        <br/>
        <input type="text" runat="server" placeholder="EMPLEO" disabled id="text12" />
        <br/>
        <br/>
        <br/>
        <br/>
        <br/>
        <br/>

        <asp:GridView ID="GridView2" runat="server" >  

        </asp:GridView>

        <br/>
        <br/>
        <br/>
        <br/>
        <br/>
        <br/>
        <asp:Label Text="Fecha Inicio" runat="server" />
        <input type="text" runat="server" placeholder="EMPLEO" disabled id="text1" />

        <asp:Label Text="Fecha Fin" runat="server" />
        <input type="text" runat="server" placeholder="EMPLEO" disabled id="text2" />

        <asp:Label Text="Alquiler Mensual" runat="server" />
        <input type="text" runat="server" placeholder="EMPLEO" disabled id="text3" />

        <asp:Label Text="Tipo de Inmueble" runat="server" />
        <input type="text" runat="server" placeholder="EMPLEO" disabled id="text4" />

    </form>

</body>
</html>
