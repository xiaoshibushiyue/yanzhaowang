using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_r.GetPath
{
    class Province
    {
        void Find_Province(IWebDriver driver)
        {
            var provinces = driver.FindElement(By.XPath("//select[@id='ssdm']"));
        }
        List<string> Show_Province(string provines)
        {
            provines = provines.Replace(System.Environment.NewLine, string.Empty);
            int Counts = provines.Count();
            List<string> provincelist = new List<string>();
            for (int i=1;i<Counts;i++)
            {
                provincelist.Add(provines.ElementAt(i).ToString());
            }
            return provincelist;
        }
    }
}
