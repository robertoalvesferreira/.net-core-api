using System.Linq;
using ResApiCore.Model;
using ResApiCore.Model.Context;
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
