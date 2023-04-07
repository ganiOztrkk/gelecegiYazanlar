namespace LiskovPrinciple_RentalTask;

public interface ICustomer
{
    public string CustomerName { get; set; }
    public string CustomerSurname { get; set; }
    public int CustomerAge { get; }
    public string CustomerPhone { get; set; }
}