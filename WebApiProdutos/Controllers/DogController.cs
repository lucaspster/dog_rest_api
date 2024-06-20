using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApiDog.Models;

namespace WebApiDog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DogController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetBreeds()
        {
            var breeds = await FetchBreedsAsync();
            return Ok(breeds);
        }

        public static async Task<BreedResponse> FetchBreedsAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "https://dogapi.dog/api/v2/breeds";
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<BreedResponse>(responseBody);
            }
        }
    }

}
