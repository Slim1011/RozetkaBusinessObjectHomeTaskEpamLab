using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RozetkaHomeTaskEpamLab.Decorator
{
    class DecoratedGetText : AbstractElement
    {
        public DecoratedGetText(IWebElement element) : base(element)
        {
             
        }

        public string SafeGetText()
        {
            if (!String.IsNullOrEmpty(element.Text))
            {
                return element.Text;
            }
            else
            {
                Console.WriteLine("Element not contains any text!");
                return null;
            }
        }

    }
}
