<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConvertEnergy.aspx.cs" Inherits="WcfServiceClientProj1.ConvertEnergy" %>

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
        <asp:Label ID="Label1" runat="server" Text="Energy Converter" Font-Bold="True" Font-Size="XX-Large" ForeColor="#CC99FF" ></asp:Label>
            <br />
            <hr />
            <br />
           
            <br />
            From&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlist1" runat="server">
                <asp:ListItem>Kilojoule</asp:ListItem>
                <asp:ListItem>joule</asp:ListItem>
                <asp:ListItem>calorie</asp:ListItem>
                <asp:ListItem>kilocalorie</asp:ListItem>
                <asp:ListItem>watt hour</asp:ListItem>
                <asp:ListItem>Kilowatt hour</asp:ListItem>
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; to&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlist2" runat="server">
                <asp:ListItem>Kilojoule</asp:ListItem>
                <asp:ListItem>joule</asp:ListItem>
                <asp:ListItem>calorie</asp:ListItem>
                <asp:ListItem>kilocalorie</asp:ListItem>
                <asp:ListItem>watt hour</asp:ListItem>
                <asp:ListItem>Kilowatt hour</asp:ListItem>
            </asp:DropDownList>
                &nbsp;<br />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Enter Energy Amount"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="amount" runat="server"></asp:TextBox>
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

