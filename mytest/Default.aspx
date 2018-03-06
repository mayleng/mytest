<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
     
            &nbsp;</div>
        <p>
            <asp:TextBox ID="TextBox1" runat="server" BackColor="Lime" BorderColor="#FF99FF" BorderStyle="Solid" BorderWidth="1px" Height="17px"  Width="80px"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="提交" Width="59px" OnClick="Button1_Click" />
        </p>
        <asp:TextBox ID="TextBox2" runat="server" BackColor="Lime" BorderColor="#FF66FF" BorderStyle="Solid" BorderWidth="1px" Height="17px" Width="80px"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="确定" Width="59px" />
        <br />
        <br />
        <br />
        &nbsp;<asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="log" />
        &nbsp; <asp:Button ID="Button7" runat="server" Text="测试下钻" OnClick="Button7_Click" />
        <br />
        <br />
        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="http状态码" />
        <br />
        <br />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="redis" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="配置文件"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" ></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="跳转页面" />
        <br />
       
        <p>
            <asp:Image ID="Image1" runat="server" Height="300px" ImageUrl="~/images/640 (1).jpg" Width="300px" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
