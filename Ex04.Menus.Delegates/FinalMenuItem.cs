using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class FinalMenuItem : MenuItem, IActivable
    {
        public event ActivateHandler Activation;

        public FinalMenuItem(string i_Name) : base(i_Name)
        {
        }

        public void Invoke()
        {
            this.OnActivation();
        }

        protected virtual void OnActivation()
        {
            Activation?.Invoke();
        }
    }
}
