using System;
using System.Linq;
using Queries.Core.Data;

namespace Queries.Core
{
  class Program
  {
    static void Main(string[] args)
    {
      var context = new PlutoContext();

      // LINQ syntax
      Console.WriteLine("LINQ syntax");
      var query =
        from c in context.Courses
        where c.Name.Contains("C#")
        orderby c.Name
        select c;
      foreach (var querycourses in query)
      {
        Console.WriteLine(querycourses.Name);
      }

      Console.WriteLine("Extension methods");
      // Extension methods
      var courses = context.Courses.Where(c => c.Name.Contains("C#")).OrderBy(c => c.Name);
      foreach (var course in courses)
      {
        Console.WriteLine(course.Name);
      }

    }
  }
}
