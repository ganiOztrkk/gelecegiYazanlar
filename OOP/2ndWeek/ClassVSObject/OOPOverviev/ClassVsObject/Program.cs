using ClassVsObject;

Console.WriteLine("Hello, World!");
Product p1 = new Product
{
    Name = "Telefon"
};

Product p2 = p1;

p2.Name = "Telefon";

Console.WriteLine(p1.Name);