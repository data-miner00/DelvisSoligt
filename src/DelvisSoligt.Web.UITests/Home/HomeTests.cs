namespace DelvisSoligt.Web.UITests.Home;

using FluentAssertions;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public sealed class HomeTests : IDisposable
{
    public const string Url = "https://localhost:7104";

    public readonly IWebDriver driver;

    public HomeTests()
    {
        this.driver = new ChromeDriver();
        this.driver.Navigate().GoToUrl(Url);
    }

    [Fact]
    public void NavigateToHomePage_ExpectTitleFound()
    {
        var h1 = this.driver.FindElement(By.TagName("h1"));
        h1.Text.Should().BeEquivalentTo("The Ultimate .NET Core MVC Template");
    }

    [Theory]
    [InlineData(1, "https://localhost:7104/Home/Showcase")]
    [InlineData(2, "https://localhost:7104/Home/Docs")]
    public void HomePage_ClickedOnHeaderLink_NavigateToDestination(int linkIndex, string expectedUrl)
    {
        var link = this.driver.FindElement(By.CssSelector($"nav ul li:nth-child({linkIndex})"));
        link.Click();
        this.driver.Url.Should().Be(expectedUrl);
    }

    [Fact]
    public void HomePage_ClickedOnSearchButton_ExpectPopupDialog()
    {
        var searchButton = this.driver.FindElement(By.Id("input-button"));
        var popupOverlay = this.driver.FindElement(By.Id("popupOverlay"));
        var dialogItems = this.driver.FindElements(By.CssSelector("#popupOverlay ul li"));

        popupOverlay.Displayed.Should().BeFalse();
        searchButton.Click();
        popupOverlay.Displayed.Should().BeTrue();
        dialogItems.Count.Should().Be(6);
    }

    public void Dispose()
    {
        this.driver.Quit();
    }
}
