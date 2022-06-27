


string _silah, _kiyafet;
int _guc, _can, _defans;
char _cinsiyet;

Console.WriteLine("Karakterin cinsiyetini girin");
_cinsiyet = Convert.ToChar(Console.ReadLine());

Console.WriteLine("Karakterin güç değerini girin");
_guc = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Karakterin silahını girin");
_silah = Console.ReadLine();

Console.WriteLine("Karakterin kıyafetini girin");
_kiyafet = Console.ReadLine();

Console.WriteLine("Karakterin can değerini girin");
_can = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Karakterin defans değerini girin");
_defans = Convert.ToInt32(Console.ReadLine());

Karakter k1 = new Karakter(_cinsiyet, _guc, _silah, _kiyafet, _can, _defans);


class Karakter
{
    public Karakter(char Cinsiyet, int Guc, string Silah, string Kiyafet, int Can, int Defans)
    {
        Console.WriteLine("Cinsiyet: " + Cinsiyet);
        Console.WriteLine("Güç: " +Guc);
        Console.WriteLine("Silah: " + Silah);
        Console.WriteLine("Kıyafeti: " + Kiyafet);
        Console.WriteLine("Can değeri: " + Can);
        Console.WriteLine("Defans değeri: " + Defans);
    }
}
