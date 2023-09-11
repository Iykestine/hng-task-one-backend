using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace HNGtask.Controllers
{
    [Route("api")]
    [ApiController]
    public class TaskController : ControllerBase
    {

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetProfile(string slack_name="Iykestine", string track="backend")
        {
            var originalTime = DateTime.UtcNow;

            var profile = new Profile
            {
                Slack_name = slack_name,
                Current_day = DateTime.Today.DayOfWeek.ToString(),
                Utc_time = originalTime.ToString("yyyy-MM-ddTHH:mm:ssZ"), // Truncate milliseconds and convert back to string
                Track = track,
                Github_file_url = track,
                Github_repo_url = track,
                Status_code = 200,
            };

            return Ok(profile);
        }
    }
}
