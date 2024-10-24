using System;
using System.Linq;

namespace _06_Arrays
{
    public class Program
    {
        static void Main(string[] args)
        {

            #region Temel Dizi Örnekleri

            //string[] colors = new string[4];
            //colors[0] = "YEŞİL";
            //colors[1] = "PEMBE";
            //colors[2] = "MOR";
            //colors[3] = "TURUNCU";

            //Console.WriteLine(colors[3]);

            //string[] cities = new string[5];

            //cities[0] = "VENEDİK";
            //cities[1] = "TOKYO";
            //cities[2] = "PARIS";
            //cities[3] = "BARSELONA";
            //cities[4] = "FRANSA";

            //Console.WriteLine(cities[2]);

            //int[] numbers = new int[10];

            //numbers[0] = 9969;
            //numbers[1] = 67868;
            //numbers[2] = 45;
            //numbers[3] = 456;
            //numbers[7] = 4325;

            //Console.WriteLine(numbers[1]);

            //string[] cities = { "İZMİR", "İSTNBUL", "MUĞLA", "TRANZON", "DÜZCE" };

            //Console.WriteLine(cities[3]);

            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "SİYAH", "BEYAZ", "MAVİ", "YEŞİL", "SARI", "MOR", "KAHVERENGİ" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 439, 532, 974, 743, 754, 685, 123, 201, 401, 435 };

            //for (int i = 0; i < numbers.Length; i++)
            //{

            //    if (numbers[i] % 5 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'ü', 'e', '*', '+', 'o', '-' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] my_array = { 940, 932 , 293, 493 , 434 , 324 , 943 , 274 };

            //int maxnumber = my_array[0];

            //for (int i = 0; i < my_array.Length; i++)
            //{
            //    if (my_array[i] > maxnumber)
            //    {
            //        maxnumber = my_array[i];
            //    }
            //}

            //Console.WriteLine(maxnumber);

            //string[] persons = { "Ümran", "Edanur", "Ebru", "Fatma", "Cihat", "Ayaz" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 435, 35, 76, 654, 98, 43, 65 };

            //Array.Sort(numbers);  Küçükten Büyüğe sıralıyor

            //for (int i = 0; i < numbers.Length; i++) { 
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 5, 32, 76, 34, 89, 93, 432 };
            //Array.Reverse(numbers);  diziyi tersten tekrar yaızyor

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            #region Dizi Metodları

            //string[] customers = { "ali", "buse", "ayşegül", "merve", "çınar", "kaya" };
            //int index = Array.IndexOf(customers, "merve"); //index numarası

            //Console.WriteLine(index);

            //int[] numbers = { 45, 83, 96, 63, 74, 10, 25, 22, 36 };
            //Console.WriteLine("Dizinin en büyük elemanı: " + numbers.Max() + " -Dizinin en küçük elemanı: " + numbers.Min());

            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[3];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("------------------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 45, 58, 84, 535, 79 };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}

            //Console.WriteLine(sum);

            //int[] numbers = { 35, 86, 53, 79, 68, 30, 894, 98654, 3478, 91 };
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