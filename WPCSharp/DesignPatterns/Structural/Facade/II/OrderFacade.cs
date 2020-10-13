using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Facade.II
{
    public class OrderFacade
    {
        private IProductService _productService;
        private IPaymentService _paymentService;
        private ICartService _cartService;

        public OrderFacade(IProductService productService, IPaymentService paymentService, ICartService cartService)
        {
            _productService = productService;
            _paymentService = paymentService;
            _cartService = cartService;
        }

        public void Order(int[] productIds, int cartId)
        {
            foreach (var id in productIds)
            {
                _cartService.AddProduct(id, _productService.GetPrice(id));
            }
            _paymentService.Pay(cartId, _cartService.GetPrice(cartId));
        }
    }
}
