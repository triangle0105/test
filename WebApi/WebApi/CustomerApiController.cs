using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Script.Serialization;
using WebApi.Models;

namespace WebApi.WebApi
{
    public class CustomerApiController : ApiController
    {
        /// summary
        /// -----同源策略,限制跨域访问
        /// summary
        //public IHttpActionResult Get()
        //{
        //    var cutomers = new List<CustomerModel>
        //    {
        //        new CustomerModel
        //        {
        //            Id = Guid.NewGuid(),
        //            Name = "Customer1",
        //            Type = "Type1"
        //        },
        //        new CustomerModel
        //        {
        //            Id = Guid.NewGuid(),
        //            Name = "Customer2",
        //            Type = "Type2"
        //        },
        //        new CustomerModel
        //        {
        //            Id = Guid.NewGuid(),
        //            Name = "Customer3",
        //            Type = "Type3"
        //        }
        //    };
        //    return Json<IEnumerable<CustomerModel>>(cutomers);
        //}

        /// summary
        /// -----JSONP
        /// summary
        //public HttpResponseMessage Get(string callback)
        //{
        //    var cutomers = new List<CustomerModel>
        //    {
        //        new CustomerModel
        //        {
        //            Id = Guid.NewGuid(),
        //            Name = "Customer1",
        //            Type = "Type1"
        //        }
        //    };
        //    var serializer = new JavaScriptSerializer();
        //    string content = string.Format("{0}({1})", callback, serializer.Serialize(cutomers));
        //    return new HttpResponseMessage(HttpStatusCode.OK)
        //    {
        //        Content = new StringContent(content, Encoding.UTF8, "text/javascript")
        //    };
        //}

        public IEnumerable<CustomerModel> Get()
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
       
    }
}
