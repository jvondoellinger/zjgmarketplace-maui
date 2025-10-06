using Marketplace.Products.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace.Products.Core.Requests;

public interface IProductCartCommandRequest
{
    Task SendAsync(ProductCart model);
}
