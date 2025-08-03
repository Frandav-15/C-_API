using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using MyFirst_Api.Data;
using MyFirst_Api.Models;

namespace MyFirst_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployedController : Controller
    {

        private readonly MyAppContext _appContext;
        public EmployedController(MyAppContext appContext)
        {
            _appContext = appContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var list = _appContext.employeds.ToList();
            return Ok(list);
        }

        [HttpPost]

        public IActionResult AddEmployed(EmployedDTO emp)
        {
            var emplo = new Employed()
            {
                Name = emp.Name,
                Phone = emp.Phone,
                Email = emp.Email,
                Salary = emp.Salary
            };

            _appContext.employeds.Add(emplo);
            _appContext.SaveChanges();

            return Ok(emplo);

        }
    }
}
