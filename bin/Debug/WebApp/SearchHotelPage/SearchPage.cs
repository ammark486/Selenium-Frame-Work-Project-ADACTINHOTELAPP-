using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDemoProject
{
    internal class SearchPage : CorePage
    {
        #region Locators
        By locationDropDown = By.Id("location");
        By hotelDropDown = By.Id("hotels");
        By roomTypeDropDown = By.Id("room_type");
        By noOfRoomDropDown = By.Id("room_nos");
        By checkInDateTxt = By.Id("datepick_in");
        By checkOutDateTxt = By.Id("datepick_out");
        By adultPerRoomDropDown = By.Id("adult_room");
        By childrenPerRoomDropDwon = By.Id("child_room");
        By searchBtn = By.Id("Submit");
        By resetBtn = By.Id("Reset");
        #endregion

        public void SearchHotel()
        {
            //driver.FindElement(locationDropDown).SendKeys("sydney");
            //driver.FindElement(hotelDropDown).SendKeys("Hotel Hervey");
            //driver.FindElement(roomTypeDropDown).SendKeys("Standard");
            //driver.FindElement(noOfRoomDropDown).SendKeys("2 - Two");
            //driver.FindElement(checkInDateTxt).SendKeys("00/07/2021");
            //driver.FindElement(checkOutDateTxt).SendKeys("09/07/2021");
            //driver.FindElement(adultPerRoomDropDown).SendKeys("2 - Two");
            //driver.FindElement(childrenPerRoomDropDwon).SendKeys("2 - Two");
            //driver.FindElement(searchBtn).Click();
            
            Step = Test.CreateNode("SearchPage");


            Write(locationDropDown,"sydney");
            Write(hotelDropDown,"Hotel Hervey");
            Write(roomTypeDropDown,"Standard");
            Write(noOfRoomDropDown,"2 - Two");
            Write(checkInDateTxt,"00/07/2021");
            Write(checkOutDateTxt,"09/07/2021");
            Write(adultPerRoomDropDown,"2 - Two");
            Write(childrenPerRoomDropDwon,"2 - Two");
            Click(searchBtn); 
        }      
    }
}   