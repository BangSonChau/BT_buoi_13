List<NhanVien> nhanViens = new List<NhanVien>();

DanhSachNhanVien danhSachNhanVien = new DanhSachNhanVien(nhanViens);

NhanVien nv = new NhanVien("Son", "0934104327", 2006, "SE203452", "DEV", 20000);

int choice;

do
{
  choice = Convert.ToInt32(Console.ReadLine());
  switch (choice)
  {
    case 1:
      {
        danhSachNhanVien.them(nv);
      }
      break;
    case 2:
      {
        danhSachNhanVien.xoa(Console.ReadLine());
      }
      break;
    case 3:
      {
        danhSachNhanVien.timTheoChucVu(Console.ReadLine());
      }
      break;
    case 4:
      {
        danhSachNhanVien.hienThi();
      }
      break;
    case 5:
      {
        Console.WriteLine(danhSachNhanVien.tongLuong());
      }
      break;
  }
} while (choice != 0);
