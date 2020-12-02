using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    public delegate string myDelegate(string str);
    class EventFunction
    {
        event myDelegate newEvent;
      
    
        public void  EventProgram()
        {
            this.newEvent += new myDelegate(this.WelcomeUser);   
            //subscribe(+=),unsubscribe(-=).
        }

        public string WelcomeUser(string username)
        {
            return "Welcome " + username;
        }
    }
    }

