using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.WebApi
{
    public class CustomerApiController : ApiController
    {
        // GET api/coustomerapi
        public object Get()
        {
            var cutomers = new List<CustomerModel>
            {
                new CustomerModel
                {
                    Id = Guid.NewGuid(),
                    Name = "Customer1",
                    Type = "Type1"
                },
                new CustomerModel
                {
                    Id = Guid.NewGuid(),
                    Name = "Customer2",
                    Type = "Type2"
                },
                new CustomerModel
                {
                    Id = Guid.NewGuid(),
                    Name = "Customer3",
                    Type = "Type3"
                }
            };

            return cutomers;
        }

        // GET api/coustomerapi/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/coustomerapi
        public void Post([FromBody]string value)
        {
        }

        // PUT api/coustomerapi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/coustomerapi/5
        public void Delete(int id)
        {
        }
    }
}
