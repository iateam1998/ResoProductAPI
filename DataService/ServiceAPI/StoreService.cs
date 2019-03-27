using AutoMapper;
using DataService.DBEntity;
using DataService.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.ServiceAPI
{
    public interface IStoreService : IBaseService<Store, StoreViewModel>
    {
        StoreViewModel GetStoreByIdSync(int storeId);
    }
    public class StoreService : BaseService<Store, StoreViewModel>, IStoreService
    {
        public StoreService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
        public StoreViewModel GetStoreByIdSync(int storeId)
        {
            var store = this.FirstOrDefault(p => p.Id == storeId);
            if (store == null)
            {
                return null;
            }
            else
            {
                return store;
            }
        }
    }
}
