using Assignment_4_WebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;

namespace Assignment_4_WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Home()
        {
            return View("Index");
        }
        /// api call
        HttpClient httpClient;

        static string BASE_URL = "https://api.usa.gov/crime/fbi/sapi/";
        static string API_KEY = "g1mjvzQVDzMmHo0UQgfjLMgV4pzyazleokQOM5XS";
        /*Using general api for explore page*/
        public IActionResult Explore()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Add("X-Api-Key", API_KEY);
            httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            string FBI_DATA_API_PATH = BASE_URL + "api/participation/national?";
            string resultsData = "";

            Results results = null;

            httpClient.BaseAddress = new Uri(FBI_DATA_API_PATH);

            try
            {
                HttpResponseMessage response = httpClient.GetAsync(FBI_DATA_API_PATH).GetAwaiter().GetResult();

                if (response.IsSuccessStatusCode)
                {
                    resultsData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                }

                if (!resultsData.Equals(""))
                {
                    // JsonConvert is part of the NewtonSoft.Json Nuget package
                    results = JsonConvert.DeserializeObject<Results>(resultsData);
                }
            }
            catch (Exception e)
            {
                // This is a useful place to insert a breakpoint and observe the error message
                Console.WriteLine(e.Message);
            }

            return View(results);
            //return View("Explore");
        }
        public IActionResult Report()
        {
            return View("Report");
        }
        public IActionResult AboutUs()
        {
            return View("AboutUs");
        }
        /*Using Homicide api for HomicideData page*/
        public IActionResult HomicideData()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Add("X-Api-Key", API_KEY);
            httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            string FBI_DATA_API_PATH = BASE_URL + "api/participation/national?";
            string resultsData = "";

            Results results = null;

            httpClient.BaseAddress = new Uri(FBI_DATA_API_PATH);

            try
            {
                HttpResponseMessage response = httpClient.GetAsync(FBI_DATA_API_PATH).GetAwaiter().GetResult();

                if (response.IsSuccessStatusCode)
                {
                    resultsData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                }

                if (!resultsData.Equals(""))
                {
     
                    results = JsonConvert.DeserializeObject<Results>(resultsData);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return View(results);
        }
        /*Using Property api for PropertyData page*/
        public IActionResult PropertyData()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Add("X-Api-Key", API_KEY);
            httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            string FBI_DATA_API_PATH = BASE_URL + "api/participation/national?";
            string resultsData = "";

            Results results = null;

            httpClient.BaseAddress = new Uri(FBI_DATA_API_PATH);

            try
            {
                HttpResponseMessage response = httpClient.GetAsync(FBI_DATA_API_PATH).GetAwaiter().GetResult();

                if (response.IsSuccessStatusCode)
                {
                    resultsData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                }

                if (!resultsData.Equals(""))
                {

                    results = JsonConvert.DeserializeObject<Results>(resultsData);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return View(results);
            //return View("page");
        }
        /*Using Arrest api for ArrestData page*/
        public IActionResult ArrestData()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Add("X-Api-Key", API_KEY);
            httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            string FBI_DATA_API_PATH = BASE_URL + "api/participation/national?";
            string resultsData = "";

            Results results = null;

            httpClient.BaseAddress = new Uri(FBI_DATA_API_PATH);

            try
            {
                HttpResponseMessage response = httpClient.GetAsync(FBI_DATA_API_PATH).GetAwaiter().GetResult();

                if (response.IsSuccessStatusCode)
                {
                    resultsData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                }

                if (!resultsData.Equals(""))
                {

                    results = JsonConvert.DeserializeObject<Results>(resultsData);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return View(results);
            //return View("page");
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
