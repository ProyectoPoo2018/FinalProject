﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RecuperarPassword.aspx.cs" Inherits="ProyectoFinalPoo.RecuperarPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Recuperar Passwd</title>
    <link href="centrarLogin.css" rel="stylesheet" />
</head>
<body >
    <form id="form1" runat="server" class="centrarswf">
        
        <asp:PasswordRecovery ID="PasswordRecovery1" runat="server">
        </asp:PasswordRecovery>
    </form>
</body>
</html>
