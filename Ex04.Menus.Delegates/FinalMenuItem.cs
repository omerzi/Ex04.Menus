using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class FinalMenuItem : MenuItem
    {
        public event ActivateHandler HasActivated;

        public FinalMenuItem(string i_Name) : base(i_Name)
        {
        }

        protected virtual void OnActivation()
        {
            HasActivated?.Invoke();
        }
    }
}
