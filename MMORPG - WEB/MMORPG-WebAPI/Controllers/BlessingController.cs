using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MMORPG;
using System;

namespace OracleWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlessingController : ControllerBase
    {
        [HttpGet]
        [Route("ReturnAllBlessings")]
        public IActionResult ReturnAllBlessings()
        {
            try
            {
                var blessings = DTOManager.ReturnAllBlessings();
                return Ok(blessings);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("ReturnBlessing/{id}")]
        public IActionResult ReturnBlessing(int id)
        {
            try
            {
                var blessing = DTOManager.ReturnBlessing(id);
                if (blessing == null)
                {
                    return BadRequest("This blessing does not exist");
                }
                return Ok(blessing);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete]
        [Route("RemoveBlessing/{id}")]
        public IActionResult RemoveBlessing(int id)
        {
            try
            {
                var blessingRemoved = DTOManager.RemoveBlessing(id);
                return Ok(blessingRemoved);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("SaveBlessing")]
        public IActionResult SaveBlessing([FromBody] BlessingView blessing)
        {
            try
            {
                var blessingSaved = DTOManager.SaveBlessing(blessing);
                return Ok(blessingSaved);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        [Route("UpdateBlessing")]
        public IActionResult UpdateBlessing([FromBody] BlessingView blessing)
        {
            try
            {
                var blessingUpdated = DTOManager.UpdateBlessing(blessing);
                return Ok(blessingUpdated);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("AddBlessingToPriest/{blessingId}/{characterId}")]
        public IActionResult AddBlessingToPriest(int blessingId, int characterId)
        {
            try
            {
                var blessingAdded = DTOManager.AddBlessingToPriest(blessingId, characterId);
                return Ok(blessingAdded);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}