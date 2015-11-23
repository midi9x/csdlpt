using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class _Default : System.Web.UI.Page
{
    DataBank data = new DataBank();
    protected void Page_Load(object sender, EventArgs e)
    {
        //grvTk.HeaderRow.TableSection = TableRowSection.TableHeader;
        sua.Enabled = false;
        txtNgayTao.Text = DateTime.Now.ToString();
        if (!IsPostBack)
        {
            FillGridView();
            DataTable table = data.GetLoaiTK();
            ddMaLoaiTK.DataSource = table;
            ddMaLoaiTK.DataTextField = "TenLoaiTK";
            ddMaLoaiTK.DataValueField = "MaLoaiTK";
            ddMaLoaiTK.DataBind();
            //=========
            DataTable table2 = data.GetKH();
            ddMaKH.DataSource = table2;
            ddMaKH.DataTextField = "TenKH";
            ddMaKH.DataValueField = "MaKH";
            ddMaKH.DataBind();

            if (Request.QueryString["action"] != null)
            {
                them.Enabled = false;
                sua.Enabled = true;
                string SoTK = Convert.ToString(Request.QueryString["SoTK"]);
                TaiKhoan tk = data.GetATaiKhoan(SoTK); 
                txtSoTK.Text = tk.SoTK;
                ddMaKH.Text = tk.MaKH.ToString() ;
                txtSoDu.Text = tk.SoDu.ToString();
                ddMaLoaiTK.Text = tk.MaLoaiTK.ToString();
                txtNgayTao.Text = tk.NgayTao.ToString();

            }
        }
    }

    private void FillGridView()
    {
        
        DataTable table = data.GetAllTaiKhoan();
        grvTk.DataSource = table;
        grvTk.DataBind();
    }

    public void Delete_Click(object b, CommandEventArgs e)
    {
        try
        {
            string SoTK = Convert.ToString(e.CommandArgument);
            data.DelTaiKhoan(SoTK);
            txtmsg.Text = "Xoa thanh cong";
            data.DongBo("exec msdb.dbo.sp_start_job N'MINHDINH-bank-may1-MAY1-14'");
            data.DongBo("exec msdb.dbo.sp_start_job N'MINHDINH-bank-may2-MAY2-15'");
            data.DongBo("exec msdb.dbo.sp_start_job N'MINHDINH-bank-may3-MAY3-12'");
            data.DongBo("exec msdb.dbo.sp_start_job N'MINHDINH-bank-may4-MAY4-16'");
            FillGridView();
        }
        catch (Exception ex)
        {
            txtmsg.Text = "Có lỗi xảy ra: " + ex.Message.ToString();

        }

    }

    public void Add()
    {
        try
        {
            TaiKhoan tk = new TaiKhoan();
            tk.SoTK = txtSoTK.Text;
            tk.MaKH = Convert.ToString(ddMaKH.Text);
            tk.SoDu = Convert.ToDecimal(txtSoDu.Text);
            tk.MaLoaiTK = Convert.ToString(ddMaLoaiTK.Text);
            tk.NgayTao = Convert.ToDateTime(txtNgayTao.Text);
            data.AddTaiKhoan(tk);
            txtmsg.Text = "Them thanh cong";
            data.DongBo("exec msdb.dbo.sp_start_job N'MINHDINH-bank-may1-MAY1-14'");
            data.DongBo("exec msdb.dbo.sp_start_job N'MINHDINH-bank-may2-MAY2-15'");
            data.DongBo("exec msdb.dbo.sp_start_job N'MINHDINH-bank-may3-MAY3-12'");
            data.DongBo("exec msdb.dbo.sp_start_job N'MINHDINH-bank-may4-MAY4-16'");
            FillGridView();
        }
        catch (Exception ex)
        {
            txtmsg.Text = "Có lỗi xảy ra: " + ex.Message.ToString();

        }
          
    }

    public void Update()
    {
        try
        {
            TaiKhoan tk = new TaiKhoan();
            tk.SoTK = txtSoTK.Text;
            tk.MaKH = ddMaKH.Text;
            tk.SoDu = Convert.ToDecimal(txtSoDu.Text);
            tk.MaLoaiTK = Convert.ToString(ddMaLoaiTK.Text);
            tk.NgayTao = Convert.ToDateTime(txtNgayTao.Text);
            data.UpdateTaiKhoan(tk);
            txtmsg.Text = "Them thanh cong";
            data.DongBo("exec msdb.dbo.sp_start_job N'MINHDINH-bank-may1-MAY1-14'");
            data.DongBo("exec msdb.dbo.sp_start_job N'MINHDINH-bank-may2-MAY2-15'");
            data.DongBo("exec msdb.dbo.sp_start_job N'MINHDINH-bank-may3-MAY3-12'");
            data.DongBo("exec msdb.dbo.sp_start_job N'MINHDINH-bank-may4-MAY4-16'");
            FillGridView();

        }
        catch (Exception ex)
        {
            txtmsg.Text = "Có lỗi xảy ra: " + ex.Message.ToString();

        }
    }
    protected void them_Click(object sender, EventArgs e)
    {
        Add();
        Reset();
    }
    protected void sua_Click(object sender, EventArgs e)
    {
        Update();
        Response.Redirect("Default.aspx");
    }
    public void Reset()
    {
        txtSoDu.Text = "";
        txtSoTK.Text = "";
        txtNgayTao.Text = "";
        ddMaKH.Text = "KH001";
        ddMaLoaiTK.Text = "ML001";
    }
}