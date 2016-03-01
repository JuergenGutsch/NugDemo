using System.Linq;
using Demo.Services;
using Microsoft.AspNet.Mvc;

namespace Demo.ViewComponents
{
    // usage: @Component.Invoke("Top20Customers");
    public class Top20CustomersViewComponent : ViewComponent
    {
        private readonly ICustomerService _tagService;

        public Top20CustomersViewComponent(ICustomerService tagService)
        {
            _tagService = tagService;
        }

        public IViewComponentResult Invoke()
        {
            var products = _tagService.LoadTopCustomers().Take(20);
        
            return View(products);
        }
    }
}
