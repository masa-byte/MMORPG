using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MMORPG;
using System;

namespace OracleWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransitController : ControllerBase
    {
        [HttpGet]
        [Route("ReturnTransit/{id}")]
        public IActionResult ReturnTransit(int id)
        {
            try
            {
                var transit = DTOManager.ReturnTransit(id);
                if (transit == null)
                {
                    return BadRequest("This transit does not exist");
                }
                return Ok(new {transit.Id, transit.EnemiesDefeated, transit.Successful});
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("PlayerPlaysGame/{playerId}/{difficulty}/{trackId}")]
        public IActionResult PlayerPlaysGame(int playerId, string difficulty, int trackId)
        {
            try
            {
                var messageAndTransit = DTOManager.PlayGame(playerId, difficulty, trackId);
                return Ok(new 
                {
                    Message = messageAndTransit.Item1,
                    Transit = messageAndTransit.Item2 
                });
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}