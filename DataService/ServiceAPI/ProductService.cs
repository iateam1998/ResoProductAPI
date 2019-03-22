using AutoMapper;
using AutoMapper.QueryableExtensions;
using DataService.DBEntity;
using DataService.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataService.ServiceAPI
{
    public interface IProductService : IBaseService<Product, ProductViewModel>
    {
        IQueryable<ProductViewModel> GetAvailableByProductCategoryId(int categoryId);
        IEnumerable<ProductViewModel> GetAllProductsByBrand(int brandId);
    }
    public class ProductService : BaseService<Product, ProductViewModel>, IProductService
    {
        public ProductService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public IEnumerable<ProductViewModel> GetAllProductsByBrand(int brandId)
        {
            var result = this.GetAsNoTracking(q =>
                    q.Cat.BrandId == brandId && q.Cat.Active.Value && q.Active)
                    .ProjectTo<ProductViewModel>(Mapper.ConfigurationProvider);
            return result;
        }

        public IQueryable<ProductViewModel> GetAvailableByProductCategoryId(int categoryId)
        {
            var products = this
                .GetActiveAsNoTracking(q => q.CatId == categoryId 
                && q.IsAvailable == true)
                .OrderBy(q => q.Position)
                .ProjectTo<ProductViewModel>(Mapper.ConfigurationProvider);
            return products;
        }
    }
}
