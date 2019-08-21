using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1_r.Page
{
    class GetPage
    {
        void page(IWebDriver driver)
        {
            var nextpage = driver.FindElement(By.ClassName("ch-page"));
            string text = nextpage.Text;

            text = text.Replace(System.Environment.NewLine, string.Empty).Replace(" ", "");
            int num = text.Count();
            char you = text.ElementAt(num - 2);
            string page_number = you.ToString();
            int n = Convert.ToInt32(page_number);
            for (int i = 1; i < n; i++)
            {
                //找到下一页按钮
                var byXPath = driver.FindElement(By.XPath("//ul[@class='ch-page']/li[last()-1]/a"));
                //找到这个页上的所有大学
                var Major = driver.FindElements(By.XPath("//tbody//a"));
                //点击
                foreach (IWebElement webElement in Major)
                {
                    webElement.Click();
                    driver.Close();
                    //driver.Navigate().Forward();

                }
                byXPath.Click();

                Thread.Sleep(300);
            }
        }
    }
}
