using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_r.GetPath
{
    class Major
    {
        void Find_Subject(IWebDriver driver)
        {
            var Major = driver.FindElement(By.XPath("//select[@id='zymc']"));
        }
        List<string> Show_Major(string Major)
        {
            Major = Major.Replace(System.Environment.NewLine, string.Empty);
            int Counts = Major.Count();
            List<string> provincelist = new List<string>();
            for (int i = 1; i < Counts; i++)
            {
                provincelist.Add(Major.ElementAt(i).ToString());
            }
            return provincelist;
        }
    }
}
