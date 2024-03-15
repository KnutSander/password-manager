using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace password_manager.Pages;

public class IndexModel : Controller
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult LoginPost(string username, string password)
    {
        if (IsValid(username, password))
        {
            return RedirectToAction("Dashboard", "DashboardController");
        }
        else
        {
            ViewBag.ErrorMessage = "Invalid username or password";
            return View();
        }
    }

    private bool IsValid(string username, string password)
    {
        // More logic to follow
        return username == "admin" && password == "password";
    }
}
