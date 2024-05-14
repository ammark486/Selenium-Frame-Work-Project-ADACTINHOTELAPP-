using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using System.IO;

namespace SeleniumDemoProject
{
    public class CorePage
    {
        public static IWebDriver driver;

        public static ExtentReports extentReports;
        public static ExtentTest Test;
        public static ExtentTest Step;


        public static void SeleinumInit(String browser)
        {
            if (browser == "Chrome")
            {
                var chromeOptions = new ChromeOptions();
                chromeOptions.AddArguments("--start-maximized");
                chromeOptions.AddArguments("--incognito");
                IWebDriver chromeDriver = new ChromeDriver(chromeOptions);
                driver = chromeDriver;
            }
            else if (browser == "FireFox")
            {
                FirefoxOptions options = new FirefoxOptions();
                options.AddArguments("");
                driver = new FirefoxDriver(options);
            }
            else if (browser == "MicrosoftEdge")
            {
               // var options = new OpenQA.Selenium.Edge.EdgeOptions();
               // var service = EdgeDriverService.CreateDefaultService(@"C:\Users\shahr\source\repos\DATA DRIVEN YT PROJ\DATA DRIVEN YT PROJ\bin\Debug", @"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe");
               // service.Start();
               //driver = new RemoteWebDriver(service.ServiceUrl, options);
            }
            else if (browser == "InternetExplorer")
            {

            }

        }

        //*********Wrapper Methods********//
        public void Write(By by ,string data)
        {
           // try
         //   {

                driver.FindElement(by).SendKeys(data);
          //      TakeScreenshot(Status.Pass, data+ ": Data Entered Successfully");
          //  }
          //  catch(Exception ex)
         //   {
              //  TakeScreenshot(Status.Fail, "Failed to enter data: " + ex);

          //  }

        }
        public void Click(By by)
        {
           // try
           // {
                driver.FindElement(by).Click();
               // TakeScreenshot(Status.Pass, "clicked successfully");

          //  }
            
          //  catch(Exception ex)
          //  {

               // TakeScreenshot(Status.Fail, "Failed to Click" + ex);
           // }
        }

        public void Clear(By by)
        {
              driver.FindElement(by).Clear();   
        }
            
        public void OpenUrl(string url)
        {
            driver.Url = url;

        }

        public static void CreateReport(string path)
        {
            extentReports = new ExtentReports();
            var sparkReporter = new ExtentSparkReporter(path); 
            extentReports.AttachReporter(sparkReporter);
        }

        /*public static void TakeScreenshot(Status status, string stepDetail)
        {

            string path = @"C:\ExtentReports\images\" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".png";
            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            File.WriteAllBytes(path, screenshot.AsByteArray);

            Step.Log(status, stepDetail, MediaEntityBuilder.CreateScreenCaptureFromPath(path).Build());
        }
        */




    }
}