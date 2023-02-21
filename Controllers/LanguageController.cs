using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
namespace translater.Controllers;
public class LanguageController : Controller
    {
        private readonly IStringLocalizer<LanguageController> _localizer;
        public LanguageController(IStringLocalizer<LanguageController> localizer)
        {
            _localizer = localizer;
        }
    public IActionResult Get()
    {
        var guid = Guid.NewGuid();
        return Ok(_localizer["RandomGUID", guid.ToString()].Value);
    }
    public IActionResult Index(){
        return View();
    }
}