using Microsoft.EntityFrameworkCore;

namespace Week02.Data
{
    public class Week02Context : DbContext
    {
        public Week02Context(DbContextOptions<Week02Context> options)
            : base(options)
        {
        }

        public DbSet<Week02.Models.Movie> Movie { get; set; } = default!;
    }
}
