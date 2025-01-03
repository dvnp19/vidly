using Microsoft.AspNetCore.Mvc;
using Vidly.Models;

namespace Vidly.Controllers;

public class MoviesController : Controller
{
    public ActionResult Random()
    {
        var movie = new Movie() {Name = "Shrek"};
        return View(movie);
    }
    
    public ViewResult Index()
    {
        var movies = GetMovies();
        return View(movies);    
    }
    private IEnumerable<Movie> GetMovies()
    {
        return new List<Movie>
        {
            new Movie { Id = 1, Name = "Shrek" },
            new Movie { Id = 2, Name = "Wall-e" }
        };
    }
}