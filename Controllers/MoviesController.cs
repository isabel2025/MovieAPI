using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieAPI.Models;

namespace MovieAPI.Controllers
{

    [Route("api/[controller]")]
    public class MoviesController : Controller
    {
        private WebApiDataContext _webApiDataContext;

        public MoviesController(WebApiDataContext webApiDataContext)
        {
            _webApiDataContext = webApiDataContext;
        }

        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return _webApiDataContext.Movies.AsEnumerable();
        }

        [HttpGet("{id}")]
        public Movie Get(int id)
        {
            return _webApiDataContext.Movies.FirstOrDefault(x => x.Id == id);
        }

        [HttpPost]
        public void Post([FromBody] Movie movie)
        {
            _webApiDataContext.Add(movie);
            _webApiDataContext.SaveChanges();
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Movie movie)
        {
            var selesctedMovie = _webApiDataContext.Movies.AsNoTracking().FirstOrDefault(x => x.Id == id);
            if (selesctedMovie != null)
            {
                _webApiDataContext.Entry(selesctedMovie).Context.Update(movie);
                _webApiDataContext.SaveChanges();
            }
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var movie = _webApiDataContext.Movies.FirstOrDefault(x => x.Id == id);
            if (movie != null)
            {
                _webApiDataContext.Movies.Remove(movie);
                _webApiDataContext.SaveChanges();
            }




        }



    }
}



