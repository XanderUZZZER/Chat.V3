using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat
{
    class User
    {
        public string Name { get; private set; }
        
        private string password;

        public bool CorrectPassword(string password)
        {
            return this.password == password;
        }
    }
}
