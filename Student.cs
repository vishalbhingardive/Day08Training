namespace Day08Training;
class student 
{
    public int Rollno;
    public string Name;
    public DateTime DOB;

    List<StudentInfo> studentInfos;

    public string StudentText;

    public student(int rollno, string name, DateTime dOB)
    {
        Rollno = rollno;
        Name = name;
        DOB = dOB;

        studentInfos = new List<StudentInfo>();

    }
    internal void AddStudent()
    {

        Console.WriteLine("--------------------------------Student----------------------------\n\n");
        Console.WriteLine("|-------------------------|-------------------------|-------------|");
        Console.WriteLine($"|        RollNo           |  Name                   | DateOfBirth |");
        Console.WriteLine("|-------------------------|-------------------------|-------------|");
        Console.WriteLine($"|{Rollno,10}               |{Name,-25}|{DOB,10:dd-MMM-yyyy}  |");
        Console.WriteLine("|-------------------------|-------------------------|-------------|");
        Console.WriteLine("                                                                   ");
        string modulesText = "Student has Enrolled: ";
        foreach (StudentInfo studentInfo in studentInfos)
        {
            StudentText = StudentInfo.SName;

        }
        Console.WriteLine(modulesText);
    }

    public void AddStudent(StudentInfo studentInfo)
    {
        Console.WriteLine("----------------");
        Console.WriteLine("Add New Student");
        Console.WriteLine("----------------");
        Console.WriteLine("Enter Student Roll NO");
        var rollno = Console.ReadLine();

        Console.Write("Enter Name : ");
        var name = Console.ReadLine();

        Console.Write("Enter DOB ");
        var dOB = Console.ReadLine();



    }

    public void Display()
    {
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Search Module");
        Console.WriteLine("--------------------------------");

        Console.Write("Enter a module name to search");
    }
}
