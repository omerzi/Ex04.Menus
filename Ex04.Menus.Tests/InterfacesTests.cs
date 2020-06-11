using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Tests
{
    public class InterfacesTests
    {
        public void StartTest()
        {
            MainMenu secondInterfaceMenu = new MainMenu("Show Date/Time");
            FinalMenuItem showTime = new FinalMenuItem("Show Time");
            FinalMenuItem showDate = new FinalMenuItem("Show Date");
            Date date = new Date();
            Time time = new Time();
            showDate.AddInvoker(date);
            showTime.AddInvoker(time);
            secondInterfaceMenu.AddMenuItem(showDate);
            secondInterfaceMenu.AddMenuItem(showTime);

            secondInterfaceMenu.Show();
        }


    }
}
