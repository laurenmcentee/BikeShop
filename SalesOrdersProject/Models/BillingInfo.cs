using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SalesOrdersProject.Models
{
    public class BillingInfo
    {

        [Required(ErrorMessage = "Billing First Name is Mandatory")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Billing Last Name is Mandatory")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Billing Card NUmber Name is Mandatory")]
        public string CreditCardNumber  { get; set; }
        [Required(ErrorMessage = "Billing Address is Mandatory")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Billing City is Mandatory")]
        public string City { get; set; }
        [Required(ErrorMessage = "Billing State is Mandatory")]
        public string State { get; set; }
        [Required(ErrorMessage = "Billing Postal Code is Mandatory")]
        public string PostalCode { get; set; }
        [Required(ErrorMessage = "Billing Expiration is Mandatory")]

        public string ExpireMonth { get; set; }
        public SelectList Months()
        {
            return new SelectList(new string[]
            {
                "01","02","03","04",
                "05", "06", "07", "08",
                "09", "10","11", "12"
            });
        }


        [Required(ErrorMessage = "Billing Expiration is Mandatory")]
        public string ExpireYear { get; set; }
        public SelectList Years()
        {
            return new SelectList(new string[]
            {
                "2019", "2020", "2021", "2022",
                "2023", "2024", "2025", "2026",
                "2027", "2028", "2029", "2030"
            });
        }



    }
}