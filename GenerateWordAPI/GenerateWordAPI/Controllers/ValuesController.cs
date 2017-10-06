using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.IO;

namespace GenerateWordAPI.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            Program.CreateFromTemplate("template.docx", "goodbye.docx",id);
            return "value";
        }

        // POST api/values
        [HttpPost]
        //public void Post([FromBody]string value)
        //public string Post([FromBody]string value)
        public Problems Post([FromBody]Problems value)
        {
            /*    JsonTextReader reader = new JsonTextReader(new StringReader(value));
                string response = "";
                while (reader.Read())
                {

                    if (reader.Value != null)
                    {
                        response += "Token: " + reader.TokenType + "Value: " + reader.Value;
                    }
                    else
                    {
                        response += "Token: " + reader.TokenType;
                    }

                }*/
            
            return value;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        public class Problems
        {
            [JsonProperty("ProblemID")]
            public string ProblemID { get; set; }

            [JsonProperty("State")]
            public string State { get; set; }
        }
    }
}
