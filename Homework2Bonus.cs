namespace Homework2Bonus;

class Program
{
    static void Main(string[] args)
    {
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
        
    }
}


