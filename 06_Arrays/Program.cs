using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            //2, sarı, adana vb. 
            //Değişken Türü [] DiziAdı = DeğişkenTürü[Eleman Sayısı]
            //string[] colors = new string[4];
            //colors[0] = "Kırımızı";
            //colors[1] = "Sarı";
            //colors[2] = "Mavi";
            //colors[3] = "Yeşil";
            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];

            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";


            //Console.WriteLine(cities[3]);

            //int[] numbers = new int[10];

            //numbers[0] = 50;
            //numbers[1] = 55;
            //numbers[2] = 48;
            //numbers[3] = 550;
            //numbers[4] = 20;
            //numbers[5] = 80;
            //numbers[6] = 90;
            //Console.WriteLine(numbers[3]);

            //string[] citiess = { "Prag", "Roma", "Atina", " Ankara", "Bursa" };
            //Console.WriteLine(citiess[0]);

            #endregion
            #region Dizide ki Tüm Elemanları Listeleme 

            //string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };
            //for(int i = 0; i <colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}



            //int[] numbers = { 4, 85, 96, 74, 125, 635, 488, 520, 7456, 4234, 54354, 23434, 3434, 234 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0) 
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'A', 'b', 'W', '+', '/', '-', ',' };
            //for(int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] my_array = { 47, 85, 95,46, 52, 153, 658, 140 };

            //int maxnumber = my_array[0];

            //for (int i = 0; i < my_array.Length; i++)
            //{
            //    if (my_array[i] > maxnumber)
            //    {
            //        maxnumber = my_array[i];
            //    }
            //}
            //Console.WriteLine(maxnumber);


            //string[] persons = { "ali", "ahmet", "ayşe", "birgül", "cem", "deniz" };
            //Console.WriteLine(persons.Length);


            //int[] numbers = { 3, 8, 95, 82, 86, 11, 35 };

            //Array.Sort(numbers); //küçükten büyüğüe sıralıyor

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 3, 8, 95, 82, 86, 11, 35 };
            //Array.Reverse(numbers); // diziyi tersten sıralıyor

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            #endregion
            #region Dizi Methodları

            ////string[] customers = { "ali", "buse", "ayşegül", "merve", "çınar", "kaya" };
            ////int index = Array.IndexOf(customers, "merve"); //listede ki sıra numarasını veriyoruz. 

            //int[] numbers = { 54, 23, 66, 69, 14, 11, 22,92, 36 };
            //Console.WriteLine("Dizinin en büyük elemanı: " + numbers.Max()
            //    + "Dizinin en küçük elemanı: " + numbers.Min());

            #endregion
            #region Kullanıcıdan Değer Alma
            //string[] cities = new string[5];

            //    for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri Giriniz: ");
            //      cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("------------------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}


            //int[] numbers = { 21, 42, 33, 54, 55, 66, 897, 748, 39, 220 };
            //Console.WriteLine("Çift Sayılar");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("Tek Sayılar");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}


            #endregion

            Console.Read();
        }
    }
}
