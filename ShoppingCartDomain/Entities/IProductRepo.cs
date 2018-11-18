﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartDomain.Entities
{
    public interface IProductRepo
    {
        IEnumerable<Product> Products { get; }

        IEnumerable<Category> Categories { get;  }
    }
}
