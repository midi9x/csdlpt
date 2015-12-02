<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ThanhCong.aspx.cs" Inherits="RutTien_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../css/StyleSheet.css" rel="stylesheet" />
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
            <div style="text-align:center;position:relative;">
               
                <p> Rút tiền thanh công!
                </p>
                 <p> Bạn có muốn tiếp tục thực hiện giao dịch không?
                </p>
            </div>
			<div class="select-single" style=" top: 20px;">
				<div class="area-single">Có</div>
				<div class="area-single">Thoát</div>
			</div>
		</div>

		<div class="right">
            <asp:Button ID="btnRight1" runat="server" CssClass="button-right" Text="" />
            <asp:Button ID="btnRight2" runat="server" CssClass="button-right" Text="" OnClick="btnRight2_Click" />
            <asp:Button ID="btnRight3" runat="server" CssClass="button-right" Text="" OnClick="btnRight3_Click" />
        </div>
	</div>
    </form>
</body>
</html>
