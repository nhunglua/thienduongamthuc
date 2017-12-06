using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ThienDuongAmThuc.Model.Models;
using ThienDuongAmThuc.Web.Models;

namespace ThienDuongAmThuc.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<Post, PostViewModel>();
                cfg.CreateMap<PostCategory, PostCategoryViewModel>();
                cfg.CreateMap<Tag, TagViewModel>();

                cfg.CreateMap<ProductCategory, ProductCategoryViewModel>();
                cfg.CreateMap<Product, ProductViewModel>();
                cfg.CreateMap<ProductTag, ProductTagViewModel>();

            });
        }
    }
}