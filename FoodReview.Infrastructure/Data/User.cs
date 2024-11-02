using FoodReview.Infrastructure.Data.Constants;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace FoodReview.Infrastructure.Data
{
    public class User : IdentityUser
    {
        public User()
        {
            LikedFoodPlaces = new List<FoodPlace>();
            Discounts = new List<Discount>();
        }

        public int Points { get; set; } = 0;

        [StringLength(DatabaseConstants.ProfilePicture_Max_Length)]
        public string? ProfilePicture { get; set; }

        public IList<FoodPlace> LikedFoodPlaces { get; set; }

        public IList<Discount> Discounts { get; set; }
    }

}
