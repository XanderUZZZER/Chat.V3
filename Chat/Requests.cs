using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat
{
    public enum Requests
    {
        ConnectionOk,
        Disconnect,
        LoginBad,
        LoginOk,
        Message,
        PasswordBad
    }
}
