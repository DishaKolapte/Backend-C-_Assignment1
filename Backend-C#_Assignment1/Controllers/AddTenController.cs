using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Backend_C__Assignment1.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// takes int id and adds 10
        /// </summary>
        /// <param name="id"> </param>
        /// <returns>Returns 10 more than the integer input {id}.</returns>
        /// <example>/api/addTen/10 output = 20</example>
        /// <example>/api/addTen/-9 output = 1</example>
        public int Get(int id) {
            return id + 10;
        }
    }
}
