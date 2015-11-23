using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for TaiKhoan
/// </summary>
public class TaiKhoan
{
    public string SoTK { get; set; }
    public string MaKH { get; set; }
    public decimal SoDu { get; set; }
    public string MaLoaiTK { get; set; }
    public DateTime NgayTao { get; set; }

	public TaiKhoan()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public TaiKhoan(string SoTK, string MaKH, decimal SoDu, string MaLoaiTK, DateTime NgayTao)
    {
        this.SoTK = SoTK;
        this.MaKH = MaKH;
        this.SoDu = SoDu;
        this.MaLoaiTK = MaLoaiTK;
        this.NgayTao = NgayTao;
    }
}