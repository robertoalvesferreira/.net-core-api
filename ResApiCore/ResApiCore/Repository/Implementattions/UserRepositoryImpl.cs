using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Microsoft.EntityFrameworkCore.Internal;
using ResApiCore.Business;
using ResApiCore.Model;
using ResApiCore.Model.Base;
using ResApiCore.Model.Context;
using ResApiCore.Repository;
namespace ResApiCore.Repository.Implementattions
{
    public class UserRepositoryImpl : IUserRepository
    {
        private MySQLContext _context;
        public UserRepositoryImpl(MySQLContext context)
        {
            _context = context;
        }

        public User FindByLogin(string login)
        {
            return _context.User.SingleOrDefault(u => u.Login.Equals(login));
                
        }

        

      
    }
}
