using Microsoft.EntityFrameworkCore;
using Week02.Data;

namespace Week02.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Week02Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<Week02Context>>()))
            {

                if (context.Movie.Any())
                {
                    return;
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Rating = "R",
                        Price = 7.99M
                    },
                    new Movie
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Rating = "R",
                        Price = 8.99M
                    },
                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Rating = "R",
                        Price = 9.99M
                    },
                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Rating = "R",
                        Price = 3.99M
                    }, new Movie
                    {
                        Title = "Toy Story 3",
                        ReleaseDate = DateTime.Parse("2010-6-18"),
                        Genre = "Animation",
                        Rating = "G",
                        Price = 10.99M
                    },
                    new Movie
                    {
                        Title = "Blade Runner",
                        ReleaseDate = DateTime.Parse("1982-6-25"),
                        Genre = "Science Fiction",
                        Rating = "R",
                        Price = 9.99M
                    },
                    new Movie
                    {
                        Title = "Titanic",
                        ReleaseDate = DateTime.Parse("1997-12-19"),
                        Genre = "Drama",
                        Rating = "PG-13",
                        Price = 11.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
