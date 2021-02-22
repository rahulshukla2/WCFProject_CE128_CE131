<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalcInterest.aspx.cs" Inherits="WcfServiceClientProj1.CalcInterest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
<!DOCTYPE html>

    <title></title>
    <form id="form2" runat="server">
        <div>
            <asp:LinkButton ID="LinkButton1" runat="server" BorderWidth="1px" PostBackUrl="~/HomePage.aspx">Home</asp:LinkButton>
            &nbsp;&nbsp;&nbsp;&nbsp;</div>
        <center>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" ForeColor="#CC99FF" Text="Calculate Interest"></asp:Label>
            <br />
            <br />
            <hr />
            <br />
            <br />
        
        <div>
            <asp:RadioButtonList ID="rdlist1" runat="server">
                <asp:ListItem>Simple Interest</asp:ListItem>
                <asp:ListItem>Compund Interest</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Enter Principal Amount"></asp:Label>
&nbsp;
            <asp:TextBox ID="prinAmt" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Enter Interest Rate(per year)"></asp:Label>
&nbsp;
            <asp:TextBox ID="rate" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Enter Tenure(in years)"></asp:Label>
&nbsp;
            <asp:TextBox ID="years" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Calculate" />
            <br />
            <br />
            <br />
            <asp:Label ID="msg" runat="server" Text="Label" Visible="False"></asp:Label>
        </div>
            </center>
    </form>
</body>
</html>
