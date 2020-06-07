using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class FinalMenuItem : MenuItem, IActivable
    {
        public event ActivateHandler HasActivated;

        public FinalMenuItem(string i_Name) : base(i_Name)
        {
        }

        public void DoOnActivation()
        {
            this.OnActivation();
        }

        protected virtual void OnActivation()
        {
            HasActivated?.Invoke();
        }
    }
}
