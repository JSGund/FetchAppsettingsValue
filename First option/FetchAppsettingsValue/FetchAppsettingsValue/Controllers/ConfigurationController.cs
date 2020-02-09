namespace FetchAppsettingsValue.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using System.Collections.Generic;

    [Route("api/Configuration")]
    [ApiController]
    public class ConfigurationController : ControllerBase
    {
        private readonly IConfiguration _config;

        public ConfigurationController(IConfiguration config)
        {
            _config = config;
        }

        // GET: api/Configuration
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var result = _config.GetValue<string>("Logging:LogLevel:Default");
            return new string[] { result.ToString() };
        }
    }
}
