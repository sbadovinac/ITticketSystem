using System;
using System.Collections.Generic;
using System.Linq;

namespace DBIT
{
    class Report
    {
        List<Ticket> tickets;
        List<User> users;

        public int numTickets;
        public int numUsers;

        public int numPM;
        public int numAD;
        public int numIT;
        public int numRM;

        public int numUnsolved;
        public int numSolved;
        public int numAssigned;
        public int numUnassigned;

        public Report()
        {
            tickets = Ticket.GetAll();
            users = User.GetAll();

            numTickets = tickets.Count();
            numUsers = users.Count();

            numPM = 0;
            numIT = 0;
            numAD = 0;
            numRM = 0;

            countUsers();

            numUnsolved = 0;
            numSolved = 0;
            numAssigned = 0;
            numUnassigned = 0;

            countTickets();
        }

        public string toString()
        {
            return "Total Users: " + numUsers
                 + "\n  Program Members: " + numPM
                 + "\n  IT Specialists: " + numIT
                 + "\n  Report Managers: " + numRM
                 + "\n  Admins: " + numAD
                 + "\n\nTotal Tickets: " + numTickets
                 + "\n  Unsolved: " + numUnsolved
                 + "\n  Solved: " + numSolved;
        }

        // Determines the number of solved and unsolved tickets
        private void countTickets()
        {
            foreach (var ticket in tickets)
            {
                if (ticket.dateSolved != DateTime.MinValue)
                    numSolved++;
                else
                    numUnsolved++;

                if (ticket.assigned != null)
                    numAssigned++;
                else
                    numUnassigned++;
            }
        }

        // Determines the number of solved and unsolved tickets
        private void countUsers()
        {
            foreach (var user in users)
            {
                if (user.type == "AD")
                    numAD++;
                else if (user.type == "IT")
                    numIT++;
                else if (user.type == "PM")
                    numPM++;
                else if (user.type == "RM")
                    numRM++;
            }
        }
    }
}
