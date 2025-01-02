using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class MoviesController : Controller
{
    public ActionResult Random()
    {
        var movie = new Movie() {Name = "Shrek"};
        return View(movie);
    }
}