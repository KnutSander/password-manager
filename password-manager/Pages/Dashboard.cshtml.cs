using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace password_manager.Pages;
public class DashboardController : Controller
{
    public IActionResult Dashboard()
    {
        // Add logic for dashboard page
        return View();
    }
}