// yeni şekil eklemek istediğimizde sadece ilgili sınıfı oluşturup shape sınıfından miras alıyoruz

using OpenClosedExample;

Rectangle rectangle = new Rectangle
{
    Width = 4,
    Height = 4
};
Console.WriteLine(rectangle.CalculateArea());

Circle circle = new Circle(){Radius = 5};

Console.WriteLine(circle.CalculateArea());

