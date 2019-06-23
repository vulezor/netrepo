using EmployeeManagement1.Models;
using EmployeeManagement1.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement1.Controllers
{
	[Route("[controller]/[action]")]
	public class HomeController : Controller
	{
		private readonly IEmployeeRepository _employeeRepository;

		public HomeController(IEmployeeRepository employeeRepository)
		{
			_employeeRepository = employeeRepository;
		}

		[Route("~/Home")]
		//[Route("[action]")]
		[Route("~/")]
		public ViewResult Index()
		{
			var model =  _employeeRepository.GetAllEmployee();
			return View(model);
		}

		//[Route("[action]/{id?}")]
		[Route("{id?}")]
		public ViewResult Details(int? id)
		{
			HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
			{
				Employee = _employeeRepository.GetEmployee(id??1),
				PageTitle = "This is Page Title"
			};

			Employee model = _employeeRepository.GetEmployee(id??1);
			//ViewData
			//ViewData["Employee"] = model;
			//ViewData["PageTitle"] = "Employee Datails";

			//ViewBag
			//ViewBag.Employee = model;
			ViewBag.PageTitle = "Employee Datails";

			return View(homeDetailsViewModel); // in Views\Home folder target Details.cshtml page
			//return View("Test", model); in Views\Home folder target Test.cshtml page
			//return View("../Test/Update", model); //in Views\Test folder target Updtae.cshtml page
		}
	}
}
