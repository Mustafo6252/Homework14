namespace Homework14;

public class Birds
{
    public int sum = 0;
    public int count = 0;
    
// // ----------------------------------------  Task 2  -------------------------------------------
    
    public void LastWeek(List<int> numberOfBirds)
    {
        Console.Write("Last Week Counts: ");
        foreach (int i in numberOfBirds)
        {
            Console.Write(i+" ");
        }
    }

// // ----------------------------------------  Task 3  -------------------------------------------
    
    public void Today(List<int> numberOfBirds)
    {
        Console.WriteLine($"Today Counts: {numberOfBirds[numberOfBirds.Count-1]}");
    }

// // ----------------------------------------  Task 4  -------------------------------------------
    
    public void IncrementToday(List<int> numberOfBirds)
    {
        numberOfBirds[numberOfBirds.Count - 1]++;
        Console.WriteLine($"Today Counts: {numberOfBirds[numberOfBirds.Count-1]}");
    }

// // ----------------------------------------  Task 5  -------------------------------------------
    
    public void HasDayWithoutBirds(List<int> numberOfBirds)
    {
        if (numberOfBirds.Contains(0))
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }

// // ----------------------------------------  Task 6  -------------------------------------------
    
    public void CountForFirstDay(int number, List<int> numberOfBirds)
    {
        while (true)
        {
            if (numberOfBirds[count] == number)
            {
                break;
            }
            
            sum += numberOfBirds[count];
            count++;
        }
        Console.WriteLine($"Yig'indi: {sum}");
    }
    
// // ----------------------------------------  Task 7  -------------------------------------------

    public void BusyDays(List<int> numberOfBirds)
    {
        foreach (int i in numberOfBirds)
        {
            if(i>=5)
                count++;
        }
        Console.WriteLine($"Busy Counts: {count}");
    }
}