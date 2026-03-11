using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using StayPoint.WebUI.Dtos.FollowersDtos;
using System.Net.Http.Headers;
using System.Threading.Tasks;
namespace StayPoint.WebUI.ViewComponents.DashboardViewComponents
{
    public class _DashboardSubscribeCountComponentPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://instagram-profile1.p.rapidapi.com/getprofile/yourusername"),
                Headers =
    {
        { "x-rapidapi-key", "your-api-key" },
        { "x-rapidapi-host", "instagram-profile1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                ResultInstagramFollowerDto resultInstagramFollowerDtos = JsonConvert.DeserializeObject<ResultInstagramFollowerDto>(body);
                ViewBag.v1 = resultInstagramFollowerDtos.followers;
                ViewBag.v2 = resultInstagramFollowerDtos.following;




                var client2 = new HttpClient();
                var request2 = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://twitter135.p.rapidapi.com/v1.1/Users/?usernames=yourusername"),
                    Headers =
    {
        { "x-rapidapi-key", "your-api-key" },
        { "x-rapidapi-host", "twitter135.p.rapidapi.com" },
    },
                };
                using (var response2 = await client.SendAsync(request2))
                {
                    response.EnsureSuccessStatusCode();
                    var body2 = await response.Content.ReadAsStringAsync();
                    ResultTwittterFollowersDto resultTwittterFollowersDto = JsonConvert.DeserializeObject<ResultTwittterFollowersDto>(body2);
                    ViewBag.v3 = resultTwittterFollowersDto.followers_count;
                    ViewBag.v4 = resultTwittterFollowersDto.friends_count;
                }



                return View();
            }
        }
    }
}