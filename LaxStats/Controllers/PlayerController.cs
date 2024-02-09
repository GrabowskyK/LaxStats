using LaxStats.Service.PlayerServ;
using LaxStats.Service.TeamServ;
using Microsoft.AspNetCore.Mvc;

namespace LaxStats.Controllers
{
    public class PlayerController : Controller
    {
        private readonly ILogger<PlayerController> _logger;
        private readonly IPlayerService playerService;

        public PlayerController(ILogger<PlayerController> logger, IPlayerService _playerService)
        {
            _logger = logger;
            playerService = _playerService;
        }

        [HttpGet("{leagueName}/{teamName}/Players")]
        public IActionResult PlayersInTeam(string leagueName, string teamName, int teamId) 
        { 
            var model = playerService.GetPlayersFromTeam(teamId);
            return View(model); 
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
