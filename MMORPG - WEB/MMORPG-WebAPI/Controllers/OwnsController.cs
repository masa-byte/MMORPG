
using Microsoft.AspNetCore.Mvc;
using MMORPG;

namespace OracleWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OwnsController : ControllerBase
    {
        [HttpPost]
        [Route("PlayerFindsItems/{playerId}/{numberOfItems}")]
        public IActionResult PlayerFindsItems(int playerId, int numberOfItems)
        {
            try
            {
                var items = DTOManager.PlayerFindsItems(playerId, numberOfItems);
                return Ok(items);
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}