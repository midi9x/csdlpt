using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LichSuGD : System.Web.UI.Page
{
    DataBank data = new DataBank();
    protected void Page_Load(object sender, EventArgs e)
    {
        grvGD.DataSource = data.GetGD(Session["SoThe"].ToString());
        grvGD.DataBind();
    }
    protected void grvGD_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grvGD.PageIndex = e.NewPageIndex;
        grvGD.DataSource = data.GetGD(Session["SoThe"].ToString());
        grvGD.DataBind();
    }
}