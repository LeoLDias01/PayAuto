using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PayAuto.Selenium.Infra;
using PayAuto.Selenium.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PayAuto.Selenium.Domain
{
    public class WebBrowserBase : IDisposable, IWebBrowserBase
    {
        public IWebDriver Driver { get; set; }
        public Screenshot Screenshot => (Driver as ITakesScreenshot).GetScreenshot();
        public IJavaScriptExecutor JavaScriptExecutor => Driver as IJavaScriptExecutor;
        public IAlert Alert { get; set; }
        public string DownloadPath { get; set; }

        public void Navigate(string url)
        {
            Driver.Navigate().GoToUrl(url);
            WaitUntilLoaded();
        }

        public void Refresh()
        {
            Driver.Navigate().Refresh();
        }

        public void Back()
        {
            Driver.Navigate().Back();
        }

        public bool SwitchToFrame(string frameName)
        {
            try
            {
                return Driver.SwitchTo().CustomFrame(frameName);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SwitchToFrame(int index)
        {
            try
            {
                Driver.SwitchTo().Frame(index);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void AcceptAlert()
        {
            Driver.SwitchTo().Alert().Accept();
        }

        public bool SetValue(string xPath, string value)
        {
            try
            {
                var element = CustomFindElement(By.XPath(xPath));

                if (element is null) return false;

                element.Click();
                element.Clear();

                return element.CustomSendKeys(Keys.Home + value);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SetValueByName(string Name, string value)
        {
            try
            {
                var element = CustomFindElement(By.Name(Name));

                if (element is null) return false;

                element.Click();
                element.Clear();

                element.CustomSendKeys(Keys.Home);
                element.CustomSendKeys(Keys.Control + "A");
                element.CustomSendKeys(Keys.Delete);
                return element.CustomSendKeys(value);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SetValueByCssSelector(string CssSelector, string value)
        {
            var element = CustomFindElement(By.CssSelector(CssSelector));

            if (element is null) return false;

            element.Click();
            element.Clear();

            return element.CustomSendKeys(Keys.Home + value);
        }

        public bool SetValueById(string Id, string value)
        {
            var element = CustomFindElement(By.Id(Id));

            if (element is null) return false;

            element.Click();
            element.Clear();

            return element.CustomSendKeys(Keys.Home + value);
        }

        public void MinimizarJanela()
        {
            Driver.Manage().Window.Minimize();
        }

        public string GetValue(string xPath)
        {
            var element = CustomFindElement(By.XPath(xPath));

            if (element is null) return string.Empty;

            return element.Text;
        }

        public bool Submit(string xPath)
        {
            var result = CustomFindElement(By.XPath(xPath));

            if (result is null) return false;

            return result.CustomSendKeys(Keys.Enter);
        }

        public bool Click(By by)
        {
            var element = CustomFindElement(by);

            if (element is null) return false;

            return element.CustomClick();
        }

        public bool Click(string xPath)
        {
            var element = CustomFindElement(By.XPath(xPath));

            if (element is null) return false;

            return element.CustomClick();
        }

        public bool ClickOnId(string Id)
        {
            var element = CustomFindElement(By.Id(Id));

            if (element is null) return false;

            return element.CustomClick();
        }

        public bool ClickOnClass(string Class)
        {
            var element = CustomFindElement(By.ClassName(Class));

            if (element is null) return false;

            return element.CustomClick();
        }

        public bool ClickOnCss(string Css)
        {
            var element = CustomFindElement(By.CssSelector(Css));

            if (element is null) return false;

            return element.CustomClick();
        }

        public virtual void ExecuteJScript(string jScript)
        {
            JavaScriptExecutor.ExecuteScript(jScript);
        }

        public virtual string ReturnJScript(string jScript)
        {
            var result = JavaScriptExecutor.ExecuteScript($"return {jScript}").ToString() ?? string.Empty;

            return result;
        }

        public virtual string GetAttribute(By by, string attributeName)
        {
            try
            {
                return CustomFindElement(by).GetAttribute(attributeName) ?? string.Empty;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        public virtual DropDownItem GetDropDownSelected(By by)
        {
            try
            {
                var selectItem = Driver.FindElements(by).SingleOrDefault(o => o.Selected);

                return
                    new DropDownItem()
                    {
                        ItemDescription = selectItem.Text,
                        ItemValue = selectItem.GetDomProperty("value")
                    };
            }
            catch (Exception)
            {
                return null;
            }
        }

        public virtual bool ScreenshotFull(string nomeArquivo, ScreenshotImageFormat imageFormat)
        {
            try
            {
                Screenshot.SaveAsFile(nomeArquivo, imageFormat);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public virtual bool ScreenshotOfElement(IWebElement element, string fileName)
        {
            try
            {
                using (var bmpScreen = new Bitmap(new MemoryStream(Screenshot.AsByteArray)))
                using (var bitmap = bmpScreen.Clone(new Rectangle(element.Location, element.Size), bmpScreen.PixelFormat))
                    bitmap.Save(fileName);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public virtual IWebElement CustomFindElement(By by)
        {
            try
            {
                return Driver.FindElement(by);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool TryFindElement(By by, out IWebElement element)
        {
            element = null;
            try
            {
                element = Driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException ex)
            {
                return false;
            }
        }

        public virtual IWebElement CustomFindElementXPath(string xpath)
        {
            try
            {
                return Driver.FindElement(By.XPath(xpath));
            }
            catch (Exception)
            {
                return null;
            }
        }

        public virtual IWebBrowserBase WaitUntilLoaded()
        {
            WaitUntil(b => b.ReturnJScript("document.readyState").Equals("complete"));

            return (IWebBrowserBase)this;
        }

        public virtual IWebBrowserBase WaitUntil(Expression<Func<IWebBrowserBase, bool>> predicate, int timeout = 30)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(timeout));

            wait.Until(x => predicate.Compile()(this));

            return this;
        }

        public void Dispose()
        {
            Driver?.Quit();
            Driver?.Dispose();
        }

        public bool GetAlert()
        {
            try
            {
                Alert = Driver.SwitchTo().Alert();

                return true;
            }
            catch (Exception ex)
            {
            }
            return false;
        }

        public void OpenNewTab()
        {
            Driver.SwitchTo().Window(Driver.WindowHandles.Last());

            var qtd = Driver.WindowHandles.Count;

            ((IJavaScriptExecutor)Driver).ExecuteScript("window.open();");
            while (qtd == Driver.WindowHandles.Count)
                Thread.Sleep(300);

            Driver.SwitchTo().Window(Driver.WindowHandles.Last());
        }

        public bool SwitchToTab(string tab)
        {
            Driver.SwitchTo().Window(tab);
            return Driver.CurrentWindowHandle == tab;
        }

        public void CloseTab(string tabName)
        {
            if (!Driver.WindowHandles.Contains(tabName))
                return;

            Driver.SwitchTo().Window(tabName);
            Driver.Close();
        }

        public void SetValueDropDownSelectedByValue(By by, string value)
        {
            var drop = CustomFindElement(by);
            var selectElement = new SelectElement(drop);
            selectElement.SelectByValue(value);
        }

        public void SetValueDropDownSelectedByText(By by, string value)
        {
            var drop = CustomFindElement(by);
            var selectElement = new SelectElement(drop);
            selectElement.SelectByText(value);
        }

        public bool SendEnter(By by)
        {
            try
            {
                Driver.FindElement(by).SendKeys(Keys.Enter);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

