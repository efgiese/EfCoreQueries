namespace Queries.Core.Model
{
  public class CourseCover
  {
    public int CourseCoverId { get; set; }
    public int CoverOfCourseId { get; set; }
    public Course Course { get; set; }
  }
}
