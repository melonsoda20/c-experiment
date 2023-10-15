using Experiment.Model;
using Refit;

namespace Experiment.ApiClient.Interfaces
{
    public interface IUsersClientForRefit
    {
        [Get("/users")]
        Task<IEnumerable<UserSampleRefit>> GetAll();
    }
}
