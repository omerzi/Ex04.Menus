using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Tests
{
    public class Time : IActivationInvokers
    {
        public void Invoke()
        {
            Console.Clear();
            Console.WriteLine("This is the time right now : {0}", DateTime.Now.ToShortTimeString());
            System.Threading.Thread.Sleep(2000);
        }
    }
}
