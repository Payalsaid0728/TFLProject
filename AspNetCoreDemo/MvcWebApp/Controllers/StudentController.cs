using Microsoft.AspNetCore.Mvc;
using Student.Models;
namespace Student.Controllers;

public class StudentController: Controller
{
    public IActionResult Name()
    {
        return View();
    }
    public IActionResult Details()
    {
        return View();
    }
}
