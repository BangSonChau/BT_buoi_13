public class KhachHang : People
{
  public KhachHang(string fullName, string phone, int dob, string maKh, int diemTichLuy) : base(fullName, phone, dob)
  {
    this.maKh = maKh;
    this.diemTichLuy = diemTichLuy;
  }

  public string maKh { get; set; }
  public int diemTichLuy { get; set; }

}