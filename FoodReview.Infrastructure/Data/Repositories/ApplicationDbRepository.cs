using FoodReview.Infrastructure.Data;
using FoodReview.Infrastructure.Data.Common;

namespace FoodReview.Infrastructure.Data.Repositories
{
    public class ApplicationDbRepository : Repository, IApplicationDbRepository
    {
        public ApplicationDbRepository(FoodReviewContext context)
        {
            this.Context = context;
        }
    }
}