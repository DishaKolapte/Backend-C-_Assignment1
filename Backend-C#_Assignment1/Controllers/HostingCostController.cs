using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Backend_C__Assignment1.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary> 
        /// total hosting cost  
        /// </summary> 
        /// <param name="id"> </param> 
        /// <returns>Returns 3 strings which describe the total hosting cost </returns> 
        /// <example>/api/HostingCost/ 
        /// fortnightRate = 5.50 for Cost per fortnight
        /// hstRate = 0.13 is the HST tax  rate
        /// fortnights = (id / 14) + 1 to Calculate the number of fortnights
        /// hstAmount = totalCost * hstRate;  // Calculate the HST amount
        public string Get(int id)
        {
            double fortnightRate = 5.50; 
            double hstRate = 0.13;       

            int fortnights = (id / 14) + 1; 
            double totalCost = fortnights * fortnightRate;  
            double hstAmount = totalCost * hstRate; 
            double totalAmount = totalCost + hstAmount;

            string resp1 = fortnights + " fortnights at $5.50/FN" + totalCost + "CAD";
            string resp2 = "HST 13% = $ " + hstAmount + " CAD";
            string resp3 = "Total = $ " + totalAmount + " CAD"; 

            return resp1+" , "+resp2+" , "+resp3;
        }
    }

}
