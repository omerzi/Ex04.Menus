using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Tests
{
    public  class DelegatesTest
    {
        public void StartTest()
        {
            MainMenu firstDelegateMenu = new MainMenu("Version and Digits");
            FinalMenuItem countCapitals = new FinalMenuItem("Count Capitals");
            FinalMenuItem showVersion = new FinalMenuItem("Show Version");
            countCapitals.Activate += printCountCapital_Activation;
            countCapitals.Activate += showVersion_Activation;

            firstDelegateMenu.AddMenuItem(countCapitals);
            firstDelegateMenu.Show();
        }

        private void showVersion_Activation()
        {
            Console.Clear();
            Console.WriteLine("Version 20.2.4.30620");
            System.Threading.Thread.Sleep(2000);
        }

        private void printCountCapital_Activation()
        {
            Console.WriteLine("Please enter a sentence: ");
            string userSentence = Console.ReadLine();
            int countCapital = 0;
            for(int i = 0; i < userSentence.Length; i++)
            {
                if (char.IsUpper(userSentence[i]))
                {
                    countCapital++;
                }
            }

            Console.WriteLine("Your sentence has {0} capital letters!", countCapital);
            Console.Clear();
            System.Threading.Thread.Sleep(2000);
        }
    }
}
