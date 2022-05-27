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
        private readonly ISearchAllMovie _searchAllMovie;
        private readonly ISearchOneMovie _searchOneMovie;
        private readonly IDeleteMovie _deleteMovie;


        public MovieController(IAddMovie addMovie, IUpdateMovie updateMovie, ISearchAllMovie searchAllMovie, ISearchOneMovie searchOneMovie, IDeleteMovie deleteMovie)
        {
            _addMovie = addMovie;
            _updateMovie = updateMovie;
            _searchAllMovie = searchAllMovie;
            _searchOneMovie = searchOneMovie;
            _deleteMovie = deleteMovie;
        }

        [HttpGet]
        public IActionResult GetAll() =>
            Ok(_searchAllMovie.Execute());

        [HttpGet("{id}")]
        public IActionResult GetById(string id) =>
            Ok(_searchOneMovie.Execute(id));


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
            Console.WriteLine(id);
            movieDTO.Id = id;
            var movieResponse = _updateMovie.Execute(movieDTO.ToMovie()).ToMovieDTO();
            return Ok(movieResponse);
        }

        [HttpDelete("{id}")]
        public IActionResult ToDelete(string id)
        {
            _deleteMovie.Execute(id);
            return Ok();
        }
    }
}
