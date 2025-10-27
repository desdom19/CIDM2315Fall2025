using System.Runtime.InteropServices.Marshalling;

namespace Homework8;

class Program
{
    static void Main(string[] args)
    {
// Customer objects and customer_list
        Customer cus1 = new Customer(customerName: "Alice", customerAge: 33, customerCity: "Amarillo", customerCredit: 198.5);
        Customer cus2 = new Customer(customerName: "Bob", customerAge: 23, customerCity: "Amarillo", customerCredit: 226);
        Customer cus3 = new Customer(customerName: "Cathy", customerAge: 45, customerCity: "Amarillo", customerCredit: 89.0);
        Customer cus4 = new Customer(customerName: "David", customerAge: 58, customerCity: "Amarillo", customerCredit: 198.5);
        Customer cus5 = new Customer(customerName: "Jack", customerAge: 28, customerCity: "Canyon", customerCredit: 561.6);
        Customer cus6 = new Customer(customerName: "Tom", customerAge: 36, customerCity: "Canyon", customerCredit: 98.4);
        Customer cus7 = new Customer(customerName: "Tony", customerAge: 24, customerCity: "Canyon", customerCredit: 18.5);
        Customer cus8 = new Customer(customerName: "Sam", customerAge: 35, customerCity: "Canyon", customerCredit: 228.3);

        Customer[] customer_list = { cus1, cus2, cus3, cus4, cus5, cus6, cus7, cus8 };
// Calling Q1, Q2, Q3 methods
        TotalCredits(customer_list);
        AmarilloAverageAge(customer_list);
        CanyonAge(customer_list);

    }


// Q1 method
    public static void TotalCredits(Customer[] customer_list)
    {
        double totalCredit = 0.0;

        foreach (Customer cusObject in customer_list)
        {
            totalCredit += cusObject.customerCredit;

        }

        Console.WriteLine($"the total credits: {totalCredit}");


    }

// Q2 method
    public static void AmarilloAverageAge(Customer[] customer_list)
    {
        double totalAmarilloAge = 0;
        int countAmarilloAge = 0;

        foreach (var cusObject in customer_list)
        {
            if (cusObject.customerCity == "Amarillo")
            {
                totalAmarilloAge += cusObject.customerAge;
                countAmarilloAge++;
            }
        }

        if (countAmarilloAge > 0)
        {
            double averageAmarilloAge = totalAmarilloAge / countAmarilloAge;
            Console.WriteLine($"The average age of customers in Amarillo: {averageAmarilloAge}");
        }
    }

// Q3 method
    public static void CanyonAge(Customer[] customer_list)
    {
        Console.Write($"Customers who live in Canyon and over 30 years old: ");

        foreach (var cusObject in customer_list)
        {
            if (cusObject.customerCity == "Canyon" && cusObject.customerAge > 30)
            {


                Console.Write($"{cusObject.customerName}, ");


            }


        }
    }




}
    



// Customer class
    class Customer
    {
        public string customerName { get; set; } = string.Empty;
        public int customerAge { get; set; } = 0;
        public string customerCity { get; set; } = string.Empty;
        public double customerCredit { get; set; } = 0.0;
        public Customer(string customerName, int customerAge, string customerCity, double customerCredit)
        {
            this.customerName = customerName;
            this.customerAge = customerAge;
            this.customerCity = customerCity;
            this.customerCredit = customerCredit;
        }
}


    