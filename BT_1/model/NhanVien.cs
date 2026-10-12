public class NhanVien : People
{
  public NhanVien(string fullName, string phone, int dob, string maNV, string chucVu, decimal luongThang) : base(fullName, phone, dob)
  {
    this.maNV = maNV;
    this.chucVu = chucVu;
    this.luongThang = luongThang;
  }

  public string maNV { get; set; }
  public string chucVu { get; set; }
  public decimal luongThang { get; set; }

  public decimal tienThuong() => luongThang * 0.1m;

  public string moTa() => $"{maNV} · {FullName} · {Tuoi()} tuổi · {chucVu} · {luongThang:N0} đ · thưởng {tienThuong():N0} đ";
}