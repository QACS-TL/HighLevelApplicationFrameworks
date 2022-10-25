using Microsoft.AspNetCore.Mvc;
using MoviesDataLayer;
using MoviesDataLayer.Models;
using System.IO.Pipelines;
using System.Net;

namespace TicketPriceCalculator.Controllers
{
    [ApiController]
    public class TicketController : ControllerBase
    {

        [HttpGet]
        [Route("tickets/{adultcount?}/{childcount?}")]
        public CustomerTicket GetTicket([FromBody] RequestBody body, int adultcount=0, int childCount=0)
        {
            EFMoviesDBFirst movies = new EFMoviesDBFirst();
            Movie movie = movies.GetMovieById(body.Film_id);


            CustomerTicket ticket = new CustomerTicket
            {
                FilmID = body.Film_id.ToString(),
                Title = movie.Title,
                AdultCount = adultcount,
                ChildCount = childCount,
                Date = body.Date,
                Time = body.Time
            };

            return ticket;
        }
    }
}
