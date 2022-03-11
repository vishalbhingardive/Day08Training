// See https://aka.ms/new-console-template for more information
namespace Day08Training;

class Subject : ISubject
{

    List<ModuleInfo> modules = new List<ModuleInfo>();


    public void DisplaySubject()
    {
        Console.WriteLine("----------------------------------------------------------------------");
        Console.WriteLine("Module Listing Report");
        Console.WriteLine("----------------------------------------------------------------------");
        Console.WriteLine("|Name           |Description              |Fees      |Start Date     |");
        Console.WriteLine("----------------------------------------------------------------------");


        foreach (var module in modules)
        {
            Console.WriteLine($"|{module.Name,-15}|{module.Description,-25}|{module.Fees,10:N}|{module.Date,-15:dd-mmm-yyyy}|");
            Console.WriteLine("----------------------------------------------------------------------");

        }
    }

    public void AddSubjects()
    {
        Console.WriteLine("----------------");
        Console.WriteLine("Add New Subject");
        Console.WriteLine("----------------");
        Console.WriteLine("Enter Subject Name");
        var name = Console.ReadLine();

        Console.Write("Enter Description: ");
        var description = Console.ReadLine();

        Console.Write("Enter Course Fees");
        var Fees = Console.ReadLine();

        Console.Write("Enter Course Start Date");
        var date = Console.ReadLine();

        ModuleInfo module = new ModuleInfo(name, description, double.Parse(Fees), DateTime.Parse(date));
        modules.Add(module);
    }

    public void UpdateSubject()
    {

    }

    public void AddSubjects(ModuleInfo moduleInfo)
    {
        modules.Add(moduleInfo);
    }
    public void DisplayAnyModuleInfo()
    {
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Search Module");
        Console.WriteLine("--------------------------------");

        Console.Write("Enter a module name to search");

    }
}
