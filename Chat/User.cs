using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat
{
    public class User
    {
        public string Name { get; private set; }        
        private string password;

        public User(string name, string password)
        {
            Name = name;
            this.password = password;
        }

        public bool CorrectPassword(string password)
        {
            return this.password == password;
        }
    }
}
