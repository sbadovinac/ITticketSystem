using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBIT
{
    class DatabaseHandler
    {
        // Declare the properties of the database
        public String connStr;
        public SqlConnection con;
        //public User currentUser;

        // Constructor
        public DatabaseHandler()
        {
            connStr = @"Server=tcp:dbitdb.database.windows.net,1433;
                        Initial Catalog=dbit;
                        Persist Security Info=False;
                        User ID=dbit;
                        Password=LINOS1234!;
                        MultipleActiveResultSets=True;
                        Encrypt=True;
                        TrustServerCertificate=False;
                        Connection Timeout=30;";
            con = new SqlConnection(connStr);
        }

        // Opens databse connection
        public void OpenConn()
        {
            con.Open();
        }

        // Closes database connection
        public void CloseConn()
        {
            con.Close();
        }

        
        // Return requested user from login
        public User userLogin(string email, string password)
        {
            User user = null;

            string query = "Select Id, Email, Password, Type, Date_Created From dbo.Users Where Email = @Email AND Password = @Password";

            SqlCommand com = new SqlCommand(query, con);
            com.Parameters.AddWithValue(parameterName: "@Email",        email);
            com.Parameters.AddWithValue(parameterName: "@Password",     password);

            // Check each row and match credentials
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                string dbEmail = (string)reader["Email"];
                string dbPassword = (string)reader["Password"];

                if (dbEmail == email && dbPassword == password)
                {
                    // Success!  We found a match!
                    user = readUserRow(reader);
                }
            }
            com.Dispose();
            reader.Close();

            return user;
        }

        // Get a user from the database from a given ID
        public User getUser(int userId)
        {
            User user = null;

            string query = "Select * From dbo.Users Where Id = @Id";
            SqlCommand com = new SqlCommand(query, con);
            com.Parameters.AddWithValue(parameterName: "@Id", userId);

            // Check each row and match id
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                int dbUserId = (int)reader["Id"];

                if (dbUserId == userId)
                {
                    user = readUserRow(reader);
                    break;
                }
            }
            com.Dispose();
            reader.Close();

            return user;
        }

        // Get a user from the database from a given ID
        public User getUser(string email)
        {
            User user = null;

            string query = "Select * From dbo.Users Where Email = @Email";
            SqlCommand com = new SqlCommand(query, con);
            com.Parameters.AddWithValue(parameterName: "@Email", email);

            // Check each row and match id
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                string dbEmail = (string)reader["Email"];

                if (dbEmail.Equals(email))
                {
                    user = readUserRow(reader);
                    break;
                }
            }
            com.Dispose();
            reader.Close();

            return user;
        }

        public List<User> getAllUserObjects()
        {
            List<User> users = new List<User>();

            string query = "SELECT * FROM Users";
            SqlCommand com = new SqlCommand(query, con);

            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                User user = readUserRow(reader);
                users.Add(user);
            }
            com.Dispose();
            reader.Close();

            return users;
        }

        public List<Ticket> getAllTicketObjects()
        {
            List<Ticket> tickets = new List<Ticket>();

            string query = "SELECT * FROM Ticket";
            SqlCommand com = new SqlCommand(query, con);

            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {

                Ticket ticket = readTicketRow(reader);
                tickets.Add(ticket);
            }
            com.Dispose();
            reader.Close();

            return tickets;
        }

        public void editUserType(string type, int id)
        {
            try
            {
                String newstr = "Select * From Users Where ID = @userID";
                SqlCommand outcom = new SqlCommand(newstr, con);

                //check userID
                outcom.Parameters.AddWithValue(parameterName: "@userID", id);

                SqlDataReader reader = outcom.ExecuteReader();

                //checking the query response
                if (reader.HasRows)
                {
                    // Update the existing ticket

                    reader.Close();
                    //edit existing row

                    outcom.CommandText = "UPDATE Users " +
                                         "Set Type = @userType WHERE ID = @userID";

                    //Edit existing row
                    outcom.Parameters.AddWithValue(parameterName: "@userType", type);

                    outcom.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error editing user type.\n" + ex.ToString());
            }
        }

        // Get a user from the database from a given ID
        public Ticket getTicket(int ticketId)
        {
            Ticket ticket = null;

            string query = "Select * From dbo.Ticket Where caseID = @Id";
            SqlCommand com = new SqlCommand(query, con);
            com.Parameters.AddWithValue(parameterName: "@Id", ticketId);

            // Check each row and match id
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                int dbTicketId = reader.GetInt32(0);

                if (dbTicketId == ticketId)
                {
                    ticket = readTicketRow(reader);
                    break;
                }
            }

            com.Dispose();
            reader.Close();

            return ticket;
        }

        // Takes a reader that is currently reading a row from a sql query,
        // type casts the row data, and returns a Ticket object created from it
        public Ticket readTicketRow(SqlDataReader reader)
        {
            int id = (int)reader["caseId"];

            int ownerId = 0;
            if (!reader.IsDBNull(1))
                ownerId = (int)reader["owner"];

            string head = (string)reader["header"];
            string desc = (string)reader["description"];
            DateTime created = (DateTime)reader["dateCreated"];

            DateTime solved = DateTime.MinValue;
            if (!reader.IsDBNull(5))
                solved = (DateTime)reader["dateSolved"];

            int priority = -1;
            if (!reader.IsDBNull(6))
                priority = (int)reader["priority"];

            int assignedId = 0;
            if (!reader.IsDBNull(7))
                assignedId = (int)reader["AssignedTo"];

            DateTime modified = DateTime.MinValue;
            if (!reader.IsDBNull(8))
                modified = (DateTime)reader["dateModified"];

            string solution = "";
            if (!reader.IsDBNull(9))
                solution = (string)reader["Solution"];

            // Get users for assigned and owner
            User owner = getUser(ownerId);
            User assigned = getUser(assignedId);

            bool isSolved = true;
            if (solved == DateTime.MinValue) isSolved = true;

            return new Ticket(id, head, desc, created, solved, modified,
                                       isSolved, priority, owner, assigned, solution);
        }

        // Takes a reader that is currently reading a row from a sql query,
        // type casts the row data, and returns a User object created from it
        public User readUserRow(SqlDataReader reader)
        {
            int id = (int)reader["Id"];
            string email = (string)reader["Email"];
            string type = (string)reader["Type"];
            DateTime created = (DateTime)reader["Date_Created"];

            return new User(id, email, type, created);
        }

        public void saveTicket(Ticket newTicket)
        {
            String newstr = "Select * From Ticket Where caseID = @caseID";
            SqlCommand outcom = new SqlCommand(newstr, con);

            //check caseID
            outcom.Parameters.AddWithValue(parameterName: "@caseID", newTicket.id);

            SqlDataReader reader = outcom.ExecuteReader();

            //checking the query response
            if (reader.HasRows)
            {
                // Update the existing ticket

                reader.Close();
                //edit existing row

                outcom.CommandText = "UPDATE Ticket " +
                                     "Set header = @header, description = @description, AssignedTo = @assignedTo, priority = @priority, " +
                                     "dateCreated = @dateCreated, dateSolved = @dateSolved, dateModified = @dateModified, solution = @solution, " +
                                     "owner = @ownerId WHERE caseID = @caseID";

				//Edit existing row
				outcom.Parameters.AddWithValue(parameterName: "@header", newTicket.header);
                outcom.Parameters.AddWithValue(parameterName: "@description", newTicket.description);
                outcom.Parameters.AddWithValue(parameterName: "@priority", newTicket.priority);
                outcom.Parameters.AddWithValue(parameterName: "@dateCreated", newTicket.dateCreated);
                outcom.Parameters.AddWithValue(parameterName: "@solution", newTicket.solution);
                outcom.Parameters.AddWithValue(parameterName: "@ownerId", newTicket.owner.id);

                if (newTicket.assigned != null)
                    outcom.Parameters.AddWithValue(parameterName: "@assignedTo", newTicket.assigned.id);
                else
                    outcom.Parameters.AddWithValue(parameterName: "@assignedTo", DBNull.Value);

                if (newTicket.dateSolved != DateTime.MinValue)
                    outcom.Parameters.AddWithValue(parameterName: "@dateSolved", newTicket.dateSolved);
                else
                    outcom.Parameters.AddWithValue(parameterName: "@dateSolved", DBNull.Value);

                if (newTicket.dateModified != DateTime.MinValue)
                    outcom.Parameters.AddWithValue(parameterName: "@dateModified", newTicket.dateModified);
                else
                    outcom.Parameters.AddWithValue(parameterName: "@dateModified", DBNull.Value);

                outcom.ExecuteNonQuery();
            }
            else
            {
                // No existing ticket.  Create a new row.
                reader.Close();
                outcom.CommandText = "Insert into Ticket (header, description, dateCreated, dateModified, owner, priority, AssignedTo, solution) " +
                                     " values(@header, @description, @dateCreated, @dateModified, @owner, @priority, @assignedTo, @solution);";

                //SqlCommand Incom = new SqlCommand(outcom.CommandText, con);

                //Insert new row
                outcom.Parameters.AddWithValue(parameterName: "@header", newTicket.header);
                outcom.Parameters.AddWithValue(parameterName: "@description", newTicket.description);
                outcom.Parameters.AddWithValue(parameterName: "@dateCreated", newTicket.dateCreated);
                outcom.Parameters.AddWithValue(parameterName: "@dateModified", newTicket.dateModified);
                outcom.Parameters.AddWithValue(parameterName: "@priority", newTicket.priority);
                outcom.Parameters.AddWithValue(parameterName: "@owner", User.current.id);
                outcom.Parameters.AddWithValue(parameterName: "@solution", newTicket.solution);

                if (newTicket.assigned == null)
                {
                    outcom.Parameters.AddWithValue(parameterName: "@assignedTo", 0);
                }
                else
                {
                    outcom.Parameters.AddWithValue(parameterName: "@assignedTo", newTicket.assigned.id);
                }


                //insert new row
                outcom.ExecuteNonQuery();
            }
        }
        // Register function
        public bool Register(String email, String password, String type)
        {
           
            if (email == "") throw new Exception("No email provided.");
            if (password == "") throw new Exception("No password provided.");

            String str = "insert into Users values(@Email, @Password, @Type, @Date);";

            DateTime myDateTime = DateTime.Now;
            string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss");

            SqlCommand com = new SqlCommand(str, con);
            com.Parameters.AddWithValue(parameterName: "@Email",        email);
            com.Parameters.AddWithValue(parameterName: "@Password",     password);
            com.Parameters.AddWithValue(parameterName: "@Type",         type);
            com.Parameters.AddWithValue(parameterName: "@Date",         sqlFormattedDate);
            try
            {
                com.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("That Email is already taken, please try again.", "Error");
                    return false;
                }
                else
                {
					MessageBox.Show("Please try another Username.", "Error");
					return false;
					throw;
                }
            }
        }

		public List<User> SortUsers(int Identifier)
		{
			List<User> users = new List<User>();

			string query = "SELECT * FROM Users ";

			if (Identifier == 1)
				query += "ORDER BY 'ID' ASC";

			else if (Identifier == 2)
				query += "ORDER BY 'ID' DESC";

			else if (Identifier == 3)
				query += "ORDER BY 'Date_Created' ASC";

			else if (Identifier == 4)
				query += "ORDER BY 'Date_Created' DESC";

			SqlCommand com = new SqlCommand(query, con);

			SqlDataReader reader = com.ExecuteReader();
			while (reader.Read())
			{
				User user = readUserRow(reader);
				users.Add(user);
			}
			com.Dispose();
			reader.Close();

			return users;
		}
	
    }
}
    

