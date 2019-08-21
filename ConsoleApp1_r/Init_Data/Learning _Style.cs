using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_r.GetPath
{
    class Learning__Style
    {
        void Find_Subject(IWebDriver driver)
        {
            //处理方式不一样
            var Style = driver.FindElements(By.XPath("//tbody//a"));

        }
        List<string> Show_Major(string Style)
        {
            Style = Style.Replace(System.Environment.NewLine, string.Empty);
            int Counts = Style.Count();
            List<string> provincelist = new List<string>();
            for (int i = 1; i < Counts; i++)
            {
                provincelist.Add(Style.ElementAt(i).ToString());
            }
            return provincelist;
        }
    }
}
