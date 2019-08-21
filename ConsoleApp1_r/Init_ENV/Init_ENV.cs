using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_r.Init_ENV
{
    class Init_ENV
    {
        IWebDriver driver;
        void Init()
        {
            var path = Path.Combine(Environment.CurrentDirectory);
            driver = new ChromeDriver(path);
        }
        void Goto_Url(string URL)
        {
            driver.Navigate().GoToUrl(URL);
        }
        /// <summary>
        /// 填写表单数据（学科类别为必选项，其他至少填写一项）
        /// </summary>
        /// <param name="province"></param>
        /// <param name="Category"></param>
        /// <param name="subject">学科类别</param>
        /// <param name="major"></param>
        void fill_Data(string province,string Category,string subject,string major)
        {
            var menlei = driver.FindElement(By.Id("mldm"));
            menlei.SendKeys(Category);
            var xuekeliebie = driver.FindElement(By.Id("yjxkdm"));
            xuekeliebie.SendKeys(subject);
            var zhuanyemingcheng = driver.FindElement(By.Id("zymc"));
            zhuanyemingcheng.SendKeys(major);
            var seacher = driver.FindElement(By.Name("button"));
            seacher.Click();
        }
    }
}
