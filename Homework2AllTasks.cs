namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
        //Code for Q1
        /* Console.WriteLine("Please input a letter grade: ");
        string letter = Console.ReadLine();

        
        if (letter == "A")
        {
            Console.WriteLine("GPA Point: 4");
        }
        else if (letter == "B")
        {
            Console.WriteLine("GPA Point: 3");
        }
        else if (letter == "C")
        {
            Console.WriteLine("GPA Point: 2");
        }
        else if (letter == "D")
        {
            Console.WriteLine("GPA Point: 1");
        }
        else if (letter == "F")
        {
            Console.WriteLine("GPA Point: 0");
        }
        else
        {
            Console.WriteLine("Wrong Letter Grade!");
        }

        //Code for Q2 
        Console.WriteLine("Please input the first number: ");
        string num_1 = Console.ReadLine();
        int num1_int = Convert.ToInt16(num_1);

        Console.WriteLine("Please input the second number: ");
        string num_2 = Console.ReadLine();
        int num2_int = Convert.ToInt16(num_2);

        Console.WriteLine("Please input the third number: ");
        string num_3 = Console.ReadLine();
        int num3_int = Convert.ToInt16(num_3);


    
        if (num1_int < num2_int)
        {
            if (num1_int < num3_int)
            {
                Console.WriteLine($"The smallest value is {num1_int}");
            }
            else
            {
                Console.WriteLine($"The smallest value is {num3_int}");
            }
        }
        else
        {
            if (num2_int < num3_int)
            {
                Console.WriteLine($"The smallest value is {num2_int}");
            }
            else
            {
                Console.WriteLine($"The smallest value is {num3_int}");
            }
        } 

        //Code for bonus Q
         Console.WriteLine("Please input a year: ");
        string year = Console.ReadLine();
        int year_int = Convert.ToInt16(year);

        int leap_year = year_int % 4;
        int confirmleap_year = year_int % 400;
        int notleap_year = year_int % 100;
        
        // if year can be exactly divided by 400, it's a leap year
        if (confirmleap_year == 0)
        {
            Console.WriteLine($"{year_int} is a leap year.");
        } //if year can not be exactly divided by 400, but can be exactly divided by 100, it's not a leap year
        else if (notleap_year == 0)
        {
            Console.WriteLine($"{year_int} is not leap year.");
        } // if year can not be exactly divided by 100, but can be exactly divided by 4, it's a leap year
        else if (leap_year == 0)
        {
            Console.WriteLine($"{year_int} is a leap year.");
        } // if year can not be exactly divided by general rule of 4, it's not a leap year
        else
        {
            Console.WriteLine($"{year_int} is not leap year.");
        }

*/

    }
}
