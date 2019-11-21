using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DataAccess.Models;

namespace TimeClock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClockInController : ControllerBase
    {
        public ClockInController()
        {
            //TODO: Inject manager
        }

        public async Task ClockIn(int userid, DateTime timeIn)
        {

        }

        public async Task ClockOut(int userid, DateTime timeOut)
        {

        }
    }
}