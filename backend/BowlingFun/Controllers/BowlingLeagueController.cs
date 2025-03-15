using BowlingFun.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BowlingFun.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BowlingLeagueController : ControllerBase
    {
        private BowlerDbContext _bowlingContext;
        public BowlingLeagueController(BowlerDbContext temp) 
        {
            _bowlingContext = temp;
        }

        [HttpGet(Name = "GetBowlingLeague")]
        public async Task<ActionResult<IEnumerable<BowlingLeague>>> Get()
        {
            var bowlingList = await _bowlingContext.Bowlers
                .Include(b => b.Team)  // Include the related Team data
                .Select(b => new
                {
                    BowlerFirstName = b.bowlerFirstName,
                    BowlerMiddleInitial = b.bowlerMiddleInit,
                    BowlerLastName = b.bowlerLastName,
                    BowlerAddress = b.bowleraddress,
                    BowlerCity = b.bowlercity,
                    BowlerState = b.bowlerstate,
                    BowlerZip = b.bowlerzip,
                    BowlerPhoneNumber = b.bowlerphoneNumber,

                    TeamName = b.Team.TeamName  // Access the TeamName from the Team navigation property
                })
                .ToListAsync();

            return Ok(bowlingList);
        }
    }
}
