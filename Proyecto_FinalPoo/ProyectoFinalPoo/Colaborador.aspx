<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Colaborador.aspx.cs" Inherits="ProyectoFinalPoo.Colaborador" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
    
  <fieldset>
    <legend>Colaborador:</legend>
    
      <table style="width:100%;" >
          <tr style="  text-align:center;">
              <td >
                  <asp:HyperLink ID="hplHome" runat="server">HOME</asp:HyperLink>
              </td>
              <td>TEMAS</td>
              <td>
                  <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">SALIR</asp:LinkButton>
              </td>
          </tr>
          <tr style="  text-align:center;">
              <td>DATOS GENERALES</td>
              <td>NOTICIAS</td>
              <td>VINCULACION</td>
          </tr>
          <tr style="  text-align:center;">
              <td>ESTADISTICA</td>
              <td>MENSAJES</td>
              <td>INFORME</td>
          </tr>
      </table>
    
  </fieldset>

    </form>

</body>
</html>
