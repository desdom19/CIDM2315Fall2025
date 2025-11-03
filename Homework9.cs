namespace Homework9;

using System.Dynamic;
using System.Linq;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        //Creating students
        Student stu_1 = new Student(111, "Alice");
        Student stu_2 = new Student(222, "Bob");
        Student stu_3 = new Student(333, "Cathy");
        Student stu_4 = new Student(444, "David");

        //Creating gradebook
        Dictionary<string, double> gradebook = new Dictionary<string, double>();
        gradebook.Add("Alice", 4.0);
        gradebook.Add("Bob", 3.6);
        gradebook.Add("Cathy", 2.5);
        gradebook.Add("David", 1.8);
        
        //Checking and adding Tom to gradebook

        if (gradebook.ContainsKey("Tom"))
        {
            Console.WriteLine($"Student Tom is in gradebook.");
        }
        else
        {
            gradebook.Add("Tom", 3.3);
        }

        //Calculating average gpa from total gpa

        double totalGPA = 0;
        foreach (var grade in gradebook)
        {

            totalGPA += grade.Value;

        }

        double averageGPA = totalGPA / gradebook.Count;
        Console.WriteLine($"The average GPA is: {averageGPA}");

        //Printing Students with GPA above average

        foreach(var stu in Student.student_list)
        {
            if (gradebook[stu.getStudentName()] > averageGPA)
            {
                stu.PrintInfo();
            }
        }



    }
}

//Student Class
class Student
{

    private int studentID { get; set; }
    private string studentName = string.Empty;
    public string getStudentName()
    {
        return studentName;
    }
    public void setStudentName(string name)
    {
        studentName = name;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}");
    }


    public static List<Student> student_list = new List<Student>();

//Student Constructor
    public Student(int stuID, string stuName)
    {
        studentID = stuID;
        studentName = stuName;
        student_list.Add(this);


    }


}
