using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MyWebApp.Controllers
{
    [Route("Search")]
    public class SearchController : Controller
    {
        [HttpGet("GetCategories")]
        public IActionResult GetCategories()
        {
            var categoriesDictionary = FileParser.GetCategoriesDictionaryFromFile();
            return Json(categoriesDictionary);
        }
    }
}
