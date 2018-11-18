using System;
using System.Collections.Generic;
using System.Linq;
using Genesis.Common.DTO;
using Genesis.Data;
using Genesis.Data.Repository;

namespace Genesis.Busines
{
    public class BPUser
    {
        /// <summary>
        /// Signs the user in.
        /// </summary>
        /// <returns>id,createdOn,lastUpdatedOn,lastLoginOn and token.</returns>
        /// <param name="email">Email.</param>
        /// <param name="password">Password.</param>
        public UserDTO SignIn(string email, string password){
            UserRepository repo = new UserRepository();
            return repo.List().GetEnumerator().Current;
        }

        /// <summary>
        /// Signs up.
        /// </summary>
        /// <returns>userID, CreatedON, LastUpdatedOn, LastLogin.</returns>
        /// <param name="user">User.</param>
       
        public UserDTO SignUp(UserDTO user)
        {
            var repo = new UserRepository();
            var userGuid = Guid.NewGuid();
            user.Guid = userGuid;
            user.CreatedDate = DateTime.Now;
            user.LastUpdated = DateTime.Now;
            repo.Add(user);

            return repo.List().Single(x => x.Guid == userGuid);
        }

        public IEnumerable<UserDTO> Socorro()
        {
            var repo = new UserRepository();
            return repo.List();
        }
    }
}
