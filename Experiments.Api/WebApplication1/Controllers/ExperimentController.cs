using Experiment.ApiClient.Interfaces;
using Experiment.Model;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExperimentController : ControllerBase
    {
        private readonly ILogger<ExperimentController> _logger;
        private readonly ISampleApiServices _sampleApiServices;

        public ExperimentController(
            ILogger<ExperimentController> logger,
            ISampleApiServices sampleApiServices
        )
        {
            _logger = logger;
            _sampleApiServices = sampleApiServices;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<IEnumerable<UserSample>> GetAllSampleUsers()
        {
            return await _sampleApiServices.GetAllSampleUsers();
        }
    }
}