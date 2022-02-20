using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ThiHocKy.Models;

namespace ThiHocKy.Controllers
{
    public class SVSinhVienController : ApiController
    {
        // GET: api/SVSinhVien
        MongoDBConnect connect = new MongoDBConnect("ThiHocKy");
        public void Get()
        {
            
        }

        // GET: api/SVSinhVien/5
        [Route("api/SVSinhVien/{name}/")]
        public int Get(string name)
        {
            int start = name.IndexOfAny(new[]{'@'});
            int last = name.Length;
            string new_name = name.Remove(start, last-start);
            int count = 0;
            foreach (char i in new_name)
            {
                if ('0' < i && i < '9')
                {
                    new_name = new_name.Remove(0, count+2);
                    break;
                }
                count++;
            }
            int value = int.Parse(new_name);
            return value;
        }

        // POST: api/SVSinhVien
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/SVSinhVien/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SVSinhVien/5
        public void Delete(int id)
        {
        }
    }
}
