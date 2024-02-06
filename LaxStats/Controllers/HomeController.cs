using LaxStats.Models;
using LaxStats.Service.LeagueServ;
using LaxStats.Service.MatchServ;
using LaxStats.Service.PlayerServ;
using LaxStats.Service.TeamServ;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LaxStats.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPlayerService playerService;
        private readonly ITeamService teamService;
        private readonly IMatchService matchService;
        private readonly ILeagueService leagueService;

        public HomeController(ILogger<HomeController> logger, IPlayerService _playerService, ITeamService _teamService, IMatchService _matchService, ILeagueService _leagueService)
        {
            _logger = logger;
            playerService = _playerService;
            teamService = _teamService;
            matchService = _matchService;
            leagueService = _leagueService;
        }

        public IActionResult Index()
        {

            Team team = new Team()
            {
                Name = "Polska",
                ShortName = "PL",
                win = 0,
                lose = 0,
                draw = 0
            };

            Team team1 = new Team()
            {
                Name = "Czechy",
                ShortName = "CZ",
                win = 0,
                lose = 0,
                draw = 0
            };

            Player player = new Player()
            {
                Name = "Kamil",
                Surname = "Kowalski",
                Born = DateTime.Now,
                Team = team
            };

            Player player1 = new Player()
            {
                Name = "Adam",
                Surname = "Ścioch",
                Born = DateTime.Now,
                Team = team1
            };

            //Match match = new Match(team, team1);
            League league = new League("Winter Lax 2023");
            //var result = playerService.GetPlayers().ToList();
            //var result2 = teamService.GetTeams().ToList();
            leagueService.AddLeague(league);
            return View();
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