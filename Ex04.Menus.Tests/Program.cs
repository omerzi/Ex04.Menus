using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ex04.Menus.Tests
{
    public class Program
    {
        public static void Main()
        {
            DelegatesTest delegateTest= new DelegatesTest();
            delegateTest.StartTest();

            InterfacesTests interfaceTest = new InterfacesTests();
            interfaceTest.StartTest();
        }

    }
}
