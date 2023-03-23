using OpenQA.Selenium;
using PayAuto.Selenium.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PayAuto.Selenium.Domain
{
    public interface IWebBrowserBase
    {
        IWebDriver Driver { get; set; }
        Screenshot Screenshot { get; }
        IJavaScriptExecutor JavaScriptExecutor { get; }
        IAlert Alert { get; set; }
        string DownloadPath { get; set; }

        void Navigate(string url);

        void Back();

        void Refresh();

        bool SwitchToFrame(string frameName);

        bool SwitchToTab(string tabName);

        bool SwitchToFrame(int index);

        bool SetValue(string xPath, string value);

        string GetValue(string xPath);

        void ExecuteJScript(string jScript);

        string ReturnJScript(string jScript);

        bool Submit(string xPath);

        bool Click(string xPath);

        bool Click(By by);

        string GetAttribute(By by, string attributeName);

        bool ScreenshotFull(string nomeArqquivo, ScreenshotImageFormat imageFormat = ScreenshotImageFormat.Gif);

        bool ScreenshotOfElement(IWebElement element, string fileName);

        DropDownItem GetDropDownSelected(By by);

        IWebElement CustomFindElement(By by);

        IWebElement CustomFindElementXPath(string xpath);

        IWebBrowserBase WaitUntilLoaded();

        IWebBrowserBase WaitUntil(Expression<Func<IWebBrowserBase, bool>> predicate, int timeout = 30);

        bool SetValueByName(string xPath, string value);

        bool SetValueByCssSelector(string CssSelector, string value);

        bool SetValueById(string Id, string value);

        void AcceptAlert();

        bool ClickOnId(string Id);

        bool ClickOnClass(string Class);

        bool ClickOnCss(string Css);

        bool GetAlert();

        void OpenNewTab();

        void CloseTab(string tabName);

        void SetValueDropDownSelectedByValue(By by, string value);

        void SetValueDropDownSelectedByText(By by, string value);

        bool SendEnter(By by);
    }
}
