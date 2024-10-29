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
        public async Task<bool> AuthenticateUserAsync(string login, string password)
        {
            return await _context.Users.AnyAsync(u => u.Login == login && u.Password == password);
        }
        //2) регистрациz нового пользователя
        public async Task<bool> RegisterUserAsync(User user)
        {

            bool userExists = await _context.Users.AnyAsync(u => u.Login == user.Login);
            if (userExists)
            {
                return false; 
            }
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return true; 
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
