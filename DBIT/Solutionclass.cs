using System;

namespace DBIT
{
    class Solutionclass
	{
		//static Solution
		public static Solutionclass solvedTicketinfo { set; get; }

		//properties
		public string solution { set; get; }
		public DateTime dateSolved { set; get; }

		public Solutionclass()
		{
			this.solution = "";
			this.dateSolved = DateTime.MinValue;
		}
		public Solutionclass(string Solution, DateTime DateSolved)
		{
			this.solution = Solution;
			this.dateSolved = DateSolved;
		}
	}
}
