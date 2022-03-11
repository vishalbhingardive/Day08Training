namespace Day08Training;

public class StudentInfo
{
    public static string SName;
    public static int Rollno;
    public static int DOB;


    public StudentInfo(string name, int rollno, int dob)
    {
        SName = name;
        Rollno = Rollno;
        DOB = dob;
       
    }

    public StudentInfo()
    {
    }

    internal static void AddStudent()
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

    public static void Display()
    {
        Console.WriteLine($"Student Rollno: {Rollno}, Name: {SName}, DOB : {DOB}");

    }



}



