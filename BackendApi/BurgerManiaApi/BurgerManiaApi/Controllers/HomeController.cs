using Contracts;
using Microsoft.AspNetCore.Mvc;

namespace BurgerManiaApi.Controllers
{
    public class HomeController : Controller
    {
        private ILoggerManager _logger;
        
        public HomeController(ILoggerManager logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            _logger.LogInfo("Info from home controller");
            _logger.LogDebug("Debug from home controller");
            _logger.LogWarning("Warning from home controller");
            _logger.LogError("Error from home controller");

            return new string[] { "value1, value2" };
        }
    }
}
