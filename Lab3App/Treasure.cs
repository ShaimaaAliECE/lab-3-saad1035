using System;
using System.Collections.Generic;

namespace Lab3App
{
	public class Treasure : Collectable
	{
		public int Score
		{
			get;
			set;
		}

		public Treasure(string desc, int score)
		{
			this.Description = desc;
			this.Score = score;
		}

        public override void AddMe(List<Collectable> collectables)
        {
			collectables.Add(this);
			Console.WriteLine(Description + " Collected, Congrats!!!!");
			UpdateTotalScore();
			Console.WriteLine("Total Score is updated to: " + this.Board.TotalScore);
        }

        public void UpdateTotalScore()
        {
            if (this.Board != null)
            {
                this.Board.TotalScore += this.Score;
            }
        }
    }
}

