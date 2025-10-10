using Marketplace.Products.Core.Model;

namespace Marketplace.Products.UI.Interfaces;

public interface ICheckoutPageRedirect
{
    Task RedirectAsync();
}