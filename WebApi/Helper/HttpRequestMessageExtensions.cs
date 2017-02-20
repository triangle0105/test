using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace WebApi.Helper
{
    public static class HttpRequestMessageExtensions
    {
        //包含报头“Origin”和“Access-Control-Request-Method”的HTTP-OPTIONS请求
        public static bool IsPreflightRequest(this HttpRequestMessage request)
        {
            return request.Method == HttpMethod.Options &&
                request.Headers.GetValues("Origin").Any() &&
                request.Headers.GetValues("Access-Control-Request-Method").Any();
        }
    }
}