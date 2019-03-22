using AutoMapper;
using DataService.DBEntity;
using DataService.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataService.ServiceAPI
{
    public interface IProductDetailMappingService : IBaseService<ProductDetailMapping, ProductDetailMappingViewModel>
    {
        double GetPriceByStore(int storeId, int productId);
        double GetDiscountByStore(int storeId, int productId);
        IEnumerable<ProductDetailMappingViewModel> GetProductByStoreID(int storeId, int brandId);
    }
    public class ProductDetailMappingService : BaseService<ProductDetailMapping, ProductDetailMappingViewModel>, IProductDetailMappingService
    {
        private readonly IServiceProvider _serviceProvider;
        public ProductDetailMappingService(IUnitOfWork unitOfWork, IMapper mapper, IServiceProvider serviceProvider) : base(unitOfWork, mapper)
        {
            _serviceProvider = serviceProvider;
        }

        private IEnumerable<ProductDetailMappingViewModel> GetByStoreActiveById(int storeId)
        {
            var result = this.Get(a => a.StoreId == storeId && a.Active == true);
            return result;
        }
        public IEnumerable<ProductDetailMappingViewModel> GetProductByStoreID(int storeId, int brandId)
        {
            var _productService = ServiceFactory.CreateService<IProductService>(_serviceProvider);
            var table1 = _productService.GetAllProductsByBrand(brandId);
            var table2 = this.Get(a => a.StoreId == storeId && a.Active == true);
            //var table2 = this.Get(a => a.StoreId == storeId && a.Active == true);
            var join = from t1 in table1
                       join t2 in table2
                       on t1.ProductId equals t2.ProductId
                       select new ProductDetailMappingViewModel
                       {
                           ProductDetailId = t2.ProductDetailId,
                           ProductId = t2.ProductId,
                           StoreId = t2.StoreId,
                           Price = t2.Price,
                           DiscountPrice = t2.DiscountPrice,
                           DiscountPercent = t2.DiscountPercent,
                           Active = t2.Active,
                           Product = t2.Product,
                           Store = t2.Store
                       };
            return join;
        }
        public double GetPriceByStore(int storeId, int productId)
        {
            var productDetail = this.Get(pd => pd.StoreId == storeId && pd.ProductId == productId).FirstOrDefault();
            if (productDetail != null)
            {
                return productDetail.Price.GetValueOrDefault();
            }
            return 0;
        }
        public double GetDiscountByStore(int storeId, int productId)
        {
            var product = this.Get(a => a.ProductId == productId && a.StoreId == storeId).FirstOrDefault();

            if (product != null)
            {
                return product.DiscountPrice.GetValueOrDefault();
            }
            return 0;
        }
    }
}
