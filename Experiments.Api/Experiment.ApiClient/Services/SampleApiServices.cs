using Experiment.ApiClient.Interfaces;
using Experiment.Model;
using Experiment.Model.Mapper;

namespace Experiment.ApiClient.Services
{
    public class SampleApiServices : ISampleApiServices
    {
        private readonly IUsersClientForRefit _usersClientForRefit;
        public SampleApiServices(IUsersClientForRefit usersClientForRefit)
        {
            _usersClientForRefit = usersClientForRefit;
        }

        public async Task<IEnumerable<UserSample>> GetAllSampleUsers()
        {
            var userData = await _usersClientForRefit.GetAll();
            List<UserSample> userSamples = new();

            foreach(var data in userData)
            {
                var userSample = MapModels.MapFrom(data);
                userSamples.Add(userSample);
            }

            return userSamples;
        }
    }
}
