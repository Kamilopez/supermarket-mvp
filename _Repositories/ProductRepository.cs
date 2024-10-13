using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using System.Data;
using Supermarket_mvp.Models;

namespace Supermarket_mvp._Repositories
{
    internal class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(ProductModel productModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Product VALUES (@name, @price, @stock, @category)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productModel.Name;
                command.Parameters.Add("@price", SqlDbType.Decimal).Value = productModel.Price;
                command.Parameters.Add("@stock", SqlDbType.Int).Value = productModel.Stock;
                command.Parameters.Add("@category", SqlDbType.Int).Value= productModel.Category_Id;

                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Product WHERE Product_Id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(ProductModel productModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Product
                                        SET Product_Name = @name,
                                        Product_Stock = @stock,
                                        Product_Price = @price,
                                        Category_Id = @category
                                        WHERE Product_Id = @id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productModel.Name;
                command.Parameters.Add("@price", SqlDbType.Decimal).Value = productModel.Price;
                command.Parameters.Add("@stock", SqlDbType.Int).Value = productModel.Stock;
                command.Parameters.Add("@category", SqlDbType.Int).Value = productModel.Category_Id;
                command.Parameters.Add("@id", SqlDbType.Int).Value = productModel.Id;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<ProductModel> GetAll()
        {
            var productList = new List<ProductModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Product ORDER BY Product_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productModel = new ProductModel();
                        productModel.Id = (int)reader["Product_Id"];
                        productModel.Name = reader["Product_Name"].ToString();
                        productModel.Price = (decimal)reader["Product_Price"];
                        productModel.Stock = (int)reader["Product_Stock"];
                        productModel.Category_Id = (int)reader["Category_Id"];
                        productList.Add(productModel);
                    }
                }
            }
            return productList;
        }

        public IEnumerable<ProductModel> GetByValue(string value)
        {
            var productList = new List<ProductModel>();
            int productId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string productName = value;
            decimal productPrice = decimal.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            int productStock = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            int productCategory_Id = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Product 
                                      WHERE Product_Id=@id or Product_Name LIKE @name+ '%'
                                      ORDER By Product_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = productId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productName;
                command.Parameters.Add("@price", SqlDbType.Decimal).Value = productPrice;
                command.Parameters.Add("@stock", SqlDbType.Int).Value = productStock;
                command.Parameters.Add("@category", SqlDbType.Int).Value = productCategory_Id;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productModel = new ProductModel();
                        productModel.Id = (int)reader["Product_Id"];
                        productModel.Name = reader["Product_Name"].ToString();
                        productModel.Price = (decimal)reader["Product_Price"];
                        productModel.Stock = (int)reader["Product_Stock"];
                        productModel.Category_Id = (int)reader["Category_Id"];
                        productList.Add(productModel);
                    }
                }
            }
            return productList;
        }
    }
}
