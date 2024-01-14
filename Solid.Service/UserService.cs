using Solid.Core.Repositories;
using Solid.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Solid.Service
{
    public class UserService: IUserService
    {

        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
  
        public List<User> GetAll(string? text="")
        {
            //לוגיקה עסקית
            var list=_userRepository.GetList();
            return list.Where(u => u.Name.Contains(text)).Tolist();
        }
    }
}
