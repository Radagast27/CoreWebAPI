using Microsoft.AspNetCore.Mvc;

namespace CoreWebAPI.Controllers
{
    public class ProductController : Controller
    {
        // GET http://localhost/Product/GetDescription/27
        [HttpGet]
        public string GetDescription(int id)
        {
            //product details hard-coded in this return but would be fetched from db in a real API implementation
            //ie return db.GetDesc(id);
            return "Product ID " + id.ToString() + ": This is a unique item that has no match in the market..";      
        }

        // POST http://localhost/Product/DeleteProduct/27
        [HttpPost] 
        public void DeleteProduct([FromBody]string id)
        {
            //deletion code here
            //ie. db.Delete(id);
        }   
    }
}