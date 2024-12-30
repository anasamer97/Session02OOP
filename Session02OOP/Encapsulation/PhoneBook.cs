using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02OOP.Encapsulation
{
	internal struct PhoneBook
	{
		#region Attribute
		string[] Names;
		int[] Numbers;
		public int Size { get; set; }
		#endregion

		public PhoneBook(int Size)
		{
			Names = new string[Size];
			Numbers = new int[Size];
			this.Size = Size;
		}

		public void AddPerson(int Position, string Name, int Number)
		{
			if (Names is not null && Numbers is not null)
			{
				if (Position < Size)
				{
					Names[Position] = Name;
					Numbers[Position] = Number;
				}
				else
				{
					Console.WriteLine("The position is out of range");
				}
			}

		}

		public int GetNumber(string Name)
		{
			for (int i = 0; i < Names.Length; i++)
			{

				if (Names[i] == Name)
				{
					return Numbers[i];
				}

			}
			return -1;
		}


		public void SetNumber(string Name, int NewNumber)
		{
			for (int i = 0; i < Names.Length; i++)
			{
				if (Names[i] == Name)
				{
					Numbers[i] = NewNumber;
					break;
				}
			}
		}

		// Indexer
		public int this[string Name]
		{
			get
			{
				for (int i = 0; i < Names.Length; i++)
				{
					if (Names[i] == Name)
					{
						return Numbers[i];
					}
				}
				return -1;
			}
			set
			{
				for (int i = 0; i < Names.Length; i++)
				{
					if (Names[i] == Name)
					{
						Numbers[i] = value;
						break;
					}
				}
			}
		}

		public string this[int Index]
		{
			get
			{
				return $"{Index} :: {Names[Index]} :: {Numbers[Index]}";
			}
		}
	}
}