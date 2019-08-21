using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1_r
{
    class Program
    {
        static void Main(string[] args)
        {
         
            var path = Path.Combine(Environment.CurrentDirectory);
            IWebDriver driver = new ChromeDriver(path);
            driver.Navigate().GoToUrl("https://yz.chsi.com.cn/zsml/zyfx_search.jsp");
            driver.SwitchTo().Window("");
            

            var txtusername = driver.FindElement(By.Id("mldm"));
            txtusername.SendKeys("(08)工学");
            var txtpassword = driver.FindElement(By.Id("yjxkdm"));
            txtpassword.SendKeys("(0812)计算机科学与技术");
            var d = driver.FindElement(By.Id("zymc"));
            d.SendKeys("计算机科学与技术");
            var a = driver.FindElement(By.Name("button"));
            a.Click();

            var submit1 = driver.FindElement(By.ClassName("ch-page"));
            {
                string text = submit1.Text;
                
                text = text.Replace(System.Environment.NewLine, string.Empty).Replace(" ","");
                int num = text.Count();
                char you=text.ElementAt(num-2);
                string sssss = you.ToString();
                int n=Convert.ToInt32(sssss);
                for (int i=1;i< n ;i++)
                {
                    var byXPath = driver.FindElement(By.XPath("//ul[@class='ch-page']/li[last()-1]/a"));
                    var Major = driver.FindElements(By.XPath("//tbody//a"));
                    
                    foreach (IWebElement webElement in Major)
                    {
                        
                        webElement.Click();
                        string handle = driver.CurrentWindowHandle;
                        ReadOnlyCollection<string> handles = driver.WindowHandles;
                        foreach (string han in handles)
                        {
                            if (han!=handle)
                            {
                                driver.SwitchTo().Window(han);
                                //循环
                                int number = driver.FindElement(By.ClassName("ch-page")).Text.Count();
                                
                                var xiangxi = driver.FindElements(By.XPath("//tbody//a[@class='js-from-title']"));
                                foreach (IWebElement webElement1 in xiangxi)
                                {
                                    //录取人数和备注
                                    string asd = webElement1.GetAttribute("data-title");
                                }
                                var byXPath1 = driver.FindElement(By.XPath("//ul[@class='ch-page']/li[last()-1]/a"));

                                driver.Close();
                            }
                        }
                        
                        driver.Close();
                        

                    }
                    byXPath.Click();
                    
                    Thread.Sleep(300);
                }
            }
           
            
        }
    }
}
