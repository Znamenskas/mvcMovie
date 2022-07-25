using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class PrekesController : Controller
    {
        // 
        // GET: /Prekes/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string PavyzdinePreke()
        {
            return "Laimekite nauja televizoriu...";
        }
        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        public string RodytiPrekes(string pavadinimas, decimal kaina, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Prekes: {pavadinimas}, Kaina: { kaina}, ID: {ID}");
        }
    }
}