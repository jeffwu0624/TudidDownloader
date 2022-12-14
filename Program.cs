using Microsoft.Playwright;

var playwright = await Playwright.CreateAsync();

var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions()
{
    Headless = false, 
    SlowMo = 10000
});

var page = await browser.NewPageAsync();

await page.GotoAsync("https://udid.fda.gov.tw/ManageEquipmentSearch.aspx");

await page.Locator("[popup_open='popup-1']").ClickAsync();
await page.Locator("#ContentPlaceHolder1_Button5").ClickAsync();
