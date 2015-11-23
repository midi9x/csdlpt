<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

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
			<a class="button-left" href="/RutTien" ></a>
			<a class="button-left" href="/ChuyenTien"></a>
			<a class="button-left" href="KiemTraTaiKhoan.aspx"></a>
		</div>

		<div class="main-content">
			<div class="select-left">
				<div class="area">Rút tiền</div>
				<div class="area">Chuyển tiền</div>
				<div class="area">Kiểm tra tài khoản</div>
			</div>
			<div class="select-right">
				<div class="area">Lịch sử GD</div>
				<div class="area">Nạp tiền</div>
				<div class="area">Thoát</div>
			</div>
		</div>

		<div class="right">

			<a class="button-right" href="LichSuGD.aspx"></a>
			<a class="button-right" href="/NapTien"></a>
			<a class="button-right" href="/"></a>
		</div>
	</div>
    </form>
</body>
</html>
