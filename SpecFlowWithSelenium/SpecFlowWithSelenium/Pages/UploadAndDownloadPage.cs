using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SpecFlowWithSelenium.Drivers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SpecFlowWithSelenium.Pages
{
    public class UploadAndDownloadPage : BasePage
    {
        public static readonly string SeleniumDownloadPath = @"C:\Users\khyzhnychenko\Downloads\";
        public UploadAndDownloadPage(IWebDriver driver) : base(driver) { }

        //public WebDriverWait WaitDriver { get; set; }
        public IWebElement DownloadButton => Driver.FindElement(By.Id("downloadButton"));
        public IWebElement UploadButton => Driver.FindElement(By.Id("uploadFile"));
        public IWebElement UploadFilePath => Driver.FindElement(By.Id("uploadedFilePath"));


        public  bool CheckFileDownloaded(string filename)
        {
            var firstFile = Directory
                .GetFiles(SeleniumDownloadPath)
                .FirstOrDefault(fp => fp.Contains(filename));
            if (firstFile != default)
            {
                var fileInfo = new FileInfo(firstFile);
                var isFresh = DateTime.Now - fileInfo.LastWriteTime < TimeSpan.FromMinutes(3);
                File.Delete(firstFile);
                return isFresh;
            }
            return false;
        }

    }
}
