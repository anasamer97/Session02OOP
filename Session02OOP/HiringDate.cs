using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02OOP
{
	internal class HiringDate
	{
		private int day;
		private int month;
		private int year;

		public HiringDate(int day, int month, int year)
		{
			this.day = day;
			this.month = month;
			this.year = year;
		}

		public int Day { get => day; set => day = value; }
		public int Month { get => month; set => month = value; }
		public int Year { get => year; set => year = value; }
	}
}
