using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GiftExchange.Controllers
{
    public class BooksController : ApiController
    {

        public class GetBookByIdQuery
        {
            public int Id { get; set; }
        }

        //[HttpGet]
        [Route("/api/getbook")]
        [AcceptVerbs("POST", "GET")]
        //public string Get([FromUri] GetBookByIdQuery query)
        public IHttpActionResult getbook()
        {
            return Ok(); 
        }

    }
}
