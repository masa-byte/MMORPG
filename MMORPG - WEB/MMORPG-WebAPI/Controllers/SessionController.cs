
using Microsoft.AspNetCore.Mvc;
using MMORPG;

namespace OracleWebAPI 
{
    [ApiController]
    [Route("[controller]")]
    public class SessionController : ControllerBase
    {
        [HttpPost]
        [Route("SaveSession/{playerId}/{gold}/{points}/{startTime}/{endTime}")]
        public IActionResult SaveSession(int playerId, int gold, int points, DateTime startTime, DateTime endTime)
        {
            try
            {
                var session = DTOManager.SaveSession(playerId, gold, points, startTime, endTime);
                return Ok(session);
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}