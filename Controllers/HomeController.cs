using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using guardarpdf.Models;
using guardarpdf.Data;

namespace guardarpdf.Controllers;

public class HomeController : Controller
{
    private readonly ApplicationDbContext _context;

    public HomeController(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var archivo = new Ejemplo();

        

        _context.ejemplo.Add(archivo);
        await _context.SaveChangesAsync();

        return View();
    }




    public IActionResult Privacy()
    {
        return View();
    }


}
