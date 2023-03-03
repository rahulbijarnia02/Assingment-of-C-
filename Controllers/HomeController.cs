using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using myapp.Entities;
using myapp.Models;
using MYAPP.Models;

namespace myapp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
    //      var model = new List<UserModel>();
    // model.Add(new UserModel { Name = "Dhruv",age = 21,Salary = 122,Designation = ".Net"});
    // model.Add(new UserModel{ Name = "Rahul",age = 21,Salary = 3613,Designation = ".Net"});
    // model.Add(new UserModel{ Name = "janak", age = 22,Salary = 232,Designation = "React"});
    // return View(model);
    using (var context=new EmployeeDBContext())
        {
            var employeeList=context.EmployeeLists.ToList();
             return View(employeeList);
        }
    }
     public IActionResult Employee()
    {
        using (var context=new EmployeeDBContext())
        {
            var employeeList=context.EmployeeLists.ToList();
            // var emplist=context.Forms.Where(x=>x.EmpId==3).FirstOrDefault();
        }
        return View();
    }
     public IActionResult AddEmployee(UserModel employeeModel)
    {
        using (var context=new EmployeeDBContext())
        {
            UserModel employee=new UserModel();
            // employee.FirstName=employeeModel.FirstName;
            // employee.Name=employeeModel.Name;
            // employee.Email=employeeModel.Email;
            // employee.Password=employeeModel.Password;
            // employee.ConfirmPassword=employee.ConfirmPassword;
            // employee.Contact=employeeModel.Contact;
            // context.Forms.Add(employee);
            // context.SaveChanges();
        }
        return RedirectToAction(actionName: "Index", controllerName: "Home");
        // return View();
    }
    
    public IActionResult Registration()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Registration(Registration model)
    {
        if(ModelState.IsValid){

        }
        TempData["Message"]="Record saved succesfully";
        model=new Registration();
        return View(model);
    }
[Authorize("Read")]
public IActionResult Read()
{
    return View();
}
[Authorize("Write")]
public IActionResult Edit()
{
    return View();
}

[CacheResource]
public class CachedController : Controller
{
    public IActionResult Index()
    {
        return Content("This content was generated at " + DateTime.Now);
    }
}
    public IActionResult Privacy()
    {
        return View();
    }
    [HttpPost]
     public IActionResult ALogin()
    {
        return RedirectToAction("Index", "Home");
    }
  

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
