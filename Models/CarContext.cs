using Microsoft.EntityFrameworkCore;

namespace dhbw_vs_aspdotnetcoretutorial.Models
{
    public class CarContext : DbContext
    {
        public CarContext(DbContextOptions<CarContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Car { get; set; }

    }
}
