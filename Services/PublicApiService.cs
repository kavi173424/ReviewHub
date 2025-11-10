using ReviewHubOrchestrationAPI.Models;
using ReviewHubOrchestrationAPI.Repositories;

namespace ReviewHubOrchestrationAPI.Services
{
    public class PublicApiService
    {
        private readonly IReviewRepository _repository;

        public PublicApiService(IReviewRepository repository)
        {
            _repository = repository;
        }

        public ReviewResponseModel GetReviewSummary(ReviewRequestModel request)
        {
            // Fetch data from repository (could later be DB, API, etc.)
            return _repository.GetReviewData(request);
        }
    }
}