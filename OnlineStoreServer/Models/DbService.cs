using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

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
        //public async Task<bool> AuthenticateUserAsync(string login, string password)
        //{
        //    //return await _context.Users.AnyAsync(u => u.Login == login && u.Password == password);
        //    var userExists = await _context.Users.AnyAsync(u => u.Login == login && u.Password == password);
        //    Console.WriteLine($"User exists: {userExists} for login: {login}");
        //    return userExists;
        //}
        //2) регистрациz нового пользователя
        //public async Task<bool> RegisterUserAsync(User user)
        //{

        //    bool userExists = await _context.Users.AnyAsync(u => u.Login == user.Login);
        //    if (userExists)
        //    {
        //        return false; 
        //    }
        //    _context.Users.Add(user);
        //    await _context.SaveChangesAsync();
        //    return true; 
        //}

        //1)проверка существует ли ЮЗЕР
        public async Task<bool> AuthenticateUserAsync(string login, string password)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Login == login);
            if (user == null)
            {
                return false;
            }

            var hasher = new PasswordHasher<string>();
            var result = hasher.VerifyHashedPassword(null, user.Password, password);
            return result == PasswordVerificationResult.Success;
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









        public async Task<Product> GetProductByIdAsync(int productId)
        {
            return await _context.Products
                .Include(p => p.Description) 
                .Include(p => p.Images) 
                .FirstOrDefaultAsync(p => p.Id == productId);
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            return await _context.Products
                .Include(p => p.Description)
                .Include(p => p.Images)
                .ToListAsync();
        }

        public async Task<List<Product>> GetProductsByCategoryAsync(string category)
        {
            return await _context.Products
                .Include(p => p.Description)
                .Include(p => p.Images)
                .Where(p => p.Category == category)
                .ToListAsync();
        }

        public async Task<List<Product>> GetProductsSortedByPriceAscendingAsync()
        {
            return await _context.Products
                .Include(p => p.Description)
                .Include(p => p.Images)
                .OrderBy(p => p.Price)
                .ToListAsync();
        }

        public async Task<List<Product>> GetProductsSortedByPriceDescendingAsync()
        {
            return await _context.Products
                .Include(p => p.Description)
                .Include(p => p.Images)
                .OrderByDescending(p => p.Price)
                .ToListAsync();
        }

        public async Task<List<Product>> SearchProductsByNameAsync(string namePart)
        {
            return await _context.Products
                .Include(p => p.Description)
                .Include(p => p.Images)
                .Where(p => p.Name.Contains(namePart))
                .ToListAsync();
        }

        public async Task<List<Product>> GetProductsByUserAsync(int userId)
        {
            return await _context.Products
                .Include(p => p.Description)
                .Include(p => p.Images)
                .Where(p => p.UserId == userId)
                .ToListAsync();
        }
        public async Task AddProductAsync(int userId, Product product)
        {

            var user = await _context.Users.FindAsync(userId);
            if (user == null)
            {
                throw new Exception("Пользователь не найден.");
            }

            product.UserId = userId;

            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
        }
        public async Task<User> GetUserByIdAsync(int userId)
        {
            return await _context.Users
                .Include(u => u.Products)
                    .ThenInclude(p => p.Description)
                .Include(u => u.Products)
                    .ThenInclude(p => p.Images)
                .FirstOrDefaultAsync(u => u.Id == userId);
        }

    }

}
