
using Microsoft.AspNetCore.Mvc;
using MMORPG;

namespace OracleWebAPI
{
    [ApiController]
    [Route("[controller]")]
    public class FightsController : ControllerBase
    {
        [HttpPost]
        [Route("ScheduleTeamFight/{team1Id}/{team2Id}/{bonus}/{timeHeld}")]
        public IActionResult ScheduleTeamFight(int team1Id, int team2Id, double bonus, DateTime timeHeld)
        {
            try
            {
                var fight = DTOManager.ScheduleTeamFight(team1Id, team2Id, bonus, timeHeld);
                return Ok(fight);
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        [Route("ExecuteAllPendingTeamFights")]
        public IActionResult ExecuteAllPendingTeamFights()
        {
            try
            {
                var numberOfFights = DTOManager.ExecuteAllPendingTeamFights();
                return Ok($"All pending fights executed, count: {numberOfFights}");
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}