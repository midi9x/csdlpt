using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for KhachHang
/// </summary>
public class KhachHang
{
    public string MaKH { get; set; }
    public string TenKH { get; set; }
    public KhachHang()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public KhachHang(string MaKH, string TenKH)
    {
        this.MaKH = MaKH;
        this.TenKH = TenKH;
        
    }

}