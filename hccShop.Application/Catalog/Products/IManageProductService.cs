using hccShop.Application.Catalog.Products.Dtos;
using hccShop.Application.Catalog.Products.Dtos.Manage;
using hccShop.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace hccShop.Application.Catalog.Products
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request);

        Task<int> Update(ProductUpdateRequest request);

        Task<int> Delete(int productId);

        Task<bool> UpdatePrice(int productId, decimal newPrice);

        Task UpdateStock(int productId, int addedQuantity);

        Task AddViewCount(int productId);   

        Task< List<ProductViewModel>> GetAll();

        Task<PagedResult<ProductViewModel>> GetAllPaging(GetProductPagingRequest request); 
    }
}
