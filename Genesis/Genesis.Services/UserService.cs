using System;
using System.Collections.Generic;
using Genesis.Busines;
using Genesis.Common.DTO;

namespace Genesis.Services
{
    public class UserService
    {
        public UserDTO SignIn(string email, string password)
        {
            return new BPUser().SignIn(email, password);
        }
        public UserDTO SignUp(UserDTO user)
        {
            return new BPUser().SignUp(user);
        }

        public IEnumerable<UserDTO> Socorro()
        {
            return new BPUser().Socorro();
        }
    } 
}
