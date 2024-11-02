using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodReview.Infrastructure.Data
{
    public class FoodReviewContext : IdentityDbContext<User>
    {
        public FoodReviewContext(DbContextOptions<FoodReviewContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Discount> Discounts { get; set; }

        public DbSet<FoodPlace> FoodPlaces { get; set; }
    }
}
