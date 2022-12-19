using Microsoft.Playwright;

var playwright = await Playwright.CreateAsync();

var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions()
{
    Headless = false, 
    //SlowMo = 10000
});

var page = await browser.NewPageAsync();

// add timeout
page.SetDefaultTimeout(3000000);

await page.GotoAsync("https://udid.fda.gov.tw/ManageEquipmentSearch.aspx");
var download = await page.RunAndWaitForDownloadAsync(async () =>
{
    await page.Locator("[popup_open='popup-1']").ClickAsync();
    await page.Locator("#ContentPlaceHolder1_Button5").ClickAsync();
});

Console.WriteLine(await download.PathAsync());
//await page.Locator("[popup_open='popup-1']").ClickAsync();
//await page.Locator("#ContentPlaceHolder1_Button5").ClickAsync();
