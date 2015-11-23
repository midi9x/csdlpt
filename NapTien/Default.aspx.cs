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

    }
    protected void btnRight2_Click(object sender, EventArgs e)
    {
        try
        {
            decimal tiennap = Convert.ToDecimal(txtTienNap.Text);
            if (tiennap >= 50000 && tiennap % 50000 == 0)
            {
                //data.NapTien(tiennap, Session["SoThe"].ToString());
                string SoThe = Session["SoThe"].ToString();
                GiaoDich gd = new GiaoDich();
                //mã giao dịch = mã giao dịch + 1 :3
                gd.MaGD = (data.GetMaxMaGD() + 1).ToString();
                gd.SoThe = SoThe;
                gd.MaLoaiGD = "ML003";
                gd.NgayGD = Convert.ToDateTime(DateTime.Now.ToString());
                gd.SoTienGD = tiennap;
                gd.ChiTietGD = "Nap " + string.Format("{0:C}", tiennap) + " vao tai khoan";
                data.AddGD(gd);
                //data.UpdateTien_TheoThe(500000, SoThe);
                data.DongBo("exec msdb.dbo.sp_start_job N'MINHDINH-bank-may1-MAY1-14'");
                data.DongBo("exec msdb.dbo.sp_start_job N'MINHDINH-bank-may2-MAY2-15'");
                //data.DongBo("exec msdb.dbo.sp_start_job N'MINHDINH-bank-may3-MAY3-12'");
                //data.DongBo("exec msdb.dbo.sp_start_job N'MINHDINH-bank-may4-MAY4-16'");
                Response.Redirect("ThanhCong.aspx");
               
            }
            else
            {
                txtTienNap.Text = "";
                Response.Write("<script>alert('Số tiền nạp không hợp lệ');</script>");
            }
            
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('" + ex.Message + "');</script>");
        }
        
    }
}