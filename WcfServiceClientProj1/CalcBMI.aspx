<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalcBMI.aspx.cs" Inherits="WcfServiceClientProj1.CalcBMI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:LinkButton ID="LinkButton1" runat="server" BorderWidth="1px" PostBackUrl="~/HomePage.aspx">Home</asp:LinkButton>
            &nbsp;&nbsp;&nbsp;&nbsp;</div>
        <center>
        <asp:Label ID="Label1" runat="server" Text="Body Mass Index" Font-Bold="True" Font-Size="XX-Large" ForeColor="#CC99FF" ></asp:Label>
        
            <br />
        
        <br />
        <hr />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Enter Height(in m)"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="height" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Enter Weight(in kg)"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="weight" runat="server"></asp:TextBox>
        <br />
        <br />
        &nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Calculate BMI" BackColor="#CC99FF" />
            <br />
            <br />
        <br />
        &nbsp;<asp:Label ID="msg" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        <br />
            </center>
    </form>
</body>
</html>
