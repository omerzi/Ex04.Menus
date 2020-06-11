using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class FinalMenuItem : MenuItem, IActivable
    {
        private readonly List<IActivationInvokers> r_InvokersList;

        public FinalMenuItem(string i_Name) : base(i_Name)
        {
            r_InvokersList = new List<IActivationInvokers>();
        }

        public void AddInvoker(IActivationInvokers i_Invoker)
        {
            r_InvokersList.Add(i_Invoker);
        }

        public void RemoveInvoker(IActivationInvokers i_Invoker)
        {
            r_InvokersList.Remove(i_Invoker);
        }

        public void InvokeAll()
        {
            foreach(IActivationInvokers currentItem in r_InvokersList)
            {
                currentItem.Invoke();
            }
        }
    }
}
