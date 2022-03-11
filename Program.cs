using Day08Training;



int Choice=0;
StudentInfo Student = new StudentInfo();
do
{


    
    
    Console.WriteLine("1.Add Student");
    Console.WriteLine("2.Update Student");
    Console.WriteLine("3.Get Any Record");
    Console.WriteLine("4. Get All Records");
    Console.WriteLine("5. Add Module");
    Console.WriteLine("6. Get any Module");
    Console.WriteLine("7.Get All Modules");
    Console.WriteLine("8. Update Module");
    Console.WriteLine("9. Find Modules");
    Console.WriteLine("0.Exit");
    Console.WriteLine("Enter Your Choice: ");
    
    Choice = int.Parse(Console.ReadLine());
    
    switch (Choice)
    {
        case 1:
           
            StudentInfo.AddStudent();
           
            break;

            case 2:
            
            break;

        case 3:
            break;

        case 4:
            StudentInfo.Display();
            break;


        default:
            if (Choice == 0)
                Console.WriteLine("Exting");
            else
                Console.WriteLine("Entered Choice is Invalid");
            break;
    }

}
while (Choice != 0);



