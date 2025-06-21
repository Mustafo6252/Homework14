namespace Homework14;

public class Teacher : Person
{
    public int numCources = 0;
    public string[] cources=new string[10];

    public Teacher(string name, string address) : base(name, address)
    {
    }

    // public string toString()
    // {
    //     return name + " " + address;
    // }

    public bool AddCource(string course)
    {
        if (cources.Contains(course))
            return false;
        else
        {
            cources[numCources++] = course;
            return true;
        }
    }

    public bool RemoveCource(string course)
    {
        if (!cources.Contains(course))
            return false;
        else
        {
            cources.ToList().Remove(course);
            return true;
        }
    }

    public void GetInfo()
    {
        Console.WriteLine(
            
            $"""
                1-fan : {cources[0]}
                2-fan : {cources[1]}
                3-fan : {cources[2]}
                4-fan : {cources[3]}
                5-fan : {cources[4]}
             """);
    }

    public override string toString()
    {
        return $"Teacher: {base.toString()}";
    }


}