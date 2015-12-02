<%@ Page Language="C#" AutoEventWireup="true" CodeFile="NhapMaPin.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/StyleSheet.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="container">
		<div class="left">
            <asp:Button ID="btnLeft1" runat="server" CssClass="button-left" Text="" />
            <asp:Button ID="btnLeft2" runat="server" CssClass="button-left" Text="" />
            <asp:Button ID="btnLeft3" runat="server" CssClass="button-left" Text="" />
		</div>

		<div class="main-content">
           <p>Nhập mã pin</p> 
            <p style="color:red;font-size:15px;">
                <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>

            </p>
            <center>
                <asp:TextBox ID="txtPin" TextMode="Password" CssClass="txt-single" runat="server"></asp:TextBox>
            </center>
			<div class="select-single">
				<div class="area-single">Xác nhận</div>
				<div class="area-single">Thoát</div>
			</div>
		</div>

		<div class="right">
            <asp:Button ID="btnRight1" runat="server" CssClass="button-right" Text="" />
            <asp:Button ID="btnRight2" runat="server" CssClass="button-right" Text="" OnClick="btnRight2_Click" />
            <asp:Button ID="btnRight3" runat="server" CssClass="button-right" Text="" />
        </div>
	</div>
    </form>
</body>
</html>
