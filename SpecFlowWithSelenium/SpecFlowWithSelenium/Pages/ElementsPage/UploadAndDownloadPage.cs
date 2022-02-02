using OpenQA.Selenium;
using System.IO;

namespace SpecFlowWithSelenium.Pages
{
    public class UploadAndDownloadPage : BasePage
    {

        public UploadAndDownloadPage(IWebDriver driver) : base(driver) { }

        public IWebElement DownloadButton => Driver.FindElement(By.Id("downloadButton"));
        public IWebElement UploadButton => Driver.FindElement(By.Id("uploadFile"));
        public IWebElement UploadFilePath => Driver.FindElement(By.Id("uploadedFilePath"));

        readonly string currentFile = string.Empty;


        public bool CheckFile(string nameFile)
        {
            var currentFile = @"C:\Users\khyzhnychenko\Downloads\" + nameFile + "";
            if (File.Exists(currentFile)) 
            {
                return true; 
            }
            else
            {
                return false; 
            }
        } 

        public void DeleteFilesAndDirectory()
        {
            if (Directory.Exists(@"C:\Users\khyzhnychenko\Downloads\NewFileTest"))
            {
                Directory.Delete(@"C:\Users\khyzhnychenko\Downloads\NewFileTest", true);

            }
            if (File.Exists(currentFile))
            {
                File.Delete(currentFile);
            }
        }
    }
}
