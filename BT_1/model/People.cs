public class People
{
  private string fullName;
  private string phone;
  private int dob;

  public People(string fullName, string phone, int dob)
  {
    this.fullName = fullName;
    this.phone = phone;
    this.dob = dob;
  }

  //getter, setter
  public string FullName { get => fullName; set => fullName = value; }

  public string Phone { get => phone; set => phone = value; }

  public int Dob { get => dob; set => dob = value; }

  public int Tuoi() => DateTime.Now.Year - Dob;
}