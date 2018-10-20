using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjectB.Controllers
{
    public class ValuesController : ApiController

    {
        //[Authorize] - would be used for 404 
        // GET api/values
        static List<string> ScheduleEntries = new List<string>()
        {

            "gameID","sqldID","date","opponent","opponentID","ishome", "gameType","categories[]"

        };

        public IEnumerable<string> Get()
        {
            return ScheduleEntries;
        }

        // GET api/values/5 - takes ID depending value is specified in the uri or not
        //eg. if we have the localhost/api/scheduleentries/1 - it will displayed SQLID and so on
        public string Get(int id)
        {
            return ScheduleEntries[id];
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
            ScheduleEntries.Add(value);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
            ScheduleEntries[id] = value;

        }

        // DELETE api/values/5
        public void Delete(int id)
        {

            ScheduleEntries.RemoveAt(id);
        }
    }
}
