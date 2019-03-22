using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using DataService.MappingProfileModel;
using Microsoft.EntityFrameworkCore;
using DataService.DBEntity;
using DataService.ServiceAPI;

namespace DataService
{
    public static class RootConfig
    {
        public static void Entry(IServiceCollection services, IConfiguration configuration)
        {
            #region DB Config
            services.AddDbContext<Product_StaggingContext>(options =>
               options.UseSqlServer(configuration.GetConnectionString("Product_DB")));
            services.AddScoped(typeof(DbContext), typeof(Product_StaggingContext));
            services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));
            #endregion

            #region Services config
            services.AddScoped(typeof(IProductService), typeof(ProductService));
            services.AddScoped(typeof(IStoreService), typeof(StoreService));
            services.AddScoped(typeof(IProductDetailMappingService), typeof(ProductDetailMappingService));
            services.AddScoped(typeof(ICategoryExtraMappingService), typeof(CategoryExtraMappingService));
            services.AddScoped(typeof(IProductCategoryService), typeof(ProductCategoryService));

            #endregion

            #region Mapper Config
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
            #endregion
        }
        private static void ConfigAutoMapper(IMapperConfigurationExpression config)
        {
            config.CreateMissingTypeMaps = true;
            config.AllowNullDestinationValues = false;
        }
    }
}