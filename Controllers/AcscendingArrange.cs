using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChallengeApi.BusinessLogic;

namespace ChallengeApi.Controllers
{
    [Route("api/asencdsort")]
    [ApiController]
    public class AcscendingArrangeController : ControllerBase
    {
        [HttpGet("{str}")]
        public ActionResult<string> Get(string str)
        {
            return ChallengeSolutions.AscendingArrange(str);
        }

    }

    
}