using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MMORPG;
using System;

namespace OracleWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TrackController : ControllerBase
    {
        [HttpGet]
        [Route("ReturnAllTracks")]
        public IActionResult ReturnAllTracks()
        {
            try
            {
                return Ok(DTOManager.ReturnAllTracks());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("ReturnTrack/{id}")]
        public IActionResult ReturnTrack(int id)
        {
            try
            {
                var track = DTOManager.ReturnTrack(id);
                if (track == null)
                {
                    return BadRequest("This track does not exist");
                }
                return Ok(track);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("SaveTrack")]
        public IActionResult SaveTrack([FromBody] TrackView track)
        {
            try
            {
                var trackToSave = DTOManager.SaveTrack(track);
                return Ok(trackToSave);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete]
        [Route("RemoveTrack/{id}")]
        public IActionResult RemoveTrack(int id)
        {
            try
            {
                var trackToDelete = DTOManager.RemoveTrack(id);
                return Ok(trackToDelete);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        [Route("UpdateTrack")]
        public IActionResult UpdateTrack([FromBody] TrackView track)
        {
            try
            {
                var trackToUpdate = DTOManager.UpdateTrack(track);
                return Ok(trackToUpdate);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}