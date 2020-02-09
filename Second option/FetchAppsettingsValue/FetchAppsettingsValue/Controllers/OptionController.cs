namespace FetchAppsettingsValue.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Options;
    using System.Collections.Generic;

    [Route("api/Option")]
    [ApiController]
    public class OptionController : ControllerBase
    {
        private readonly IOptions<Logging> _logging;

        public OptionController(IOptions<Logging> logging)
        {
            _logging = logging;
        }

        // GET: api/Option
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var result = _logging.Value.LogLevel.Default; // "Information"

            return new string[] { result };
        }
    }
}
