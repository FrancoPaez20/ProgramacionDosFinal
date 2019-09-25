﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HTMLDuenios.aspx.cs" Inherits="Cada_de_prensentacion.HTMLDuenios" %>

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

        <h2>BUSCAR DATOS PARA VER UN DUEÑO</h2><br/><br/><br/>

        <input type="number" runat="server" placeholder="INGRESAR DNI DEL DUEÑO" id="midni"/>
        <br/>
        <br/>
        <asp:Button ID="btnmidni" runat="server" Text="Button" OnClick="buscarduenios"/>
        <br/>
        <br/>
        <input type="text" runat="server" placeholder="APELLIDO" disabled id="inputapellido"/>
        <br/>
        <input type="text" runat="server" placeholder="NOMBRE" disabled id="inputnombre"/>
        <br/>
        <input type="text" runat="server" placeholder="DIRECCION" disabled id="inputdireccion"/>
        <br/>
        <input type="text" runat="server" placeholder="TELEFONO" disabled id="inputtelefono"/>
        <br/>
        <input type="text" runat="server" placeholder="MAIL" disabled id="inputmail"/>
        <br/>
        <input type="text" runat="server" placeholder="BANCO" disabled id="inputbanco"/>
        <br/>
        <input type="text" runat="server" placeholder="NUMERO DE CUENTA" disabled id="inputnumcuenta"/>
        <br/><br/><br/><br/><br/><br/>

        <h3>PROPIEDADES - CASA</h3>
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        <br />
        <br />
        <br />
        <h3>PROPIEDADES - DEPARTAMENTOS</h3>
        <br />
        <br />
        <asp:GridView ID="GridView2" runat="server"></asp:GridView>
        <br />
        <br />
        <br />
        <h3>PROPIEDADES - LOCALES COMERCIALES</h3>
        <br />
        <br />
        <asp:GridView ID="GridView3" runat="server"></asp:GridView>
        <br />
        <br />
        <br />

    </form>

</body>
</html>