
using System.Collections.Generic;
using System.Xml.Serialization;
using Microsoft.AspNetCore.Mvc;
using System.IO;



namespace GenerateWordAPI.Controllers
{
    [Route("xml/[controller]")]
    public class XmlController : Controller
    {
        [HttpPost]
        //public Dynatrace Post([FromBody] Dynatrace data)
        public Dynatrace Post([FromBody] Dynatrace data)
        {
            return data;
        }

    }
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
        public FileStreamResult Get(int id)
        {
            MemoryStream ms = new MemoryStream();
            ReportData data = new ReportData();
            data.name = "Test";
            ms = Program.CreateFromTemplate("template.docx", "goodbye.docx", data);
           
            ms.Seek(0, SeekOrigin.Begin);
            Response.Headers.Add("content-disposition", "attachment; filename=\"" + data.name + ".docx\"");
            return new FileStreamResult(ms, "application/vnd.openxmlformats-officedocument.wordprocessingml.document");
           
        }

        // POST api/values
        [HttpPost]
        //public void Post([FromBody]string value)
        //public string Post([FromBody]string value)
        //public async Program.ReportData Post([FromBody]Program.ReportData data)
        public FileStreamResult Post([FromBody]ReportData data)
        {
            MemoryStream ms = new MemoryStream();
            ms = Program.CreateFromTemplate("template.docx", "goodbye.docx", data);
            ms.Seek(0, SeekOrigin.Begin);
            Response.Headers.Add("content-disposition", "attachment; filename=\"" + data.name + ".docx\"");
            return new FileStreamResult(ms, "application/vnd.openxmlformats-officedocument.wordprocessingml.document");
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
        
    }
}
