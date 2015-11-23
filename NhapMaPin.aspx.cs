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
            string SoThe = Session["SoThe"].ToString();

            bool checkpin = data.GetPin(SoThe, txtPin.Text);
            if (checkpin)
            {
                Response.Redirect("Home.aspx");
            }
            else lblmsg.Text = "Sai mã pin";
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('" + ex.Message + "');</script>");
        }
        

    }
}