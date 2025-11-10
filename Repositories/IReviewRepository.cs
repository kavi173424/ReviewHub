using ReviewHubOrchestrationAPI.Models;

namespace ReviewHubOrchestrationAPI.Repositories
{
    public interface IReviewRepository
    {
        ReviewResponseModel GetReviewData(ReviewRequestModel request);
    }
}
