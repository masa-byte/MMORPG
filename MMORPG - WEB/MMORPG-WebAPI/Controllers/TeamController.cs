using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MMORPG;
using System;

namespace OracleWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeamController : ControllerBase
    {
        [HttpGet]
        [Route("ReturnPlayersFromTeam/{teamName}")]
        public IActionResult ReturnPlayersFromTeam(string teamName)
        {
            try
            {
                var players = DTOManager.ReturnAllPlayersFromTeam(teamName.ToUpper());
                return Ok(players);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("ReturnTeamsRanked")]
        public IActionResult ReturnTeamsRanked()
        {
            try
            {
                var teams = DTOManager.ReturnAllTeamsRanked();
                return Ok(teams.Select(t =>
                new
                {
                    t.Id,
                    t.Name,
                    t.BonusPoints,
                    t.Placement
                }));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("ReturnAllJoinableTeams")]
        public IActionResult ReturnAllJoinableTeams()
        {
            try
            {
                var teams = DTOManager.ReturnAllJoinableTeams();
                return Ok(teams);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("SaveTeam")]
        public IActionResult SaveTeam([FromBody] CompactTeamView teamView)
        {
            try
            {
                var team = DTOManager.SaveTeam(teamView);
                return Ok(team);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("ReturnAllFightableTeams/{teamId}")]
        public IActionResult ReturnAllFightableTeams(int teamId)
        {
            try
            {
                var teams = DTOManager.ReturnAllFightableTeams(teamId);
                return Ok(teams);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("ReturnTeam/{teamId}")]
        public IActionResult ReturnTeam(int teamId)
        {
            try
            {
                var team = DTOManager.ReturnTeam(teamId);
                return Ok(team);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}