using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentExercises
{
  class Program
  {
    static void Main(string[] args)
    {
      var students = new List<Student>();

      students.Add(new Student
      {
        FirstName = "Brenda",
        LastName = "Long",
      });
      students.Add(new Student
      {
        FirstName = "Maggie",
        LastName = "Greene",
        Exercises = new List<Exercise>()
        {
            new Exercise
            {
                Name = "Nutshell",
                Language = "JS"
            }
        }
      });
      students.Add(new Student
      {
        FirstName = "Jasmine",
        LastName = "Williams",
        Exercises = new List<Exercise>()
        {
            new Exercise
            {
                Name = "Nutshell",
                Language = "JS"
            },
            new Exercise
            {
                Name = "Bangazon",
                Language = "Csharp"
            }
        }
      });
      students.Add(new Student
      {
        FirstName = "Rose",
        LastName = "Wiz"
      });

      var exercises = new List<Exercise>();

      exercises.Add(new Exercise
      {
        Name = "Nutshell",
        Language = "JS"
      });

      exercises.Add(new Exercise
      {
        Name = "Bangazon",
        Language = "CSharp"
      });

      exercises.Add(new Exercise
      {
        Name = "Nutshell 2.0",
        Language = "JS"
      });

      var allJsExercises = exercises.Where(exercise =>
      {
        return exercise.Language == "JS";
      });

      foreach (var exercise in allJsExercises)
      {
        Console.WriteLine(exercise.Name);
      }

      var studentsOrderedByLastName = students.OrderBy(student =>
      {
        return student.LastName;
      });

      foreach (var student in studentsOrderedByLastName)
      {
        Console.WriteLine($"{student.FirstName} {student.LastName}");
      }

      var studentsWithNoExercises = students.Where(student =>
      {
        int exercisesCount = student.Exercises.Count;

        return exercisesCount == 0;
      });

      Console.WriteLine("These students aren't working on any exercises.");

      foreach (var student in studentsWithNoExercises)
      {
        Console.WriteLine(student.FirstName);
      }

      var studentWithMostExercises = students.OrderByDescending(student =>
      {
        return student.Exercises.Count;
      }).FirstOrDefault();

      //   var groups = students.GroupBy(students => students.Cohort.Name);

      //   foreach (var group in groups)
      //   {
      //     Console.WriteLine($"There are {group.Count()} students in {group.Key}");
      //   }
    }
  }
}
