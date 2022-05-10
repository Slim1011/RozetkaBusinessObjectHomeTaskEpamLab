using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RozetkaHomeTaskEpamLab.Decorator
{
    class DecoratedClick : AbstractElement
    {
        public DecoratedClick(IWebElement element) : base(element)
        {

        }

        public override void Click()
        {
            try
            {
                base.Click();
                
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
