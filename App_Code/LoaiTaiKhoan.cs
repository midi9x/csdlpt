using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for LoaiTaiKhoan
/// </summary>
public class LoaiTaiKhoan
{
    public string MaLoaiTK { get; set; }
    public string TenLoaiTK { get; set; }
        
	public LoaiTaiKhoan()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public LoaiTaiKhoan(string MaLoaiTK, string TenLoaiTK)
    {
        this.MaLoaiTK = MaLoaiTK;
        this.TenLoaiTK = TenLoaiTK;
        //
        // TODO: Add constructor logic here
        //
    }
}