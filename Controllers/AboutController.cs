using MVCWebProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MVCWebProject.Controllers
{   
  
    public class AboutController : Controller
    {

        private static List<ClientViewModel> clients = new List<ClientViewModel>();

        public IActionResult Index()
        {
           
           return View(clients);
        }

        public IActionResult Contact()
        {

            var ClientInfo = new ClientViewModel();
            return View(ClientInfo);//binding the data
        }

        public IActionResult CreatClients(ClientViewModel clientviewmodel)
        {
            clients.Add(clientviewmodel);
            return RedirectToAction(nameof(Index));
        }
       
        public IActionResult Services()
        {
            return View();
        }

       
    }
}
