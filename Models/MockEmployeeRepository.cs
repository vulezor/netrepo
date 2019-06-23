using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement1.Models
{
	public class MockEmployeeRepository : IEmployeeRepository
	{
		private List<Employee> _employeeList;

		public MockEmployeeRepository()
		{
			_employeeList = new List<Employee>()
			{
				new Employee() { Id=1, Name="Zoran", Department="HR", Email="zoran@gmail.com" },
				new Employee() { Id=2, Name = "Nenad", Department = "IT", Email = "nenad@gmail.com" },
				new Employee() { Id=3, Name = "Predrag", Department = "IT", Email = "predrag@gmail.com" }
			};
		}

		public Employee GetEmployee(int Id)
		{

			return _employeeList.FirstOrDefault(e => e.Id == Id);
		}

		public IEnumerable<Employee> GetAllEmployee()
		{
			return _employeeList;
		}
	}
}
