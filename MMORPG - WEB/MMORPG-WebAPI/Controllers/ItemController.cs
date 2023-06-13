using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MMORPG;
using System;

namespace OracleWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        [HttpGet]
        [Route("ReturnAllItems")]
        public IActionResult ReturnAllItems()
        {
            try
            {
                var items = DTOManager.ReturnAllItems();
                return Ok(items);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("ReturnItem/{id}")]
        public IActionResult ReturnItem(int id)
        {
            try
            {
                var item = DTOManager.ReturnItem(id);
                if (item == null)
                {
                    return BadRequest("This item does not exist");
                }
                return Ok(item);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("SaveItem")]
        public IActionResult SaveItem([FromBody] ItemView item)
        {
            try
            {
                var items = DTOManager.SaveItem(item);
                return Ok(items);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete]
        [Route("RemoveItem/{id}")]
        public IActionResult RemoveItem(int id)
        {
            try
            {
                var itemToRemove = DTOManager.RemoveItem(id);
                return Ok(itemToRemove);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        [Route("UpdateItem")]
        public IActionResult UpdateItem([FromBody] ItemView item)
        {
            try
            {
                var itemToUpdate = DTOManager.UpdateItem(item);
                return Ok(itemToUpdate);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}