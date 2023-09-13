using Inventory.DAL.Repositories;
using Inventory.EAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.BAL.Services
{
    public class ProductService
    {
        IProductRepo _productRepository;
        public ProductService(IProductRepo productRepository)
        {
            _productRepository = productRepository;
        }


        public void AddProduct(Product product)
        {
            _productRepository.AddProduct(product);
        }
        //update movie
        public void UpdateProduct(Product product)
        {
            _productRepository.AddProduct(product);
        }
        //delete movie
        public void DeleteProduct(int productId)
        {
            _productRepository.DeleteProduct(productId);
        }
        //Get GetMovieByid
        public Product GetProduct(int productId)
        {
            return _productRepository.GetProduct(productId);
        }
        //Get GetMovies
        public IEnumerable<Product> GetAllProduct()
        {
            return _productRepository.GetAllProduct();
        }
    }
}