// Application/UserManager.cs
using System.Collections.Generic;
using System.Threading.Tasks;
using CodeSmells.DataAccess;
using CodeSmells.Domain;

namespace CodeSmells.Application
{
    public class UserManager
    {
        private readonly UserService _userService;

        public UserManager(UserService userService)
        {
            _userService = userService;
        }

        public async Task<List<User>> FetchUsersAsync()
        {
            return await _userService.GetUsersAsync();
        }
    }
}
