using System;
using System.Collections.Generic;

namespace DBIT
{
    class Ticket
    {
		//IComparer stuff. No clue why it needs to be implemented this way. Couldn't find a better way of comparing lists of objects
		//Pros: Really quick
		//		Stacks with filtering
		//		No more database calls
		//Cons: Lots of repeated code with seemingly no way of shortening it
		private class sortIDAscendingHelper : IComparer<Ticket>
		{
			int IComparer<Ticket>.Compare(Ticket a, Ticket b)
			{
				Ticket c1 = (Ticket)a;
				Ticket c2 = (Ticket)b;

				if (c1.id > c2.id)
					return 1;

				if (c1.id < c2.id)
					return -1;

				else
					return 0;
			}
		}
		private class sortIDDescendingHelper : IComparer<Ticket>
		{
			int IComparer<Ticket>.Compare(Ticket a, Ticket b)
			{
				Ticket c1 = (Ticket)a;
				Ticket c2 = (Ticket)b;

				if (c1.id < c2.id)
					return 1;

				if (c1.id > c2.id)
					return -1;

				else
					return 0;
			}
		}

		private class sortOwnerAscendingHelper : IComparer<Ticket>
		{
			int IComparer<Ticket>.Compare(Ticket a, Ticket b)
			{
				Ticket c1 = (Ticket)a;
				Ticket c2 = (Ticket)b;

                if (String.Compare(c1.owner.email, c2.owner.email) == 1)
                    return 1;

                if (String.Compare(c1.owner.email, c2.owner.email) == -1)
                    return -1;

                else
					return 0;
			}
		}
		private class sortOwnerDescendingHelper : IComparer<Ticket>
		{
			int IComparer<Ticket>.Compare(Ticket a, Ticket b)
			{
				Ticket c1 = (Ticket)a;
				Ticket c2 = (Ticket)b;

                if (String.Compare(c1.owner.email, c2.owner.email) == -1)
                    return 1;

                if (String.Compare(c1.owner.email, c2.owner.email) == 1)
                    return -1;

                else
					return 0;
			}
		}

		private class sortDateCreatedAscendingHelper : IComparer<Ticket>
		{
			int IComparer<Ticket>.Compare(Ticket a, Ticket b)
			{
				Ticket c1 = (Ticket)a;
				Ticket c2 = (Ticket)b;

				if (c1.dateCreated < c2.dateCreated)
					return 1;

				if (c1.dateCreated > c2.dateCreated)
					return -1;

				else
					return 0;
			}
		}
		private class sortDateCreatedDescendingHelper : IComparer<Ticket>
		{
			int IComparer<Ticket>.Compare(Ticket a, Ticket b)
			{
				Ticket c1 = (Ticket)a;
				Ticket c2 = (Ticket)b;

				if (c1.dateCreated > c2.dateCreated)
					return 1;

				if (c1.dateCreated < c2.dateCreated)
					return -1;

				else
					return 0;
			}
		}

		private class sortDateSolvedAscendingHelper : IComparer<Ticket>
		{
			int IComparer<Ticket>.Compare(Ticket a, Ticket b)
			{
				Ticket c1 = (Ticket)a;
				Ticket c2 = (Ticket)b;

				if (c1.dateSolved < c2.dateSolved)
					return 1;

				if (c1.dateSolved > c2.dateSolved)
					return -1;

				else
					return 0;
			}
		}
		private class sortDateSolvedDescendingHelper : IComparer<Ticket>
		{
			int IComparer<Ticket>.Compare(Ticket a, Ticket b)
			{
				Ticket c1 = (Ticket)a;
				Ticket c2 = (Ticket)b;

				if (c1.dateSolved > c2.dateSolved)
					return 1;

				if (c1.dateSolved < c2.dateSolved)
					return -1;

				else
					return 0;
			}
		}
		//Static

		public static string SolvedTicketSolution { set; get; }
		public static DateTime SolvedTicketDate { set; get; }

