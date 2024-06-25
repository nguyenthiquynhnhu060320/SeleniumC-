using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Test case started");
        // create the reference for the browser
        IWebDriver driver = new ChromeDriver();
        // navigate to url
        driver.Navigate().GoToUrl("https://www.google.com/");
        Thread.Sleep(2000);
        // identify the google search text box
        IWebElement ele = driver.FindElement(By.Name("q"));
        // enter the value in the google search text box
        ele.SendKeys(" nhac tieng anh hay nhat moi thoi dai");
        Thread.Sleep(2000);
        // identify the gg search button
        IWebElement ele1 = driver.FindElement(By.Name("btnK"));
        // click on the google search button
        ele1.Click();
        Thread.Sleep(3000);
        // close the browser
        driver.Close();
        Console.WriteLine("Test case ended");
        
    }
}