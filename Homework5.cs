namespace Homework5;

class Program
{


    static void Main(string[] args)
    {



        //Call Q1_method()

        Console.WriteLine("Enter two numbers: ");
        int num_1 = GetNumber();
        int num_2 = GetNumber();


        Console.WriteLine($"a = {num_1}; b = {num_2}");

        int returned_largest = LargestNumber(num_1, num_2);
        Console.WriteLine($"The largest number is: {returned_largest}");




        //Call Q2_method()

        Console.WriteLine("Enter four numbers: ");
        int num_1 = GetNumber();
        int num_2 = GetNumber();
        int num_3 = GetNumber();
        int num_4 = GetNumber();

        Console.WriteLine($"a = {num_1}; b = {num_2}; c = {num_3}; d = {num_4}");

        int returned_maxone = LargestNumber(num_1, num_2);
        int returned_maxtwo = LargestNumber(num_3, num_4);
        int returned_largest = LargestNumber(returned_maxone, returned_maxtwo);
        Console.WriteLine($"The largest number is: {returned_largest}");



        //Q1_method

        static int GetNumber()
        {
            string input_num = Console.ReadLine();
            int input_int = Convert.ToInt16(input_num);
            return input_int;
        }
        static int LargestNumber(int x, int y)
        {
            if (x > y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }

        //Q2_method

        static int GetNumber()
        {
            string input_num = Console.ReadLine();
            int input_int = Convert.ToInt16(input_num);
            return input_int;
        }
        static int LargestNumber(int x, int y)
        {
            if (x > y)
            {
                return x;

            }
            else
            {
                return y;
            }
        }

        //Call Q3_method() 

        createAccount();

    }

        //Q3_method
    static bool checkAge(int birth_year)
    {
        int current_year = 2025;
        int age = current_year - birth_year;
        if (age >= 18)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    static void createAccount()
    {
        Console.WriteLine("Please enter your username: ");
        string user_name = Console.ReadLine();

        Console.WriteLine("Please enter your password: ");
        string pass_word = Console.ReadLine();

        Console.WriteLine("Please enter your password again: ");
        string repass_word = Console.ReadLine();

        Console.WriteLine("Please enter your birth year: ");
        string string_birth = Console.ReadLine();
        int int_birth = Convert.ToInt16(string_birth);

        if (checkAge(int_birth) == true)
        {
            if (pass_word == repass_word)
            {
                Console.WriteLine("Account is created successfully");
            }
            else
            {
                Console.WriteLine("Wrong password");
            }

        }
        else
        {
            Console.WriteLine("Could not create an account");

        }



    }
}



       
