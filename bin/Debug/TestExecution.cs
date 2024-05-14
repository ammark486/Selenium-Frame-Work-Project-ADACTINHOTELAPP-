using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V122.CSS;
using System;
using System.Configuration;
using System.Runtime.InteropServices;

namespace SeleniumDemoProject
{
    [TestClass]
    public class TestExecution : CorePage

    {
        #region Setups and Cleanups

        public TestContext instance;

        public TestContext TestContext
        {
            set { instance = value; }

            get {return instance; } 
        
        }
        [AssemblyInitialize()]
        public static void AssemblyInit(TestContext context)
        {
            string ResultFile = @"C:\ExtentReports\TestExecLog_" + DateTime.Now.ToString("yyyyyMMddHHmmss") + ".html";
            CreateReport(ResultFile);
        }

        [AssemblyCleanup()]
        public static void AssemblyCleanup()
        {

            extentReports.Flush();
        
        }

        [ClassInitialize()]

        public static void ClassInit(TestContext context)
        {

        }
        [ClassCleanup()]
        public static void ClassCleanup()
        {

        }
        [TestInitialize()]
        public void TestInit()
        {
            CorePage.SeleinumInit(ConfigurationManager.AppSettings["Browser"].ToString());
            Test = extentReports.CreateTest(TestContext.TestName);

        }

        [TestCleanup]
        public void TestCleanup()
        {
            CorePage.driver.Close();
        } 
        #endregion


        // IWebDriver driver = new ChromeDriver();

        LoginPage loginPage = new LoginPage();
        SearchPage searchPage = new SearchPage();
        SelectPage selectPage = new SelectPage(); 
        BookingPage bookingPage = new BookingPage();
        
        [TestMethod]
       // [TestCategory("Login")]
        public void LoginWithValidUserValidPaaword_TC001()
        {
            loginPage.login("https://adactinhotelapp.com/", "AmmarTester", "ammar12");
            String actualText = CorePage.driver.FindElement(By.ClassName("welcome_menu")).Text;
            Assert.AreEqual("Welcome to Adactin Group of Hotels", actualText);        
        }

        [TestMethod]
        public void LoginWithInvalidUserInValidPaaword_TC002()
        {
            loginPage.login("https://adactinhotelapp.com/", "AmmarTester123", "ammar123");
            String actualText = CorePage.driver.FindElement(By.ClassName("auth_error")).Text;
            Assert.AreEqual("Invalid Login details or Your Password might have expired. Click here to reset your password", actualText);
        }

        [TestMethod]
        public void SearchHotel_TC001()
        {
            loginPage.login("https://adactinhotelapp.com/", "AmmarTester", "ammar12");
            searchPage.SearchHotel();           
        }
        [TestMethod]
        public void SelectHotel_TC001()
        {
            loginPage.login("https://adactinhotelapp.com/", "AmmarTester", "ammar12");
            searchPage.SearchHotel();
            selectPage.SelectHotel();
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML","Data.xml", "BookHotel_TC001", DataAccessMethod.Sequential)] //DataDriven
        [TestCategory("BookHotel")] //KeywordDriven
        public void BookHotel_TC001()
        {
            string url = TestContext.DataRow["url"].ToString();
            string user = TestContext.DataRow["username"].ToString();
            string pass = TestContext.DataRow["password"].ToString();
            
            loginPage.login(url, user, pass);
            searchPage.SearchHotel();
            selectPage.SelectHotel();
            bookingPage.BookHotel();  
        }



    }
}
