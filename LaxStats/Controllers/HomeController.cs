using LaxStats.Database;
using LaxStats.Models;
using LaxStats.Service.LeagueServ;
using LaxStats.Service.MatchServ;
using LaxStats.Service.PlayerServ;
using LaxStats.Service.TeamServ;
using Microsoft.AspNetCore.Mvc;
using NuGet.Packaging;
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
            //StaticObjects();
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

        //Func to insert into database
        public void StaticObjects()
        {
            //Teams
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

            Team team2 = new Team()
            {
                Name = "Niemcy",
                ShortName = "DE",
                win = 0,
                lose = 0,
                draw = 0
            };

            Team team3 = new Team()
            {
                Name = "Anglia",
                ShortName = "EN",
                win = 0,
                lose = 0,
                draw = 0
            };

            Team team4 = new Team()
            {
                Name = "Dania",
                ShortName = "DEN",
                win = 0,
                lose = 0,
                draw = 0
            };

            Team team5 = new Team()
            {
                Name = "Ukraina",
                ShortName = "UA",
                win = 0,
                lose = 0,
                draw = 0
            };
            List<Team> teamsList = new List<Team>();
            teamsList.AddRange(new List<Team> { team, team1, team2, team3, team4, team5});
            teamService.AddTeams(teamsList);


            // Players
            Player player1 = new Player()
            {
                Name = "Kamil",
                Surname = "Kowalski",
                Born = new DateTime(1990, 5, 15),
                Team = team
            };

            Player player2 = new Player()
            {
                Name = "Adam",
                Surname = "Ścioch",
                Born = new DateTime(1988, 10, 20),
                Team = team
            };

            Player player3 = new Player()
            {
                Name = "Jakub",
                Surname = "Nowak",
                Born = new DateTime(1995, 2, 28),
                Team = team
            };

            Player player4 = new Player()
            {
                Name = "Mateusz",
                Surname = "Wiśniewski",
                Born = new DateTime(1992, 7, 10),
                Team = team1
            };

            Player player5 = new Player()
            {
                Name = "Piotr",
                Surname = "Dąbrowski",
                Born = new DateTime(1991, 9, 5),
                Team = team1
            };

            Player player6 = new Player()
            {
                Name = "Michał",
                Surname = "Lewandowski",
                Born = new DateTime(1987, 3, 18),
                Team = team1
            };

            Player player7 = new Player()
            {
                Name = "Karol",
                Surname = "Wójcik",
                Born = new DateTime(1993, 6, 22),
                Team = team2
            };

            Player player8 = new Player()
            {
                Name = "Tomasz",
                Surname = "Kamiński",
                Born = new DateTime(1989, 8, 14),
                Team = team2
            };

            Player player9 = new Player()
            {
                Name = "Bartosz",
                Surname = "Kowalczyk",
                Born = new DateTime(1994, 4, 30),
                Team = team2
            };

            Player player10 = new Player()
            {
                Name = "Marek",
                Surname = "Zieliński",
                Born = new DateTime(1986, 11, 25),
                Team = team3
            };

            Player player11 = new Player()
            {
                Name = "Marcin",
                Surname = "Szymański",
                Born = new DateTime(1996, 1, 8),
                Team = team3
            };

            Player player12 = new Player()
            {
                Name = "Łukasz",
                Surname = "Nowak",
                Born = new DateTime(1990, 12, 3),
                Team = team3
            };

            Player player13 = new Player()
            {
                Name = "Jan",
                Surname = "Kowalski",
                Born = new DateTime(1985, 7, 17),
                Team = team4
            };

            Player player14 = new Player()
            {
                Name = "Anna",
                Surname = "Nowak",
                Born = new DateTime(1993, 11, 12),
                Team = team4
            };

            Player player15 = new Player()
            {
                Name = "Katarzyna",
                Surname = "Kowalczyk",
                Born = new DateTime(1988, 4, 5),
                Team = team4
            };

            Player player16 = new Player()
            {
                Name = "Paweł",
                Surname = "Lewandowski",
                Born = new DateTime(1991, 2, 9),
                Team = team5
            };

            Player player17 = new Player()
            {
                Name = "Ewa",
                Surname = "Wiśniewska",
                Born = new DateTime(1992, 3, 20),
                Team = team5
            };

            Player player18 = new Player()
            {
                Name = "Krzysztof",
                Surname = "Kowalski",
                Born = new DateTime(1987, 9, 10),
                Team = team5
            };

            Player player19 = new Player()
            {
                Name = "Alicja",
                Surname = "Nowak",
                Born = new DateTime(1994, 5, 15),
                Team = team
            };

            Player player20 = new Player()
            {
                Name = "Damian",
                Surname = "Kowalczyk",
                Born = new DateTime(1989, 12, 18),
                Team = team1
            };

            Player player21 = new Player()
            {
                Name = "Magdalena",
                Surname = "Zielińska",
                Born = new DateTime(1990, 7, 22),
                Team = team2
            };

            Player player22 = new Player()
            {
                Name = "Rafał",
                Surname = "Kamiński",
                Born = new DateTime(1988, 4, 5),
                Team = team3
            };

            Player player23 = new Player()
            {
                Name = "Aleksandra",
                Surname = "Nowak",
                Born = new DateTime(1993, 8, 30),
                Team = team4
            };

            Player player24 = new Player()
            {
                Name = "Wojciech",
                Surname = "Szymański",
                Born = new DateTime(1991, 1, 25),
                Team = team5
            };
            List<Player> playerList = new List<Player>();
            playerList.AddRange(new List<Player> { player1, player2, player3, player4, player5, player6, player7, player8, player9, player10, player11, player12, player13, player14, player15, player16, player17, player18, player19, player20, player21, player22, player23, player24 });
            playerService.AddPlayersList(playerList);


            // Leagues
            League league = new League("NBLL");
            League league1 = new League("FIDE");
            List<League> leagueList = new List<League>();
            leagueList.AddRange(new List<League> { league, league1 });
            leagueService.AddLeague(league);
            leagueService.AddLeague(league1);


            //TeamsInLeague
            TeamsInLeague teamsInLeague = new TeamsInLeague(team, league);
            TeamsInLeague teamsInLeague1 = new TeamsInLeague(team1, league);
            TeamsInLeague teamsInLeague2 = new TeamsInLeague(team2, league);
            TeamsInLeague teamsInLeague3 = new TeamsInLeague(team3, league1);
            TeamsInLeague teamsInLeague4 = new TeamsInLeague(team4, league1);
            TeamsInLeague teamsInLeague5 = new TeamsInLeague(team5, league1);
            List<TeamsInLeague> teamsInLeagueList = new List<TeamsInLeague>();
            teamsInLeagueList.AddRange(new List<TeamsInLeague> { teamsInLeague, teamsInLeague1, teamsInLeague2, teamsInLeague3, teamsInLeague4, teamsInLeague5 });
            teamService.AddTeamsToLeague(teamsInLeagueList);
        }
    }
}