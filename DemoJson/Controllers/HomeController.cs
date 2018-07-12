using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DemoJson.Models;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;

namespace DemoJson.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            using (var f = System.IO.File.OpenRead(@"data\v1.json"))
            using (var s = new StreamReader(f))
            using (var js = new JsonTextReader(s)) {
                var json = JToken.ReadFrom(js);
                var paths = json["paths"] as JObject;
                var props = paths.Properties();

                var sb = new StringBuilder();
                var cnt = 0;
                foreach (var p in props)
                {
                    var v = p.Value as JObject;
                    sb.AppendFormat("\"{0}\",\"{1}\"", 
                    p.Name.Replace("/thaiwater30/api_service?mid=","").Trim(), 
                    v["get"]["description"].ToString().Trim());
                    sb.AppendLine();

                    // if (++cnt > 9)
                    // {
                    //     break;
                    // }
                }
                return Content(sb.ToString());
            }
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
    }
}
