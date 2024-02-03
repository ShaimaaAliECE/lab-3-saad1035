using System;
namespace Lab3App
{
	public class MagicWand : Tool
	{
		public MagicWand(string desc) : base(desc)
		{

		}

        public override void DoAction()
        {
            Console.WriteLine("MagicWand is Used");
        }

        public override void Display()
        {
            Console.WriteLine("MagicWand " + Description + " is displayed");
        }
    }
}

