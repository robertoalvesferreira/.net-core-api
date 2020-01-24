using ResApiCore.Model;
using ResApiCore.Repository;
using ResApiCore.Repository.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResApiCore.Business.Implementattions
{
    public class ProfileBusinessImpl : IProfileBusiness
    {
        //private IProfileRepository _repository;
        private readonly IRepository<Profile> _repository;

        public ProfileBusinessImpl(IRepository<Profile> repository)
        {
            _repository = repository;
        }

        public Profile Create(Profile profile)
        {
            return _repository.Create(profile);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public List<Profile> FindAll()
        {
            return _repository.FindAll();
        }

        public Profile FindById(long id)
        {
            return _repository.FindById(id);

        }

        public Profile Update(Profile profile)
        {
            return _repository.Update(profile);
        }
    }
}
