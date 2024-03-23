using Microsoft.AspNetCore.Mvc;
using StackExchange.Redis;
using System.Diagnostics;

namespace ContainerAppDemoTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RedisController : ControllerBase
    {
        private readonly ILogger<RedisController> _logger;

        public RedisController(ILogger<RedisController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<string> Get()
        {
            var redisHost = Environment.GetEnvironmentVariable("REDIS_HOST") ?? "redis";
            var redis = ConnectionMultiplexer.Connect($"{redisHost}:6379");
            var db = redis.GetDatabase();

            var key = "testKey";
            var value = "This is a test value";

            var stopwatch = Stopwatch.StartNew();

            db.StringSet(key, value);

            stopwatch.Stop();

            var currentTime = DateTime.Now;

            // Formatting elapsed time to include more precision (e.g., milliseconds to two decimal places)
            var elapsedTime = stopwatch.Elapsed.TotalMilliseconds.ToString("0.00");

            // Formatting the current time to include milliseconds
            var formattedCurrentTime = currentTime.ToString("yyyy-MM-dd HH:mm:ss.fff");

            return Ok($"Inserted into Redis. Time taken: {elapsedTime} ms. Current server time: {formattedCurrentTime}");
        }
    }
}
