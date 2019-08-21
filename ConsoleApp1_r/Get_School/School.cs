using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_r.Get_School
{
    class School
    {
        void Find_Subject(IWebDriver driver)
        {
            var schools =driver.FindElements(By.XPath("//tbody//a"));
            
        }
        void Print_schoolname(List<string> schoolname)
        {

        }
        void Find_ohter(IWebDriver driver)
        {
            var byXPath = driver.FindElement(By.XPath("//ul[@class='ch-page']/li[last()-1]/a"));

        }
    }
}
