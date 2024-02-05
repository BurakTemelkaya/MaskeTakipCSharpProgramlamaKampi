// See https://aka.ms/new-console-template for more information

//Degiskenler();

using Business.Concrete;
using Entites.Concrete;

Selamver("Burak");
Selamver("Engin");
Selamver("Ahmet");
Selamver();

int sonuc = Topla(new Random().Next(0, int.MaxValue / 2), new Random().Next(0, int.MaxValue / 2));

string[] ogrenciler = new string[3];

ogrenciler[0] = "Engin";
ogrenciler[1] = "Burak";
ogrenciler[2] = "Berkay";

for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}

string[] sehirler1 = ["Ankara", "İstanbul", "İzmir"];
string[] sehirler2 = ["Bursa", "Antalya", "Diyarbakır"];
sehirler2 = sehirler1;

foreach (string sehir in sehirler1)
{
    Console.WriteLine(sehir);
}

List<string> yeniSehirler = new() { "Ankara", "İstanbul", "İzmir" };
yeniSehirler.Add("İzmir");

foreach (var sehir in yeniSehirler)
{
    Console.WriteLine(sehir);
}

Console.WriteLine(sehirler2[0]);

Person person1 = new Person();
person1.FirstName = "Burak";
person1.LastName = "Temelkaya";
person1.NationalIdentity = 12345678910;
person1.DateOfBirthYear = 2000;

Person person2 = new Person();
person2.FirstName = "Engin";

PttManager pttManager = new PttManager(new PersonManager());

pttManager.GiveMask(person1);

Console.ReadLine();

static void Selamver(string isim = "isimsiz")
{
    Console.WriteLine("Merhaba " + isim);
}

static int Topla(int sayi1 = 5, int sayi2 = 10)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Sonuc = " + sonuc);
    return sonuc;
}

static void Degiskenler()
{
    string mesaj = "Merhaba";
    double tutar = 100000; //dbden getir
    int sayi = 100;
    bool girisYapmisMi = false;

    string ad = "Burak";
    string soyad = "Temelkaya";
    int doguumYili = 2001;
    long tcNo = 12345678910;
}

// pascal casing
class Vatandas
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int DogumYili { get; set; }
    public long TcNo { get; set; }
}