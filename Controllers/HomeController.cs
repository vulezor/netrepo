﻿using EmployeeManagement1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement1.Controllers
{
	public class HomeController : Controller
	{
		private readonly IEmployeeRepository _employeeRepository;

		public HomeController(IEmployeeRepository employeeRepository)
		{
			_employeeRepository = employeeRepository;
		}

		public string index()
		{
			return _employeeRepository.GetEmployee(1).Name;
		}

		public ViewResult Details()
		{
			Employee model = _employeeRepository.GetEmployee(1);
			return View(model);
		}
	}
}
