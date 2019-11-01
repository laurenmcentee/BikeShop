using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SalesOrdersProject.Models
{
    public class ProductsModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PaginationModel Pagination { get; set; }

        public int CategoryID { get; set; }

        public string SearchString { get; set; }

        public SelectList Categories()
        {
            SalesOrdersDatabase2Entities db = new SalesOrdersDatabase2Entities();

            var categories = from c in db.Categories
                             orderby c.CategoryDescription
                             select new
                             {
                                 c.CategoryID,
                                 c.CategoryDescription
                             };

            return new SelectList(categories, "CategoryID", "CategoryDescription");
        }
    }
}