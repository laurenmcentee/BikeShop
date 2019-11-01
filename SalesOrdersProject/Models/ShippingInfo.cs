using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SalesOrdersProject.Models
{
    public class ShippingInfo
    {
        [Required(ErrorMessage = "Shipping Address is Mandatory")]
        public string Address { get; set; }

        [Required(ErrorMessage = "City is Mandatory")]
        public string City { get; set; }

        [Required(ErrorMessage = "State is Mandatory")]
        public string State { get; set; }

        [Required(ErrorMessage = "Postal Code is Mandatory")]
        public string PostalCode { get; set; }

    }
}