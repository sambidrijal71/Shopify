using System.Reflection.Metadata.Ecma335;
using API.Data;
using API.Dtos;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class BasketController : BaseController
    {
        private readonly StoreContext _context;
        public BasketController(StoreContext context)
        {
            _context = context;
        }

        [HttpGet(Name = "GetBasketItems")]
        public async Task<ActionResult<BasketDto>> GetBasketItems()
        {
            var basket = await RetrieveBasket();
            if (basket == null) return NotFound(new ProblemDetails { Title = "Basket Not Found. Please add Items to access basket." });
            return CreatedAtRoute("GetBasketItems", MapBasketToDto(basket));
        }
        [HttpPost]
        public async Task<ActionResult<BasketDto>> AddBasketItems(int productId, int quantity)
        {
            var basket = await RetrieveBasket() ?? CreateBasket();
            var product = await _context.Products.FindAsync(productId);
            if (product == null) return NotFound();
            basket.AddItems(product, quantity);
            var result = await _context.SaveChangesAsync() > 0;
            if (result) return CreatedAtRoute("GetBasketItems", MapBasketToDto(basket));
            return BadRequest();
        }

        [HttpDelete]
        public async Task<ActionResult<BasketDto>> RemoveBasketItems(int productId, int quantity)
        {
            var basket = await RetrieveBasket();
            if (basket == null) return NotFound(new ProblemDetails { Title = "Basket Not Found. Please add Items to access basket." });
            var product = await _context.Products.FindAsync(productId);
            if (product == null) return NotFound();
            basket.RemoveItems(productId, quantity);
            var result = await _context.SaveChangesAsync() > 0;
            if (result) return CreatedAtRoute("GetBasketItems", MapBasketToDto(basket));
            return BadRequest();
        }

        private async Task<Basket> RetrieveBasket()
        {
            return await _context.Baskets.Include(i => i.Items).ThenInclude(p => p.Product).FirstOrDefaultAsync(buyerId => buyerId.BuyerId == Request.Cookies["BuyerId"]);
        }

        private Basket CreateBasket()
        {
            var buyerId = Guid.NewGuid().ToString();
            var cookieOptions = new CookieOptions { IsEssential = true, Expires = DateTime.Now.AddDays(7) };
            Response.Cookies.Append("BuyerId", buyerId, cookieOptions);
            var basket = new Basket { BuyerId = buyerId };
            _context.Add(basket);
            return basket;
        }

        private static BasketDto MapBasketToDto(Basket basket)
        {
            return new BasketDto
            {
                Id = basket.Id,
                BuyerId = basket.BuyerId,
                Items = basket.Items.Select(item => new BasketItemDto
                {
                    ProductId = item.ProductId,
                    Name = item.Product.Name,
                    Price = item.Product.Price,
                    Description = item.Product.Description,
                    Rating = item.Product.Rating,
                    DiscountPercentage = item.Product.DiscountPercentage,
                    Thumbnail = item.Product.Thumbnail,
                    Category = item.Product.Category,
                    Brand = item.Product.Brand,
                    Quantity = item.Quantity
                }).ToList()
            };
        }


    }
}