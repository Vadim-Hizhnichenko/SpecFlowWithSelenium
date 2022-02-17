using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowWithSelenium.Pages.WidgetsPage
{
    public class DatePicker : BasePage
    {
        public DatePicker(IWebDriver driver) : base(driver) { }

        public IWebElement SelectDataInput => Driver.FindElement(By.XPath("//*[@id='datePickerMonthYearInput']"));

        public IWebElement SelectDateAndTimeInput => Driver.FindElement(By.XPath("//*[@id='dateAndTimePickerInput']"));

        public void SelectDate(string date)
        {
            SelectDataInput.SendKeys(date);
        }

        public void SelectDateAndTime(string dateAndTime)
        {
            SelectDateAndTimeInput.SendKeys(dateAndTime);
        }
    }
}
