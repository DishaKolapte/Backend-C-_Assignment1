using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Backend_C__Assignment1.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary> 
        ///applies mathematical operations to a given number 
        /// </summary> 
        /// <param name="id"> </param> 
        /// <returns>Returns the final output of id  + 5 - 6 * 5 / 2 to the given number </returns> 
        /// <example>  5 + 5 - 6 * 5 / 2  Output = 4 </example>
         
        public int Get(int id)
        {
            int result = (id + 5) - 6 * 5 / 5;
            return result;
        }
    }
}
