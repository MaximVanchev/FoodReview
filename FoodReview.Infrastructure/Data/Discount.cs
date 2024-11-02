using FoodReview.Infrastructure.Data.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodReview.Infrastructure.Data
{
    public class Discount
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        public Guid Code { get; set; } = Guid.NewGuid();

        [Required]
        [Range(DatabaseConstants.Percent_Min_Range, DatabaseConstants.Percent_Max_Pange)]
        public int Percent { get; set; }

        [Required]
        [StringLength(DatabaseConstants.Info_Max_Length)]
        public string Info { get; set; }

        public bool IsUsed { get; set; } = false;

        [Required]
        [StringLength(DatabaseConstants.Guid_Max_Length)]
        public Guid FoodPlaceId { get; set; }

        [ForeignKey(nameof(FoodPlaceId))]
        public FoodPlace FoodPlace { get; set; }
    }
}
