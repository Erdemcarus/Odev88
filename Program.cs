Console.Write("Birinci sayıyı giriniz: ");
int sayi1 = Convert.ToInt32(Console.ReadLine());

Console.Write("İkinci sayıyı giriniz: ");
int sayi2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Üçüncü sayıyı giriniz: ");
int sayi3 = Convert.ToInt32(Console.ReadLine());

Console.Write("Dördüncü sayıyı giriniz: ");
int sayi4 = Convert.ToInt32(Console.ReadLine());

Console.Write("Beşinci sayıyı giriniz: ");
int sayi5 = Convert.ToInt32(Console.ReadLine());

int[] sayilar = { sayi1, sayi2, sayi3, sayi4, sayi5 };

int toplam = 0;



for (int i = 0; i < sayilar.Length; i++)
{
    toplam += sayilar[i];


}

double ortalama = (double)toplam / 5;

Console.WriteLine(ortalama);