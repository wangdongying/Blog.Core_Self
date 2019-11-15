using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Core.Controllers
{
    [ApiExplorerSettings(IgnoreApi =true)]//隐藏某些接口
    [Route("api/[controller]")]
    [ApiController]
    public class SiteLinkssController : ControllerBase
    {
        /// <summary>
        /// 测试
        /// </summary>
        /// <param name="value"></param>
        [HttpPost]
        public void Test(string value)
        {

        }
    }
}