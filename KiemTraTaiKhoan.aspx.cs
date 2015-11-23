using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class KiemTraTaiKhoan : System.Web.UI.Page
{
    DataBank data = new DataBank();
    protected void Page_Load(object sender, EventArgs e)
    {
        txtHoten.Text = data.Get_TenKH_The(Session["SoThe"].ToString());
        txtTK.Text = data.Get_TK_The(Session["SoThe"].ToString());
        decimal tien = Convert.ToDecimal(data.CheckTien(Session["SoThe"].ToString()));
        txtTien.Text = string.Format("{0:C}", tien);
        
    }
    protected void btnRight2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Home.aspx");
    }
    protected void btnRight3_Click(object sender, EventArgs e)
    {
        Response.Redirect("/");
    }
}