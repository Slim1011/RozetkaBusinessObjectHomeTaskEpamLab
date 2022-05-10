using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RozetkaHomeTaskEpamLab.Decorator
{
    public class AbstractElement : IWebElement
    {
        protected IWebElement element;

        public AbstractElement(IWebElement element)
        {
            this.element = element;
        }

        public  virtual void Clear()
        {
            element.Clear();
        }

        public virtual void SendKeys(string text)
        {
            element.SendKeys(text);
        }

        public virtual void Click()
        {
            element.Click();
        }
        public string TagName => throw new NotImplementedException();

        public virtual string Text => element.Text;

        public bool Enabled => throw new NotImplementedException();

        public bool Selected => throw new NotImplementedException();

        public Point Location => throw new NotImplementedException();

        public Size Size => throw new NotImplementedException();

        public bool Displayed => throw new NotImplementedException();

        

        

        public IWebElement FindElement(By by)
        {
            throw new NotImplementedException();
        }

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            throw new NotImplementedException();
        }

        public string GetAttribute(string attributeName)
        {
            throw new NotImplementedException();
        }

        public string GetCssValue(string propertyName)
        {
            throw new NotImplementedException();
        }

        public string GetDomAttribute(string attributeName)
        {
            throw new NotImplementedException();
        }

        public string GetDomProperty(string propertyName)
        {
            throw new NotImplementedException();
        }

        public string GetProperty(string propertyName)
        {
            throw new NotImplementedException();
        }

        public ISearchContext GetShadowRoot()
        {
            throw new NotImplementedException();
        }

        

        public void Submit()
        {
            throw new NotImplementedException();
        }
    }
}
