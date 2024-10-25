# 🚀 C# EĞİTİM KAMPI
Bu repo, Murat Yücedağ'ın eğitmenliğinde gerçekleştirilen **C# Eğitim Kampı** süresince öğrendiğim temel C# programlama konularını uyguladığım projeleri içermektedir. Her bir başlık, C# diline dair bilgi ve becerilerimi geliştirmemde önemli bir rol oynadı. Aşağıda her konuya dair kısa açıklamaları bulabilirsiniz:

## 📌 Proje 1: Temel Konular
Kampın başlangıcında, C# programlama diline giriş yaptım ve temel konular üzerinde çalışarak dilin yapısına dair ilk bilgilerimi edindim. Uygulama üzerinde basit projeler geliştirdim. 🎉
- **Yazdırma Komutları**: **Console.Write** ve **Console.WriteLine** komutlarıyla konsola veri yazdırdım.
- **String Değişkenler**: Metinsel verileri saklamak için **string** değişkenlerini öğrendim.
- **Int Değişkenler**: Tam sayıları saklamak ve işlem yapmak için **int** veri türünü kullandım.

```csharp
Console.Write("Merhaba"); // Aynı satıra yazar
Console.WriteLine("Dünya!"); // Sonraki satıra yazar

// Çıktı:
// MerhabaDünya!
```

## 📌  Proje 2: Değişkenler (Variables)
Bu bölümde, farklı veri türlerinde (int, string, double, vb.) değişkenler tanımlamayı ve kullanmayı öğrendim. Programlamada veri işleme ve değişkenlerle çalışma yeteneklerimi geliştirdim. 💡
- **Double Değişkenler**: Ondalıklı sayılar için **double** veri türünü öğrendim.
- **Char Değişkenler**: Tek karakter verileri için **char** veri türünü kullandım.
- **Klavyeden Veri Girişleri*: Kullanıcıdan **string**, **int**, **double** ve **char** veri girişlerini almayı öğrendim.

```csharp
int yas = 25; // Tam sayı değişkeni
string isim = "Ahmet"; // Metin değişkeni
double maas = 3500.50; // Ondalıklı sayı değişkeni

Console.WriteLine("Yaş: " + yas);
Console.WriteLine("İsim: " + isim);
Console.WriteLine("Maaş: " + maas);
```

## 📌  Proje 3: Koşullu İfadeler (Making Decisions)
If, else if ve else ifadelerini kullanarak karar yapıları oluşturmayı öğrendim. Farklı koşullar altında programın nasıl davrandığını anlamaya yönelik basit projeler gerçekleştirdim. ⚙️
- **If Else**: Şartlı ifadelerle koşullar belirledim.
- **Mod İşlemleri**: Sayıların kalanlarını kontrol etmek için **mod** operatörünü kullandım.
- **Char Değişkenler ile Karar Yapıları**: **char** türüyle karar yapıları oluşturmayı öğrendim.
- **Switch Case**: Farklı durumlar arasında seçim yapmak için **switch-case** ifadesini kullandım.

```csharp
int yas = 20;
if (yas >= 18){
    Console.WriteLine("Reşitsiniz.");
}else{
    Console.WriteLine("Reşit değilsiniz.");
}
```

## 📌  Proje 4: Döngüler (Loops)
Döngü yapılarını kullanarak tekrarlayan işlemleri otomatikleştirmeyi öğrendim. For ve while döngüleri ile tekrarlayan yapıları işledim. 🔄
- **For Döngüsü**: Belirli bir sayıda tekrar eden işlemler için **for** döngüsünü kullandım.
- **For Döngüsü ile Karar Yapıları**: Döngü içinde koşul kontrolleri yapmayı öğrendim.
- **While Döngüsü**: Belirli bir koşul sağlandığı sürece tekrar eden işlemler için **while** döngüsünü kullandım.

```csharp
for (int i = 1; i <= 5; i++){
    Console.WriteLine(i);
}

// Çıktı:
// 1
// 2
// 3
// 4
// 5
```

## 📌  Proje 5: Yıldızlı Döngüler (Loops with Stars)
Yıldız karakteri (*) kullanarak çeşitli desenleri ekrana yazdırma projeleri üzerinde çalıştım. Bu çalışmalar algoritma mantığımı güçlendirmeme yardımcı oldu. ✨
- **Yıldız Oluşturma**: Tekli yıldız karakteri ile desen oluşturmayı öğrendim.
- **Dik Üçgen**: Yıldızları kullanarak dik üçgen deseni çizdim.
- **Baklava Dilimi**: Yıldızlarla baklava dilimi deseni oluşturmayı öğrendim.

