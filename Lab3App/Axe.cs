﻿using System;
namespace Lab3App
{
	public class Axe : Tool
	{
		public Axe(string desc) : base(desc)
		{
		}

        public override void DoAction()
        {
            Console.WriteLine("Axe is Used");
        }

        public override void Display()
        {
            Console.WriteLine("Axe " + Description + " is displayed");
        }
    }
}

