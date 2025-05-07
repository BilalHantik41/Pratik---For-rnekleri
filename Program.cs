using System;

namespace ForDöngüleri
{
    class Program
    {
        static void Main(string[] args)

        {   // Birinci Soru: Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.

            for(int i=1; i<=10; i++)      // for döngüsüyle tanımlamış olduğumuz i değerini 1'den başlatıp 10 olana kadar 1er 1er artırıyoruz.
            {
            Console.WriteLine("Kendime inaniyorum, ben bu yazilim işini hallederim!"); //Değer her 1 arttığında bu komut çalıyor ve toplamda 10 kez Kendime inaniyorum yazmış oluyoruz.
            }


            // İkinci Soru : 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.
            for(int a=1; a<=20; a++)
            {
            Console.WriteLine("Sayi: "+ a);
            }

            // Üçüncü Soru: 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.
            for(int b=1; b<=20; b++)
            {
            if(b%2==0)
            Console.WriteLine("ÇiftSayilar: "+ b);
            }


            //Dördüncü Soru: 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.
            int toplam = 0;             // Toplam değerini tutucak olan değişkenimiz.
            for(int c=50; c<=150; c++)  // Döngü 50'den başlayıp 150'ye kadar 1er 1er artar
            {
            toplam += c;  // 3. Her adımda c değerini toplam değişkenine ekle
            Console.WriteLine("50 ile 150 arasindaki sayilarin toplami: " + toplam);
            }


            // Beşinci Soru: 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.
            int toplamCift = 0;
            int toplamTek = 0;
            for(int d=1; d<=120; d++)
            {
            if (d%2==0)
            {   // d çiftse çiftler toplamına ekle
                toplamCift += d;
            }
            else 
            {   // d tekse tekler toplamına ekle
                toplamTek += d;
            }
            Console.WriteLine("Toplam Çift Sayilar: "+ toplamCift);
            Console.WriteLine("Toplam Tek Sayilar: "+ toplamTek);
            }
        }

    }
}