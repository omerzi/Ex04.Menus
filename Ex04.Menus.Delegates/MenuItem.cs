using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class MenuItem
    {
        private readonly List<MenuItem> r_SubMenu = null;
        private string m_ItemName;

        public MenuItem(string i_Name)
        {
            m_ItemName = i_Name;
        }

        public List<MenuItem> SubMenu
        {
            get { return r_SubMenu; }
        }

        public string ItemName
        {
            get { return m_ItemName; }
            set 
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new NullReferenceException("A name cannot be empty or consist of white-spaces only!");
                }

                m_ItemName = value;
            }
        }
    }
}
