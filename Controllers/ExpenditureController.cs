using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using Templating_Razor.Models;

namespace Templating_Razor.Controllers
{
    public class ExpenditureController : Controller
    {
        public ActionResult Index()
        {
            var expenditures = new List<Expenditure>
        {
            new Expenditure { Name = "Dépense 1", Date = DateTime.Now.AddDays(-1), Price = 10.0 },
            new Expenditure { Name = "Dépense 2", Date = DateTime.Now.AddDays(-2), Price = 20.0 },
            new Expenditure { Name = "Dépense 3", Date = DateTime.Now.AddDays(-3), Price = 30.0 }
        };

            return View(expenditures);
        }
    }
}
