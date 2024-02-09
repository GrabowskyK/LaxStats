using LaxStats.Service.LeagueServ;
using LaxStats.Service.MatchServ;
using LaxStats.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace LaxStats.Controllers
{
    public class MatchController : Controller
    {
        private readonly ILogger<MatchController> _logger;
        private readonly IMatchService matchService;

        public MatchController(ILogger<MatchController> logger, IMatchService _matchService)
        {
            _logger = logger;
            matchService = _matchService;
        }

        [HttpGet("{leagueName}/Matches")]
        public IActionResult MatchesInLeague(string leagueName, int leagueId)
        {
            var model = matchService.GetMatches(leagueId);
            var xd = matchService.GetSingleMatch(10);
            return View(model);
        }

        [HttpGet("{leagueName}/Matches/{matchId}")]
        public IActionResult InfoAboutMatch(string leagueName, int leagueId, int matchId)
        {
            matchService.GetSingleMatch(matchId);
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
