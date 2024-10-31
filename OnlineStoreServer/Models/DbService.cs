using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OnlineStoreServer.Models.Cart;
using System.Runtime.CompilerServices;

namespace OnlineStoreServer.Models
{
    public class DbService
    {
        private readonly ApplicationDbContext _context;

        public DbService(ApplicationDbContext context)
        {
            _context = context;
        }

        //1)проверка существует ли ЮЗЕР
        public async Task<int?> AuthenticateUserAsync(string login, string password)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Login == login);
            if (user == null) return null;
            return VerifyPassword(user.Password, password) ? user.Id : (int?)null;
        }

        //2) регистрациz нового пользователя и хеширование пароля
        public async Task<bool> RegisterUserAsync(User user)
        {
            bool userExists = await _context.Users.AnyAsync(u => u.Login == user.Login);
            if (userExists)
            {
                return false;
            }

            user.Password = HashPassword(user.Password);
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return true;
        }
        //Hash password
        private string HashPassword(string password)
        {
            var hasher = new PasswordHasher<string>();
            return hasher.HashPassword(null, password);
        }
        private bool VerifyPassword(string hashedPassword, string password)
        {
            var hasher = new PasswordHasher<string>();
            return hasher.VerifyHashedPassword(null, hashedPassword, password) == PasswordVerificationResult.Success;
        }

        //3) добавление продукта
        public async Task<bool> AddProductAsync(ProductRequest productRequest)
        {
            var user = await _context.Users.FindAsync(productRequest.UserId);
            if (user == null) return false;

            string userDirectory = Path.Combine("wwwroot", "images", "users", user.Id.ToString());

            if (!Directory.Exists(userDirectory))
            {
                Directory.CreateDirectory(userDirectory);
            }

            var imageBytes = productRequest.Image;
            string fileName = $"{Guid.NewGuid()}.jpg";
            string filePath = Path.Combine(userDirectory, fileName);

            await File.WriteAllBytesAsync(filePath, imageBytes);

            // Относительный URL к картинке для клиента
            string relativeImageUrl = Path.Combine("images", "users", user.Id.ToString(), fileName);
            string imageUrl = new Uri(new Uri("https://localhost:7284/"), relativeImageUrl).ToString();
            Console.WriteLine($"Image URL: {imageUrl}");
            var product = new Product
            {
                Name = productRequest.Name,
                Category = productRequest.Category,
                Price = productRequest.Price,
                Description = productRequest.Description,
                UserId = productRequest.UserId,
                ImageUrl = imageUrl,
                User = user
            };

            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return true;
        }

        //4) все продукты по юзеру
        public async Task<List<Product>> GetProductsByUserIdAsync(int userId)
        {
            return await _context.Products
                .Where(p => p.UserId == userId)
                .ToListAsync();
        }
        //5) удалить продукт по ID
        public async Task<bool> DeleteProductAsync(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product == null)
            {
                return false;
            }
            if (!string.IsNullOrEmpty(product.ImageUrl))
            {
                string relativeImageUrl = product.ImageUrl.Replace("https://localhost:7284/", "");
                string fullPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", relativeImageUrl);

                try
                {
                    if (File.Exists(fullPath))
                    {
                        File.Delete(fullPath);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при удалении файла: {ex.Message}");
                }
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return true; 
        }




        // Cart methods

        // Add
        public async Task<bool> AddToCartAsync(int userId, int productId, int quantity)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product == null) return false;

            var cartItem = await _context.CartItems
                .FirstOrDefaultAsync(ci => ci.UserId == userId && ci.ProductId == productId);

            if (cartItem != null)
            {
                cartItem.Quantity += quantity;
            }
            else
            {
                cartItem = new CartItem
                {
                    UserId = userId,
                    ProductId = productId,
                    Quantity = quantity
                };
                _context.CartItems.Add(cartItem);
            }

            await _context.SaveChangesAsync();
            return true;
        }

        // Get List
        public async Task<List<CartItem>> GetCartItemsAsync(int userId)
        {
            return await _context.CartItems
                .Where(ci => ci.UserId == userId)
                .Include(ci => ci.Product)
                .ToListAsync();
        }

        // Remove Product From Cart
        public async Task<bool> RemoveFromCartAsync(int userId, int productId)
        {
            var cartItem = await _context.CartItems
                .FirstOrDefaultAsync(ci => ci.UserId == userId && ci.ProductId == productId);

            if (cartItem == null)
            {
                return false;
            }

            _context.CartItems.Remove(cartItem);
            await _context.SaveChangesAsync();
            return true;
        }








        //6) поиск по фильтру
        public async Task<List<Product>> GetFilteredProductsAsync(ProductFilterRequest filterRequest)
        {
            var query = _context.Products.AsQueryable();

            if (!string.IsNullOrEmpty(filterRequest.Name))
            {
                query = query.Where(p => p.Name.Contains(filterRequest.Name));
            }

            if (!string.IsNullOrEmpty(filterRequest.Category))
            {
                query = query.Where(p => p.Category == filterRequest.Category);
            }

            if (filterRequest.MinPrice.HasValue)
            {
                query = query.Where(p => p.Price >= filterRequest.MinPrice.Value);
            }

            if (filterRequest.MaxPrice.HasValue)
            {
                query = query.Where(p => p.Price <= filterRequest.MaxPrice.Value);
            }

            // Применение постраничной навигации
            return await query
                .Skip((filterRequest.Page - 1) * filterRequest.PageSize)
                .Take(filterRequest.PageSize)
                .ToListAsync();
        }
    }
}
