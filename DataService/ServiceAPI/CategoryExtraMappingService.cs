using AutoMapper;
using DataService.DBEntity;
using DataService.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.ServiceAPI
{
    public interface ICategoryExtraMappingService : IBaseService<CategoryExtraMapping, CategoryExtraMappingViewModel>
    {
        IEnumerable<CategoryExtraMappingViewModel> GetCategoryExtraMappings();
    }
    public class CategoryExtraMappingService : BaseService<CategoryExtraMapping, CategoryExtraMappingViewModel>, ICategoryExtraMappingService
    {
        public CategoryExtraMappingService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public IEnumerable<CategoryExtraMappingViewModel> GetCategoryExtraMappings()
        {
            var result = this.Get(p => p.IsEnable == true);
            return result;
        }
    }
}
