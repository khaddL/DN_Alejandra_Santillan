using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Events;
using System;
using System.Diagnostics;
using System.IO;

namespace GymManager.Web.Controllers
{
    public class MembersController : Controller
    {

        private readonly ILogger<MembersController> _logger;
        readonly IDiagnosticContext _diagnosticContext;

        public MembersController(ILogger<MembersController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            
            _logger.LogInformation("Log message generated with INFORMATION severity level.");

            _logger.LogWarning("Log message generated with WARNING severity level.");

            _logger.LogError("Log message generated with ERROR severity level.");

            _logger.LogCritical("Log message log generated with CRITICAL severity level.");

            Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
            .MinimumLevel.Override("Microsoft.AspNetCore", LogEventLevel.Warning)
            .WriteTo.File("C:\\Logs\\Demo.txt", rollingInterval: RollingInterval.Day).CreateLogger();

            return View();
        }

    }
    
}
