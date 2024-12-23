using Airlines_Reservation_DAL.DataContext;
using Airlines_Reservation_DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Airlines_Reservation_BLL.Services
{
    public class UserService
    {
        public readonly ApplicationDbContext _context;

        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }

        // Lấy danh sách tất cả người dùng
        public async Task<List<User>> GetAllUsersAsync()
        {
            return await _context.Set<User>().ToListAsync();
        }

        // Lấy thông tin người dùng theo ID
        public async Task<User?> GetUserByIdAsync(int userId)
        {
            return await _context.Set<User>().FindAsync(userId);
        }

        // Thêm người dùng mới
        public async Task AddUserAsync(User user)
        {
            if (string.IsNullOrWhiteSpace(user.FullName))
                throw new ArgumentException("FullName is required.");

            _context.Set<User>().Add(user);
            await _context.SaveChangesAsync();
        }

        // Cập nhật thông tin người dùng
        public async Task UpdateUserAsync(User user)
        {
            var existingUser = await GetUserByIdAsync(user.UserId);

            if (existingUser == null)
                throw new KeyNotFoundException("User not found.");

            existingUser.FullName = user.FullName;
            existingUser.Address = user.Address;
            existingUser.PhoneNumber = user.PhoneNumber;
            existingUser.PreferredCreditCardNumber = user.PreferredCreditCardNumber;
            existingUser.SkyMiles = user.SkyMiles;

            await _context.SaveChangesAsync();
        }

        // Xóa người dùng
        public async Task DeleteUserAsync(int userId)
        {
            var user = await GetUserByIdAsync(userId);

            if (user == null)
                throw new KeyNotFoundException("User not found.");

            _context.Set<User>().Remove(user);
            await _context.SaveChangesAsync();
        }
    }
}
