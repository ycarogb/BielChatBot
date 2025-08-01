using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BielChatBot.Models;
using BielChatBot.Models.Entities.Dtos;
using BielChatBot.Models.Services.Interfaces;

namespace BielChatBot.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IOutputGenerator _outputGenerator;

    public HomeController(ILogger<HomeController> logger, IOutputGenerator outputGenerator)
    {
        _logger = logger;
        _outputGenerator = outputGenerator;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    [HttpPost]
    public async Task<IActionResult> GenerateOutput([Bind("Value")] InputDto input)
    {
        var chatResponse = await _outputGenerator.GenerateAsync(input.Value);

        return View(chatResponse);
    }
}