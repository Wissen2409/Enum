// Enum tanımlayalım

public enum DaysOfWeek{

 Pazartesi,
 Salı,
 Çarşamba,
 Perşembe,
 Cuma,
 Cumartesi,
 Pazar
}

// Her enum sabitinin bir rakamsal değeri vardır
// Bu rakamsal değer, siz vermesenizde kendiliğinden atanır!!

// Enum sabitleri arka planında bir değer taşıyabilirler
// enum sabitlerine, bir tip bildirilmediği sürece, taşıdıkları değerin tipi int olur
// eğer farklı bir tip değişken verirseniz o değişken tipinde değerler taşıyabilirler
public enum Aylar{
    Ocak=1,
    Şubat=2,
    Mart=3,
    Nisan=4,
    Mayıs=5,
    Haziran=6,
    Temmuz=7,
    Ağustos=8,
    Eylül=9,
    Ekim=10,
    Kasım=11,
    Aralık=12
}

// Enum oluşturulurken enum sabitlerinin değerlerinin tipleri ayarlanabilir
// aşağıdaki enum sabitlerinin değerleri short tipindedir
// enum sabitlerinin değer verme işinde, verilebilecek değerler tam sayı değişken tipleri olmalıdır!!!


public enum Departmanlar:short
{
    Muhasebe=10,
    Yazılım=15,

    Satış=20,

    İnsanKaynakları=25
}

// Enum sabitlerine tam sayı tiplerinden başka bir tip sabit verilemez!!!
/*
public enum Renkler{
Red="Kırmızı",
Yeşil = "Green"
}*/



