using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowWithSelenium.Pages.WidgetsPage
{
    public class SliderPage : BasePage
    {
        public SliderPage(IWebDriver driver) : base(driver) { }

        public IWebElement Slider => Driver.FindElement(By.XPath("//*[@class='range-slider range-slider--primary']"));
        public IWebElement SliderValue => Driver.FindElement(By.XPath("//*[@id='sliderValue']"));

        public void MoveSlider()
        {
            var action = new Actions(Driver);
            action.ClickAndHold(Slider);
            action.MoveByOffset(100, 0).Click();
            action.Release().Build().Perform();
        }
    }
}
