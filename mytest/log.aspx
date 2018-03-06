<%@ Page Language="C#" AutoEventWireup="true" CodeFile="log.aspx.cs" Inherits="log" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="Button1" runat="server" Text="log4net" OnClick="Button1_Click" />
        <p>
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="NLog" />
        </p>
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="返回" />
    </form>
    
</body>
</html>
