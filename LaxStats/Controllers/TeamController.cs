using LaxStats.Service.LeagueServ;
using LaxStats.Service.MatchServ;
using LaxStats.Service.PlayerServ;
using LaxStats.Service.TeamServ;
using Microsoft.AspNetCore.Mvc;

namespace LaxStats.Controllers
{
    public class TeamController : Controller
    {
        private readonly ILogger<TeamController> _logger;
        private readonly ITeamService teamService;

        public TeamController(ILogger<TeamController> logger, ITeamService _teamService)
        {
            _logger = logger;
            teamService = _teamService;
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
