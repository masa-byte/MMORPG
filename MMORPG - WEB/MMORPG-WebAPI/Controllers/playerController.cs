using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MMORPG;
using System;

namespace OracleWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlayerController : ControllerBase
    {
        [HttpGet]
        [Route("SignIn/{nickname}/{password}")]
        public IActionResult SignIn(string nickname, string password)
        {
            try
            {
                var player = DTOManager.SignInPlayer(nickname, password);
                if (player == null)
                    return BadRequest("Player not found");
                return Ok(new { player.Name, player.Surname, player.Gender, player.Age });
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("SignUp/{password}")]
        public IActionResult SignUp([FromBody] PlayerView playerView, string password)
        {
            try
            {
                var player = DTOManager.SignUpPlayer(playerView, password);
                if (player == null)
                    return BadRequest("Nickname already exists");
                return Ok($"Player {player.Name} was successfully saved with id = {player.Id}");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("GetAvailableFunds/{nickname}")]
        public IActionResult GetAvailableFunds(string nickname)
        {
            try
            {
                var funds = DTOManager.GetAvailableFunds(nickname);
                if (funds == -1)
                    return BadRequest("This player does not exist");
                return Ok($"Available funds are {funds}");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("GetExperience/{nickname}")]
        public IActionResult GetExperience(string nickname)
        {
            try
            {
                var exp = DTOManager.GetExperience(nickname);
                if (exp == -1)
                    return BadRequest("This player does not exist");
                return Ok($"Current experience is {exp}");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("GetTotalPoints/{nickname}")]
        public IActionResult GetTotalPoints(string nickname)
        {
            try
            {
                var points = DTOManager.ReturnPlayerPoints(nickname);
                if (points == -1)
                    return BadRequest("This player does not exist");
                return Ok(points);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("ReturnRankedPlayers")]
        public IActionResult ReturnRankedPlayers()
        {
            try
            {
                var players = DTOManager.ReturnAllPlayersRanked();
                return Ok(players);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("ReturnPlayerCharacters/{nickname}")]
        public IActionResult ReturnPlayerCharacters(string nickname)
        {
            try
            {
                var characters = DTOManager.ReturnAllPlayerCharacters(nickname);
                if (characters == null)
                    return BadRequest("This player does not exist");
                return Ok(characters);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("ReturnAllPlayerItems/{nickname}")]
        public IActionResult ReturnAllPlayerItems(string nickname)
        {
            try
            {
                var items = DTOManager.ReturnAllPlayerItems(nickname);
                return Ok(items);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("BuyItem/{playerId}/{itemId}")]
        public IActionResult BuyItem(int playerId, int itemId)
        {
            try
            {
                var itemBought = DTOManager.BuyItem(playerId, itemId);
                return Ok(itemBought);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete]
        [Route("SellItem/{playerId}/{itemId}")]
        public IActionResult SellItem(int playerId, int itemId)
        {
            try
            {
                var itemSold = DTOManager.SellItem(playerId, itemId);
                return Ok(itemSold);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("ReturnTeamForPlayer/{playerId}")]
        public IActionResult ReturnTeamForPlayer(int playerId)
        {
            try
            {
                var team = DTOManager.ReturnTeamForPlayer(playerId);
                if (team == null)
                    return BadRequest("This player does not exist");
                return Ok(team);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        [Route("JoinTeam/{playerId}/{teamId}")]
        public IActionResult JoinTeam(int playerId, int teamId)
        {
            try
            {
                var message = DTOManager.JoinTeam(playerId, teamId);
                return Ok(message);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        [Route("LeaveTeam/{playerId}")]
        public IActionResult LeaveTeam(int playerId)
        {
            try
            {
                var message = DTOManager.LeaveTeam(playerId);
                return Ok(message);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}