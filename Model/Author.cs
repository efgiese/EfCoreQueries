using System.Collections.Generic;

namespace Queries.Core.Model
{
  public class Author
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<Course> Courses { get; set; }
  }
}
