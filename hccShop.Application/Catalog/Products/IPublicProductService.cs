using hccShop.Application.Catalog.Products.Dtos;
using hccShop.Application.Catalog.Products.Dtos.Public;
using hccShop.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace hccShop.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        PagedResult<ProductViewModel> GetAllByCategoryId(GetProductPagingRequest request);
    }
}