```csharp
for (int i = 1; i <= 5; i++){
    for (int j = 1; j <= i; j++){
        Console.Write("*");
    }
    Console.WriteLine();
}

// Çıktı:
// *
// **
// ***
// ****
// *****
```

## 📌  Proje 6: Diziler (Arrays)
Birden fazla veriyi dizi içerisinde depolama ve döngülerle işleme üzerine çalışmalar yaptım. Dizilerle, temel işlemleri nasıl gerçekleştirebileceğimi öğrendim. 🧩
- **Temel Dizi Örnekleri**: Basit dizi işlemlerini öğrendim.
- **Dizideki Tüm Elemanları Listeleme**: **for** döngüsüyle dizi elemanlarını yazdırdım.
- **Dizi Metodları**: Dizilerle birlikte **Length** gibi metodları kullandım.

```csharp
int[] sayilar = { 1, 2, 3, 4, 5 };

for (int i = 0; i < sayilar.Length; i++){
    Console.WriteLine(sayilar[i]);
}

// Çıktı:
// 1
// 2
// 3
// 4
// 5
```

## 📌  Proje 7: Foreach Döngüsü
Foreach döngüsü ile dizileri daha pratik bir şekilde gezmeyi ve veriler üzerinde toplu işlemler yapmayı öğrendim. Bu yapıyı sınav sistemi gibi projelerde aktif olarak kullandım. 🎓
- **Foreach Döngüsü**: Diziler üzerinde gezinmeyi öğrendim.
- **Örnek Sınav Sistemi Uygulaması**: Foreach döngüsü ile örnek bir uygulama geliştirdim.

```csharp
int[] notlar = { 85, 90, 78, 92 };

foreach (int not in notlar){
    Console.WriteLine("Not: " + not);
}

// Çıktı:
// Not: 85
// Not: 90
// Not: 78
// Not: 92
```

## 📌  Proje 8: Metotlar (Methods)
Kod yapımı daha düzenli hale getirmek amacıyla parametre alıp değer döndüren metotlar yazmayı öğrendim. Bu sayede kod tekrarını önleyip, yapılandırılmış kod yazma becerimi geliştirdim. 🛠️
- **Void Metotlar**: Geriye değer döndürmeyen metotlarla çalıştım.
- **Parametreli Metotlar**: **string** ve **int** parametreleri kabul eden metotlar yazdım.
- **Geriye Değer Döndüren Metotlar**: Sonuç döndüren metotlarla işlemler yaptım.

```csharp
void Sum(){
    int x = 18, y = 46;
    int z = x + y;
    Console.WriteLine(z);
}
Sum();

// Çıktı:
// 64
```

## 📌 Proje 9: Database Projesi
Bu derste, **MSSQL** kullanarak temel bir veritabanı projesi oluşturdum. Bu proje kapsamında veritabanı oluşturmayı, tablolar tanımlamayı, veri eklemeyi ve basit SQL sorguları yazmayı öğrendim. Ek olarak, veritabanını C# ile bağlayarak veri işlemlerini uygulamalı olarak gerçekleştirdim. Bu çalışma, verilerin saklanması ve yönetimi üzerine temel bilgiler edinmemi sağladı. 📊

```csharp
// Veritabanı bağlantısı kurma ve tablo verilerini çekme
SqlConnection connection = new SqlConnection("Data Source=DESKTOP-0AI6GGL\\SQLEXPRESS; Initial Catalog=CampDB; Integrated Security=True;");
connection.Open();
SqlCommand command = new SqlCommand("select * from TblCategory", connection);
SqlDataAdapter adapter = new SqlDataAdapter(command);
DataTable dt = new DataTable();
adapter.Fill(dt);

foreach (DataRow row in dt.Rows)
{
    foreach (var item in row.ItemArray)
    {
        Console.Write(item.ToString());
    }
    Console.WriteLine();
}
Console.WriteLine();
```

Bu eğitim kampı sayesinde C# diline dair temel konuları uygulamalı olarak öğrenme ve deneyimleme fırsatı buldum. Her konu, programlamaya dair bilgi birikimimi arttırarak daha karmaşık projelere geçişime zemin hazırladı. 📈
