using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace MovieStore.Controllers
{
    public class DownloadController : Controller
    {
        private readonly IHostingEnvironment host;
        public DownloadController(IHostingEnvironment h)
        {
            host = h;
        }
        public IActionResult Index(IFormFile Photo)
        {
            if(Photo != null)
            {
                var path = Path.Combine(host.WebRootPath, Path.GetFileName(Photo.FileName));
                Photo.CopyTo(new FileStream(path,FileMode.Create));
                ViewData["fileLocation"] = "/" + Path.GetFileName(Photo.FileName);
            }
            return View();
        }
    }
}