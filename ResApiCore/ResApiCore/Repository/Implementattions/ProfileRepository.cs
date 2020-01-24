using ResApiCore.Model;
using ResApiCore.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResApiCore.Repository.Implementattions
{
    public class ProfileRepository : IProfileRepository
    {
        private MySQLContext _context;
        public ProfileRepository(MySQLContext context)
        {
            _context = context;
        }



        public Profile Create(Profile profile)
        {
            try
            {
                _context.Add(profile);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return profile;
        }

        public void Delete(long id)
        {
            var result = _context.Profile.SingleOrDefault(p => p.Id.Equals(id));
            try
            {
                if (result != null) _context.Profile.Remove(result);

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<Profile> FindAll()
        {
            return _context.Profile.ToList();
        }

        public Profile FindById(long id)
        {
            return _context.Profile.SingleOrDefault(p => p.Id.Equals(id));

        }

        public Profile Update(Profile profile)
        {
            if (!Exist(profile.Id)) return new Profile();

            var result = _context.Persons.SingleOrDefault(p => p.Id.Equals(profile.Id));
            try
            {
                _context.Entry(result).CurrentValues.SetValues(profile);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return profile;
        }

        public bool Exist(long? id)
        {
            return _context.Persons.Any(p => p.Id.Equals(id));
        }
    }
}
