namespace Day08Training;

public class ModuleInfo
{
    public string Name;
    public string Description;
    public double Fees;
    public DateTime Date;

    public ModuleInfo(string name, string description, double fees, DateTime date)
    {
        Name = name;
        Description = description;
        Fees = fees;
        Date = date;
    }

   
    public void Display()
    {
        Console.WriteLine($"Subject Name: {Name}, Description: {Description}, Fees : {Fees}, Date: {Date}");
       
    }

   

}
