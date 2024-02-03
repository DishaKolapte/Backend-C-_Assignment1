using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Backend_C__Assignment1.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// takes int id and squares the input 
        /// </summary>
        /// <param name="id"> </param>
        /// <returns>Returns the squate of the integer input {id}.</returns>
        /// <example>/api/Square/2 output= 4 </example>
        
        public int Get(int id)
        {
            return id*id;
        }
    }
}
