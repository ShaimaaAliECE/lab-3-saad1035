using System;
using System.Collections.Generic;
namespace Lab3App
{
	public abstract class Collectable : Displayable
	{

		public string Description
		{
			get;
			set;
		}

		public CollectionBoard Board
		{
			get;
			set;
		}

		public abstract void AddMe(List<Collectable> collectables);

		public virtual void Display()
		{
			Console.WriteLine(Description + " is displayed");
		}
	}
}

