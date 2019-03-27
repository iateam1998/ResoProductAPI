using AutoMapper;
using DataService.DBEntity;
using DataService.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataService.ServiceAPI
{
    public interface IProductComboDetailService : IBaseService<ProductComboDetail, ProductComboDetailViewModel>
    {
        IEnumerable<ICollection<ProductComboDetailViewModel>> GetProductComboDetailsByStoreId(int storeId);
        List<ProductComboAPIViewModel> GetProductComboAPIViews(int storeId);
        ProductComboAPIViewModel GetProductComboByProductId(int storeId, int productId);
    }

    public class ProductComboDetailService : BaseService<ProductComboDetail, ProductComboDetailViewModel>, IProductComboDetailService
    {
        private readonly IServiceProvider _serviceProvider;
        public ProductComboDetailService(IUnitOfWork unitOfWork, IMapper mapper, IServiceProvider serviceProvider) : base(unitOfWork, mapper)
        {
            _serviceProvider = serviceProvider;
        }

        public IEnumerable<ICollection<ProductComboDetailViewModel>> GetProductComboDetailsByStoreId(int storeId)
        {
            var _productDetailService = ServiceFactory.CreateService<IProductDetailMappingService>(_serviceProvider);
            var listProducts = _productDetailService
                .GetProductDetailByStoreId(storeId)
                .Select(p => p.Product.ProductComboDetailCombo)
                .ToList();
            listProducts.RemoveAll(p => p == null || p.Count == 0);
            return listProducts;
        }

        public List<ProductComboAPIViewModel> GetProductComboAPIViews(int storeId)
        {
            var _productService = ServiceFactory.CreateService<IProductService>(_serviceProvider);
            var listCombo = this.GetProductComboDetailsByStoreId(storeId);
            var result = new List<ProductComboAPIViewModel>();
            foreach (ICollection<ProductComboDetailViewModel> productCombos in listCombo)
            {
                var combo = productCombos.FirstOrDefault();
                var comboDetail = _productService
                    .GetProductByProductId(combo.ComboId);
                if (comboDetail == null)
                {
                    break;
                }
                var product = new ProductComboAPIViewModel()
                {
                    ProductId = combo.ProductId,
                    ProductName = comboDetail.ProductName,
                    Quantity = combo.Quantity,
                    CatId = comboDetail.CatId,
                    Code = comboDetail.Code,
                    PicUrl = comboDetail.PicUrl,
                    DiscountPercent = comboDetail.DiscountPercent,
                    DiscountPrice = comboDetail.DiscountPrice,
                    Price = comboDetail.Price,
                    ProductType = comboDetail.ProductType,
                    IsAvailable = comboDetail.IsAvailable,
                    ProductNameEng = comboDetail.ProductNameEng,
                    listProducts = new List<ProductViewModel>()
                };
                foreach (ProductComboDetailViewModel productInCombo in productCombos)
                {
                    var productDetail = _productService.GetProductByProductId(productInCombo.ProductId);
                    if (productDetail != null)
                    {
                        product.listProducts.Add(productDetail);
                    }
                }
                result.Add(product);
            }
            return result;
        }

        public ProductComboAPIViewModel GetProductComboByProductId(int storeId, int productId)
        {
            var listCombos = this.GetProductComboAPIViews(storeId);
            var result = listCombos.FirstOrDefault(p => p.ProductId == productId);
            return result;
        }
    }
}
