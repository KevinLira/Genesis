using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Genesis.Common.DTO;
using Genesis.Data.Model;
using AutoMapper;
using System.Linq;

namespace Genesis.Data.Repository
{

    public class UserRepository : IRepository<UserDTO>
    {
        private readonly DataContext _context = new DataContext();

        public UserRepository()
        {


        }

        public void Add(UserDTO entity)
        {
            var user = Mapper.Map<User>(entity);
            var userGuid = Guid.NewGuid();
            user.Guid = userGuid;
            _context.User.Add(user);

            var telephones = Mapper.Map<List<Telephone>>(entity.Telephones);
            foreach (var item in telephones)
            {
                item.UserGuid = userGuid;
                _context.Telephone.Add(item);
            }
        }

        public void Delete(UserDTO entity)
        {
            throw new NotImplementedException();
        }

        public UserDTO FindById(Guid Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserDTO> List()
        {
            var itens =  _context.User.Select(x =>x).AsEnumerable();
            return Mapper.Map<IEnumerable<UserDTO>>(itens);
        }


        public void Update(UserDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
