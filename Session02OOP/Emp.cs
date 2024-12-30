using System;

namespace Session02OOP
{
	#region Enums
	public enum Gender
	{
		Male, Female
	}

	public enum SecurityLevel
	{
		Guest, Developer, Secretary, DBA, SecurityOfficer
	}
	#endregion

	internal class Emp
	{
		#region Fields
		private int id;
		private string name;
		private SecurityLevel securityLevel;
		private decimal salary;
		private string hiringDate;
		private Gender gender;
		#endregion

		#region Constructors
		public Emp(int id, string name, SecurityLevel securityLevel, decimal salary, string hiringDate, Gender gender)
		{
			this.id = id;
			this.name = name;
			this.securityLevel = securityLevel;
			this.salary = salary;
			this.hiringDate = hiringDate;
			this.gender = gender;
		}

		public Emp() { } 
		#endregion

		#region Properties
		public int Id { get => id; set => id = value; }
		public string Name { get => name; set => name = value; }
		public SecurityLevel SecurityLevel { get => securityLevel; set => securityLevel = value; }
		public decimal Salary { get => salary; set => salary = value; }
		public string HiringDate { get => hiringDate; set => hiringDate = value; }
		public Gender Gender { get => gender; set => gender = value; }
		#endregion

		#region Methods
		public override string ToString()
		{
			return $"Employee ID: {id}\nEmployee Name: {name}\nEmployee Security Level: {securityLevel}\nEmployee Salary: {salary:n}\nEmployee Hiring Date {HiringDate}\nEmployee Gender {Gender}";
		}



		#region Validator Functions

		public bool ValidateName(string name)
		{
			return !string.IsNullOrWhiteSpace(name) && !HasNumbers(name);
		}

		private bool HasNumbers(string input)
		{
			foreach (char c in input)
			{
				if (char.IsDigit(c)) return true;
			}
			return false;
		}

		public bool ValidateSecurityLevel(string input, out SecurityLevel securityLevel)
		{
			return Enum.TryParse(input, out securityLevel) && Enum.IsDefined(typeof(SecurityLevel), securityLevel);
		}

		public bool ValidateSalary(string input, out decimal salary)
		{
			return decimal.TryParse(input, out salary) && salary >= 0;
		}

		public bool ValidateHiringDate(string input)
		{
			return DateTime.TryParse(input, out _);
		}

		public bool ValidateGender(string input, out Gender gender)
		{
			return Enum.TryParse(input, true, out gender) && Enum.IsDefined(typeof(Gender), gender);
		}

		// User Input Functions (called in Program.cs)
		public string GetValidName()
		{
			string name;
			while (true)
			{
				Console.WriteLine("Enter Employee Name:");
				name = Console.ReadLine();
				if (ValidateName(name))
				{
					break;
				}
				else
				{
					Console.WriteLine("Invalid input. Name must be non-empty and cannot contain numbers.");
				}
			}
			return name;
		}

		public SecurityLevel GetValidSecurityLevel()
		{
			SecurityLevel securityLevel;
			while (true)
			{
				Console.WriteLine("Enter Security Level (0: Guest, 1: Developer, 2: Secretary, 3: DBA, 4: SecurityOfficer):");
				string input = Console.ReadLine();
				if (ValidateSecurityLevel(input, out securityLevel))
				{
					break;
				}
				else
				{
					Console.WriteLine("Invalid input. Please enter a valid Security Level (0-4).");
				}
			}
			return securityLevel;
		}

		public decimal GetValidSalary()
		{
			decimal salary;
			while (true)
			{
				Console.WriteLine("Enter Employee Salary:");
				string input = Console.ReadLine();
				if (ValidateSalary(input, out salary))
				{
					break;
				}
				else
				{
					Console.WriteLine("Invalid input. Please enter a valid salary (non-negative).");
				}
			}
			return salary;
		}

		public string GetValidHiringDate()
		{
			string hiringDate;
			while (true)
			{
				Console.WriteLine("Enter Hiring Date (yyyy-mm-dd):");
				hiringDate = Console.ReadLine();
				if (ValidateHiringDate(hiringDate))
				{
					break;
				}
				else
				{
					Console.WriteLine("Invalid input. Please enter a valid date in yyyy-mm-dd format.");
				}
			}
			return hiringDate;
		}

		public Gender GetValidGender()
		{
			Gender gender;
			while (true)
			{
				Console.WriteLine("Enter Gender (Male/Female):");
				string input = Console.ReadLine();
				if (ValidateGender(input, out gender))
				{
					break;
				}
				else
				{
					Console.WriteLine("Invalid input. Please enter either 'Male' or 'Female'.");
				}
			}
			return gender;
		}
		#endregion
		#endregion
	}
}
