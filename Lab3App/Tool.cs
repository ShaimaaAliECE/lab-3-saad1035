using System;
using System.Collections.Generic;

namespace Lab3App
{
	public abstract class Tool : Collectable
	{
		public Tool(string desc)
		{
			this.Description = desc;
		}

		public abstract void DoAction();

		public override void AddMe(List<Collectable> collectables)
		{
			collectables.Add(this);
			Console.WriteLine(Description + " Collected, Congrats!!!!");
			DoAction();
		}
	}
}

