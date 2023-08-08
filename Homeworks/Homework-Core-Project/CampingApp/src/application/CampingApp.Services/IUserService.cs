using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CampingApp.DataTransferObjects.requests;
using CampingApp.DataTransferObjects.responses;
using CampingApp.Entities;

namespace CampingApp.Services
{
    public interface IUserService
    {
        User? ValidateUser(string username, string password);
        IEnumerable<UsersDisplayResponseDto> GetUsersDisplayResponses();

        Task<UpdateUserRequestDto> GetUserForUpdateAsync(int id);
        Task UpdateUserAsync(UpdateUserRequestDto updateUserRequestDto);
        Task CreateUserAsync(CreateNewUserRequestDto createNewUserRequestDto);

        Task DeleteUserAsync(User? user);
        Task<User?> GetUserByIdAsync(int id);
    }
}
