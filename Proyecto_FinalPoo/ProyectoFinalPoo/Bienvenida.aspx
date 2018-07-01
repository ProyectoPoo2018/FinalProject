<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bienvenida.aspx.cs" Inherits="ProyectoFinalPoo.Bienvenina" %>



<!DOCTYPE html >

<html xmlns="http://www.w3.org/1999/xhtml" class="Imagenfon" >
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Proyecto Poo 2018</title>
    <link href="centrarLogin.css" rel="stylesheet" />
</head>
<body class="centrarswf" >

    <form id="form1" runat="server"  class="colorFondo"  >
    
          <div class="colorText" style="  text-align:center;">Bienvenido al sistema de Proyectos de Vinculacion Pucese</div>
        <br />
   
    <div>
        <p>  
            <asp:Label class="colorText"  style="margin-left: 43px" Width="108px" ID="Label1"  runat="server" Text="Usuario"></asp:Label>
            <asp:TextBox  ID="txtUsuario" runat="server" style="margin-left: 0px" Width="269px" Height="26px" TextMode="Email"></asp:TextBox>
        </p>
            </div> 
    
    <div>
        <p>  
            <asp:Label class="colorText"  ID="Label2" style="margin-left: 44px" Width="108px" runat="server" Text="Pasword"></asp:Label>

            <asp:TextBox ID="txtPassword" runat="server" style="margin-left: 0px" Width="269px" Height="26px" TextMode="Password"></asp:TextBox>
        </p>
            </div>
              

          <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Olvide Mi Contraseña</asp:LinkButton>
              

          <asp:LinkButton ID="lnkCrearUsuario" runat="server" style="margin-left: 15px" Width="150px" Height="19px" OnClick="lnkCrearUsuario_Click">Crear Usuario</asp:LinkButton>
              

        <asp:Button class="Imagenbtn"  ID="btnIngresar" runat="server" Text="Ingresar" style="margin-left: 250px" Width="70px" Height="25px" OnClientClick="return cerrarpagina();" OnClick="Button1_Click1" />

        

          <p>
              &nbsp;</p>

        

    </form>
    
    </body>
</html>
