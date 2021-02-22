<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConvertTemp.aspx.cs" Inherits="WcfServiceClientProj1.ConvertTemp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <!--<center>-->
        <div>
        &nbsp;<asp:LinkButton ID="LinkButton1" runat="server" BorderWidth="1px" PostBackUrl="~/HomePage.aspx">Home</asp:LinkButton>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <center>
        <asp:Label ID="Label1" runat="server" Text="Temperature Converter" Font-Bold="True" Font-Size="XX-Large" ForeColor="#CC99FF" ></asp:Label>
            <br />
            <hr />
            <br />
           
            <br />
            From&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlist1" runat="server">
                <asp:ListItem Value="0">Celsius</asp:ListItem>
                <asp:ListItem Value="1">Fahrenheit</asp:ListItem>
                <asp:ListItem Value="2">Kelvin</asp:ListItem>
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; to&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlist2" runat="server">
                <asp:ListItem Value="0">Celsius</asp:ListItem>
                <asp:ListItem Value="1">Fahrenheit</asp:ListItem>
                <asp:ListItem Value="2">Kelvin</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Enter Temperature"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="temp" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Convert" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:Label ID="msg" runat="server" Text="Label" Visible="False"></asp:Label>
            <br />
        </div>
            </center>
    </form>
</body>
</html>
