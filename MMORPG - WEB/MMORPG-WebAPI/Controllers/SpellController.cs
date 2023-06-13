using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MMORPG;
using System;

namespace OracleWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SpellController : ControllerBase
    {
        [HttpGet]
        [Route("ReturnAllSpells")]
        public IActionResult ReturnAllSpells()
        {
            try
            {
                return Ok(DTOManager.ReturnAllSpells());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("ReturnSpell/{id}")]
        public IActionResult ReturnSpell(int id)
        {
            try
            {
                var spell = DTOManager.ReturnSpell(id);
                if (spell == null)
                {
                    return BadRequest("This spell does not exist");
                }
                return Ok(spell);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("SaveSpell")]
        public IActionResult SaveSpell([FromBody] SpellView Spell)
        {
            try
            {
                var spellToSave = DTOManager.SaveSpell(Spell);
                return Ok(spellToSave);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete]
        [Route("RemoveSpell/{id}")]
        public IActionResult RemoveSpell(int id)
        {
            try
            {
                var spellToDelete = DTOManager.RemoveSpell(id);
                return Ok(spellToDelete);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        [Route("UpdateSpell")]
        public IActionResult UpdateSpell([FromBody] SpellView Spell)
        {
            try
            {
                var spellToUpdate = DTOManager.UpdateSpell(Spell);
                return Ok(spellToUpdate);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("AddSpellToWizard/{spellId}/{playerId}")]
        public IActionResult AddSpellToWizard(int spellId, int playerId)
        {
            try
            {
                var spellAdded = DTOManager.AddSpellToWizard(spellId, playerId);
                return Ok(spellAdded);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}