using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDemoProject
{
    internal class BookingPage : CorePage
    {
        #region Locators
        By fnameTxt = By.Id("first_name");
        By lnameTxt = By.Id("last_name");
        By addressTxt = By.Id("address");
        By cCNoTxt = By.Id("cc_num");
        By cCtypeDropDown = By.Id("cc_type");
        By expiryDateDropDown = By.Id("cc_exp_month");
        By expiryYearDropDown = By.Id("cc_exp_year");
        By cVVNoTxt = By.Id("cc_cvv");
        By bookNowBtn = By.Id("book_now");
        By cancelBtn = By.Id("cancel");
        By orderNoTxt = By.Id("order_no");
        #endregion

        public void BookHotel()
        {
            // driver.FindElement(fnameTxt).SendKeys("Ammar");
            // driver.FindElement(lnameTxt).SendKeys("khan");
            // driver.FindElement(addressTxt).SendKeys("A-28,DHA");
            //driver.FindElement(cCNoTxt).SendKeys("12345678901234");
            // driver.FindElement(cCtypeDropDown).SendKeys("VISA");
            // driver.FindElement(expiryDateDropDown).SendKeys("APRIL");
            // driver.FindElement(expiryYearDropDown).SendKeys("2024");
            // driver.FindElement(cVVNoTxt).SendKeys("1234");
            // driver.FindElement(bookNowBtn).Click();

            Step = Test.CreateNode("BookingPage");

            Write(fnameTxt, "Ammar");
            Write(lnameTxt, "Khan");
            Write(addressTxt, "a-28,dha");
            Write(cCNoTxt, "12345678990");
            Write(cCtypeDropDown, "VISA");
            Write(expiryDateDropDown, "APRIL");
            Write(expiryYearDropDown, "2024");
            Write(cVVNoTxt, "1234");
            Click(bookNowBtn);

        }


    }
}

