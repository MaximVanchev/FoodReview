using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace FoodReview.Infrastructure.Data
{
    public class FoodReviewContextFactory : IDesignTimeDbContextFactory<FoodReviewContext>
    {
        public FoodReviewContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<FoodReviewContext>();
            optionsBuilder.UseSqlServer("Server=172.17.192.1,1433;Database=FoodReview_Container;User Id=sa;Password=Maxmen111;TrustServerCertificate=True;"); // Replace with your actual connection string

            return new FoodReviewContext(optionsBuilder.Options);
        }
    }
}