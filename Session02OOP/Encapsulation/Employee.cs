using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02OOP.Encapsulation
{
	
	internal struct Employee
	{
		#region Attributes
		
		public int Id;

		
		private string? Name;

		
		private decimal salary;
		#endregion

		// ctor snippet to generate a constructor
		#region Constructors
		public Employee(int id, string name, decimal _salary)
		{
			Id = id;
			Name = name;
			Salary = _salary;
		}
		#endregion

		#region Methods
		public override string ToString()
		{
			return $"Id: {Id}\nName: {Name}\nSalary: {salary:c}";
		}
		#endregion

		#region Getter - Setter
		public string GetName()
		{
			return Name;
		}

		public void SetName(string? Name)
		{
			Name = Name?.Length > 5 ? Name.Substring(0, 5) : Name;
		}
		#endregion

		#region Property
		// Full property is a property that has validation
		public decimal Salary
		{
			get { return salary; }
			set { salary = value > 5000 ? 5000 : value; }
		}


		//private int age;

		//public int Age
		//{
		//	get { return age; }
		//	set { age = value; }
		//}

		public int Age { get; set; }

		// prop snippet
		//private decimal deduction;
		public decimal Deduction
		{
			get { return Salary * 0.2m; }
		}
		#endregion


	}
}
