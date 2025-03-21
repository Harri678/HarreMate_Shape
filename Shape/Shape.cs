﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
	internal abstract class Shape
	{
		bool isHoley;
		string color;

		public string Color { get => color; set => color = value; }

		protected Shape(string color, bool isHoley = false)
		{
			this.isHoley = isHoley;
			this.color = color;
		}

		protected Shape(string color)
		{
			this.color = color;
			isHoley = false;
		}

		public void MakeHoley()
		{
			isHoley = true;
		}

		public abstract double Perimiter();
		public abstract double Area();

		public override bool Equals(object? obj)
		{
			return base.Equals(obj);
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override string? ToString()
		{
			return $"{color} - {isHoley} : K: {Perimiter} : T: {Area}";
		}
	}
}
