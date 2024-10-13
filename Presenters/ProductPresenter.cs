using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Views;
using Supermarket_mvp.Models;

namespace Supermarket_mvp.Presenters
{
    internal class ProductPresenter
    {
        private IProductView view;
        private IProductRepository repository;
        private BindingSource productBindingSource;
        private IEnumerable<ProductModel> productList;

        public ProductPresenter(IProductView view, IProductRepository repository)
        {
            this.productBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchProduct;
            this.view.AddNewEvent += AddNewProduct;
            this.view.EditEvent += LoadSelectProductToEdit;
            this.view.DeleteEvent += DeleteSelectedProduct;
            this.view.SaveEvent += SaveProdcut;
            this.view.CancelEvent += CancelAction;

            this.view.SetProductListBildingSource(productBindingSource);

            loadAllProductList();

            this.view.Show();
        }

        private void loadAllProductList()
        {
            productList = repository.GetAll();
            productBindingSource.DataSource = productList;
        }

        private void SearchProduct(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                productList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                productList = repository.GetAll();
            }
            productBindingSource.DataSource = productList;
        }

        private void AddNewProduct(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void LoadSelectProductToEdit(object? sender, EventArgs e)
        {
            var product = (ProductModel)productBindingSource.Current;

            view.ProductId = product.Id.ToString();
            view.ProductName = product.Name;
            view.ProductPrice = product.Price.ToString();
            view.ProductStock = product.Stock.ToString();
            view.ProductCategory = product.Category_Id.ToString(); 

            view.IsEdit = true;
        }

        private void DeleteSelectedProduct(object? sender, EventArgs e)
        {
            try
            {
                var product = (ProductModel)productBindingSource.Current;

                repository.Delete(product.Id);
                view.IsSuccessful = true;
                view.Message = "Product deleted successfuly";
                loadAllProductList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete product";
            }
        }

        private void SaveProdcut(object? sender, EventArgs e)
        {
            var product = new ProductModel();
            product.Id = Convert.ToInt32(view.ProductId);
            product.Name = view.ProductName;
            product.Price = Convert.ToInt32(view.ProductPrice);
            product.Stock = Convert.ToInt32(view.ProductStock);
            product.Category_Id = Convert.ToInt32(view.ProductCategory);

            try
            {
                new Common.ModelDataValidation().Validate(product);
                if (view.IsEdit)
                {
                    repository.Edit(product);
                    view.Message = "Product edited successfuly";
                }
                else
                {
                    repository.Add(product);
                    view.Message = "Product added successfuly";
                }
                view.IsSuccessful = true;
                loadAllProductList();
                CleanViewFields();
            }
            catch (Exception ex) 
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            view.ProductId = "0";
            view.ProductName = "";
            view.ProductPrice = "0";
            view.ProductStock = "0";
            view.ProductCategory = "0";
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields (); 
        }
    }
}
