using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDemoProject
{
    internal class SelectPage : CorePage
    {
        #region Locators

        By selectRadioBtn = By.Id("radiobutton_0");
        By continueBtn = By.Id("continue");
        By cancelbtn = By.Id("Cancel");

        #endregion

        public void SelectHotel()
        {
            // driver.FindElement(selectRadioBtn).Click();
            // driver.FindElement(continueBtn).Click();

            //*********Action BASED METHODS**********//

            Step = Test.CreateNode("SelectPage");
            Click(selectRadioBtn);
            Click(continueBtn);


        }


    }
}

