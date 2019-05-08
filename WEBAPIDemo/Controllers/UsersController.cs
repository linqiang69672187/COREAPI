using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WEBAPIDemo.DbComponet;
using WEBAPIDemo.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WEBAPIDemo.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "WEB API", "ASP.NET Core" };
        }

        // GET api/<controller>/5
        [HttpGet("{id}/{pid}")]
        public TestParam Get(int id,int pid)
        {
            var idx = SQLHelper.Insert();

            var ts = new TestParam();
            ts.ID = id;

            return ts;
        }

        [HttpGet("{id}")]
        public TestParam Get(int id)
        {
           SqlBulk.InsertTwo();
            RedisHelper redisHelper = new RedisHelper("127.0.0.1:6379");
            redisHelper.SetValue("mykey", "abc111");

            var person = new Users
            {
                UserName = "林强",
                Email = "69672187@qq.com",
                Address = "浙江"

            };
           // redisHelper.SetEntryInHash("Hash", "Name", "wujf");

            redisHelper.SetHashValue("user:123", person);

            var ts = new TestParam();
            ts.ID = id;

            return ts;
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        public class TestParam
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public DateTime Date { get; set; }
        }
        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
