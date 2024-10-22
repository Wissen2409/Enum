// Enum Nedir : Sabitlerdir
// Yazılım içerisindeki sabit değerleri tanımlamak için kullanılır
// Bir sabit değer enum olarak tanımlanır ve bu sabit değeri kullanacak olan kişiler enunm olarak kullanırlar

// böylelikle, hatanın önüne geçilir

// if(secim=="Akbank")

// akbank
// AKBANK
// akBANK
// AkBaNk


// Haftanın günleri enum'unu kullanalım

// PAzartesi


using System.Globalization;
using Microsoft.VisualBasic;

Console.ForegroundColor=ConsoleColor.DarkMagenta;


// Sistemde de enum kullanımı olduça fazladır.!!!
//string cumartesi = DaysOfWeek.Cumartesi.ToString();
//Console.WriteLine(cumartesi);

//string deger = Console.ReadLine();

//if(DaysOfWeek.Cuma.ToString()==deger){
//    Console.WriteLine("Cumadır");
//}



// her hangi bir string metinin, enum'a çevrilmesi !! 

//String tipinde Ocak değerini,Enum sabiti olan Ocak olarak dönüştürebilir miyim ?


// enum tipinin sayısal değerini görelim 
int aralik = (int)Aylar.Aralık;
Console.WriteLine("Aralık Enum sabitinin sayısal karşılığı : {0}",aralik);


// Bir enum içerisinde foreach ile gezilebilir mi  ? 
// typeof ? 
// 

string type = typeof(Departmanlar).ToString();
Console.WriteLine(type);

// Enum içerisindeki sabitleri ekrana foreach ile yazdırmak !!!
string[] enumSabitleri = typeof(Departmanlar).GetEnumNames();
foreach (string item in enumSabitleri){
    // hem enum sabitleri hemde bunların arkada tuttukları değerleri ekrana yazdıralım
   Departmanlar seciliDepartman= (Departmanlar)Enum.Parse(typeof(Departmanlar),item);
  
   short departmanId= (short)seciliDepartman;
   Console.WriteLine("Departman değeri : {0} Departman Adı : {1}",departmanId,item);
}



