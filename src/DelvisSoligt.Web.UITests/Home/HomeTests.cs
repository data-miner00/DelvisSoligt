namespace DelvisSoligt.Web.UITests.Home;

using FluentAssertions;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public sealed class HomeTests
{
    public const string Url = "https://localhost:7104";

    [Fact]
    public void NavigateToHomePage_ExpectTitleFound()
    {
        var driver = new ChromeDriver();

        driver.Navigate().GoToUrl(Url);

        var h1 = driver.FindElement(By.TagName("h1"));

        h1.Text.Should().BeEquivalentTo("The Ultimate .NET Core MVC Template");

        driver.Quit();
    }

    [Fact]
    public void HomePage_ClickedOnSearchButton_ExpectPopupDialog()
    {
        var driver = new ChromeDriver();

        driver.Navigate().GoToUrl(Url);

        var searchButton = driver.FindElement(By.Id("input-button"));
        var popupOverlay = driver.FindElement(By.Id("popupOverlay"));
        var dialogItems = driver.FindElements(By.CssSelector("#popupOverlay ul li"));

        popupOverlay.Displayed.Should().BeFalse();
        searchButton.Click();
        popupOverlay.Displayed.Should().BeTrue();
        dialogItems.Count.Should().Be(6);

        driver.Quit();
    }
}
