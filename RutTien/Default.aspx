<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="RutTien_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../css/StyleSheet.css" rel="stylesheet" />
    <style>
        .area {
            top: -25px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
   <div id="container">
		<div class="left">
            <asp:Button ID="btnLeft500" runat="server" CssClass="button-left" Text="" OnClick="btnLeft500_Click" />
            <asp:Button ID="btnLeft10000" runat="server" CssClass="button-left" Text="" OnClick="btnLeft10000_Click" />
            <asp:Button ID="btnLeft20000" runat="server" CssClass="button-left" Text="" OnClick="btnLeft20000_Click" />
		</div>

		<div class="main-content">
            
            <center><p>Nhập số tiền cần rút</p></center>

			<div class="select-left">
				<div class="area">500,000 VND</div>
				<div class="area">1,000,000 VND</div>
				<div class="area">2,000,000 VND</div>
			</div>
			<div class="select-right">
				<div class="area">2,500,000 VND</div>
				<div class="area">5,000,000 VND</div>
				<div class="area">Thoát</div>
			</div>
		</div>

		<div class="right">
			<asp:Button ID="btnRight2500" runat="server" CssClass="button-right" Text="" OnClick="btnRight2500_Click" />
            <asp:Button ID="btnRight50000" runat="server" CssClass="button-right" Text="" OnClick="btnRight50000_Click" />
            <asp:Button ID="btnRightthoat" runat="server" CssClass="button-right" Text="" OnClick="btnRightthoat_Click" />
		</div>
	</div>
    </form>
</body>
</html>
