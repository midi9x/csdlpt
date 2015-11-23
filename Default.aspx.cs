using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    DataBank data = new DataBank();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnRight2_Click(object sender, EventArgs e)
    {
        try 
        {
            The t = new The();
            string SoThe = txtThe.Text;
            t = data.GetAThe(SoThe);
            if (t != null)
            {
                Session["SoThe"] = SoThe.ToString();
                Response.Redirect("NhapMaPin.aspx");
            }
            else
            {
                lblmsg.Text = "Thẻ không tồn tại";
            }
        }
        catch(Exception ex)
        {
            Response.Write("<script>alert('"+ex.Message+"');</script>");
        }
        
    }
}