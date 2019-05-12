using Microsoft.EntityFrameworkCore;
using Queries.Core.EntityConfigurations;
using Queries.Core.Model;

namespace Queries.Core.Data
{
  public class PlutoContext : DbContext
  {
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseMySql("server=127.0.0.1;user id=root;password=felina;port=3306;database=QueriesCore;");
    }

    public virtual DbSet<Author> Authors { get; set; }
    public virtual DbSet<Course> Courses { get; set; }
    public virtual DbSet<Tag> Tags { get; set; }
    public virtual DbSet<CourseTag> CourseTags { get; set; }
    public virtual DbSet<CourseCover> CourseCovers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.ApplyConfiguration(new CourseTagsConfiguration());
      modelBuilder.ApplyConfiguration(new TagConfiguration());
      modelBuilder.ApplyConfiguration(new AuthorConfiguration());
      modelBuilder.ApplyConfiguration(new CourseConfiguration());
    }
  }
}
