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
   
    protected void btnLeft500_Click(object sender, EventArgs e)
    {
        
            string SoThe = Session["SoThe"].ToString();
            decimal tien = data.CheckTien(SoThe);
            if (tien < 450000)
            {
                Response.Write("<script>alert('Tài khoản không đủ để rút tiền');</script>");
            }
            else
            {
                //xu ly rut tien
                GiaoDich gd = new GiaoDich();
                //mã giao dịch = mã giao dịch + 1 :3
                gd.MaGD = (data.GetMaxMaGD() + 1).ToString();
                gd.SoThe = SoThe;
                gd.MaLoaiGD = "ML002";
                gd.NgayGD = Convert.ToDateTime(DateTime.Now.ToString());
                gd.SoTienGD = 500000;
                gd.ChiTietGD = "Rut tien 500,000 VND";
                data.AddGD(gd);
                //data.UpdateTien_TheoThe(500000, SoThe);
                data.DongBo("exec msdb.dbo.sp_start_job N'MINHDINH-bank-may1-MAY1-14'");
                data.DongBo("exec msdb.dbo.sp_start_job N'MINHDINH-bank-may2-MAY2-15'");
                //data.DongBo("exec msdb.dbo.sp_start_job N'MINHDINH-bank-may3-MAY3-12'");
                //data.DongBo("exec msdb.dbo.sp_start_job N'MINHDINH-bank-may4-MAY4-16'");
                Response.Redirect("ThanhCong.aspx");
            }
         
        
    }
    protected void btnLeft10000_Click(object sender, EventArgs e)
    {
        try
        {
            string SoThe = Session["SoThe"].ToString();
            decimal tien = data.CheckTien(SoThe);
            if (tien < 950000)
            {
                Response.Write("<script>alert('Tài khoản không đủ để rút tiền');</script>");
            }
            else
            {
                //xu ly rut tien
                GiaoDich gd = new GiaoDich();
                //mã giao dịch = mã giao dịch + 1 :3
                gd.MaGD = (data.GetMaxMaGD() + 1).ToString();
                gd.SoThe = SoThe;
                gd.MaLoaiGD = "ML002";
                gd.NgayGD = Convert.ToDateTime(DateTime.Now.ToString());
                gd.SoTienGD = 1000000;
                gd.ChiTietGD = "Rut tien 1,000,000 VND";
                data.AddGD(gd);
                //data.UpdateTien_TheoThe(1000000, SoThe);
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
    protected void btnLeft20000_Click(object sender, EventArgs e)
    {
        try
        {
            string SoThe = Session["SoThe"].ToString();
            decimal tien = data.CheckTien(SoThe);
            if (tien < 1950000)
            {
                Response.Write("<script>alert('Tài khoản không đủ để rút tiền');</script>");
            }
            else
            {
                //xu ly rut tien
                GiaoDich gd = new GiaoDich();
                //mã giao dịch = mã giao dịch + 1 :3
                gd.MaGD = (data.GetMaxMaGD() + 1).ToString();
                gd.SoThe = SoThe;
                gd.MaLoaiGD = "ML002";
                gd.NgayGD = Convert.ToDateTime(DateTime.Now.ToString());
                gd.SoTienGD = 2000000;
                gd.ChiTietGD = "Rut tien 2,000,000 VND";
                data.AddGD(gd);
               // data.UpdateTien_TheoThe(2000000, SoThe);
                data.DongBo("exec msdb.dbo.sp_start_job N'MINHDINH-bank-may1-MAY1-14'");
                data.DongBo("exec msdb.dbo.sp_start_job N'MINHDINH-bank-may2-MAY2-15'");
                //data.DongBo("exec msdb.dbo.sp_start_job N'MINHDINH-bank-may3-MAY3-12'");
               // data.DongBo("exec msdb.dbo.sp_start_job N'MINHDINH-bank-may4-MAY4-16'");
                Response.Redirect("ThanhCong.aspx");
            }
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('" + ex.Message + "');</script>");
        }
        
    }
    protected void btnRight2500_Click(object sender, EventArgs e)
    {
        try
        {
            string SoThe = Session["SoThe"].ToString();
            decimal tien = data.CheckTien(SoThe);
            if (tien < 2450000)
            {
                Response.Write("<script>alert('Tài khoản không đủ để rút tiền');</script>");
            }
            else
            {
                //xu ly rut tien
                GiaoDich gd = new GiaoDich();
                //mã giao dịch = mã giao dịch + 1 :3
                gd.MaGD = (data.GetMaxMaGD() + 1).ToString();
                gd.SoThe = SoThe;
                gd.MaLoaiGD = "ML002";
                gd.NgayGD = Convert.ToDateTime(DateTime.Now.ToString());
                gd.SoTienGD = 2500000;
                gd.ChiTietGD = "Rut tien 2,500,000 VND";
                data.AddGD(gd);
               // data.UpdateTien_TheoThe(2500000, SoThe);
                data.DongBo("exec msdb.dbo.sp_start_job N'MINHDINH-bank-may1-MAY1-14'");
                data.DongBo("exec msdb.dbo.sp_start_job N'MINHDINH-bank-may2-MAY2-15'");
              //  data.DongBo("exec msdb.dbo.sp_start_job N'MINHDINH-bank-may3-MAY3-12'");
              //  data.DongBo("exec msdb.dbo.sp_start_job N'MINHDINH-bank-may4-MAY4-16'");
                Response.Redirect("ThanhCong.aspx");
            }
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('" + ex.Message + "');</script>");
        }
        
    }
    protected void btnRight50000_Click(object sender, EventArgs e)
    {
        try
        {
            string SoThe = Session["SoThe"].ToString();
            decimal tien = data.CheckTien(SoThe);
            if (tien < 4500000)
            {
                Response.Write("<script>alert('Tài khoản không đủ để rút tiền');</script>");
            }
            else
            {
                //xu ly rut tien
                GiaoDich gd = new GiaoDich();
                //mã giao dịch = mã giao dịch + 1 :3
                gd.MaGD = (data.GetMaxMaGD() + 1).ToString();
                gd.SoThe = SoThe;
                gd.MaLoaiGD = "ML002";
                gd.NgayGD = Convert.ToDateTime(DateTime.Now.ToString());
                gd.SoTienGD = 5000000;
                gd.ChiTietGD = "Rut tien 5,000,000 VND";
                data.AddGD(gd);
                //data.UpdateTien_TheoThe(5000000, SoThe);
                data.DongBo("exec msdb.dbo.sp_start_job N'MINHDINH-bank-may1-MAY1-14'");
                data.DongBo("exec msdb.dbo.sp_start_job N'MINHDINH-bank-may2-MAY2-15'");
               // data.DongBo("exec msdb.dbo.sp_start_job N'MINHDINH-bank-may3-MAY3-12'");
                //data.DongBo("exec msdb.dbo.sp_start_job N'MINHDINH-bank-may4-MAY4-16'");
                Response.Redirect("ThanhCong.aspx");
            }
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('" + ex.Message + "');</script>");
        }
        
    }
    protected void btnRightthoat_Click(object sender, EventArgs e)
    {
        Response.Redirect("/Home.aspx");
    }
}