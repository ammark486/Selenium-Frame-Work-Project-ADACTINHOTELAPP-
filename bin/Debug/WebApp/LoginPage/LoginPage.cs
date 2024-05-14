using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDemoProject
{
    internal class LoginPage : CorePage 
    {

        By usernameTxt = By.Id("username");
        By passwordTxt = By.Id("password");
        By loginBtn = By.Id("login");


        public void login(String url, String username, String password)
        {
            // driver.Url = url;
            //driver.FindElement(usernameTxt).SendKeys(username);
            // driver.FindElement(passwordTxt).SendKeys(password);
            // driver.FindElement(loginBtn).Click();

            Step = Test.CreateNode("LoginPage"); 
            OpenUrl(url);
            Write(usernameTxt,username);
            Write(passwordTxt,password);
            Click(loginBtn);
        }

    }
}
