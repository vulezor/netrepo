using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeManagement1.Controllers
{
	[Route("[controller]/[action]")]
	public class DepartmentsController : Controller
	{
		public string List()
		{
			return "List() of DepartmentController";
		}

		public string Details()
		{
			return "Details() of DepartmentController";
		}
	}
}
