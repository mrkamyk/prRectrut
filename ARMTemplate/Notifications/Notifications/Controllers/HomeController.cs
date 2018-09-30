using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Notifications.Models;

namespace Notifications.Controllers
{
    public class HomeController : Controller
    {
        private static readonly HttpClient client = new HttpClient();
        private readonly IConfiguration configuration;

        public HomeController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public IActionResult Index()
        {
            var notifications = GetNotifications();
            return View(notifications);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private IEnumerable<Notification> GetNotifications()
        {
            client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json; charset=utf-8");
            var notificationUrl = configuration["NotificationUrl"];
            var apiKey = configuration["WarsawApiKey"];
            var requestUrl = $"{notificationUrl}&apikey={apiKey}";

            var requestResult = client.GetStringAsync(requestUrl).Result;
            try
            {
                var response = JsonConvert.DeserializeObject<ServiceResponse>(requestResult);

                return response?.Result?.Result?.Notifications.OrderByDescending(n => n.CreateDate);
            } catch (JsonSerializationException)
            {
                var error = JsonConvert.DeserializeObject<RequestError>(requestResult);
                throw new Exception(error.Error);
            }

        }
    }
}
