using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RutTien_Default : System.Web.UI.Page
{
    DataBank data = new DataBank();
    protected void Page_Load(object sender, EventArgs e)
    {
        TaiKhoan tk = (TaiKhoan)Session["tk"];
        txttkNhan.Text = tk.SoTK;
        txtNguoiNhan.Text = data.GetNguoiNhan(tk.SoTK);
        txtTien.Text = string.Format("{0:C}", Session["tien"]);
        
    }
    protected void btnRight2_Click(object sender, EventArgs e)
    {
        try
        {
            string SoThe = Session["SoThe"].ToString();
            decimal tienchuyen = Convert.ToDecimal(Session["tien"].ToString());
            decimal tienco = data.CheckTien(SoThe);
            TaiKhoan tk = (TaiKhoan)Session["tk"];
            if (tienco < tienchuyen - 50000)
            {
                Response.Write("<script>alert('Tài khoản không đủ để chuyển tiền');</script>");
            }
            else
            {
                GiaoDich gd = new GiaoDich();
                //mã giao dịch = mã giao dịch + 1 :3
                gd.MaGD = (data.GetMaxMaGD() + 1).ToString();
                gd.SoThe = SoThe;
                gd.MaLoaiGD = "ML001";
                gd.NgayGD = Convert.ToDateTime(DateTime.Now.ToString());
                gd.SoTienGD = tienchuyen;
                gd.ChiTietGD = "Chuyen " + string.Format("{0:C}", tienchuyen) + " den tai khoan " + tk.SoTK;
                data.AddGD(gd);
                //data.UpdateTien_TheoTK(tienchuyen,tk.SoTK);
                //data.UpdateTien_TheoThe(tienchuyen, SoThe);
                data.DongBo("exec msdb.dbo.sp_start_job N'MINHDINH-bank-may1-MAY1-14'");
                data.DongBo("exec msdb.dbo.sp_start_job N'MINHDINH-bank-may2-MAY2-15'");
                //data.DongBo("exec msdb.dbo.sp_start_job N'MINHDINH-bank-may3-MAY3-12'");
                //data.DongBo("exec msdb.dbo.sp_start_job N'MINHDINH-bank-may4-MAY4-16'");
                Response.Redirect("ThanhCong.aspx");
            }
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('" + ex.Message + "');</script>");
        }
        
    }
}