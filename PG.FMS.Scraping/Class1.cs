using Microsoft.Playwright;

namespace PG.FMS.Scraping;

public class HhLaSailingList
{
    public async Task ExecuteAsync()
    {
        using var playwright = await Playwright.CreateAsync();
        await using var browser = await playwright.Chromium.LaunchAsync();
        var page = await browser.NewPageAsync();

        await page.GotoAsync("https://coast.hhla.de/report?id=Standard-Report-Segelliste");
    }
}