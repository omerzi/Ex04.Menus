using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public abstract class MenuItem
    {
        private readonly string r_Label;

        public MenuItem(string i_Label)
        {
            r_Label = i_Label;
        }

        public string ItemName
        {
            get { return r_Label; }
        }
    }
}
