using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for LoaiGD
/// </summary>
public class LoaiGD
{

    public string MaLoaiGD { get; set; }
    public string TenLoaiGD { get; set; }
    public LoaiGD(string MaLoaiGD, string TenLoaiGD)
    {
        this.MaLoaiGD = MaLoaiGD;
        this.TenLoaiGD = TenLoaiGD;
    }
    public LoaiGD()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}