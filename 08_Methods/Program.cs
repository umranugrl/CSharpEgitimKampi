using System;

namespace _08_Methods
{
    public class Program
    {
        static void Main(string[] args)
        {

            #region Void Metotlar

            //void CustomerList()
            //{
            //    Console.WriteLine("1. Ümran Uğurlu");
            //    Console.WriteLine("2. Edanur Esertaş");
            //    Console.WriteLine("3. Ebru Aydın");
            //    Console.WriteLine("4. Ayaz Taha Aydın");
            //}

            //CustomerList();

            //void Sum()
            //{
            //    int x = 1890, y = 4637;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //Sum();

            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Ümran Uğurlu");

            //void CustomerCard(string name, string surname)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surname);
            //}

            //CustomerCard("Edanur", "Esertaş");
            //CustomerCard("Ebru", "Aydın");

            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int number1, int number2, int number3)
            //{

            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);

            //}

            //Sum(90, 45, 432);
            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Neva Uğurlu";
            //}

            //Console.WriteLine(CustomerName());

            //string StudentCard()
            //{

            //    string name = "Fatih";
            //    string surname = "Türkoğlu";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor){
            //    string cardInfo = "Ülke: " + countryName + " - Başkent: " + capital + " - Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}

            //string u, b, r;

            //Console.Write("Ülke adını giriniz: ");
            //u = Console.ReadLine();

            //Console.Write("Başkenti giriniz: ");
            //b = Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz: ");
            //r = Console.ReadLine();

            //Console.WriteLine(CountryCard(u, b, r));
            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı - Beyaz"));

            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(5436, 392));
            //Console.WriteLine(Sum(4235, 78));

            #endregion

            #region Örnek Uygulama

            //string Examresult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;

            //    if (result >= 50)
            //    {
            //        return student + " isimli öğrenci sınavı geçti. " + "Ortalama: " + result;
            //    }
            //    else
            //    {
            //        return student + " isimli öğrenci sınavı geçemedi. Ortalama: " + result;
            //    }
            //}

            //Console.WriteLine(Examresult("Ebru", 65, 43, 97));
            //Console.WriteLine(Examresult("Edanur", 90, 32, 20));

            #endregion

            Console.Read();

        }
    }
}