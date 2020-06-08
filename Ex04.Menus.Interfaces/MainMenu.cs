using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class MainMenu : MenuItem
    {
        private const int k_ExitLevel = 0;
        private int m_CurrentLevel = 0;
        private readonly List<MenuItem> r_MenuItems;

        public MainMenu(string i_Label, int i_CurrentLevel = 0) : base(i_Label)
        {
            m_CurrentLevel = i_CurrentLevel;
            r_MenuItems = new List<MenuItem>();
        }

        public void AddMenuItem(MenuItem i_MenuItem)
        {
            r_MenuItems.Add(i_MenuItem);
        }

        public void DeleteMenuItem(MenuItem i_MenuItem)
        {
            r_MenuItems.Remove(i_MenuItem);
        }

        public void Show()
        {
            bool isRunning = true;
            while (isRunning)
            {
                int currentMenuItem = 1;
                Console.WriteLine("---- {0} (Current Level: {1}) ----", ItemName, m_CurrentLevel);
                printIfExitLevel(
                    string.Format("Please select one of the options between 1 to {0}", r_MenuItems.Count),
                    string.Format("{0}, please select one of the options between 1 to {1}: ", ItemName, r_MenuItems.Count));

                foreach (MenuItem menuItem in r_MenuItems)
                {
                    printIfExitLevel("0. Exit", "0. Back");
                    Console.WriteLine("{0}. {1}", currentMenuItem, menuItem.ItemName);
                }

                Console.Write("Enter selection: ");
                int userSelection = getValidSelection(k_ExitLevel, r_MenuItems.Count);
                operateBySelection(userSelection, ref isRunning);
            }
        }

        private void operateBySelection(int i_UserSelection, ref bool io_IsRunning)
        {
            if (i_UserSelection == k_ExitLevel)
            {
                io_IsRunning = false;
            }
            else
            {
                if(r_MenuItems[i_UserSelection - 1] is IActivable)
                {
                    (r_MenuItems[i_UserSelection - 1] as IActivable).InvokeAll();
                }
            }
        }

        private void printIfExitLevel(string i_FirstMsg, string i_SecondMsg)
        {
            if (m_CurrentLevel == k_ExitLevel)
            {
                Console.WriteLine(i_FirstMsg);
            }
            else
            {
                Console.WriteLine(i_SecondMsg);
            }
        }

        private int getValidSelection(int i_MinValue, int i_MaxValue)
        {
            bool isValid = int.TryParse(Console.ReadLine(), out int selection);
            while(!isValid && selection < i_MinValue || selection > i_MaxValue)
            {
                Console.WriteLine("Invalid choice! Please try again:");
                isValid = int.TryParse(Console.ReadLine(), out selection); 
            }

            return selection;
        }
    }
}
