using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for The
/// </summary>
public class The
{
    public string SoThe { get; set; }
    public string SoTK { get; set; }
    public string MaPin { get; set; }   
    public DateTime NgayTao { get; set; }
    public DateTime NgayHetHan { get; set; }
    public int TinhTrang { get; set; }
    public The(string SoThe, string SoTK, string MaPin, DateTime NgayTao, DateTime NgayHetHan, int TinhTrang)
    {
        this.SoThe = SoThe;
        this.SoTK = SoTK;
        this.MaPin = MaPin;
        this.NgayTao = NgayTao;
        this.NgayHetHan = NgayHetHan;
        this.TinhTrang = TinhTrang;
    }
    public The()
	{
		
	}
}