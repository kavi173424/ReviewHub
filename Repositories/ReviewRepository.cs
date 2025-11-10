using ReviewHubOrchestrationAPI.Models;

namespace ReviewHubOrchestrationAPI.Repositories
{
    public class ReviewRepository : IReviewRepository
    {
        public ReviewResponseModel GetReviewData(ReviewRequestModel request)
        {
            // Dummy data for now (later connect DB or API)
            return new ReviewResponseModel
            {
                ProductName = request.ProductName,
                Summary = $"Fetched review data for {request.ProductName} from repository.",
                Rating = 4.2,
                Source = request.Platform
            };
        }
    }
}
