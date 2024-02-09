using LaxStats.Models;
using LaxStats.Service.LeagueServ;
using LaxStats.Service.MatchServ;
using LaxStats.Service.PlayerServ;
using LaxStats.Service.TeamServ;
using Microsoft.AspNetCore.Mvc;

namespace LaxStats.Controllers
{
    public class LeagueController : Controller
    {
        private readonly ILogger<LeagueController> _logger;
        private readonly ILeagueService leagueService;

        public LeagueController(ILogger<LeagueController> logger, ILeagueService _leagueService)
        {
            _logger = logger;
            leagueService = _leagueService;
        }

        [HttpGet("Leagues")]
        public IActionResult LeaguesList()
        {
            var model = leagueService.GetLeagues();
            return View(model);
        }

        [HttpGet("{leagueName}/Teams")]
        public IActionResult TeamsInLeagueList(string leagueName, int leagueId)
        {
            var model = leagueService.GetTeamsFromLeague(leagueId);
            return View(model);
        }

    }
}
