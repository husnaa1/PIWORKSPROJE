
//all prime numbers having 3 digits and starting with 5


Console.Write("5 ile başlayan 3 basamaklı tüm asal sayılar \n");

int sayac;

    for (int i = 500; i < 600; i++)
    {
        sayac = 0;
        for (int j = 2; j < i; j++)
        {
            if (i % j == 0)
            {
                sayac++;
            }
        }
        if (sayac == 0)
        {
            Console.WriteLine("Asal Sayılar = " + i);
        }
    }
    Console.ReadLine();
