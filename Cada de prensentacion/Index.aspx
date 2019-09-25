<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Cada_de_prensentacion.Index" %>

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

        <h2>CREAR CONTRATO DE ALQUILER NUEVO</h2><br/><br/><br/>

        <h3>DATOS DE DUEÑO</h3>
        <br />
        <br />
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
        <br/>
        <br/>
        <br/>
        <br/>
        <br/>
        <br/>
        
        <h3>DATOS DE DATOS INQUILINO</h3>
        <br/><br/>
        <input type="number" runat="server" placeholder="INGRESAR DNI DEL INQUILINO" id="midni1" />
        <br/>
        <br/>
        <asp:Button ID="btnmidni1" runat="server" Text="Button" OnClick="buscarinquilinos"/>
        <br/>
        <br/>
        <input type="text" runat="server" placeholder="APELLIDO" disabled id="Text1" />
        <br/>
        <input type="text" runat="server" placeholder="NOMBRE" disabled id="Text2" />
        <br/>
        <input type="text" runat="server" placeholder="DIRECCION" disabled id="Text3" />
        <br/>
        <input type="text" runat="server" placeholder="TELEFONO" disabled id="Text4" />
        <br/>
        <input type="text" runat="server" placeholder="MAIL" disabled id="Text5" />
        <br/>
        <br/>
        <br/>
        <br/>
        <br/>
        <br/>
        
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

        <h3>DATOS EXTRAS PARA EL CONTRATO DE ALQUILER</h3>
        <br/><br/>
        <input type="date" runat="server" min="2019-09-25" placeholder="INGRESAR FECHA DE INCIO DE ALQUILER" id="fechaAlquiler"/>
        <br/>
        <input type="number" runat="server" placeholder="MESES QUE DURA EL ALQUILER" id="mesesalquiler"/>
        <br/>
        <input type="text" runat="server" placeholder="PRECIO TOTAL DEL ALQUILER" id="precioalquiler"/>
        <br/>
        <br/>
        <br/>
        <br/>
        <br/>
        <br/>
        
        <h3>DATOS INMUEBLES</h3>
        <br/><br/>
        <input type="number" runat="server" placeholder="INGRESAR ID DE INMUEBLE"/>



        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="CargarCasa">

            <Columns>

                <asp:CommandField SelectText="elegir" ShowSelectButton="true" />

            </Columns>



        </asp:GridView>

        <asp:GridView ID="GridView2" runat="server"  OnSelectedIndexChanged="CargarDepartamento">

            
            <Columns>

                <asp:CommandField SelectText="elegir" ShowSelectButton="true" />

            </Columns>

        </asp:GridView>

        <asp:GridView ID="GridView3" runat="server"  OnSelectedIndexChanged="CargarLocalComercial">

            
            <Columns>

                <asp:CommandField SelectText="elegir" ShowSelectButton="true" />

            </Columns>

        </asp:GridView>

        <input type="text" name="name" value="" runat="server" id="txtinmueble" Visible="false"/>

        <br/>
        <br/>
        <asp:Button ID="Button2" runat="server" Text="Button" OnClick="CargaBoton"/>
        <br/>
        <br/>

    </form>

</body>
</html>
