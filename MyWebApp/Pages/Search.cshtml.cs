using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyWebApp;
using System.Collections.Generic;

namespace MyWebApp.Pages
{
    public class SearchModel : PageModel
    {
        public void OnGet()
        {
        }

        public JsonResult OnGetGetCategories()
        {
            var categoriesDictionary = FileParser.GetCategoriesDictionaryFromFile();
            return new JsonResult(categoriesDictionary);
        }
    }
}