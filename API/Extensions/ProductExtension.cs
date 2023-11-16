using API.Entities;

namespace API.Extensions
{
    public static class ProductExtension
    {
        public static IQueryable<Product> Sort(this IQueryable<Product> query, string orderBy)
        {
            if (string.IsNullOrWhiteSpace(orderBy)) return query.OrderBy(p => p.Name);

            query = orderBy switch
            {
                "price" => query.OrderBy(p => p.Price),
                "priceDesc" => query.OrderByDescending(p => p.Price),
                "discountDesc" => query.OrderByDescending(p => p.DiscountPercentage),
                "ratingDesc" => query.OrderByDescending(p => p.Rating),
                _ => query.OrderBy(p => p.Name),
            };
            return query;
        }

        public static IQueryable<Product> Search(this IQueryable<Product> query, string searchTerm)
        {
            if (string.IsNullOrEmpty(searchTerm)) return query;

            var lowerSearchTerm = searchTerm.Trim().ToLower();
            return query.Where(p => p.Name.ToLower().Contains(lowerSearchTerm));
        }

        public static IQueryable<Product> Filter(this IQueryable<Product> query, string brands, string categories)
        {
            var brandList = new List<string>();
            var categoryList = new List<string>();
            if (!string.IsNullOrEmpty(brands))
            {
                brandList.AddRange(brands.Trim().ToLower().Split(",").ToList());
            }

            if (!string.IsNullOrEmpty(categories))
            {
                categoryList.AddRange(categories.Trim().ToLower().Split(",").ToList());
            }

            query = query.Where(p => brandList.Count == 0 || brandList.Contains(p.Brand.ToLower()));
            query = query.Where(p => categoryList.Count == 0 || categoryList.Contains(p.Category.ToLower()));
            return query;
        }
    }
}