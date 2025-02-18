﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02OOP
{
	internal struct Person
	{
		private string name;
		private int age;

		public string Name { get => name; set => name = value; }
		public int Age { get => age; set => age = value; }

		public Person(string name, int age)
		{
			Name = name;
			Age = age;
		}

		public override string ToString()
		{
			return $"Name: {Name}, Age: {Age}";
		}
	}
}
