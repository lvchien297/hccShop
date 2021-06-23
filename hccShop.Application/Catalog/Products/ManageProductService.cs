using hccShop.Application.Catalog.Products.Dtos;
using hccShop.Application.Catalog.Products.Dtos.Manage;
using hccShop.Application.Dtos;
using hccShop.Data.EF;
using hccShop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace hccShop.Application.Catalog.Products
{
    public class ManageProductService : IManageProductService

    {
        private readonly HccShopDbContext _context;
        public ManageProductService(HccShopDbContext contex)
        {
            _context = contex;
        }

        public async Task AddViewCount(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            product.ViewCount += 1;
            await _context.SaveChangesAsync();

        }

        public async Task<int> Create(ProductCreateRequest request)
        {
            var product = new Product()
            {
                Price = request.Price,
                OriginalPrice = request.OriginalPrice,
                Stock = request.Stock,
                ViewCount = 0,
                DateCreated = DateTime.Now,
                ProductTranslations = new List<ProductTranslation>()
                {
                    new ProductTranslation()
                    {
                        Name = request.Name,
                        Description = request.Description,
                        Details = request.Details,
                        SeoAlias = request.SeoAlias,
                        LanguageId = request.LanguageId,
                    }
                }
                    
            };
            _context.Products.Add(product);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            if(product = null) throw new Exceptions
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();  
        }

        public Task<List<ProductViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<PagedResult<ProductViewModel>> GetAllPaging(GetProductPagingRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(ProductUpdateRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdatePrice(int productId, decimal newPrice)
        {
            throw new NotImplementedException();
        }

        public Task UpdateStock(int productId, int addedQuantity)
        {
            throw new NotImplementedException();
        }
    }
}
