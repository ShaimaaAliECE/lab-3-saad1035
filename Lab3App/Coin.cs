using System;
using System.Collections.Generic;

namespace Lab3App
{
	public class Coin : Treasure
	{
		public int Value
		{
			get;
			set;
		}

		public Coin(string desc, int score, int value) : base(desc, score)
		{
			this.Value = value;
		}

		public void UpdateTotalValue(CollectionBoard collectionBoard)
		{
			collectionBoard.TotalValue += Value;
		}

        public override void AddMe(List<Collectable> collectables)
        {
			base.AddMe(collectables);
			if (this.Board != null)
			{
				UpdateTotalValue(this.Board);
				Console.WriteLine("Total Value is updated to: " + this.Board.TotalValue);
			}
        }

        public override void Display()
        {
            Console.WriteLine("Coin " + Description + " is displayed");
        }
    }
}


