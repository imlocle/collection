using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using collection.Models;

namespace collection.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public List<ProductView> GetAll()
        {
            var allProducts = new List<ProductView>();

            var p1 = new ProductView()
            {
                Id="1",
                Name="Samsung Galaxy S10+",
                PurchaseDate="12/13/2020",
                PurchasePrice="800.00",
                Manufacture="Samsung",
                ProductCategoryName="Mobile Phone"
            };

            allProducts.Add(p1);

            return allProducts;
        }
        // [HttpPost]
        // [Route("ProductAdd")]
        // public Object ProductAdd(Object data)
        // {   

        // }
        // [HttpPut]
        // [Route("ProductUpdate")]
        // public Object ProductUpdate(Object data)
        // {

        // }
        // [HttpDelete]
        // [Route("ProductDelete")]
        // public Object ProductDelete(Object data)
        // {

        // }
    }
}
