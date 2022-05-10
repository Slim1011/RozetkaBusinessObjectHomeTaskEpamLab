using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RozetkaHomeTaskEpamLab.Decorator
{
    public class DecoratedSendKeys : AbstractElement
    {
       
        public DecoratedSendKeys(IWebElement element) : base(element)
        {
          
        }

        public override void SendKeys(string text)
        {
            element.Clear();
            element.SendKeys(text);
            Console.WriteLine($"Start searching for: {text}");
        }
    }
}
