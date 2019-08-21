using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_r.GetPath
{
    class Subject
    {
        void Find_Subject(IWebDriver driver)
        {
            var Subject = driver.FindElement(By.XPath("//select[@id='yjxkdm']"));
        }
        List<string> Show_Subject(string Subject)
        {
            Subject = Subject.Replace(System.Environment.NewLine, string.Empty);
            int Counts = Subject.Count();
            List<string> provincelist = new List<string>();
            for (int i = 1; i < Counts; i++)
            {
                provincelist.Add(Subject.ElementAt(i).ToString());
            }
            return provincelist;
        }

    }
}
