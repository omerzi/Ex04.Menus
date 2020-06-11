using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Tests
{
    public class Date : IActivationInvokers
    {
        public void Invoke()
        {
            Console.Clear();
            Console.WriteLine("This is the current date: {0}", DateTime.Now.ToShortDateString());
            System.Threading.Thread.Sleep(2000);
        }
    }
}
