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
            //MainMenu firstDelegateMenu = new MainMenu("Version and Digits");
            //FinalMenuItem countCapitals = new FinalMenuItem("Count Capitals");
            //FinalMenuItem showVersion = new FinalMenuItem("Show Version");

            //countCapitals.Activate += new DelegatesTest().printCountCapital_Activate;
            
            DelegatesTest test= new DelegatesTest();
            test.StartTest();
        }

    }
}
