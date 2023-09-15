namespace DelvisSoligt.Web.UITests.Home;

using FluentAssertions;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public sealed class HomeTests
{
    [Fact]
    public void HomeTest()
    {
        var url = "https://localhost:7104";
        var driver = new ChromeDriver();

        driver.Navigate().GoToUrl(url);

        var h1 = driver.FindElement(By.TagName("h1"));

        h1.Text.Should().BeEquivalentTo("The Ultimate .NET Core MVC Template");

        driver.Quit();
    }
}
