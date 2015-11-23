using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for GiaoDich
/// </summary>
public class GiaoDich
{
    public string MaGD { get; set; }
    public string SoThe { get; set; }
    public string MaLoaiGD { get; set; }
    public DateTime NgayGD { get; set; }
    public decimal SoTienGD { get; set; }
    public string ChiTietGD { get; set; }

    public GiaoDich(string MaGD, string SoThe, string MaLoaiGD, DateTime NgayGD, decimal SoTienGD,string ChiTietGD)
    {
        this.MaGD = MaGD;
        this.SoThe = SoThe;
        this.MaLoaiGD = MaLoaiGD;
        this.NgayGD = NgayGD;
        this.SoTienGD = SoTienGD;
        this.ChiTietGD = ChiTietGD;
    }
    public GiaoDich()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}