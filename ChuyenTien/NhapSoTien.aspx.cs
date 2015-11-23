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
    }
    protected void btnRight2_Click(object sender, EventArgs e)
    {
        try
        {
            string SoThe = Session["SoThe"].ToString();
            decimal tienchuyen = Convert.ToDecimal(txtTien.Text.ToString());
            decimal tienco = data.CheckTien(SoThe);
            if (tienco < tienchuyen - 50000)
            {
                Response.Write("<script>alert('Tài khoản không đủ để chuyển tiền');</script>");
            }
            else
            {
                Session["tien"] = tienchuyen;
                Response.Redirect("XacNhan.aspx");
            }
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('" + ex.Message + "');</script>");
        }
       
        
    }
}