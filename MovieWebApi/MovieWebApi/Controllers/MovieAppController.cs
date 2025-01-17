using Microsoft.AspNetCore.Mvc;
using MovieWebApi.Data;
using MovieWebApi.Models;

namespace MovieWebApi.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class MovieAppController : ControllerBase
    {
        private readonly ApiContext _context;

        public MovieAppController(ApiContext context)
        {
            _context = context;
        }

        //create
        [HttpPost]
        public JsonResult Create(MovieApp movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
            return new JsonResult(Ok(movie));
        }
        //list all movies
        [HttpGet("/all")]
        public JsonResult GetAll()
        {
            var result = _context.Movies.ToList();
            return new JsonResult(Ok(result));
        }
        // list one movie
        [HttpGet]
        public JsonResult Get(int id)
        {
            var result = _context.Movies.Find(id);

            if (result == null)
                return new JsonResult(NotFound());

            return new JsonResult(Ok(result));            
        }
        //edit movie
        [HttpPut]
        public JsonResult Edit(MovieApp movie)
        {
            var movieInDb = _context.Movies.Find(movie.Id);

            if (movieInDb == null)
                return new JsonResult(NotFound());

            movieInDb.MovieType = movie.MovieType;
            movieInDb.MovieName = movie.MovieName;
            _context.SaveChanges();

            return new JsonResult(Ok(movie)); 
        }
        //delete movie
        [HttpDelete]
        public JsonResult Delete(int id)
        {
            var result = _context.Movies.Find(id);

            if (result == null)
                return new JsonResult(NotFound());

            _context.Movies.Remove(result);
            return new JsonResult(Ok(result));
        }
    }
}
