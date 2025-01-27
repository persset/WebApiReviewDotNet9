
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiReviewDotNet9.Models;

namespace WebApiReviewDotNet9.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoGameController : ControllerBase
    {
        static private List<VideoGame> videoGames = new List<VideoGame>
        {
            new VideoGame
            {
                Id = 1,
                Title = "Monster Hunter",
                Platform = "PS2",
                Developer = "Capcom",
                Publisher = "Capcom"
            },
            new VideoGame
            {
                Id = 2,
                Title = "The Legend of Zelda",
                Platform = "NES",
                Developer = "Nintendo",
                Publisher = "Nintendo"
            },
            new VideoGame
            {
                Id = 3,
                Title = "Yakuza Kiwami",
                Platform = "PC",
                Developer = "Ryu Ga Gotoku Studio",
                Publisher = "Sega"
            }
        };
        [HttpGet]
        public ActionResult<List<VideoGame>> GetVideoGames()
        {
            return Ok(videoGames);
        }
    }
}
