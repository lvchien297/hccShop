﻿using System;
using System.Collections.Generic;
using System.Text;

namespace hccShop.Application.Catalog.Products.Dtos.Manage
{
    public class ProductUpdateRequest
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public string Details { set; get; }
        public string SeoAlias { get; set; }
        public string LanguageId { set; get; }
    }
}
