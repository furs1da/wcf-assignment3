using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WCF3_Client.Models;

namespace WCF3_Client.Controllers
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
        [HttpGet("GetComputer/{uuid}")]
        public ComputerReference.Computer GetComputer(string uuid)
        {
            ComputerReference.ComputerServiceClient client = new ComputerReference.ComputerServiceClient();
            ComputerReference.Computer computer = new ComputerReference.Computer();
            computer = client.GetComputer(uuid);

            return computer;
        }

        [HttpGet("GetAllComputers")]
        public List<ComputerReference.Computer> GetAllComputers()
        {
            ComputerReference.ComputerServiceClient client = new ComputerReference.ComputerServiceClient();
            List<ComputerReference.Computer> computerList = new List<ComputerReference.Computer>();
            computerList = client.GetAllComputers();
            return computerList;
        }

        [HttpPost("AddComputer")]
        public string AddComputer(ComputerReference.Computer computer)
        {
            ComputerReference.ComputerServiceClient client = new ComputerReference.ComputerServiceClient();
            string result = "";
            result = client.AddComputer(computer);

            return result;
        }

        [HttpPost("UpdateComputer")]
        public string UpdateComputer(ComputerReference.Computer computer)
        {
            ComputerReference.ComputerServiceClient client = new ComputerReference.ComputerServiceClient();
            string result = "";
            result = client.UpdateComputer(computer);

            return result;
        }

        [HttpGet("DeleteComputer/{uuid}")]
        public string UpdateComputer(string uuid)
        {
            ComputerReference.ComputerServiceClient client = new ComputerReference.ComputerServiceClient();
            string result = "";
            result = client.DeleteComputer(uuid);

            return result;
        }


        public IActionResult AllComputers()
        {
            ComputerReference.ComputerServiceClient client = new ComputerReference.ComputerServiceClient();
            List<ComputerReference.Computer> computerList = new List<ComputerReference.Computer>();
            computerList = client.GetAllComputers();
            ViewBag.Brands = client.GetAllBrands();
            ViewBag.OS = client.GetAllOses();
            return View(computerList);
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