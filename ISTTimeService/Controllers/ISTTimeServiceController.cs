using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ISTTimeService.Controllers
{
    // URI
    
    public class ISTTimeServiceController : ApiController
    {
        // api/isttimeservice/time
        [HttpGet]
        [Route("api/isttimeservice/time")]
        public string ShowTime()
        {
            return DateTime.Now.ToLongTimeString();
        }
        // api/isttimeservice/datetime
        [HttpGet]
        [Route("api/isttimeservice/datetime")]
        public string ShowDateTime()
        {
            return DateTime.Now.ToString();
        }

    }
}
