using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace DBIT
{
    class User
    {

        // Static Properties

        public static User current { set; get; }
        public static User workaround { set; get; }

        // Properties

        public int id { set; get; }
        public string email { set; get; }
        public string type { set; get; }
        public DateTime dateCreated { set; get; }

        // Constructors

        public User()
        {
            this.id = 0;
            this.email = "";
            this.type = "";
            this.dateCreated = DateTime.Now;
        }

        public User(string email, string type)
        {
            this.id = 0;
            this.email = email;
            this.type = type;
            this.dateCreated = DateTime.Now;
        }

        public User(int id, string email, string type, DateTime dateCreated)
        {
            this.id = id;
            this.email = email;
            this.type = type;
            this.dateCreated = dateCreated;
        }

        // Methods

        public string getType()
        {
            return type;
        }

        public int getID()
        {
            return id;
        }

        public string[] toStringArray()
        {
            string[] str = new string[4];
            str[0] = id + "";
            str[1] = email;
            str[2] = type;
            str[3] = dateCreated.ToString();
            return str;
        }

        public static User fromStringArray(string[] str)
        {
            int id = Convert.ToInt32(str[0]);
            string email = str[1];
            string type = str[2];
            DateTime created = DateTime.Parse(str[3]);

            return new User(id, email, type, created);
        }

        // DATABASE related methods

        // Returns a user with the given email and password
        // Returns null if no id exists (from DatabaseHandler.getUser)
        public static User Get(string email, string password)
        {
            DatabaseHandler db = new DatabaseHandler();
            User user;
            try
            {
                db.OpenConn();
                user = db.userLogin(email, password);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db.CloseConn();
            }
            return user;
        }

        // Returns a user with the given id
        // Returns null if no id exists (from DatabaseHandler.getUser)
        public static User Get(int id)
        {
            DatabaseHandler db = new DatabaseHandler();
            User user;
            try
            {
                db.OpenConn();
                user = db.getUser(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db.CloseConn();
            }
            return user;
        }

        // Returns a user with the given id
        // Returns null if no id exists (from DatabaseHandler.getUser)
        public static User Get(string email)
        {
            DatabaseHandler db = new DatabaseHandler();
            User user;
            try
            {
                db.OpenConn();
                user = db.getUser(email);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db.CloseConn();
            }
            return user;
        }

        public bool Register(string password)
        {
            DatabaseHandler db = new DatabaseHandler();
            try
            {
                db.OpenConn();
                return db.Register(email, password, type);
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

        public static List<User> GetAll()
        {
            DatabaseHandler db = new DatabaseHandler();
            List<User> users;
            try
            {
                db.OpenConn();
                users = db.getAllUserObjects();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db.CloseConn();
            }
            return users;
        }
		public static List<User> GetAllSorted(int Identifier)
		{
			DatabaseHandler db = new DatabaseHandler();
			List<User> users;
			try
			{
				db.OpenConn();
				users = db.SortUsers(Identifier);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				db.CloseConn();
			}
			return users;
		}

        public void EditUserType(string type, int id)
        {
            DatabaseHandler db = new DatabaseHandler();
            try
            {
                db.OpenConn();
                db.editUserType(type, id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error editing user type.\n" + ex.ToString());
            }
            finally
            {
                db.CloseConn();
            }
        }
	}
}
