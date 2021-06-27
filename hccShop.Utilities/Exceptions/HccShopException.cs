using System;
using System.Collections.Generic;
using System.Text;

namespace hccShop.Utilities.Exceptions
{
    public class HccShopException : Exception
    {
        public HccShopException()
        {
        }

        public HccShopException(string message)
            : base(message)
        {
        }

        public HccShopException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
