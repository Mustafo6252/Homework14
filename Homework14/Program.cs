
// // ----------------------------------------  Task 1  -------------------------------------------
//
// using Homework14;
//
// var student=new Student("Mustafo", "Bukhara");
// student.AddCourseGrade("Math",5);
// student.AddCourseGrade("Pysics",5);
// student.AddCourseGrade("Science",4);
// student.AddCourseGrade("geography",3);
// student.AddCourseGrade("biology",4);
// student.PrintGrades();
// Console.WriteLine($"Average grade: {student.GetAverageGrade()}");
// Console.WriteLine(student.toString());
// Console.WriteLine("-----------------------------------------------------");
//
// var teacher=new Teacher("Mario", "Peterson");
// teacher.AddCource("Math");
// teacher.AddCource("Geography");
// teacher.AddCource("Biology");
// teacher.AddCource("Math");
// teacher.AddCource("Science");
// teacher.AddCource("Pysics");
//
// teacher.RemoveCource("Math");
// teacher.RemoveCource("geometry");
//
// teacher.GetInfo();
// Console.WriteLine(teacher.toString());
// Console.WriteLine("-----------------------------------------------------");


using Homework14;
var birds = new Birds();
List<int> counts = new List<int>() { 0, 2, 5, 3, 7, 8, 4 };
List<int> counts2 = new List<int>() { 2, 5, 0, 7, 4, 1 };

// // ----------------------------------------  Task 2  -------------------------------------------
//
// birds.LastWeek(counts);

// // ----------------------------------------  Task 3  -------------------------------------------
//
// birds.Today(counts2);

// // ----------------------------------------  Task 4  -------------------------------------------
//
// birds.IncrementToday(counts2);

// // ----------------------------------------  Task 5  -------------------------------------------
//
// birds.HasDayWithoutBirds(counts2);

// // ----------------------------------------  Task 6  -------------------------------------------
//
// birds.CountForFirstDay(4,counts2);

// // ----------------------------------------  Task 7  -------------------------------------------
//
// birds.BusyDays(counts2);
