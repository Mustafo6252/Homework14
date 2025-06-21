namespace Homework14;

public class Student:Person
{
    public int numCourses=0;
    public string[] cources=new string[5];
    public int[] grades=new int[5];
    public double sum = 0;
    public Student(string name, string address) : base(name, address)
    { }

    // public string toString()
    // {
    //     return name + " " + address;
    // }

    public void AddCourseGrade(string course, int grade)
    {
        cources[numCourses] = course;
        grades[numCourses]=grade;
        numCourses++;
    }

    public void PrintGrades()
    {
        for (int i = 0; i < grades.Length; i++)
        {
            Console.WriteLine($"{i+1}-grade: {grades[i]}");
        }
    }

    public double GetAverageGrade()
    {
        for (int i = 0; i < grades.Length; i++)
        {
           sum += grades[i]; 
        }
        return sum / grades.Length;
    }

    public override string toString()
    {
        return $"Student: {base.toString()}";
    }
}