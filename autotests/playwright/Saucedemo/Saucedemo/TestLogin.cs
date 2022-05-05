using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

namespace Saucedemo
{
    [Parallelizable(ParallelScope.Self)]
    public class Tests: PageTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task ShouldLogin()
        {
            await using var browser = await Playwright.Firefox.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,
                SlowMo = 50,
            }) ;
            var context = await browser.NewContextAsync();
            // Open new page
            var page = await context.NewPageAsync();
            // Go to https://www.saucedemo.com/
            await page.GotoAsync("https://www.saucedemo.com/");
            // Click [data-test="username"]
            await page.Locator("[data-test=\"username\"]").ClickAsync();
            // Fill [data-test="username"]
            await page.Locator("[data-test=\"username\"]").FillAsync("standard_user");
            // Click [data-test="password"]
            await page.Locator("[data-test=\"password\"]").ClickAsync();
            // Fill [data-test="password"]
            await page.Locator("[data-test=\"password\"]").FillAsync("secret_sauce");
            // Click [data-test="login-button"]
            await page.Locator("[data-test=\"login-button\"]").ClickAsync();
             Assert.AreEqual("https://www.saucedemo.com/inventory.html", page.Url);
        }

        [Test]
        public async Task ShouldNotLogin()
        {
            await using var browser = await Playwright.Firefox.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,
                SlowMo = 50,
            });
            var context = await browser.NewContextAsync();
            // Open new page
            var page = await context.NewPageAsync();
            // Go to https://www.saucedemo.com/
            await page.GotoAsync("https://www.saucedemo.com/");
            // Click [data-test="username"]
            await page.Locator("[data-test=\"username\"]").ClickAsync();
            // Fill [data-test="username"]
            await page.Locator("[data-test=\"username\"]").FillAsync("locked_out_user");
            // Click [data-test="password"]
            await page.Locator("[data-test=\"password\"]").ClickAsync();
            // Fill [data-test="password"]
            await page.Locator("[data-test=\"password\"]").FillAsync("secret_sauce");
            // Click [data-test="login-button"]
            await page.Locator("[data-test=\"login-button\"]").ClickAsync();
            var expectedText = await page.Locator("[data-test=\"error\"]").TextContentAsync();
            Assert.AreEqual("Epic sadface: Sorry, this user has been locked out.", expectedText);
            //Assert.AreEqual("https://www.saucedemo.com/inventory.html", page.Url);
        }
    }
}