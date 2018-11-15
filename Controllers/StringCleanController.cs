using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChallengeApi.BusinessLogic;

namespace ChallengeApi.Controllers
{
    [Route("api/strclean")]
    [ApiController]
    public class StringCleanController : ControllerBase
    {
        [HttpGet("{str}")]
        public ActionResult<string> Get(string str)
        {
            return ChallengeSolutions.StringClean(str);
        }

    }

    
}