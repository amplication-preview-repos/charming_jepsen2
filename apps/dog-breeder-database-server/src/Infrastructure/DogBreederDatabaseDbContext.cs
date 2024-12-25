using Microsoft.EntityFrameworkCore;

namespace DogBreederDatabase.Infrastructure;

public class DogBreederDatabaseDbContext : DbContext
{
    public DogBreederDatabaseDbContext(DbContextOptions<DogBreederDatabaseDbContext> options)
        : base(options) { }
}
