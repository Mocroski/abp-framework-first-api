﻿using AutoMapper;
using ProductManagement.Categories;
using ProductManagement.Products;

namespace ProductManagement;

public class ProductManagementApplicationAutoMapperProfile : Profile
{
    public ProductManagementApplicationAutoMapperProfile()
    {
        CreateMap<Product, ProductDto>();
        CreateMap<Category, CategoryLookupDto>();
    }
}
