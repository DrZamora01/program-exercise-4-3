using System;
using static System.Console;
class Admission
{
    static void Main()
    {
        Console.WriteLine("enter student gpa: ");
        double Gpa = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("enter student test score: ");
        int testScore = Convert.ToInt32(Console.ReadLine());



        if (testScore >= 60 && Gpa >= 3.0 || testScore >= 80 && Gpa < 3.0)
        {
            Console.WriteLine("Accept");
        }

        //if (Gpa < 3.0 || testScore < 60)
        // {Console.WriteLine("Accept");}


        else { Console.WriteLine("Reject"); }


    }
}