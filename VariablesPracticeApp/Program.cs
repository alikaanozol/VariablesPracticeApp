Console.WriteLine("Patika+ Giyim Dünyasına Hoşgeldiniz!");

//////////////////////////////////////////////////////////////////////

Console.WriteLine("Lütfen aşağıdaki bilgileri giriniz");
Console.Write("T.C Kimlik Numarası: ");
string idNumber= Console.ReadLine();
// kafa karışıklığı olmaması için detaylı tckn kontrolü yapılmamıştır :)
// tckn bilgisi doğru girilmiş mi diye if-else ve döngüALİ yapısında sorgulama gerekir.

Console.Write("Adı : ");
string name = Console.ReadLine();
Console.Write("Soyadı : ");
string surname = Console.ReadLine();

Console.Write("Telefon Numarası : ");
var phnumber = Console.ReadLine();

// telefon numarası olarak rakam girebileceği için integer giriş sağlamalıdır."var" keyword ile kontrol altına alınmıştır.

Console.Write("Yaş : ");
string age = Console.ReadLine();


Console.Write("İlk Aldığınız Ürünün Fiyatı : ");
string price1 = Console.ReadLine();

Console.Write("İkinci Aldığınız Ürünün Fiyatı : ");
string price2 = Console.ReadLine();

//müşteri küsüratlı(örn; 575,2) ürün alabileceği için double veri tipi kullanılmıştır.
double p1 = Convert.ToDouble(price1);
double p2 = Convert.ToDouble(price2);

double totalcost = p1 + p2;

double totalpoint = totalcost * (0.1);

Console.WriteLine("----------------------------------------");

Console.WriteLine(idNumber + " TCKN numaralı " + name + " " + surname + " " + "isimli kişi için kayıt oluşturulmuştur.");

Console.WriteLine(phnumber + " " + "telefon numarasına bildirim mesajı gönderilmiştir.");

Console.WriteLine(totalcost + "toplam harcama karşılığı kazanılan %10 patika puan miktarı ->" + " " + totalpoint + " " + "TL'dir.");




























