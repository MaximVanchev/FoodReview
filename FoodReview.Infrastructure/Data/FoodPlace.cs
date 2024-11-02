using FoodReview.Infrastructure.Data.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodReview.Infrastructure.Data
{
    public class FoodPlace
    {
        public FoodPlace()
        {
            Discounts = new List<Discount>();
            UsersLiked = new List<User>();
        }

        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [StringLength(DatabaseConstants.FoodPlace_Name_Max_Length)]
        public string Name { get; set; }

        public int ReviewPoints { get; set; } = 0;

        public IList<Discount> Discounts { get; set; }

        public IList<User> UsersLiked  { get; set; }
    }
}
