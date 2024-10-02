using System;
using System.Text;

namespace _02_Variables
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler

            //double pi;
            //pi = 3.14;
            //Console.WriteLine(pi);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double bananaPrice, kiwiPrice, watermelonPrice, mandarinPrice, plumPrice;

            //bananaPrice = 75.50;
            //kiwiPrice = 50.95;
            //watermelonPrice = 11.90;
            //mandarinPrice = 35.75;
            //plumPrice = 65.90;

            //Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine("---- Muz Birim Fiyatı:" + bananaPrice + "₺");
            //Console.WriteLine("---- Kivi Birim Fiyatı:" + kiwiPrice + "₺");
            //Console.WriteLine("---- Karpuz Birim Fiyatı:" + watermelonPrice + "₺");
            //Console.WriteLine("---- Mandalina Birim Fiyatı:" + mandarinPrice + "₺");
            //Console.WriteLine("---- Erik Birim Fiyatı:" + plumPrice + "₺");
            //Console.WriteLine();
            //Console.WriteLine();

            //double bananaGram, kiwiGram, watermelonGram, mandarinGram, plumGram;

            //bananaGram = 2.450;
            //kiwiGram = 1.150;
            //watermelonGram = 15.750;
            //mandarinGram = 5.750;
            //plumGram = 2.550;

            //double bananaTotalPrice = bananaGram * bananaPrice;
            //double kiwiTotalPrice = kiwiGram * kiwiPrice;
            //double watermelonTotalPrice = watermelonGram * watermelonPrice;
            //double mandarinTotalPrice = mandarinGram * mandarinPrice;
            //double plumTotalPrice = plumGram * plumPrice;

            //Console.WriteLine("Alınan Ürün: Muz - " + "Birim Fiyat: " + bananaPrice + " - Gramaj: " + bananaGram + " - Toplam Tutar: " + bananaTotalPrice + "₺");
            //Console.WriteLine("Alınan Ürün: Kivi - " + "Birim Fiyat: " + kiwiPrice + " - Gramaj: " + kiwiGram + " - Toplam Tutar: " + kiwiTotalPrice + "₺");
            //Console.WriteLine("Alınan Ürün: Karpuz - " + "Birim Fiyat: " + watermelonPrice + " - Gramaj: " + watermelonGram + " - Toplam Tutar: " + watermelonTotalPrice + "₺");
            //Console.WriteLine("Alınan Ürün: Mandalina - " + "Birim Fiyat: " + mandarinPrice + " - Gramaj: " + mandarinGram + " - Toplam Tutar: " + mandarinTotalPrice + "₺");
            //Console.WriteLine("Alınan Ürün: Erik - " + "Birim Fiyat: " + plumPrice + " - Gramaj: " + plumGram + " - Toplam Tutar: " + plumTotalPrice + "₺");

            //double shoppingTotalPrice = bananaTotalPrice + kiwiTotalPrice + watermelonTotalPrice + plumTotalPrice + mandarinTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Alışveriş Toplam Tutar:" + shoppingTotalPrice + "₺");

            #endregion

            #region Char Değişkenler

            //char symbol;
            //symbol = 'ü';
            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("-----------------------");
            //Console.WriteLine("Yolcu TC Kimlik No: " + passengerIdentityNumber +  " - Yolcu Ad Soyad: " + passengerName + " " + passengerSurname + " "  + passengerDistrict  + " / " + passengerCity + " " + passengerAge);

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int telephonePrice, tvPrice, laptopPrice, bagPrice;
            //telephonePrice = 80000;
            //tvPrice = 70000;
            //laptopPrice = 35000;
            //bagPrice = 1000;

            //int telephoneCount, tvCount, laptopCount, bagCount;

            //Console.Write("Lütfen aldığınız telefonun sayısını giriniz: ");
            //telephoneCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız laptop sayısını giriniz: ");
            //laptopCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız çanta sayısını giriniz: ");
            //bagCount = int.Parse(Console.ReadLine());

            //int totalPrice = telephoneCount * telephonePrice + tvCount * tvPrice + laptopCount * laptopPrice + bagCount * bagPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice);

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.Sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.Sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);

            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;

            //Console.Write("Lütfen cinsiyet seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçilen Cinsiyet: " + gender);

            #endregion

            Console.Read();
        }
    }
}