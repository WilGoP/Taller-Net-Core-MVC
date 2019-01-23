using Microsoft.AspNetCore.Mvc;

namespace ClienteMVCVacio.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hola desde MVC";
        }

        public string Saludar(string nombre)
        {
            return "Hola Sr. : " + nombre;
        }
    }
}