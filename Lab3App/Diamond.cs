using System;
namespace Lab3App
{
	public class Diamond : Treasure
	{
		public Diamond(string desc, int score) : base(desc, score)
		{
		}

        public override void Display()
        {
            Console.WriteLine("Diamond" + Description + " is displayed");
        }
    }
}

