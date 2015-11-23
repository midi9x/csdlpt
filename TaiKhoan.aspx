<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TaiKhoan.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Nhóm 4 - Hệ Thống Thông Tin K7</title>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <link href="css/bootstrap-theme.min.css" rel="stylesheet" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <script src="js/bootstrap.min.js"></script>
</head>
<body>
  <form id="form1" runat="server" class="form-horizontal">
    <div class="container">
    <div class="row">
        <br />
        <div class="form-group">
            <label  class="col-md-2 col-md-offset-3">Số TK</label>
            <div class="col-sm-3 ">
                <asp:TextBox ID="txtSoTK" CssClass="form-control" runat="server" />
            </div>
        </div>

        <div class="form-group">
            <label  class="col-md-2 col-md-offset-3">Khách Hàng</label>
            <div class="col-sm-3 ">
                <asp:DropDownList ID="ddMaKH" CssClass="form-control" runat="server" />
            </div>
        </div>

        <div class="form-group">
            <label  class="col-md-2 col-md-offset-3">Số Dư</label>
            <div class="col-sm-3 ">
                  <asp:TextBox ID="txtSoDu" CssClass="form-control" runat="server" />
            </div>
        </div>

        <div class="form-group">
            <label  class="col-md-2 col-md-offset-3">Loại Tài Khoản</label>
            <div class="col-sm-3 ">
                 <asp:DropDownList CssClass="form-control" ID="ddMaLoaiTK" runat="server" />
            </div>
        </div>

        <div class="form-group">
            <label  class="col-md-2 col-md-offset-3">Ngày Tạo</label>
            <div class="col-sm-3 ">
                 <asp:TextBox ID="txtNgayTao" CssClass="form-control"  runat="server" />
            </div>
        </div>

        <div class="form-group">
             <div class="col-md-offset-5">
                <asp:Button ID="them" Text="Thêm" CssClass="btn btn-success" runat="server" OnClick="them_Click"  />
                <asp:Button ID="sua" Text="Sửa" CssClass="btn btn-warning" runat="server" OnClick="sua_Click" />
                <input type="reset" value="Reset" class="btn btn-danger"/>
             </div>
       </div>
       <div class="form-group">
             <div>
                <h3 style="text-align:center"><asp:Label ID="txtmsg" runat="server"></asp:Label></h3>
             </div>
       </div>
    </div>
                

    <h2>Danh sách tài khoản</h2>
    <asp:GridView CssClass="table table-striped table-bordered table-hover" ID="grvTk" runat="server"
	AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="SoTK" HeaderText="SoTK" />
            <asp:BoundField DataField="MaKH" HeaderText="MaKH" />
            <asp:BoundField DataField="SoDu" HeaderText="SoDu" />
            <asp:BoundField DataField="MaLoaiTK" HeaderText="MaLoaiTK" />
            <asp:BoundField DataField="NgayTao" HeaderText="NgayTao" />

            <asp:HyperLinkField DataNavigateUrlFields="SoTK" DataNavigateUrlFormatString="?SoTK={0}&action=edit"
                Text="Sửa" HeaderText="Sửa"></asp:HyperLinkField>

            <asp:TemplateField HeaderText="Xóa">
                <ItemTemplate>
                    <asp:Button ID="btndel"  CssClass="btn btn-danger" Text="Xóa" runat="server" 
                    OnClientClick="return confirm('Bạn có muốn xóa không?')"
                    OnCommand="Delete_Click"
                    CommandName="Xoa"
                    CommandArgument='<%# Eval("SoTK") %>' />
                </ItemTemplate>
            </asp:TemplateField>
           
            
        </Columns>
    </asp:GridView>


    </div>
    </form>
</body>
</html>
