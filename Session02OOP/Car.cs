using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02OOP
{
	internal class Car
	{
		public int Id { get; set; }
		public string Model { get; set; }
		public int Speed { get; set; }




		// Code repetition because of the constructors

		public Car(int id, string model, int speed)
		{
			Id = id;
			Model = model;
			Speed = speed;
			//Console.WriteLine("CTOR01"); 
		}  

		public Car(int id, string model):this(id, model, 290)
		{
			/*Id = id;
			Model = model;
			Speed = 250;*/
			//Console.WriteLine("CTOR02");
			
		}
		

		public Car(int id):this(id, "Audi", 350)
		{
			/*Id = id;
			Model = "Audi";
			Speed = 350;*/
			//Console.WriteLine("CTOR03");
		}

		public override string ToString()
		{
			return $"Id: {Id}, Model: {Model}, Speed: {Speed}";
		}
	}
}
