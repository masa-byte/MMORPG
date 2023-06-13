
using Microsoft.AspNetCore.Mvc;
using MMORPG;
using MMORPG.Entities;

namespace OracleWebAPI
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        [HttpGet]
        [Route("GetCharacterForPlayer/{playerId}/{getMainCharacter}")]
        public IActionResult GetCharacterForPlayer(int playerId, bool getMainCharacter)
        {
            try
            {
                var character = DTOManager.ReturnCharacterForPlayer(playerId, getMainCharacter);
                if (character == null)
                    return BadRequest("Character not found");
                return Ok(character);
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("SaveThief/{playerId}")]
        public IActionResult SaveThief([FromBody] SaveThiefView thief, int playerId)
        {
            try
            {
                Thief thiefToSave = new Thief
                {
                    FatigueLevel = thief.FatigueLevel,
                    HealthLevel = thief.HealthLevel,
                    Experience = thief.Experience,
                    Gold = thief.Gold,
                    Race = thief.Race,
                    EnergyLevel = thief.EnergyLevel,
                    WeaponType = thief.WeaponType,
                    HidingSkill = thief.HidingSkill,
                    Assistant = thief.Assistant,
                    AssistantName = thief.AssistantName,
                    AssistantBonus = thief.AssistantBonus,
                    NoiseLevel = thief.NoiseLevel,
                    TrapRemoval = thief.TrapRemoval,
                };
                var character = DTOManager.SaveCharacter(thiefToSave, playerId);
                return Ok(character);
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("SaveFighter/{playerId}")]
        public IActionResult SaveFighter([FromBody] SaveFighterView fighter, int playerId)
        {
            try
            {
                Fighter fighterToSave = new Fighter
                {
                    FatigueLevel = fighter.FatigueLevel,
                    HealthLevel = fighter.HealthLevel,
                    Experience = fighter.Experience,
                    Gold = fighter.Gold,
                    Race = fighter.Race,
                    EnergyLevel = fighter.EnergyLevel,
                    WeaponType = fighter.WeaponType,
                    HidingSkill = fighter.HidingSkill,
                    Assistant = fighter.Assistant,
                    AssistantName = fighter.AssistantName,
                    AssistantBonus = fighter.AssistantBonus,
                    Shield = fighter.Shield,
                    TwohandedWeapon = fighter.TwohandedWeapon,
                };
                var character = DTOManager.SaveCharacter(fighterToSave, playerId);
                return Ok(character);
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("SavePriest/{playerId}")]
        public IActionResult SavePriest([FromBody] SavePriestView priest, int playerId)
        {
            try
            {
                Priest priestToSave = new Priest
                {
                    FatigueLevel = priest.FatigueLevel,
                    HealthLevel = priest.HealthLevel,
                    Experience = priest.Experience,
                    Gold = priest.Gold,
                    Race = priest.Race,
                    EnergyLevel = priest.EnergyLevel,
                    WeaponType = priest.WeaponType,
                    HidingSkill = priest.HidingSkill,
                    Assistant = priest.Assistant,
                    AssistantName = priest.AssistantName,
                    AssistantBonus = priest.AssistantBonus,
                    Religion = priest.Religion,
                    Heals = priest.Heals,
                };
                var character = DTOManager.SaveCharacter(priestToSave, playerId);
                return Ok(character);
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("SaveArcher/{playerId}")]
        public IActionResult SaveArcher([FromBody] SaveArcherView archer, int playerId)
        {
            try
            {
                Archer archerToSave = new Archer
                {
                    FatigueLevel = archer.FatigueLevel,
                    HealthLevel = archer.HealthLevel,
                    Experience = archer.Experience,
                    Gold = archer.Gold,
                    Race = archer.Race,
                    EnergyLevel = archer.EnergyLevel,
                    WeaponType = archer.WeaponType,
                    HidingSkill = archer.HidingSkill,
                    Assistant = archer.Assistant,
                    AssistantName = archer.AssistantName,
                    AssistantBonus = archer.AssistantBonus,
                    BowCrossbow = archer.BowCrossbow,
                };
                var character = DTOManager.SaveCharacter(archerToSave, playerId);
                return Ok(character);
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("SaveWizard/{playerId}")]
        public IActionResult SaveWizard([FromBody] SaveWizardView wizard, int playerId)
        {
            try
            {
                Wizard wizardToSave = new Wizard
                {
                    FatigueLevel = wizard.FatigueLevel,
                    HealthLevel = wizard.HealthLevel,
                    Experience = wizard.Experience,
                    Gold = wizard.Gold,
                    Race = wizard.Race,
                    EnergyLevel = wizard.EnergyLevel,
                    WeaponType = wizard.WeaponType,
                    HidingSkill = wizard.HidingSkill,
                    Assistant = wizard.Assistant,
                    AssistantName = wizard.AssistantName,
                    AssistantBonus = wizard.AssistantBonus,
                };
                var character = DTOManager.SaveCharacter(wizardToSave, playerId);
                return Ok(character);
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("SaveDefender/{playerId}")]
        public IActionResult SaveDefender([FromBody] SaveDefenderView defender, int playerId)
        {
            try
            {
                Defender defenderToSave = new Defender
                {
                    FatigueLevel = defender.FatigueLevel,
                    HealthLevel = defender.HealthLevel,
                    Experience = defender.Experience,
                    Gold = defender.Gold,
                    Race = defender.Race,
                    EnergyLevel = defender.EnergyLevel,
                    WeaponType = defender.WeaponType,
                    HidingSkill = defender.HidingSkill,
                    Assistant = defender.Assistant,
                    AssistantName = defender.AssistantName,
                    AssistantBonus = defender.AssistantBonus,
                    MaxArmourWeight = defender.MaxArmourWeight,
                };
                var character = DTOManager.SaveCharacter(defenderToSave, playerId);
                return Ok(character);
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete]
        [Route("DeleteCharacters/{playerId}")]
        public IActionResult DeleteCharacters(int playerId)
        {
            try
            {
                var message = DTOManager.DeleteCharacters(playerId);
                return Ok(message);
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}