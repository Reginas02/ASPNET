using Dapper;
using System.Collections.Generic;
using System.Data;
using Testing.Models;

namespace Testing
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDbConnection _conn;

        public ProductRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _conn.Query<Product>("select * From products");

        }
     public Product GetProduct(int id)
        {
            return (Product)_conn.Query<Product>("SELECT * FROM PRODUCTS WHERE PRODUTID = @ID", new { id = id});
        }
    
    }


}