		// Properties

		public int id { set; get; }

        public string header { set; get; }
        public string description { set; get; }

        public DateTime dateCreated { set; get; }
        public DateTime dateSolved { set; get; }
        public DateTime dateModified { set; get; }

        public bool isSolved { set; get; }
        public int priority { set; get; }

        public User assigned { set; get; }
        public User owner { set; get; }

        public  string solution { set; get; }

        // Constructors

        public Ticket(int id, string header, string description, DateTime dateCreated,
                      DateTime dateSolved, DateTime dateModified, bool isSolved, int priority)
        {
            this.id = id;

            this.header = header;
            this.description = description;

            this.dateCreated = dateCreated;
            this.dateSolved = dateSolved;
            this.dateModified = dateModified;

            this.isSolved = isSolved;
            this.priority = priority;

            this.assigned = new User();
            this.owner = new User();
        }

        public Ticket(int id, string header, string description, DateTime dateCreated,
                      DateTime dateSolved, DateTime dateModified, bool isSolved,
                      int priority, User owner, User assigned, string solution)
        {
            this.id = id;

            this.header = header;
            this.description = description;

            this.dateCreated = dateCreated;
            this.dateSolved = dateSolved;
            this.dateModified = dateModified;

            this.isSolved = isSolved;
            this.priority = priority;

            this.assigned = assigned;
            this.owner = owner;

            this.solution = solution;
        }

        // Methods

        public void Assign(User assignedTo)
        {
            this.assigned = assignedTo;
        }

        public void Solve()
        {
            if (this.isSolved)
            {
                // Already solved, throw error
                throw new Exception();
            }
            else
            {
                this.isSolved = true;
                this.dateSolved = DateTime.Now;
            }
        }

        public TimeSpan TimeUnsolved()
        {
            TimeSpan difference;
            if (this.isSolved)
            {
                difference = this.dateSolved - this.dateCreated;
            }
            else
            {
                difference = DateTime.Now - this.dateCreated;
            }
            return difference;
        }

        public void updatePriority()
        {
            int daysSinceMod, datePriority;
            TimeSpan difference;
            if (this.isSolved)   //the ticket is solved
            {
                this.priority = -1;
            }
            else
            {
                
                difference = DateTime.Now - this.dateModified;
                daysSinceMod = (int)difference.TotalDays;
                if (daysSinceMod < 3)   
                    datePriority = 1;
                else if (daysSinceMod < 7)  
                    datePriority = 2;
                else    
                    datePriority = 3;
                // This line was so the ticket is never given a lower priority then it already had but I don't think that really makes sense
                //if (datePriority > this.priority)   
                //    this.priority = datePriority;
                this.priority = datePriority; 
            }
            return; 
        }

        // Used for printing tickets to table
        public string[] toStringArray()
        {
            string[] str = new string[10];
            str[0] = id + "";
            str[1] = owner.email + "";
            str[2] = header;
            str[3] = description;
            str[4] = dateCreated.ToShortDateString();
            str[5] = dateSolved == DateTime.MinValue ? "Not yet solved" : dateSolved.ToShortDateString();
            str[6] = dateModified == DateTime.MinValue ? DateTime.Now.ToShortDateString() : dateModified.ToShortDateString();
            str[7] = priority == 0 ? "Unassigned" : priority + "";
            str[8] = assigned == null ? "Unassigned" : assigned.email + "";
			str[9] = solution;
            return str;
        }

