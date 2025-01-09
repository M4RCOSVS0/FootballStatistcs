using Core.Service;
using Microsoft.AspNetCore.Mvc;

namespace FutstaticsWeb.Controllers
{
    public class JogoController : Controller
    {
        private readonly IJogoService jogoService;

        public JogoController(IJogoService jogoService)
        {
            this.jogoService = jogoService;
        }   

        public IActionResult Index()
        {
            var jogos = jogoService.GetAll().ToList();
            return View();
        }
    }
}
