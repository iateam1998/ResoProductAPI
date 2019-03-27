using AutoMapper;
using DataService.DBEntity;
using DataService.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataService.ServiceAPI
{
    public interface IProductImageService : IBaseService<ProductImage, ProductImageViewModel>
    {
        IEnumerable<ProductImageViewModel> GetListImagesByStoreId(int storeId);
        ProductImageViewModel GetImageByProductId(int storeId, int productId);
    }
    public class ProductImageService : BaseService<ProductImage, ProductImageViewModel>, IProductImageService
    {
        private readonly IServiceProvider _serviceProvider;
        public ProductImageService(IUnitOfWork unitOfWork, IMapper mapper, IServiceProvider serviceProvider) : base(unitOfWork, mapper)
        {
            _serviceProvider = serviceProvider;
        }

        public ProductImageViewModel GetImageByProductId(int storeId, int productId)
        {
            var result = GetListImagesByStoreId(storeId)
                .FirstOrDefault(p => p.ProductId == productId);
            return result;
        }

        public IEnumerable<ProductImageViewModel> GetListImagesByStoreId(int storeId)
        {
            var _productDetailMappingService = ServiceFactory.CreateService<IProductDetailMappingService>(_serviceProvider);
            // Select Product Image From Product Enity
            var result = _productDetailMappingService
                .GetProductDetailByStoreId(storeId)
                .Select(p => p.Product.ProductImage
                    .FirstOrDefault(q => q.Active == true)
                    ).ToList();
            // Remove null collection
            result.RemoveAll(p => p == null);
            return result;
        }
    }
}
