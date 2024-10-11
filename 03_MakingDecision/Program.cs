using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If-else
            //Console.WriteLine("Lütfen Şifreyi Giriyiniz.");
            //string pasword;
            //pasword =  Console.ReadLine();
            //if(pasword == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");

            //}else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //string capital, country;
            //Console.WriteLine("Başkenti giriniz");
            //capital = Console.ReadLine();
            //Console.WriteLine("Ülkeyi giriniz");
            //country = Console.ReadLine();

            //if (capital=="ankara" & country=="türkiye")
            //{
            //    Console.WriteLine("Veriler Doğru");
            //}else
            //{
            //    Console.WriteLine("Hatalı bilgi.");
            //}

            //int sayi;
            //Console.WriteLine("Sayılari giriniz");
            //sayi = int.Parse(Console.ReadLine());  
            //if(sayi == 5)
            //{
            //    Console.WriteLine("Sayı Doğru");
            //}else
            //{
            //    Console.WriteLine("Yanlış kardeşim");
            //}

            //int exam1, exam2, exam3, exam4,  average;
            //string result = "";

            //Console.WriteLine("Sınav 1 Sonucunu girinizi");
            // exam1 = int.Parse(Console.ReadLine());   
            //Console.WriteLine("Sınav 2 Sonucunu girinizi");
            // exam2 = int.Parse(Console.ReadLine());    
            //Console.WriteLine("Sınav 3 Sonucunu girinizi");
            // exam3 = int.Parse(Console.ReadLine());  
            //Console.WriteLine("Sınav 4 Sonucunu girinizi");
            // exam4 = int.Parse(Console.ReadLine());  
            //average = (exam1 + exam2 + exam3 + exam4) / 4;
            //Console.WriteLine("Sınavların ortalaması" + average);

            //if (average > 0 & average <= 50) {
            //    result = "vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "orta";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "iyi";
            //}
            //if (average > 84)
            //{
            //    result = "Çok İyi";
            //}

            //Console.WriteLine(result);



            //string city;
            //Console.Write("Lütfen şehir girişi yapınız: ");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "Üsküdar")
            //{
            //    Console.WriteLine("şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil");
            //}

            //Console.Write("Lütfen kullanıcı adını giriniz: ");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.Write("bu kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.Write("Hoş geldiniz");
            //}
            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine("Sonuç" + result);

            //Console.WriteLine("Lütfen 1.sayıyı giriniz");
            // int number1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen 2.sayıyı giriniz");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.WriteLine($"1.Sayının : {number1} 2.sayıya{number2} bölümünden kalan : {result}");


            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.Write("Sayı Çifttir");
            //}
            //else
            //{
            //    Console.Write("Sayı tektir");
            //}
            #endregion

            #region Char Değişkenler Karar Yapıları
            //char team;

            //Console.WriteLine("Lütfen takım sembolü giriiz");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' |team == 'G' )
            //{
            //    Console.WriteLine("Galatasaray");
            //}

            //if (team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}

            //if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}
            #endregion

            #region Örnek-Proje

            //Console.WriteLine("********C# Eğitim Kampı Restoran");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar ");
            //Console.WriteLine("----------------------------------------");
            //Console.WriteLine();
            //string menuItem;

            //Console.WriteLine("Lütfen detayını görmek istediğiniz menü seçin");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------------Ana Yemekler---------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Köri Soslu Tavuk");
            //    Console.WriteLine("2- Kızartma Tabağı");
            //    Console.WriteLine("3- Fasulye Pİlav");
            //    Console.WriteLine("4- Fırında Somon");
            //    Console.WriteLine("5- Patlıcan Musakka");
            //    Console.WriteLine();
            //    Console.WriteLine("-------------------Ana Yemekler---------------------");
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------------Çorbalar---------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Mercimek ");
            //    Console.WriteLine("2- EzoGelin");

            //    Console.WriteLine("-------------------Çorbalar---------------------");
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------------Pizzalar---------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Margeritha ");
            //    Console.WriteLine("2- SebzeSever");
            //    Console.WriteLine("3- Akdeniz");

            //    Console.WriteLine("-------------------Pizzalar---------------------");
            //}


            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------------İçecekler---------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Kola ");
            //    Console.WriteLine("2- Ayran");
            //    Console.WriteLine("3- Fanta");

            //    Console.WriteLine("-------------------İçecekler---------------------");
            //}


            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------------Tatlılar---------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Kazandibi ");
            //    Console.WriteLine("2- Baklava");
            //    Console.WriteLine("3- Fırında Sütlaç");

            //    Console.WriteLine("-------------------Tatlılar---------------------");
            //}
            #endregion

            #region Switch-Case

            //Console.WriteLine("lütfen Hazirana kadar Ay Giriniz");
            //int monthNumber = int.Parse(Console.ReadLine());


            //switch (monthNumber)
            //{
            //    case 1:
            //        Console.WriteLine("Ocak");
            //        break;
            //    case 2:
            //        Console.WriteLine("Şubat");
            //        break;
            //    case 3:
            //        Console.WriteLine("Mart");
            //        break;
            //    case 4:
            //        Console.WriteLine("Nisan");
            //        break;
            //    case 5:
            //        Console.WriteLine("Mayıs");
            //        break;
            //    case 6:
            //        Console.WriteLine("Nisan");
            //        break;
            //    case 7:
            //        Console.WriteLine("Mayıs");
            //        break;
            //    default:
            //        Console.WriteLine("Hatalı veri girişi yaptınız. "); break;
            //}
            #endregion

            #region Hesap Makinesi
            int number1, number2, result;
            char symbol;
            Console.WriteLine("1. sayı gir");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2. sayı gir");
            number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen yapmak istediğiniz işlemi giriniz");
            symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine("Toplam" + result);
                    break;
                case '-':
                    result = number1 - number2;
                    Console.WriteLine("Fark: " + result);
                    break;

                case '*':
                    result = number1 * number2;
                    Console.WriteLine("Çarpım: " + result);
                    break;

                case '/':
                    result = number1 / number2;
                    Console.WriteLine("Bölüm: " + result);
                    break;
            }
   

        #endregion
        Console.Read();
        }
    }
}