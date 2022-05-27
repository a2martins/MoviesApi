using Microsoft.AspNetCore.Mvc;
using MoviesApi.Application.Controller.DTO;
using MoviesApi.Application.Extensions;
using MoviesApi.Core.Service;

namespace MoviesAPI.Application.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        private readonly IAddMovie _addMovie;
        private readonly IUpdateMovie _updateMovie;

        public MovieController(IAddMovie addMovie, IUpdateMovie updateMovie)
        {
            _addMovie = addMovie;
            _updateMovie = updateMovie;
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
        public IActionResult ToAdd([FromBody] MovieDTO movieDTO)
        {
            Console.WriteLine(movieDTO.ToString());
            var movieResponse = _addMovie.Execute(movieDTO.ToMovie()).ToMovieDTO();
            return CreatedAtAction(nameof(GetById), new { Id = movieResponse.Id }, movieResponse);
        }

        [HttpPut("{id}")]
        public IActionResult ToUpdate(string id, [FromBody] MovieDTO movieDTO)
        {
            movieDTO.Id = id;
            var movieResponse = _updateMovie.Execute(movieDTO.ToMovie()).ToMovieDTO();
            return Ok(movieResponse);
        }
    }
}
