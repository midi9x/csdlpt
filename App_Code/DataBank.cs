using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for DataBank
/// </summary>
public class DataBank
{
    SqlConnection con = new SqlConnection("Data Source=MINHDINH; Initial Catalog=bank; Integrated Security=true;User Id=sa;Password=123456");

    public DataTable GetAllTaiKhoan()
    {
        SqlDataAdapter adap = new SqlDataAdapter("SELECT * FROM TaiKhoan", con);
        DataTable table = new DataTable();
        adap.Fill(table);
        return table;
    }
    public TaiKhoan GetATaiKhoan(string SoTK) 
    {
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "SELECT * FROM TaiKhoan WHERE SoTK=@SoTK";
        cmd.Connection = con;
        cmd.Parameters.AddWithValue("@SoTK", SoTK);
        SqlDataReader rd = cmd.ExecuteReader();
        TaiKhoan tk = new TaiKhoan(); 
        if (rd.Read())
        {
            tk.SoTK = Convert.ToString(rd["SoTK"]);
            tk.MaKH = Convert.ToString(rd["MaKH"]);
            tk.SoDu = Convert.ToDecimal(rd["SoDu"]);
            tk.MaLoaiTK = Convert.ToString(rd["MaLoaiTK"]);
            tk.NgayTao = Convert.ToDateTime(rd["NgayTao"]);
        }
        else
        {
            tk = null;
        }
        con.Close();
        return tk;
    }
    public string Get_TK_The(string SoThe)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = @"SELECT		TaiKhoan.SoTK, KhachHang.TenKH	
                            FROM		TaiKhoan INNER JOIN The 
			                            ON		The.SoTK = TaiKhoan.SoTK 
			                            INNER JOIN KhachHang 
			                            ON TaiKhoan.MaKH = KhachHang.MaKH
                            WHERE		The.SoThe=@SoThe";
        cmd.Connection = con;
        cmd.Parameters.AddWithValue("@SoThe", SoThe);
        SqlDataReader rd = cmd.ExecuteReader();
        string tk;
        if (rd.Read())
        {
            tk = Convert.ToString(rd["SoTK"]);
        }
        else
        {
            tk = null;
        }
        con.Close();
        return tk;
    }
    public string Get_TenKH_The(string SoThe)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = @"SELECT		TaiKhoan.SoTK, KhachHang.TenKH	
                            FROM		TaiKhoan INNER JOIN The 
			                            ON		The.SoTK = TaiKhoan.SoTK 
			                            INNER JOIN KhachHang 
			                            ON TaiKhoan.MaKH = KhachHang.MaKH
                            WHERE		The.SoThe=@SoThe";
        cmd.Connection = con;
        cmd.Parameters.AddWithValue("@SoThe", SoThe);
        SqlDataReader rd = cmd.ExecuteReader();
        string kh;
        if (rd.Read())
        {
            kh = Convert.ToString(rd["TenKH"]);
        }
        else
        {
            kh = null;
        }
        con.Close();
        return kh;
    }
    public string GetNguoiNhan(string SoTK)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "SELECT TenKH FROM TaiKhoan INNER JOIN KhachHang ON TaiKhoan.MaKH = KhachHang.MaKH AND SoTK=@SoTK";
        cmd.Connection = con;
        cmd.Parameters.AddWithValue("@SoTK", SoTK);
        SqlDataReader rd = cmd.ExecuteReader();
        string nguoinhan;
        if (rd.Read())
        {
            nguoinhan = Convert.ToString(rd["TenKH"]);
        }
        else
        {
            nguoinhan = null;
        }
        con.Close();
        return nguoinhan;
    }
    public The GetAThe(string SoThe)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "SELECT * FROM The WHERE SoThe=@SoThe";
        cmd.Connection = con;
        cmd.Parameters.AddWithValue("@SoThe", SoThe);
        SqlDataReader rd = cmd.ExecuteReader();
        The t = new The();
        if (rd.Read())
        {

            t.SoThe = Convert.ToString(rd["SoThe"]);
            t.SoTK = Convert.ToString(rd["SoTK"]);
            t.MaPin = Convert.ToString(rd["MaPin"]);
            t.NgayTao = Convert.ToDateTime(rd["NgayTao"]);
            t.NgayHetHan = Convert.ToDateTime(rd["NgayHetHan"]);
            t.TinhTrang = Convert.ToInt32(rd["TinhTrang"]);
        }
        else
        {
            t = null;
        }
        con.Close();
        return t;
    }

    public decimal CheckTien(string SoThe)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "SELECT SoDu FROM The INNER JOIN TaiKhoan ON The.SoTK = TaiKhoan.SoTK WHERE SoThe=@SoThe";
        cmd.Connection = con;
        cmd.Parameters.AddWithValue("@SoThe", SoThe);
        SqlDataReader rd = cmd.ExecuteReader();
        decimal SoDu = 0;
        if (rd.Read())
        {
            SoDu = Convert.ToInt32(rd["SoDu"]);
            
        }
        con.Close();
        return SoDu;
    }
    public bool GetPin(string SoThe, string MaPin)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "SELECT * FROM The WHERE SoThe=@SoThe AND MaPin = @MaPin";
        cmd.Connection = con;
        cmd.Parameters.AddWithValue("@SoThe", SoThe);
        cmd.Parameters.AddWithValue("@MaPin", MaPin);
        SqlDataReader rd = cmd.ExecuteReader();
        bool check = false;
        if (rd.Read())
        {
            check =  true;
        }
        con.Close();
        return check;

    }

    public void DelTaiKhoan(string SoTK)
    {
        con.Open();
        SqlCommand cmd= new SqlCommand("DELETE  FROM TaiKhoan WHERE SoTK=@SoTK",con);
        cmd.Parameters.AddWithValue("@SoTK", SoTK);
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public void AddTaiKhoan(TaiKhoan tk)
    {
        string sql = "INSERT INTO TaiKhoan(SoTK,MaKH,SoDu,MaLoaiTK,NgayTao) VALUES(@SoTK, @MaKH, @SoDu, @MaLoaiTK, @NgayTao)";
        con.Open();
        SqlCommand cmd = new SqlCommand(sql,con);
        cmd.Parameters.AddWithValue("@SoTK", tk.SoTK);
        cmd.Parameters.AddWithValue("@MaKH", tk.MaKH);
        cmd.Parameters.AddWithValue("@SoDu", tk.SoDu);
        cmd.Parameters.AddWithValue("@MaLoaiTK", tk.MaLoaiTK);
        cmd.Parameters.AddWithValue("@NgayTao", tk.NgayTao);
        cmd.ExecuteNonQuery();
        con.Close();
    }

    public void AddGD(GiaoDich gd)
    {
        string sql = @"INSERT INTO GiaoDich(MaGD,SoThe,MaLoaiGD,NgayGD,SoTienGD,ChiTietGD)
                                            VALUES(@MaGD,@SoThe,@MaLoaiGD,@NgayGD,@SoTienGD,@ChiTietGD)";
        con.Open();
        SqlCommand cmd = new SqlCommand(sql, con);
        cmd.Parameters.AddWithValue("@MaGD", gd.MaGD);
        cmd.Parameters.AddWithValue("@SoThe", gd.SoThe);
        cmd.Parameters.AddWithValue("@MaLoaiGD", gd.MaLoaiGD);
        cmd.Parameters.AddWithValue("@NgayGD", gd.NgayGD);
        cmd.Parameters.AddWithValue("@SoTienGD", gd.SoTienGD);
        cmd.Parameters.AddWithValue("@ChiTietGD", gd.ChiTietGD);
        cmd.ExecuteNonQuery();
        con.Close();
    }

    public int GetMaxMaGD()
    {
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "SELECT MAX(CAST(MaGD AS Int)) As max FROM GiaoDich WHERE ISNUMERIC(MaGD)=1 ";
        cmd.Connection = con;
        SqlDataReader rd = cmd.ExecuteReader();
        int magd = 0;
        if (rd.Read())
        {
            magd = Convert.ToInt32(rd["max"]);
        }
        con.Close();
        return magd;
    }

    public void UpdateTaiKhoan(TaiKhoan tk)
    {
        string sql = "UPDATE TaiKhoan SET MaKH=@MaKH, SoDu=@SoDu, MaLoaiTK=@MaLoaiTK, NgayTao=@NgayTao WHERE SoTK=@SoTK";
        con.Open();
        SqlCommand cmd = new SqlCommand(sql,con);
        cmd.Parameters.AddWithValue("@SoTK", tk.SoTK);
        cmd.Parameters.AddWithValue("@MaKH", tk.MaKH);
        cmd.Parameters.AddWithValue("@SoDu", tk.SoDu);
        cmd.Parameters.AddWithValue("@MaLoaiTK", tk.MaLoaiTK);
        cmd.Parameters.AddWithValue("@NgayTao", tk.NgayTao);
        cmd.ExecuteNonQuery();
        con.Close();
    }

    public void UpdateTien_TheoThe(decimal tien, string SoThe)
    {
        con.Open();
        string sql = @"UPDATE TaiKhoan SET SoDu = SoDu - @tien 
                            WHERE SoTK =    (   SELECT      TaiKhoan.SoTK
                                                FROM        TaiKhoan
                                                            INNER JOIN The 
                                                            ON TaiKhoan.SoTK = The.SoTK WHERE SoThe = @SoThe
                                            )";
        SqlCommand cmd = new SqlCommand(sql,con);
        cmd.Parameters.AddWithValue("@SoThe", SoThe);
        cmd.Parameters.AddWithValue("@tien", tien);
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public void NapTien(decimal tien, string SoThe)
    {
        con.Open();
        string sql = @"UPDATE TaiKhoan SET SoDu = SoDu + @tien 
                            WHERE SoTK =    (   SELECT      TaiKhoan.SoTK
                                                FROM        TaiKhoan
                                                            INNER JOIN The 
                                                            ON TaiKhoan.SoTK = The.SoTK WHERE SoThe = @SoThe
                                            )";
        SqlCommand cmd = new SqlCommand(sql, con);
        cmd.Parameters.AddWithValue("@SoThe", SoThe);
        cmd.Parameters.AddWithValue("@tien", tien);
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public void UpdateTien_TheoTK(decimal tien, string SoTK)
    {
        con.Open();
        string sql = "UPDATE TaiKhoan SET SoDu=SoDu + @tien WHERE SoTK=@SoTK";
        SqlCommand cmd = new SqlCommand(sql,con);
        cmd.Parameters.AddWithValue("@SoTK", SoTK);
        cmd.Parameters.AddWithValue("@tien", tien);
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public void DongBo(string sql)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand(sql, con);
        cmd.ExecuteNonQuery();
        con.Close();
    }

    public DataTable GetLoaiTK()
    {
        SqlDataAdapter adap = new SqlDataAdapter("SELECT * FROM LoaiTaiKhoan", con);
        DataTable table = new DataTable();
        adap.Fill(table);
        return table;
    }
    public DataTable GetKH()
    {
        SqlDataAdapter adap = new SqlDataAdapter("SELECT * FROM KhachHang", con);
        DataTable table = new DataTable();
        adap.Fill(table);
        return table;
    }
    public DataTable GetGD(string SoThe)
    {
        SqlDataAdapter adap = new SqlDataAdapter(@"SELECT GiaoDich.*, CONVERT(varchar, CAST(SoTienGD AS money), 1) AS TienGD, TenLoaiGD FROM GiaoDich INNER JOIN LoaiGiaoDich 
                                                    ON GiaoDich.MaLoaiGD = LoaiGiaoDich.MaLoaiGD WHERE SoThe = " + SoThe + " Order BY CAST(MaGD AS Int) ", con);
        DataTable table = new DataTable();
        adap.Fill(table);
        return table;
    }
   
	public DataBank()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}