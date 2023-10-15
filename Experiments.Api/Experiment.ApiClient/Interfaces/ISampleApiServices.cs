using Experiment.Model;

namespace Experiment.ApiClient.Interfaces
{
    public interface ISampleApiServices
    {
        Task<IEnumerable<UserSample>> GetAllSampleUsers();
    }
}
