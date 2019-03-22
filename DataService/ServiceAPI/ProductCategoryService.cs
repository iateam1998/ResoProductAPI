using AutoMapper;
using DataService.DBEntity;
using DataService.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.ServiceAPI
{
    public interface IProductCategoryService : IBaseService<ProductCategory, ProductCategoryViewModel>
    {
        IEnumerable<ProductCategoryViewModel> GetProductCategoriesByBrandId(int brandId);
    }

    public class ProductCategoryService : BaseService<ProductCategory, ProductCategoryViewModel>, IProductCategoryService
    {
        public ProductCategoryService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
        public IEnumerable<ProductCategoryViewModel> GetProductCategoriesByBrandId(int brandId)
        {
            var productCategories = this.GetActive(c => c.BrandId == brandId && c.Active.Value);
            return productCategories;
        }
    }
}
