/* Homework :)))
 */

List<Ogrenci> Students = new List<Ogrenci> { };
Console.WriteLine("Sınıfta kaç öğrenci var?");
int maxstudents = Convert.ToInt32(Console.ReadLine());

for (var sayac = 0; sayac < maxstudents; sayac = sayac + 1)
{
    Console.WriteLine($"{sayac + 1}.  Öğrencinin adını giriniz.");
    var Name = Console.ReadLine();
    Console.WriteLine($"{sayac + 1}. Öğrencinin vize notunu giriniz.");
    var Visa = Console.ReadLine();
    Console.WriteLine($"{sayac + 1}. Öğrencinin final notunu giriniz.");
    var Final = Console.ReadLine();

    Students.Add(new Ogrenci() { Name = Name, Lesson = new Lesson { Visa = Convert.ToInt32(Visa), Final = Convert.ToInt32(Final) } }) ;
}

foreach (var student in Students)
{
    Console.WriteLine ($"{student.Name} adlı öğrencinin notu : {student.Lesson.GetResult()} , Puanı : {student.Lesson.GetPoint()}");
}
Console.ReadLine();

public class Ogrenci {
public string Name { get; set; }    
public Lesson Lesson { get; set; }    = new Lesson();


}


public class Lesson

{
    public string GetResult()
    {
        if (GetPoint() <= 35)
        {
            return "FF";
        }
        else if (GetPoint() <= 40)
        {
            return "FD";
        }
        else if (GetPoint() <= 45)
        {
            return "DD";
        }
        else if (GetPoint() <= 60)
        {
            return "DC";
        }
        else if (GetPoint() < 70)
        {
            return "CC";
        }
        else if (GetPoint() < 80)
        {
            return "BB";
        }
        else
        {
            return "AA";
        }
    }
    public int Visa { get; set; }
    public int Final { get; set; }
    public int GetPoint()
    {
        return Visa * 40 / 100 + Final * 60 / 100;
    }

}












