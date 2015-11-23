<%@ Page Language="C#" AutoEventWireup="true" CodeFile="XacNhan.aspx.cs" Inherits="RutTien_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="/css/StyleSheet.css" rel="stylesheet" />
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
            <div style="text-align: left;left: 160px; position: relative;font-size: 20px;padding-top: 20px;line-height: 30px;">
                Số tk nhận: <asp:Label ID="txttkNhan" runat="server" Text="Label"></asp:Label><br />
                Tên người nhận: <asp:Label ID="txtNguoiNhan" runat="server" Text="Label"></asp:Label><br />
                Số tiền chuyển:  <asp:Label ID="txtTien" runat="server" Text="Label"></asp:Label><br />
                Bấm xác nhận để đồng ý chuyển tiền ?
            </div>
			<div class="select-single" style="    top: -15px;">
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
