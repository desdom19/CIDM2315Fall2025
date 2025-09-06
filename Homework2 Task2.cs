namespace Homework2Part2;

class Program
{
    static void Main(string[] args)
    {


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
    } 
}
