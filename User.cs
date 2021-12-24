using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement1
{
    internal class User
    {

        // constructor
        public User()
        {

        }
        //parameterized constructor 
        public User(string username, string mailId, string password)
        {
            Username = username;
            MailId = mailId;
            Password = password;
        }


        //properties
        public string Username { get; set; }
        public string MailId { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return String.Format("Username:{0}\nMail Id:{1}\nPassword:{2}", Username, MailId, Password);
        }

        public override bool Equals(object obj)
        {
            User obj_user = (User)obj;
            return this.Username.Equals(obj_user.Username);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}