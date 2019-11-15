using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Core.Model;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Core.Controllers
{
    [Route("api/[controller][action]")]//修改路由规则 api/[controller]->api/[controller]/[action] 防止路由过载 
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            // return Json(id);//ControllerBase除非改成继承Controller
            return "value";  // return new JsonResult(id);
        }

        // POST api/values
        /// <summary>
        /// post请求api注释
        /// </summary>
        /// <param name="value"></param>
        [HttpPost]
        public void Post([FromBody] string value)
        {
      
        }
        /// <summary>
        /// post love
        /// </summary>
        /// <param name="love">model实体类参数</param>
        [HttpPost]
        public  void PostLove(Love love)
        {

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
