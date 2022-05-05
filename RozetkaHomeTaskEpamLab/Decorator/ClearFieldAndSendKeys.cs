using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RozetkaHomeTaskEpamLab.Decorator
{
    public class ClearFieldAndSendKeys : AbstractElement
    {
        public ClearFieldAndSendKeys(IWebElement element) : base(element)
        {

        }

        public override void SendKeys(string text)
        {
            element.Clear();
            base.SendKeys(text);
        }
    }
}
