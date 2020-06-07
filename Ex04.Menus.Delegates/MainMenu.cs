using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class MainMenu : MenuItem
    {
        private const int k_FirstMenu = 0;
        private int m_CurrentLevel;
        private readonly List<MenuItem> r_MenuItems;
        private MainMenu m_PreviousMenu = null;

        public MainMenu(string i_Label, int i_CurrentLevel = 0, MainMenu i_PreviousMenu = null) : base(i_Label)
        {
            m_PreviousMenu = i_PreviousMenu;
            m_CurrentLevel = i_CurrentLevel;
            r_MenuItems = new List<MenuItem>();
        }

        public void AddMenuItem(string i_MenuItemName, List<MenuItem> i_MenuItemList = null)
        {
            if (i_MenuItemList == null)
            {
                r_MenuItems.Add(new FinalMenuItem(i_MenuItemName));
            }
            else
            {
                r_MenuItems.Add(new MenuItem(i_MenuItemName));
            }
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
                if (m_CurrentLevel == k_FirstMenu)
                {
                    Console.WriteLine("Please select one of the options between 1 to {0}", r_MenuItems.Count);
                }
                else
                {
                    Console.WriteLine("{0}, please select one of the options between 1 to {1}: ", ItemName, r_MenuItems.Count);
                }

                foreach (MenuItem menuItem in r_MenuItems)
                {
                    if (m_CurrentLevel == k_FirstMenu)
                    {
                        Console.WriteLine("{0}. Exit", k_FirstMenu);
                    }
                    else
                    {
                        Console.WriteLine("0. Back");
                    }

                    Console.WriteLine("{0}. {1}", currentMenuItem, menuItem.ItemName);
                }

                Console.Write("Enter selection: ");
                int userSelection = getValidSelection(k_FirstMenu, r_MenuItems.Count);
                if (userSelection == k_FirstMenu && m_CurrentLevel == 0)
                {
                    isRunning = false;
                }
                else if (userSelection == k_FirstMenu)// back sitautation
                {
                    m_CurrentLevel--;
                    m_PreviousMenu.Show();
                }
                else
                {
                    if (r_MenuItems[userSelection] is FinalMenuItem)
                    {
                        (r_MenuItems[userSelection] as FinalMenuItem).DoOnActivation();
                    }
                    else
                    {
                        (r_MenuItems[userSelection] as MainMenu).Show();
                    }
                }
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
