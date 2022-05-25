using Microsoft.AspNetCore.Mvc;
using MovieApi.Core.Domain;
using MovieApi.Core.Service;

namespace MoviesAPI.Application.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        private readonly IUpsertMovie _upsetMovie;

        public MovieController(IUpsertMovie upsetMovie)
        {
            _upsetMovie = upsetMovie;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }


        [HttpPost]
        public IActionResult ToAdd([FromBody] Movie movie)
        {
            _upsetMovie.Execute(movie);
            return CreatedAtAction(nameof(GetById), new { Id = movie.Id }, movie);
        }
    }
}
