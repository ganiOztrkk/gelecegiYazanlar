// 4 farklı  geometrik şekle dair alan hesabı yapmak istiyoruz


using System;

Geometry geometry = new Geometry();




public class Geometry
{
    //kare, daire, üçgen, dikdörtgen

    /// <summary>
    /// Kare ve Daire Şekillerinin alanlarını hesaplamak için kullanılır.
    /// </summary>
    /// <param name="unit1">Karenin Birim Uzunluğu veya dairenin yarı çapı</param>
    /// <param name="geometry">Kare veya Daire kelimelerinden biri</param>
    /// <returns></returns>
    public double GetArea(double unit1, string geometry)
    {
        double result = 0;
        switch (geometry)
        {
            case "Kare":
                result = unit1 * unit1;
                break;
            case "Daire":
                result = Math.Pow(unit1, 2) * Math.PI;
                break;
            default:
                break;
        }
        return result;
    }

    /// <summary>
    /// Dikdörtgen ve Üçgen Şekillerinin alanlarını hesaplamak için kullanılır.
    /// </summary>
    /// <param name="unit1">Dikdörtgenin eni veya üçgenin tabanı</param>
    /// <param name="unit2">dikdörtgenin uzunluğu veya üçgeinin yüksekliği</param>
    /// <param name="geometry">Dikdörtgen veya Üçgen kelimelerinden biri.</param>
    /// <returns></returns>
    public double GetArea(double unit1,double unit2, string geometry)
    {
        double result = 0;
        switch (geometry)
        {
            case "Dikdörtgen":
                result = unit1 * unit2;
                break;
            case "Üçgen":
                result = (unit1*unit2) / 2;
                break;
            default:
                break;
        }
        return result;
    }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="unit1">[ZORUNLU] Kenar uzunluğu</param>
    /// <param name="unit2">[OPSIYONEL] Kenar Uzunluğu</param>
    /// <param name="geometry">[OPSIYONEL]</param>
    /// <returns></returns>
    public double AlternativeGetArea(double unit1, double unit2 = 1, string geometry = "Kare")
    {
        double result = 0;
        switch (geometry)
        {
            case "Kare":
                result = unit1 * unit1;
                break;
            case "Daire":
                result = Math.Pow(unit1,2)* Math.PI;
                break;
            case "Dikdörtgen":
                result = unit1 * unit2;
                break;
            case "Üçgen":
                result = (unit1 * unit2) / 2;
                break;
            default:
                break;
        }
        return result;
    }
}