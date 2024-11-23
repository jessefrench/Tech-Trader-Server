﻿using TechTrader.Models;

namespace TechTrader.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetUserByIdAsync(int UserId);
        Task<User> CreateUserAsync(User User);
        Task<User> UpdateUserAsync(int UserId, User User);
    }
}