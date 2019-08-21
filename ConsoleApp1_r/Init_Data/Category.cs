using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_r.GetPath
{
    class Category
    {
        void Find_Category(IWebDriver driver)
        {
            var Category = driver.FindElement(By.XPath("//select[@id='mldm']"));
        }
        List<string> Show_Category(string Category)
        {
            Category = Category.Replace(System.Environment.NewLine, string.Empty);
            int Counts = Category.Count();
            List<string> provincelist = new List<string>();
            for (int i = 1; i < Counts; i++)
            {
                provincelist.Add(Category.ElementAt(i).ToString());
            }
            return provincelist;
        }
    }
}
