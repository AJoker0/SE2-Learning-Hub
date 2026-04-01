using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers
{
    [ApiController]
    [Route("test")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpPost]
        [Route("house-party")]
        public IActionResult Hello([FromBody] HousePartyInput input)
        {
            List<string> result = new List<string>();
            List<string> coming = new List<string>();

            for (int i = 0; i < input.Lines; i++)
            {
                string command = input.Commands[i];

                string name = command.Substring(0, command.IndexOf(' '));

                if (command.Contains("not"))
                {
                    if (coming.Contains(name))
                    {
                        coming.Remove(name);
                    }
                    else
                    {
                        result.Add($"{name} is not in the list");
                    }
                }
                else
                {
                    if (coming.Contains(name))
                    {
                        result.Add($"{name} is already in the list");
                    }
                    else
                    {
                        coming.Add(name);
                    }
                }
            }

            foreach (string name in coming)
            {
                result.Add(name);
            }

            return Ok(result);
        }
    }
}
