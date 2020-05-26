using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Models
{
    public class UserRepository : IUserRepository
    {
        private UserContext _userContext;

        public UserRepository(UserContext userContext)
        {
            _userContext = userContext;
        }
        public IEnumerable<User> GetUsers()
        {
            return _userContext.Users;
        }
    }
}
