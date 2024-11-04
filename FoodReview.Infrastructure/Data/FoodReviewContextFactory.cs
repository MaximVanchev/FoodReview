using FoodReview.Infrastructure.Data.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace FoodReview.Infrastructure.Data
{
    public class FoodReviewContextFactory : IDesignTimeDbContextFactory<FoodReviewContext>
    {
        public FoodReviewContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<FoodReviewContext>();
            optionsBuilder.UseSqlServer(DatabaseConstants.Connection_String); // Replace with your actual connection string

            return new FoodReviewContext(optionsBuilder.Options);
        }
    }
}