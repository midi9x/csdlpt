<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LichSuGD.aspx.cs" Inherits="LichSuGD" %>

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
           <p>Lịch sử giao dịch</p> 
            <center>
                
                <asp:GridView BorderColor="White" ID="grvGD"  PageSize="4" AllowPaging="true" runat="server" AutoGenerateColumns="False" DataKeyNames="MaGD" OnPageIndexChanging="grvGD_PageIndexChanging">
                    <HeaderStyle BackColor="#19A4E6"  />
                    <Columns>
                        <asp:BoundField ItemStyle-HorizontalAlign="Center" ItemStyle-VerticalAlign="Middle" ItemStyle-Width="30" HeaderStyle-Width="30" DataField="MaGD" HeaderText="MaGD" ReadOnly="True" SortExpression="MaGD" />
                        <asp:BoundField ItemStyle-HorizontalAlign="Center" ItemStyle-VerticalAlign="Middle" ItemStyle-Width="40" HeaderStyle-Width="40" DataField="TenLoaiGD" HeaderText="LoaiGD" SortExpression="TenLoaiGD" />
                        <asp:BoundField ItemStyle-HorizontalAlign="Center" ItemStyle-VerticalAlign="Middle" ItemStyle-Width="70" HeaderStyle-Width="70" DataField="SoThe" HeaderText="SoThe" SortExpression="SoThe" />
                        <asp:BoundField ItemStyle-HorizontalAlign="Center" ItemStyle-VerticalAlign="Middle" ItemStyle-Width="60" HeaderStyle-Width="60" DataField="NgayGD" HeaderText="NgayGD" SortExpression="NgayGD" />
                        <asp:BoundField ItemStyle-HorizontalAlign="Center" ItemStyle-VerticalAlign="Middle" ItemStyle-Width="100" HeaderStyle-Width="100" DataField="TienGD" HeaderText="SoTienGD" SortExpression="SoTienGD" />
                        <asp:BoundField ItemStyle-HorizontalAlign="Center" ItemStyle-VerticalAlign="Middle" ItemStyle-Width="190" HeaderStyle-Width="190" DataField="ChiTietGD" HeaderText="ChiTietGD" SortExpression="ChiTietGD" />
                    </Columns>
                </asp:GridView>
                  </center>
			<div class="select-single">
				
			</div>
            
		</div>

		<div class="right">
            <asp:Button ID="btnRight1" runat="server" CssClass="button-right" Text="" />
            <asp:Button ID="btnRight2" runat="server" CssClass="button-right" Text="" />
            <a class="button-right" href="/Home.aspx"></a>
        </div>
	</div>
    </form>
</body>
</html>
