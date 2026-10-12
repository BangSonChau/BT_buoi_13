public class DanhSachNhanVien
{

  public List<NhanVien> lstNhanvien { get; set; }

  public DanhSachNhanVien(List<NhanVien> lstNhanvien)
  {
    this.lstNhanvien = lstNhanvien;
  }

  public bool them(NhanVien nv)
  {
    if (tim(nv.maNV) != null)
    {
      return false;
    }
    lstNhanvien.Add(nv);
    return true;
  }

  public bool xoa(string maNV)
  {
    var nv = tim(maNV);
    if (nv == null) return false;
    lstNhanvien.Remove(nv);
    return true;
  }

  public NhanVien? tim(string maNV)
  {
    foreach (NhanVien nv in lstNhanvien)
    {
      if (nv.maNV == maNV)
      {
        return nv;
      }
    }
    return null;
  }

  public List<NhanVien> timTheoChucVu(string chucVu)
  {
    return lstNhanvien.FindAll(nv => nv.chucVu == chucVu);
  }

  public decimal tongLuong()
  {
    decimal tong = 0;
    foreach (var nv in lstNhanvien)
    {
      tong += nv.luongThang;
    }
    return tong;
  }

  public void hienThi()
  {
    if (lstNhanvien.Count == 0)
    {
      Console.WriteLine("Danh sách trống.");
      return;
    }

    Console.WriteLine($"=== Danh sách nhân viên ({lstNhanvien.Count} người) ===");
    foreach (var nv in lstNhanvien)
    {
      Console.WriteLine(nv.moTa());
    }
    Console.WriteLine($"Tổng lương: {tongLuong():N0} đ");
  }
}