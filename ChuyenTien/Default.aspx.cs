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
            TaiKhoan tk = data.GetATaiKhoan(txtTkNhan.Text);
            if (tk == null)
            {
                Response.Write("<script>alert('Tài khoản không tồn tại'); </script>");
            }
            else
            {
                Session["tk"] = tk;
                Response.Redirect("NhapSoTien.aspx");
            }
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('" + ex.Message + "');</script>");
        }
        
    }
}