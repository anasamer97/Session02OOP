using Session02OOP.Encapsulation;

namespace Session02OOP
{
	internal class Program
	{
		static void Main(string[] args)
		{

			#region Encapsulation
			//Employee employee = new Employee(10, "Mohamed", 4000);
			//Console.WriteLine(employee); // boxing
			//employee.SetName("Ahmed");
			//Console.WriteLine(employee.GetName());


			//employee.Salary = 4000;
			//Console.WriteLine(employee);
			//Console.WriteLine(employee.Deduction);
			#endregion

			#region Phonebook
			/*PhoneBook Note = new PhoneBook(3);
            Note.AddPerson(0, "Ahmed", 123);
            Note.AddPerson(1, "Mona", 456);
            Note.AddPerson(2, "Omar", 789);

            int Number = Note.GetNumber("Ahmed");
            Console.WriteLine(Number);
            Console.WriteLine(Note.GetNumber("Mona"));

            Note.SetNumber("Mona", 939);
            Note.GetNumber("Mona");
            Console.WriteLine(Note.GetNumber("Mona"));
            Note["Mona"] = 100;
            Console.WriteLine(Note["Mona"]);
            for (int i = 0; i < Note.Size; i++)
            {
                Console.WriteLine(Note[i]);
            }*/
			#endregion

			#region Class
			/* Car C01 = new Car(10, "BMW", 250);
             Console.WriteLine(C01);

             Car C02 = new Car(10, "Peaguot");*/
			#endregion

			#region Assignment OOP #02
			#region Part 01 Solved in Demo & Project Files
			#endregion
			#region Part 02
			#region Q1 
			// Define a struct, create an array, and then display it.
			/* Person PersonOne = new Person("Ahmed", 25);
             Person PersonTwo = new Person("Mohamed", 30);
             Person PersonThree = new Person("Ali", 35);

             string[] Persons = { PersonOne.ToString(), PersonTwo.ToString(), PersonThree.ToString() };

             foreach (string person in Persons)
             {
                 Console.WriteLine(person);
             }*/
			#endregion

			#region Q2
			// Create a new Person object
			// Create an array to store 3 persons
			//Person[] persons = new Person[3];

			// Get details of 3 persons
			//for (int i = 0; i < 3; i++)
			//{
			//	Console.WriteLine($"Enter details for person {i + 1}:");

			//	// Get name
			//	Console.Write("Enter name: ");
			//	string name = Console.ReadLine();

			//	// Get age and validate it
			//	int age;
			//	while (true)
			//	{
			//		Console.Write("Enter age: ");
			//		if (int.TryParse(Console.ReadLine(), out age) && age > 0)
			//		{
			//			break; // Exit the loop if the age is valid
			//		}
			//		else
			//		{
			//			Console.WriteLine("Invalid age. Please enter a valid positive integer.");
			//		}
			//	}

			//	// Store the person in the array
			//	persons[i] = new Person(name, age);
			//}

			//// Find the oldest person
			//Person oldestPerson = persons[0]; // Assume the first person is the oldest initially

			//for (int i = 1; i < persons.Length; i++)
			//{
			//	if (persons[i].Age > oldestPerson.Age)
			//	{
			//		oldestPerson = persons[i]; // Update oldest person if we find a person with a higher age
			//	}
			//}

			// Display the name and age of the oldest person
			//Console.WriteLine($"\nThe oldest person is {oldestPerson.Name} with an age of {oldestPerson.Age}.");

			#endregion
			#endregion

			#region Part 03 Solved in project files
			//Emp Employee1 = new Emp(1, "Mohamed", SecurityLevel.DBA, 10000, "5/5/2019", Gender.Male);
			//Emp Employee2 = new Emp(2, "Salma", SecurityLevel.Guest, 9000, "5/4/2017", Gender.Female);
			//Emp Employee3 = new Emp(3, "Ahmed", SecurityLevel.SecurityOfficer, 10000, "7/14/2016", Gender.Male);
			//Emp Employee4 = new Emp();
			//Employee4.Id = 4;
			//Employee4.Name = "Mona";
			//Employee4.SecurityLevel = SecurityLevel.Secretary;
			//Employee4.Gender = Gender.Male;
			//Employee4.Salary = 8000;
			//Employee4.HiringDate = "5/5/2018";
			//Console.WriteLine(Employee4.Id);
			//Console.WriteLine(Employee1.ToString());


			#region Taking Input (Validated and modular using functions)
			// Create Emp object
			Emp employee = new Emp();

			// Get valid inputs from user and assign to employee
			//string name = employee.GetValidName();
			//SecurityLevel securityLevel = employee.GetValidSecurityLevel();
			//decimal salary = employee.GetValidSalary();
			//string hiringDate = employee.GetValidHiringDate();
			//Gender gender = employee.GetValidGender();

			// Set the employee properties
			//employee.Name = name;
			//employee.SecurityLevel = securityLevel;
			//employee.Salary = salary;
			//employee.HiringDate = hiringDate;
			//employee.Gender = gender;

			// Display employee details
			//Console.WriteLine("\nEmployee Details:");
			//Console.WriteLine(employee.ToString());



			#endregion

			#endregion
			#endregion
		}
	}
}
