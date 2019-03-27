using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Applitools.Selenium;
using OpenQA.Selenium.Chrome;

namespace Applitools
{
    class Program
    {
        static void Main(string[] args)
        {

            var driver = new ChromeDriver();

            var eyes = new Eyes();

            eyes.ForceFullPageScreenshot = true;

            eyes.ApiKey = "5WF2aPeC5IC108n110UTpeXKGQosC8u9JmhQE9X5k5mD7RU110";

            try
            {
                
                eyes.Open(driver, "Demo C# app", "Login Window", new Size(600, 800));
 
                driver.Url = "https://demo.applitools.com";
                
                eyes.CheckWindow("Login Window test");
      
                eyes.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                driver.Quit();
                eyes.AbortIfNotClosed();
            }
        }
    }
}

