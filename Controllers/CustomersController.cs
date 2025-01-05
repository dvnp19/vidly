using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vidly.Models;

namespace Vidly.Controllers;

public class CustomersController : Controller
{
    private  DataContext _context;

    public CustomersController()
    {
        _context = new DataContext();
    }

    protected override void Dispose(bool disposing)
    {
       _context.Dispose();
    }

    public ActionResult Index()
    {
        var customers = _context.Customers.Include(c=>c.MembershipType).ToList();
        return View(customers);
    }
    
    public ActionResult Details(int id)
    {
        var customer = _context.Customers.Include(c=>c.MembershipType).SingleOrDefault(c => c.Id == id);
        if (customer == null)
            return NotFound();
        return View(customer);
    }
}