        // Generates a ticket from the array above
        public static Ticket fromStringArray(string[] str)
        {
            int id = Convert.ToInt32(str[0]);
            string ownerEmail = str[1];
            string header = str[2];
            string description = str[3];
            DateTime created = DateTime.Parse(str[4]);
            DateTime solved = DateTime.MinValue;
            try { solved = DateTime.Parse(str[5]); } catch { } //use DateTime.TryParse()
            DateTime modified = DateTime.MinValue;
            try { modified = DateTime.Parse(str[6]); } catch { }
            int priority = 0;
            try { priority = Convert.ToInt32(str[7]); } catch { }
            string assignedEmail = str[8];
            string solution = str[9];

            bool isSolved = solved != DateTime.MinValue;
            User owner = User.Get(ownerEmail);

            User assigned = null;
            if (!assignedEmail.Equals("Unassigned"))
            {
                assigned = User.Get(assignedEmail);
            }

            return new Ticket(id, header, description, created, solved, DateTime.MinValue, isSolved, priority, owner, assigned, solution);
        }

        // DATABASE related methods

        // Saves this ticket into the database
        public void Save()
        {
            DatabaseHandler db = new DatabaseHandler();
            try
            {
                db.OpenConn();
                db.saveTicket(this);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db.CloseConn();
            }
        }

        // Returns a ticket with the given id
        // Returns null if no id exists (from DatabaseHandler.getTicket)
        public static Ticket Get(int id)
        {
            DatabaseHandler db = new DatabaseHandler();
            Ticket ticket;
            try
            {
                db.OpenConn();
                ticket = db.getTicket(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db.CloseConn();
            }
            return ticket;
        }
		
		// Returns a list of all tickets in database
		public static List<Ticket> GetAll()
        {
            DatabaseHandler db = new DatabaseHandler();
            List<Ticket> tickets;
            try
            {
                db.OpenConn();
                tickets = db.getAllTicketObjects();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db.CloseConn();
            }
            return tickets;
        }

		//Sorting functions
		public static List<Ticket> sortIDAscending(List<Ticket> tickets)
		{
			sortIDAscendingHelper eAsc = new sortIDAscendingHelper();

			// Sort Tickets by id by ascending order.   
			tickets.Sort(eAsc);

			return tickets;
		}

		public static List<Ticket> sortIDDescending(List<Ticket> tickets)
		{
			sortIDDescendingHelper eDesc = new sortIDDescendingHelper();

			// Sort Tickets by id by ascending order.   
			tickets.Sort(eDesc);

			return tickets;
		}

		public static List<Ticket> sortOwnerAscending(List<Ticket> tickets)
		{
			sortOwnerAscendingHelper eAsc = new sortOwnerAscendingHelper();

			// Sort Tickets by id by ascending order.   
			tickets.Sort(eAsc);

			return tickets;
		}

		public static List<Ticket> sortOwnerDescending(List<Ticket> tickets)
		{
			sortOwnerDescendingHelper eDesc = new sortOwnerDescendingHelper();

			// Sort Tickets by id by ascending order.   
			tickets.Sort(eDesc);

			return tickets;
		}

		public static List<Ticket> sortDateCreatedAscending(List<Ticket> tickets)
		{
			sortDateCreatedAscendingHelper eAsc = new sortDateCreatedAscendingHelper();

			// Sort Tickets by id by ascending order.   
			tickets.Sort(eAsc);

			return tickets;
		}

		public static List<Ticket> sortDateCreatedDescending(List<Ticket> tickets)
		{
			sortDateCreatedDescendingHelper eDesc = new sortDateCreatedDescendingHelper();

			// Sort Tickets by id by ascending order.   
			tickets.Sort(eDesc);

			return tickets;
		}

		public static List<Ticket> sortDateSolvedAscending(List<Ticket> tickets)
		{
			sortDateSolvedAscendingHelper eAsc = new sortDateSolvedAscendingHelper();

			// Sort Tickets by id by ascending order.   
			tickets.Sort(eAsc);

			return tickets;
		}

		public static List<Ticket> sortDateSolvedDescending(List<Ticket> tickets)
		{
			sortDateSolvedDescendingHelper eDesc = new sortDateSolvedDescendingHelper();

			// Sort Tickets by id by ascending order.   
			tickets.Sort(eDesc);

			return tickets;
		}



	}
}
