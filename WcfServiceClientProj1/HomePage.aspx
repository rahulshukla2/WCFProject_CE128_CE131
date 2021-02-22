<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="WcfServiceClientProj1.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <center>
        <asp:Label ID="Label1" runat="server" Text="Unit Converter" Font-Bold="True" Font-Size="XX-Large" ForeColor="#CC99FF" ></asp:Label>
        </center>
        <br />
        <hr />
        <br />
        <br />
        <br />
        <br />
        <asp:Menu ID="Menu1" CssClass="Menu" runat="server" BorderColor="#CC33FF">
            <Items>
                <asp:MenuItem Text="Calculate BMI" Value="Calculate BMI" NavigateUrl="~/CalcBMI.aspx"></asp:MenuItem>
                <asp:MenuItem Text="Length Converter" Value="Length Converter" NavigateUrl="~/ConvertLength.aspx"></asp:MenuItem>
                <asp:MenuItem Text="Temperature Converter" Value="Temperature Converter" NavigateUrl="~/ConvertTemp.aspx"></asp:MenuItem>
                <asp:MenuItem Text="Mass Converter" Value="Mass Converter" NavigateUrl="~/ConvertMass.aspx"></asp:MenuItem>
                <asp:MenuItem Text="Energy Converter" Value="Energy Converter" NavigateUrl="~/ConvertEnergy.aspx"></asp:MenuItem>
                <asp:MenuItem Text="Calculate Interest" Value="Calculate Interest" NavigateUrl="~/CalcInterest.aspx"></asp:MenuItem>
            </Items>
        </asp:Menu>
    </form>
</body>
</html>
