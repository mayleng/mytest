<%@ Page Language="C#" AutoEventWireup="true" CodeFile="http.aspx.cs" Inherits="http" %>

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
        <asp:Button ID="Button1" runat="server" Text="正确" OnClick="Button1_Click" />
        <p>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="错误" />
        </p>
        <p>
            <asp:Button ID="Button3" runat="server" Text="其他" OnClick="Button3_Click" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button4" runat="server" Text="返回" OnClick="Button4_Click" />
        </p>
    </form>
</body>
</html>
