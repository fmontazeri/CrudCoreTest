using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudCoreTest.Domain.CustomerAgg;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FatemehMontazeriCrudCoreTest.Presentation.Controllers
{
    public class CustomerController : Controller
    {

        // GET: /<controller>/
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Create()
        {

            return View();
        }


    }
}
