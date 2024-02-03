using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Backend_C__Assignment1.Controllers
{

    public class GreetingsController : ApiController
    {
        /// <summary>
        /// This controller is used to display a string (in this context, greetings) 
        /// </summary>
        /// <returns>Returns the squate of the integer input {id}.</returns>
        /// <example>/api/Greetings output= "Hello World!"</example>

        public string Get( )
        {
            return "Hello World!";
        }
    }
}
