using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class SubMenuItem : MainMenu, IActivable
    {
        public SubMenuItem(string i_Label) : base(i_Label) 
        {
        }

        public void Invoke()
        {
            base.Show();
        }
    }
}
