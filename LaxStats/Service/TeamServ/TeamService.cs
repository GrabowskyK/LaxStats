using LaxStats.Database;
using LaxStats.Models;
using Microsoft.EntityFrameworkCore;

namespace LaxStats.Service.TeamServ
{
    public class TeamService : ITeamService
    {
        private readonly DatabaseContext databaseContext;

        public TeamService(DatabaseContext _databaseContext)
        {
            databaseContext = _databaseContext;
        }

        public void AddTeam(Team team)
        {
            databaseContext.Add(team);
            databaseContext.SaveChanges();
        }

        public IEnumerable<Team> GetTeams() => databaseContext.Teams;

        public void AddTeams(List<Team> teams)
        {
            databaseContext.Teams.AddRange(teams);
            databaseContext.SaveChanges();
        }


        //TO już xd co tu robi XD 
        // Only for static add to database
        public void AddTeamsToLeague(List<TeamsInLeague> teams)
        {
            databaseContext.TeamsInLeagues.AddRange(teams);
            databaseContext.SaveChanges();
        }

    }
}
