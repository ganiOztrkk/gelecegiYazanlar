using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CampingApp.DataTransferObjects.requests;
using CampingApp.DataTransferObjects.responses;
using CampingApp.Entities;
using CampingApp.Infrastructure.repositories;
using CampingApp.Infrastructure.Repositories;
using CampingApp.Services.extensions;

namespace CampingApp.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public User? ValidateUser(string username, string password)
        => _userRepository.GetAllForLogin().SingleOrDefault(_ => _!.UserName == username && _.Password == password);

        public IEnumerable<UsersDisplayResponseDto> GetUsersDisplayResponses()
        {
            var users = _userRepository.GetAll();
            return users.ConvertToDisplayResponseDto<UsersDisplayResponseDto>(_mapper);
        }

        public async Task<UpdateUserRequestDto> GetUserForUpdateAsync(int id)
        {
            var user = await _userRepository.GetAsync(id);
            return _mapper.Map<UpdateUserRequestDto>(user);
        }

        public async Task UpdateUserAsync(UpdateUserRequestDto updateUserRequestDto)
        {
            var user = _mapper.Map<User>(updateUserRequestDto);
            await _userRepository.UpdateAsync(user);
        }

        public async Task DeleteUserAsync(User user)
        {
            var deletingUser = await _userRepository.GetAsync(user.UserID);
            await _userRepository.DeleteAsync(user);
        }

        public async Task CreateUserAsync(CreateNewUserRequestDto createNewUserRequestDto)
        {
            var user = _mapper.Map<User>(createNewUserRequestDto);
            await _userRepository.InsertAsync(user);
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _userRepository.GetAsync(id);

        }
    }
}
