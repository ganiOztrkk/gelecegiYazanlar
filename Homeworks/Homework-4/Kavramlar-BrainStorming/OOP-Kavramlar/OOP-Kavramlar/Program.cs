using OOP_Kavramlar;

Otomobil otomobil1 = new Otomobil();
//new operatoruyle sınıfımızdan urettigimiz nesnemizi otomobil1 refere etmektedir. dolayısıyla otomobil1 ile sınıfımızın tüm özelliklerine ulaşabiliriz.

otomobil1.Ad = "BMW 520D";
otomobil1.AracSinif = "D";
otomobil1.CekisTip = "Arkadan İtiş";
otomobil1.Fiyat = 750000;
otomobil1.MotorGuc = 2.0;
otomobil1.YakitTip = "Dizel";
otomobil1.OtomobilHizi = 220;  // kapsulleme uyguladık ve deger bizim kontrolumuz ile dısarı acılıyor.

Console.WriteLine(otomobil1.OtomobilHizi);


//kalıtımı orneklendirmek icin bmw sınıfından bir nesne uretelim ve hangi ozelliklere erisebildigimizi gorelim.

BMW bmw = new BMW();
bmw.DriftModu(); // otomobile ait tum ozelliklere ek olarak drift modu ozelligimiz de geldi. bu ozellige otomobilden turettigimiz nesne ile erisemezdik.

bmw.Vergilendir();

otomobil1.Vergilendir();