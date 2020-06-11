
namespace Ex04.Menus.Tests
{
    using Ex04.Menus.Delegates;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public class DelegatesTest
    {
        public void StartTest()
        {
            MainMenu firstDelegateMenu = new MainMenu("Version and Digits");
            FinalMenuItem countCapitals = new FinalMenuItem("Count Capitals");
            FinalMenuItem showVersion = new FinalMenuItem("Show Version");
            countCapitals.Activation += printCountCapital_Activation;
            showVersion.Activation += showVersion_Activation;
            firstDelegateMenu.AddMenuItem(countCapitals);
            firstDelegateMenu.AddMenuItem(showVersion);
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
            Console.Clear();
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

            Console.Clear();
            Console.WriteLine("Your sentence has {0} capital letters!", countCapital);
            System.Threading.Thread.Sleep(2000);
        }
    }
}
